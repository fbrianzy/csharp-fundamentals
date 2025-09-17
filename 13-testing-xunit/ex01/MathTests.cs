using Xunit;

public class MathTests
{
    [Theory]
    [InlineData(2,3,5)]
    [InlineData(-1,1,0)]
    [InlineData(0,0,0)]
    public void Sum_Works(int a, int b, int expected)
    {
        int Sum(int x, int y) => x + y;
        Assert.Equal(expected, Sum(a,b));
    }
}
