using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attestation_2.Task_4._13
{
    class LargeLoader 
    {
        const int amount = 100;
        public int Carring_Amount
        {
            get { return Carring_Amount; }
            set
            {
                if (value > amount)
                    Carring_Amount = amount;
                else Carring_Amount = value;
            }
        }
        public int SpeedWithCargo { get; set; }

        public LargeLoader()
        {
            Carring_Amount = 0;
            SpeedWithCargo = 5;
        }

        public void AddCargo(int cargo)
        {
            Carring_Amount = cargo;
        }

        public void ShipCargo()
        {
            Carring_Amount = 0;
        }
    }
}
