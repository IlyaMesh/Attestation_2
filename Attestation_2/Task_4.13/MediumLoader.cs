using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Attestation_2.Task_4._13
{
    class MediumLoader : ILoader
    {
        public  void DoWork(Storage target)
        {
            if (target is Storage)
            {
                Thread.Sleep(5000);
                (target as Storage).Get();
            }
        }
    }
}
