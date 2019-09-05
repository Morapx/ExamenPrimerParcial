using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class Peliculas
    {
        public string Titulo { get; set; }
        private int _año { get; set; }
        public string Director { get; set; }
        public string Pais { get; set; }
        public string Genero { get; set; }
     private int _duracion{ get; set; }
        private double _rating { get; set; }
        public string Sinopsis { get; set; }

        public int Año
        {
            get
            {
                return _año;
            }

            set
            {
                if (value >= 1800 && value <= 2019)
                {
                    _año = value;
                }
                else
                {
                    throw new Exception("Fecha incorrecta");
                }
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if(value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("Valor no valido");
                }
            }
        }

        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if(value>0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("Tiempo inadecuado");
                }
            }
        }
       
        public Peliculas()
        {
            Titulo = "Sin asignar";
            Año = 0;
            Director = "Sin asignar";
            Pais = "Sin asignar";
            Genero = "Sin asignar";
            Duracion = 0;
            Rating = 0;
            Sinopsis = "Sin asginar";

        }


        public Peliculas(string titulo, int año, string director, string pais, string sinopsis, string genero, double rating, int duracion)
        {
            Titulo = titulo;
            Año = año;
            Director = director;
            Pais = pais;
            Duracion = duracion;
            Genero = genero;
            Rating = rating;
            Sinopsis = sinopsis;


        }
        

        
    }
}
