using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Text;

namespace StringCalculator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void APlusB()
        {

            var random = Random.Shared;

            var nombreA = random.Next()/2;
            var nombreB = random.Next()/2;

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

        [Fact]

        public void PlusieursNombresEnEntreeAvecEspace()
        {
            var random = Random.Shared;

            var length = random.Next(1, 21);

            var suiteNumerique = new int[length];

            var attendu = 0;

            for (var i = 0; i < length; i++)
            {
                var nombreAleatoire = random.Next(1, 101);
                suiteNumerique[i] = nombreAleatoire;
                attendu += nombreAleatoire;
            }

            var suiteFormatee = string.Join(",", suiteNumerique);
            // M�me test que le pr�c�dent mais on rajoute des espaces al�atoires dans l'input
            var suiteAvecEspaces = new StringBuilder(suiteFormatee);
            var nombreEspaces = random.Next(1,31);  // Vous pouvez ajuster le nombre d'espaces ajout�s

            for (var i = 0; i < nombreEspaces; i++)
            {
                var indexAleatoire = random.Next(0, suiteAvecEspaces.Length - 1);
                suiteAvecEspaces=suiteAvecEspaces.Insert(indexAleatoire, ' ');
            }

            var resultat = StringCalculator.Parse(suiteAvecEspaces.ToString());

            Assert.Equal(attendu, resultat);
        }
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { "1,-2,3,-4,5", "Nombres n�gatifs d�tect�s aux positions : 2, 4 dans la cha�ne." };
            yield return new object[] { "-1,2,-3,4,5", "Nombres n�gatifs d�tect�s aux positions : 1, 3 dans la cha�ne." };
            yield return new object[] { "1,2,3,4,5", null };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Parse_ShouldHandleVariousCases(string input, string expectedErrorMessage)
        {
            if (expectedErrorMessage != null)
            {
                var exception = Assert.Throws<ArgumentException>(() => StringCalculator.Parse(input));
                Assert.Equal(expectedErrorMessage, exception.Message);
            }
            else
            {
                int result = StringCalculator.Parse(input);
                Assert.Equal(15, result);
            }
        }
    }
}