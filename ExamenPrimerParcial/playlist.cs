using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class playlist
    {
       public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Peliculas> playlistdepeliculas { get; set; }

        public playlist()
        {
            Titulo = "No se encuentra titulo";
            Descripcion = "no Se encuentra una descripcion";
            playlistdepeliculas = new List<Peliculas>();
        }

        public playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            playlistdepeliculas = new List<Peliculas>();
        }
    }
    }
}
