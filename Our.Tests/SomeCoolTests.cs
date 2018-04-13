using ConsoleApp;
using Xunit;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable S100 // Naming Styles

namespace Our.Tests
{
    public class SomeCoolTests
    {
        [Fact]
        // ReSharper disable once InconsistentNaming
        public void test() {
            Assert.Equal(1, 2);
        }

        [Fact]
        public void test_addition() {
            var result = new Sut().Add10(5);


            Assert.Equal("15", result);
        }
    }
}