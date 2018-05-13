using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy_mag.Services
{
    public static class RandomHelper
    {
        private static readonly Random Rand = new Random();

        public static int NextBitValue(double p = 0.5)
        {
            return Rand.NextDouble() <= p ? 1 : 0;
        }
        public static double NextDouble()
        {
            return Rand.NextDouble();
        }

        public static int NextInt(int start, int stop)
        {
            return Rand.Next(start, stop + 1);
        }
    }
}
