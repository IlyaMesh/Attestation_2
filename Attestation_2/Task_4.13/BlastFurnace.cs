using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Timer = System.Timers.Timer;

namespace Attestation_2.Task_4._13
{
    public class BlastFurnace
    {
        public delegate bool BlastFurnaceEventHandler (BlastFurnace sender);
        public event BlastFurnaceEventHandler Broken;
        public event BlastFurnaceEventHandler Destroyed;
        public event BlastFurnaceEventHandler Fixed;

        public Storage Store { get; set; }
        public bool IsBroken { get; set; }
        private Timer _hpTimer;
        private bool _isWorking;
        Random _rnd = new Random();
        private float _crashProbability= 0.1f;
        public int HP { get; set; } = 5;


        public void StartWork()
        {
            _isWorking = true;
            while (_isWorking)
            {
                if (_rnd.NextDouble() <= _crashProbability && !IsBroken)
                {
                    IsBroken = true;
                    Broken?.Invoke(this);
                    _hpTimer = new Timer(TimeSpan.FromSeconds(HP).TotalMilliseconds);
                    _hpTimer.Elapsed += (o, e) =>
                    {
                        Destroyed?.Invoke(this);
                        StopWork();
                        _hpTimer?.Stop();
                    };
                    _hpTimer.Start();
                    return;
                }
                if (!IsBroken && Store.CurrentVolume < Store.Capacity)
                    Store.AddIron(1);
                Thread.Sleep(1000);
            }
        }

        public void StopWork()
        {
            _isWorking = false;
        }

        public void Fix(TimeSpan time)
        {
            _hpTimer.Stop();
            Thread.Sleep(time);
            IsBroken = false;
            Fixed?.Invoke(this);
        }

    }
}
