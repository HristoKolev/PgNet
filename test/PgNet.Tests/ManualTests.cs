namespace PgNet.Tests
{
    using System.Linq;

    using Infrastructure;

    using Xunit;

    public class ManualTests : DatabaseTest
    {
        [Fact]
        public void FunctionsWork()
        {
            var query = (
                from d in this.Db.Poco.VGenerateSeries 
                select DbPocos.IncrementByOne(d.Num) == d.Num + 1
            );
            
            bool result = query.FirstOrDefault();
            
            Assert.True(result);
        }
    }
}