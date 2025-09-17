using Xunit;

public class StringTests
{
    [Theory]
    [InlineData("hello","HELLO")]
    [InlineData("C#","C#")]
    public void ToUpper_Works(string input, string expectedUpper)
    {
        Assert.Equal(expectedUpper, input.ToUpper());
    }
}
