using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int _Año;

        public List<playlist> Peliculas { get; set; }
     
        public Peliculas()
        {
            Peliculas = new List<playlist>();
        }

        public int Año
        {
            get
            {
                return _Año;
            }
            set
            {
                if (value >= 1800)
                {
                    _Año = value;
                }

                else
                {
                    throw new Exception("Año menor de 1800");
                }
            }
        }
    }
}
