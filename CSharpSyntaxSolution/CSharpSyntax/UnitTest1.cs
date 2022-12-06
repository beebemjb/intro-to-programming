using System.Transactions;

namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Given
            int a = 10, b = 20, answer;
            // when
            answer = a + b;
            // then
            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(2,2,4)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }  
}