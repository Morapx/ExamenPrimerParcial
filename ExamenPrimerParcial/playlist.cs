using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class Playlist
    {
       public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Peliculas> playlistdepeliculas { get; set; }

        public Playlist()
        {
            Titulo = "No se encuentra titulo";
            Descripcion = "no Se encuentra una descripcion";
            playlistdepeliculas = new List<Peliculas>();
        }

        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            playlistdepeliculas = new List<Peliculas>();
        }
    }
    }

