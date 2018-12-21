﻿namespace PgNet
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Npgsql;

    public partial class DbService<TPocos>
    {
        public async Task<NpgsqlTransaction> BeginTransaction()
        {
            await this.VerifyConnectionState();

            return this.dbConnection.BeginTransaction();
        }

        public async Task ExecuteInTransaction(Func<NpgsqlTransaction, Task> body, CancellationToken cancellationToken = default)
        {
            await this.VerifyConnectionState(cancellationToken);

            using (var transaction = await this.BeginTransaction())
            {
                if (cancellationToken == default)
                {
                    await body(transaction);
                }
                else
                {
                    var canceledTask = cancellationToken.AsTask();
                    var transactionTask = body(transaction);

                    var completedTask = await Task.WhenAny(transactionTask, canceledTask);

                    if (completedTask == canceledTask)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }

                    await transactionTask;
                }
            }
        }

        public Task ExecuteInTransactionAndCommit(Func<Task> body, CancellationToken cancellationToken = default)
        {
            return this.ExecuteInTransactionAndCommit(tr => body(), cancellationToken);
        }

        public async Task ExecuteInTransactionAndCommit(Func<NpgsqlTransaction, Task> body, CancellationToken cancellationToken = default)
        {
            await this.VerifyConnectionState(cancellationToken);

            using (var transaction = await this.BeginTransaction())
            {
                if (cancellationToken == default)
                {
                    await body(transaction);
                }
                else
                {
                    var canceledTask = cancellationToken.AsTask();
                    var transactionTask = body(transaction);

                    var completedTask = await Task.WhenAny(transactionTask, canceledTask);

                    if (completedTask == canceledTask)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }

                    await transactionTask;
                }

                if (!transaction.IsCompleted)
                {
                    await transaction.CommitAsync(cancellationToken);
                }
            }
        }
    }
}