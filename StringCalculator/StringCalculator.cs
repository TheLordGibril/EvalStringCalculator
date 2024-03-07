using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Parse(string str)
        {

            str=str.Replace(" ", "");
            var parts = str.Split(',');

            var negativePositions = new List<int>();

            for (var i = 0; i < parts.Length; i++)
            {
                if (int.TryParse(parts[i], out var number))
                {
                    // Vérifier si le nombre est négatif
                    if (number < 0)
                    {
                        negativePositions.Add(i);
                    }
                }
                else
                {
                    throw new ArgumentException($"La valeur à la position {i} n'est pas un nombre entier valide.");
                }
            }

            if (negativePositions.Any())
            {
                var positions = string.Join(", ", negativePositions);
                throw new ArgumentException($"Nombres négatifs détectés aux positions : {positions} dans la chaîne.");
            }

            return parts.Select(int.Parse).Sum();
        }
    }
}
