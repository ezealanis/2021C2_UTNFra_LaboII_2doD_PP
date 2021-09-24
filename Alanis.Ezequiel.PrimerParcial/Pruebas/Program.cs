using System;
using Entidades;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Computadora c1 = new Computadora("C01");
            Computadora c2 = new Computadora("C02");

            c2 += Juegos.Counter_Strike;
            c1 += Juegos.MuOnline;
            c2 += Juegos.MuOnline;
            c1 += Juegos.GTA_III;

            c1 += Perifericos.Auriculares;
            c2 += Perifericos.Auriculares;

            c1 += Software.Encarta;
            c1 += Software.Messenger;
            c2 += Software.Encarta;

            Console.Write(c1.ToString());
            Console.Write(c2.ToString());

            Console.ReadKey();
        }
    }
}
