using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{   
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            string cantidad;
            do
            {
                Console.WriteLine("segundos/minutos/horas?");
                resp = Console.ReadLine();
                Console.WriteLine("Cantidad a convertir?");
                cantidad = Console.ReadLine();

                if (resp == "segundos")
                {
                    Console.WriteLine(HadaP1.Seconds2Minutes(double.Parse(cantidad)));
                }
                else
                {
                    if (resp == "minutos")
                    {
                        Console.WriteLine(HadaP1.Minutes2Seconds(double.Parse(cantidad)));
                    }
                    else 
                    {
                        Console.WriteLine(HadaP1.Horas2Minutos(double.Parse(cantidad)));
                    }
                }
            } while (resp == "segundos" || resp == "minutos" || resp == "horas");
        }
    }
}
