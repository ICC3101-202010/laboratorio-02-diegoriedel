using System;

namespace Entrega_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion nombre = new Cancion("Rock","Queen","A night at the opera","Bohemian Rapsody");
            Console.WriteLine(nombre.informacion());


        }
    }
}
