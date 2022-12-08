
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("45", 45)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("2,3", 5)]
    [InlineData("45, 6", 51)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

     
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,1,5,6", 15)]
    [InlineData("2,3,1", 6)]
    [InlineData("45, 6", 51)]
    public void UnknownDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2,3", 6)]
    [InlineData("1\n2,3\n4", 10)]
    [InlineData("1\n2,3,5", 11)]
    public void SupportNewLines(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
