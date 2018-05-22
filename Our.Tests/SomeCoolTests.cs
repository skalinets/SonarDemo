using ConsoleApp;
using FluentAssertions;
using Xunit;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable S100 // Naming Styles
#pragma warning disable SA1300 // Naming Styles

namespace Our.Tests
{
    public class SomeCoolTests
    {
        [Fact]
        // ReSharper disable once InconsistentNaming
        public void test()
        {
            Assert.Equal(1, 2);
        }

        [Fact]
        public void test_addition()
        {
            var result = new Sut().Add10(5);

            Assert.Equal("15", result); // FIXME: change to fluent assertions
        }

        [Fact]
        public void test_with_fluentasertions()
        {
            var a = 2 + 4;
            a.Should().Be(6); 
        }

        [Fact]
        public void test_without_asertions2()
        {
            var a = 2 + 4;
        }

        [Fact(Skip = "")]
        public void ignored_test()
        {
            //TODO: add some code
        }
    }
}