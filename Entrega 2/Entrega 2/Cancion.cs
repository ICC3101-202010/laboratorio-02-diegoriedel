using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_2
{
    public class Cancion
    {
        private string genero;
        private string artista;
        private string album;
        private string nombre;
        public Cancion(string genero, string artista, string album, string nombre)
        {

            this.genero = genero;
            this.artista = artista;
            this.album = album;
            this.nombre = nombre;
        }
        public string informacion()
        {
            return "Genero: " + genero + ", Artista: " + artista + ", Album: " + album + ", Nombre: " + nombre;
        }
    }
}
