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

            var resultat = StringCalculator.Parse(str);

            Assert.Equal(nombreA+nombreB, resultat);
        }

        [Fact]

        public void PlusieursNombresEnEntree()
        {
            var random = Random.Shared;

            var length = random.Next(1,21);

            var suiteNumerique = new int[length];

            var attendu = 0;

            for (var i = 0; i < length; i++)
            {
                var nombreAleatoire = random.Next(1,101);
                suiteNumerique[i] = nombreAleatoire;
                attendu += nombreAleatoire;
            }

            var suiteFormatee = string.Join(",", suiteNumerique);

            var resultat=StringCalculator.Parse(suiteFormatee);

            Assert.Equal(attendu, resultat);
        }
    }
}