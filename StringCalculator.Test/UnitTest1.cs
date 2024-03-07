namespace StringCalculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void APlusB()
        {
            var str = "1,2";

            var result = StringCalculator.Parse(str);

            Assert.Equal(3, result);
        }
    }
}