using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class Peliculas
    {
        public string Titulo { get; set; }
        public string Año { get; set; }
        public string Director { get; set; }
        public string Pais { get; set; }

        public Peliculas(string titulo, string año, string director, string pais)
        {
            Titulo = titulo;
            Año = año;
            Director = director;
            Pais = pais;
        }
        

        
    }
}
