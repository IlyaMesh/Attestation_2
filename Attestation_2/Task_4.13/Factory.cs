using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Attestation_2.Task_4._13
{
    public class Factory
    {
        List<BlastFurnace> Furnaces { get; set; }
        List<MediumLoader> Loaders { get; set; }
        List<Worker> Workers { get; set; }
        Thread back;

        public Factory()
        {

        }
    }
}
