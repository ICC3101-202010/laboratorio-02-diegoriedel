using System;

namespace Entrega_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string ca;
            string al;
            string ar;
            string ge;
            Cancion nombre1 = new Cancion("rock", "queen", "a night at the opera", "bohemian rapsody");
            Cancion nombre2 = new Cancion("rock", "guns and roses", "appetite for destruction", "sweet child o mine");
            Cancion nombre3 = new Cancion("pop", "michael Jackson", "thriller", "beat it");

            Espotifai n1 = new Espotifai();
            n1.AgregarCancion(nombre1.informacion());
            n1.AgregarCancion(nombre2.informacion());
            n1.AgregarCancion(nombre3.informacion());

            int que_hacer;
            Console.WriteLine("Bienvenido a Espotifai");
            Console.WriteLine("¿Que quieres hacer?");
            Console.WriteLine("1: Ver todas las canciones");
            Console.WriteLine("2: Agregar una cancion");
            Console.WriteLine("3: Salir del programa");
            Console.WriteLine("4: Ver canciones por criterio");
            que_hacer = Convert.ToInt32(Console.ReadLine());
            while (que_hacer == 1 || que_hacer == 2)
            {
                string criterio;
                string valor;
                if (que_hacer == 1)
                {
                    n1.VerCanciones();
                }
                else if (que_hacer==2)
                {
                    Console.WriteLine("Cancion: ");
                    ca = Console.ReadLine();
                    Console.WriteLine("Album: ");
                    al = Console.ReadLine();
                    Console.WriteLine("Artista: ");
                    ar = Console.ReadLine();
                    Console.WriteLine("Genero: ");
                    ge = Console.ReadLine();
                    Cancion nueva = new Cancion(ge,ar,al,ca);
                    if (n1.AgregarCancion(nueva.informacion()) == false)
                    {
                        Console.WriteLine("Esta cancion ya estaba añadida");
                    }
               
                else if (que_hacer == 4)
                    {
                        Console.WriteLine("Nombre del criterio: ");
                        criterio = Console.ReadLine();
                        Console.WriteLine("Valor: ");
                        valor = Console.ReadLine();
                        Espotifai lista = new Espotifai();
                        lista.CancionesPorCriterio(criterio, valor);
                    }
                    else
                    {
                        Console.WriteLine("La cancion ha sido añadida");
                    }
                    
                }
               
                else if (que_hacer==3)
                {
                    break;
                }
                Console.WriteLine("");
                Console.WriteLine("¿Que quieres hacer ahora?");
                Console.WriteLine("1: Ver todas las canciones");
                Console.WriteLine("2: Agregar una cancion");
                Console.WriteLine("3: Salir del programa");
                que_hacer = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
