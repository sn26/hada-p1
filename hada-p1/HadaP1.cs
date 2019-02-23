using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Clase Hada-P1, donde tenemos los métodos que se utilizan para cambiar de unidad
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// Método que me sirve para cambiat de segundos a minutos 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
            {
                return 0;
            }
            return s / 60;

        }
        /// <summary>
        /// Método que me sirve para cambiar de minutos a segundos 
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double Minutes2Seconds(double m)
        {
            return 60 * m;
        }
    }
}
