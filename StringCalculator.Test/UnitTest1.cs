namespace StringCalculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void APlusB()
        {

            var random = Random.Shared;

            var nombreA = random.Next();
            var nombreB = random.Next();

            var str = $"{nombreA},{nombreB}";

            var result = StringCalculator.Parse(str);

            Assert.Equal(nombreA+nombreB, result);
        }
    }
}