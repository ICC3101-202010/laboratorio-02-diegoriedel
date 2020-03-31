using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrega_2
{
    public class Espotifai
    {
        public Espotifai()
        {

        }
        public string[] valores = { };
        List<string> cancionero = new List<string>();
        public bool AgregarCancion(string cancion)
        {

            if (cancionero.Contains(cancion))
            {
                return false;
            }
            else
            {
                cancionero.Add(cancion);
                return true;
            }
        }
        public void VerCanciones()
        {
            for (int j = 0; j < cancionero.Count; j++)
            {
                Console.WriteLine(cancionero[j]);
            }
        }
        
        public string[] CancionesPorCriterio(string criterio, string valor)
        {
            


            if (criterio == "genero")
            {
                Console.WriteLine("hola");
                for (int j = 0; j < cancionero.Count; j++)
                {
                    Console.WriteLine("entro");
                    if (cancionero[j].Contains(valor))
                    {
                        Console.WriteLine(cancionero[j]);
                        valores.Append(cancionero[j]);
                    }

                    else
                    {
                        Console.WriteLine("Valor no valido.");
                    }
                }              
            }

            if (criterio == "artista")
            {
                for (int j = 0; j < cancionero.Count; j++)
                {
                    if (cancionero[j].Contains(valor))
                    {
                        valores.Append(cancionero[j]);
                        Console.WriteLine(cancionero[j]);
                    }
                    else
                    {
                        Console.WriteLine("Valor no valido.");
                    }
                }
            }


            if (criterio == "album")
            {
                for (int j = 0; j < cancionero.Count; j++)
                {
                    if (cancionero[j].Contains(valor))
                    {
                        valores.Append(cancionero[j]);
                        Console.WriteLine(cancionero[j]);
                    }

                    else
                    {
                        Console.WriteLine("Valor no valido");
                    }
                }
            }


            if (criterio == "cancion")
            {
                for (int j = 0; j < cancionero.Count; j++)
                {
                    if (cancionero[j].Contains(valor))
                    {
                        valores.Append(cancionero[j]);
                        Console.WriteLine(cancionero[j]);
                    }
                    else 
                    {
                        Console.WriteLine("Valor no valido");
                    }
                }
            }
            else
            {
                Console.WriteLine("Este criterio no existe");
            }
            return valores;
        }
    }
}


