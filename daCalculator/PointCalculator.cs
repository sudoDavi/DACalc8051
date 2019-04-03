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
            float vStp = (waveVmax-waveVmin)/(waveResolution/2);
            int i;
            for (i = 0; i <= waveResolution / 2; i++)
            {
                returnString += "0" + ((int)(waveVmin + vStp*i/ DACResolution)).ToString("X2") + "H, ";
            }
            
            vStp = (waveVmin - WaveVmax)/(waveResolution/2);
            
            for (i = 1; i < waveResolution / 2; i++)
            {
                returnString += "0" + ((int)(waveVmax + vStp*i / DACResolution)).ToString("X2") + "H, ";
            }
            

            return "DB " + returnString ;
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
