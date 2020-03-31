using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_2
{
    public class Espotifai
    {
        public Espotifai()
        {

        }

        List<string> cancionero = new List<string>();
        List<string> solocancion = new List<string>();
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
            int i = 0;
            if (criterio == "Genero")
            {
                while (i < cancionero.Count)
                {
                    if (cancionero[i].Contains(valor))
                    {
                        Console.WriteLine(cancionero[i]);
                        solocancion.Add(cancionero[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if (criterio == "Artista")
            {
                 while (i < cancionero.Count)
                 {
                      if (cancionero[i].Contains(valor))
                      {
                          Console.WriteLine(cancionero[i]);
                          solocancion.Add(cancionero[i]);
                          i++;
                      }
                      else
                      {
                          i++;
                      }
                 }
            }


            if (criterio == "Album")
            {
                while (i < cancionero.Count)
                {
                    if (cancionero[i].Contains(valor))
                    {
                        Console.WriteLine(cancionero[i]);
                        solocancion.Add(cancionero[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }


            if (criterio == "Cancion")
            {
                while (i < cancionero.Count)
                {
                     if (cancionero[i].Contains(valor))
                     {
                            Console.WriteLine(cancionero[i]);
                            solocancion.Add(cancionero[i]);
                            i++;
                     }
                     else
                     {
                         i++;
                     }
                }
            }
        }
    }
}


