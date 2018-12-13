using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attestation_2.Task_4._13
{
    public class Storage
    {
        public double Capacity { get; private set; }
        public double CurrentVolume { get; private set; }
        public delegate void StorageEventHandler(Storage sender);

        public event StorageEventHandler IsFull;
        public event StorageEventHandler IsEmpty;
        public event StorageEventHandler Added;

        public Storage(double capacity)
        {
            Capacity = capacity;
        }

        public void AddIron(double amount)
        {
            if (CurrentVolume + amount <= Capacity)
            {
                if (CurrentVolume + amount >= Capacity)
                    IsFull?.Invoke(this);

                CurrentVolume += amount;
                Added?.Invoke(this);

            }
        }

        public void Get(double val)
        {
            if (val < CurrentVolume && CurrentVolume != 0)
                CurrentVolume -= val;
            else
            {
                CurrentVolume = 0;
                IsEmpty?.Invoke(this);
            }
        }

        public void Get()
        {
            CurrentVolume = 0;
            IsEmpty?.Invoke(this);
        }

        public void Fix(TimeSpan time)
        {
            throw new NotImplementedException();
        }
    }
}
