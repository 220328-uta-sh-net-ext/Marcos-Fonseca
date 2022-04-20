using PokemonBL;
using Xunit;

namespace PokemonTest
{
    public class TestDummyForTest
    {
        [Fact]
        public void TestAdd()
        {
            //Arrange
            DummyForTest obj=new DummyForTest();
            int a=10,b=20;expected = 30;
            //Act
            var actual=obj.add(a,b);
            //Assert
            Assert.Equal(expected, actual);        }
    }
}