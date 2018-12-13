using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attestation_2.Utils
{
    public class UtilitiesForRandom
    {
        static Random rnd = new Random();
        public static bool RandomLocked()
        {
            int i = rnd.Next(0, 2);
            if (i == 0) return true;
            return false;
        }

        public static string RandomMake()
        {
            string[] makes = { "ПТМЗ", "Scoda", "CAF", "TRAMKAR", "Siemens", "Konstal" };
            int i = rnd.Next(0, 6);
            return makes[i];
        }

        public static object[] CreateRndTram()
        {
            return new object[] { rnd.Next(1, 6), RandomLocked(), RandomMake() };
        }
        public static object[] CreateRndBus()
        {
            return new object[] { rnd.Next(50, 120), RandomMake() };
        }
    }
}
