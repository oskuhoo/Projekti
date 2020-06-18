using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Engine
{
    public class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];
            generator.GetBytes(randomNumber);
            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            int range = maximumValue - minimumValue + 1;
            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(maximumValue + randomValueInRange);
        }

        private static readonly Random simpleGenerator = new Random();

        public static int SimpleNumberBetween(int minimunValue, int maximumValue)
        {
            return simpleGenerator.Next(minimunValue, maximumValue + 1);
        }

    }
}
