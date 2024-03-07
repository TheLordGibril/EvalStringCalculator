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
            // Même test que le précédent mais on rajoute des espaces aléatoires dans l'input
            var suiteAvecEspaces = new StringBuilder(suiteFormatee);
            var nombreEspaces = random.Next(1,31);  // Vous pouvez ajuster le nombre d'espaces ajoutés

            for (var i = 0; i < nombreEspaces; i++)
            {
                var indexAleatoire = random.Next(0, suiteAvecEspaces.Length - 1);
                suiteAvecEspaces=suiteAvecEspaces.Insert(indexAleatoire, ' ');
            }

            var resultat = StringCalculator.Parse(suiteAvecEspaces.ToString());

            Assert.Equal(attendu, resultat);
        }
    }
}