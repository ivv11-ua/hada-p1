using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        public static double Seconds2Minutes(double s)
        {
            double minutos;
            if (s == 0)
            {
                return 0;
            }
            else
            {
                minutos = s / 60;
                return minutos;
            }
        }
        public static double Minutes2Seconds(double m)
        {
            double segundos;
            if (m == 0)
            {
                return 0;
            }
            else
            {
                segundos = m * 60;
                return segundos;
            }
        }
    }
}
