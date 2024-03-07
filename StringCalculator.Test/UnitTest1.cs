namespace StringCalculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void APlusB()
        {

            var random = Random.Shared;

            var str = $"{random.Next()},{random.Next()}";

            var result = StringCalculator.Parse(str);

            Assert.Equal(3, result);
        }
    }
}