using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Attestation_2.Task_4._13
{
    public class Worker
    {
        public TimeSpan TimeToFix { get; private set; } = TimeSpan.FromSeconds(2);

        public delegate void WorkerEventHandler(Worker sender);
        public event WorkerEventHandler IsFree;

        public static Semaphore Semaphore = new Semaphore(2, 2);
        public static int SemCount { get; private set; } = 2;

        public void DoWork(BlastFurnace target)
        {
            FixObject(target);
        }

        private void FixObject(BlastFurnace obj)
        {
            Semaphore.WaitOne();
            obj.Fix(TimeToFix);
            SemCount = Semaphore.Release();
            IsFree?.Invoke(this);
        }
    }
}
