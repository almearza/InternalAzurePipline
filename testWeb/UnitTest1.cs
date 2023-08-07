using webApp.Modules;
using Xunit;

namespace testWeb
{
    public class UnitTest1
    {
        [Fact]
        public void DemoTest()
        {
            int i = 1;
            var result = false;
            if (i == 1) result = true;
            Assert.True(result, "value should be equal to one ");
        }
        [Fact]
        public void TestAddFunc()
        {
            var func = new Functions();
            var testResult = false;
            var result = func.Sum(2,3);
            if (result == 5) testResult = true;
            Assert.True(testResult, "value should be equal to one ");
        }
    }
}