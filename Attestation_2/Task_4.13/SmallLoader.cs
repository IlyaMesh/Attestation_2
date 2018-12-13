using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attestation_2.Task_4._13
{
    public class SmallLoader 
    {
        const int amount = 10;
        private int carramount;
        public int Carring_Amount
        {
            get { return carramount; }
            set
            {
                if (value > amount)
                    carramount = amount;
                else carramount = value;
            }
        }

        public int SpeedWithCargo { get; set; }

        public SmallLoader()
        {
            carramount = 0;
            SpeedWithCargo = 15;
        }

        public void AddCargo(int cargo)
        {
            carramount = cargo;
        }

        public void ShipCargo()
        {
            carramount = 0;
        }
    }
}
