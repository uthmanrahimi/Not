using Not;
using Xunit;

namespace MakeNot.Tests
{
    public class StringTests
    {
        [Fact]
        public void IsNotNullEmpty()
        {
            string value = "makenot";
            var result = value.IsNotNullOrEmpty();
            Assert.True(result);
        }

        [Fact]
        public void NullStringShouldReturnFalse()
        {
            string value = "";
            var result = value.IsNotNullOrEmpty();
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace()
        {
            string value = " make it not";
            var result = value.IsNotNullOrWhiteSpace();
            Assert.True(result);
        }

    }
}
