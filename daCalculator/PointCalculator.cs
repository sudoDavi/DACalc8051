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
        protected internal float waveVmin, waveVmax;
        private double DACResolution = 5.0 / 255.0;
        


        protected internal string Square()
        {
            return "DB 0" + ((int)(waveVmax / DACResolution)).ToString("X2") + "H, 0" + ((int)(waveVmin / DACResolution)).ToString("X2") + "H";

        }

        protected internal string Triangle()
        {
            string returnString = string.Empty;
            float vRef = (waveVmax - waveVmin) / (waveResolution / 2) ;
            int i;

            for (i = 0; i <= waveResolution / 2; i++)
            {
                returnString += "0" + ((int)((waveVmin + vRef * i) / DACResolution)).ToString("X2") + "H, ";
            }

            vRef = (waveVmin - waveVmax) / (waveResolution / 2) ;

            for (i = 1; i <= waveResolution / 2; i++)
            {
                returnString += "0" + ((int)((waveVmax + vRef * i) / DACResolution)).ToString("X2") + "H, ";
            }

            return "DB " + returnString.Remove(returnString.Length - 2);
        }

        protected internal string Sin()
        {
            string returnString = string.Empty;
            float vRef = waveVmax / 2;
            int i;

            for (i = 0; i <= waveResolution; i++)
            {
                int dacValue = (int)(((waveVmax / 2) + waveVmax / 2 * Math.Sin((360 / waveResolution * i) * Math.PI / 180)) / DACResolution);
                returnString += "0" + dacValue.ToString("X2") + "H, ";
            }

            return "DB " + returnString.Remove(returnString.Length - 2);
        }

    }


}
