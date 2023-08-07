using Xunit;

namespace webTest
{
    public class UnitTest1
    {
        [Fact]
        public void DemoTest()
        {
            int i = 1;
            var result = false;
            if (i == 1) result = true;
            Assert.True(result,"value should be equal to one ");
        }
    }
}