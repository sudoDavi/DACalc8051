using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daCalculator8051
{
    class Wave
    {
        protected internal string WaveType;
        protected internal int waveResolution;
        protected internal float waveFrequency, waveVmin, waveVmax;
        private double DACResolution = 5.0 / 255.0;
        private double timeStep;


        protected internal string Square()
        {
            return ((int)(waveVmax / DACResolution)).ToString("X2") + ((int)(waveVmin / DACResolution)).ToString("X2") + "H";

        }

        protected internal string Triangle()
        {
            string returnString = string.Empty;
            float vRef = waveVmax / 2;
            int i;
            for (i = 0; i <= waveResolution / 4; i++)
            {
                returnString += ((int)((vRef + DACResolution * i) / DACResolution)).ToString("X2");
            }
            for (i = 1; i <= ((3 * waveResolution) / 4) - waveResolution / 4; i++)
            {
                returnString += ((int)((waveVmax - DACResolution * i) / DACResolution)).ToString("X2");
            }
            for (i = 1; i <= waveResolution - (3 * waveResolution) / 4; i++)
            {
                returnString += ((int)((waveVmin + DACResolution * i) / DACResolution)).ToString("X2");
            }

            return returnString + "H";
        }

        protected internal string Sin()
        {
            string returnString = string.Empty;
            timeStep = (1 / waveFrequency) / waveResolution;
            double omega = 2 * Math.PI * waveFrequency;
            float vRef = waveVmax / 2;
            int i;
            for (i = 0; i <= waveResolution / 2; i++)
            {
                returnString += ((int)(vRef + vRef * Math.Sin(omega * timeStep * i))).ToString("X2");
            }
            for (i = 1; i <= waveResolution - waveResolution / 2; i++)
            {
                returnString += ((int)(vRef - vRef * Math.Sin(omega * timeStep * i))).ToString("X2");
            }
            return returnString+"H";
        }

    }


}
