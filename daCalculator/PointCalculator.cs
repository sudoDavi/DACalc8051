using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daCalculator8051
{
    class Wave
    {
        protected internal  string WaveType;
        protected internal int waveResolution;
        protected internal float waveFrequency, waveVmin, waveVmax;
        private double DACResolution = 5.0 / 255.0;

        
         protected internal string Square()
        {
            return ((int)(waveVmax / DACResolution)).ToString("X2") + ((int)(waveVmin / DACResolution)).ToString("X2")+"H";

        }

    }


}
