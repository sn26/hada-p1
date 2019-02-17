using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fin = false;
            do
            {
                string pregunta;
                Console.WriteLine("Unidad: ");
                pregunta = Console.ReadLine();

                if (pregunta == "s" || pregunta == "S")
                {
                    Console.WriteLine("Cantidad: ");
                    pregunta = Console.ReadLine();
                    Console.WriteLine("Resultado:" + HadaP1.Seconds2Minutes(double.Parse(pregunta)));
                }
                else if (pregunta == "M" || pregunta == "m")
                {
                    Console.WriteLine("Cantidad: ");
                    pregunta = Console.ReadLine();
                    Console.WriteLine("Resultado:" + HadaP1.Minutes2Seconds(double.Parse(pregunta)));
                }
                Console.WriteLine("Seguir (Y/N) : ");
                pregunta = Console.ReadLine();
                if (pregunta == "N")
                {
                    fin = true;
                }


            } while (fin != true);

        }
    }
}
