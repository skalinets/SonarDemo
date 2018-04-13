using Xunit;
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable S100 // Naming Styles

namespace ConsoleApp
{
    public class SomeCoolTests
    {
        [Fact]
        // ReSharper disable once InconsistentNaming
        public void test()
        {
            Assert.Equal(1, 2);
        }
    }
}