using Not;
using Xunit;
namespace MakeNot.Tests
{
    public class BooleanTest
    {
        [Fact]
        public void Call_MakeNot_On_True_Should_Return_False()
        {
            //arrange
            bool value = true;
            //act
            var result = value.Not();
            //assert
            Assert.False(result);
        }

        [Fact]
        public void Call_MakeNot_On_False_Should_Return_True()
        {
            bool value = false;
            var result = value.Not();
            Assert.True(result);
        }
           
    }
}
