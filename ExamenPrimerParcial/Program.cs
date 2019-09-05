using System;
using System.Collections.Generic;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlist = new List<Playlist>();

            Playlist playlist1 = new Playlist("1)Familiar", "Peliculas para toda la familia");
            Playlist playlist2 = new Playlist("2)Mayor", "Peliculas recomendadas a mayores de 12");

            playlist.Add(playlist1);
            playlist.Add(playlist2);

            playlist1.playlistdepeliculas.Add(new Peliculas("Nemo", 2000, "Pepe", "USA", "Pez pequeño perdido", "Aventura", 8.9, 220));
            playlist1.playlistdepeliculas.Add(new Peliculas("spiderman", 2006, "Ricardo", "Mexico", "Un hombre que araña", "Accion", 6.5, 150));
            playlist1.playlistdepeliculas.Add(new Peliculas("Aladin", 1997, "Jaime", "India", "Un hombre con un esclavo azul", "Aventura y Romance", 7.3, 160));
            playlist1.playlistdepeliculas.Add(new Peliculas("Goofy", 2000, "Milos", "USA", "Un hombre perro que vive su dia dia", "Comedia", 9.6, 130));
            playlist1.playlistdepeliculas.Add(new Peliculas("Donald", 1999, "JOTARO", "japon", "Pato blanco que no se le entiende nada", "Comedia Accion", 8.2, 120));
            playlist1.playlistdepeliculas.Add(new Peliculas("Minions", 2014, "DIO", "Egipto", "Platanos vivientes", "Aventura y comedia", 1.5, 100));
            playlist1.playlistdepeliculas.Add(new Peliculas("spiderman", 2006, "Ricardo", "Mexico", "Un hombre que araña", "Accion", 6.3, 190));

            playlist2.playlistdepeliculas.Add(new Peliculas("Matrix", 2001, "Karen", "Mexico", "Un hombre drogado en un compu", "Accion y Futuristica", 9.6, 200));
            playlist2.playlistdepeliculas.Add(new Peliculas("Thor", 2010, "Eduardo", "Australia", "men que lanza truenos de las manos", "Accion y Aventura", 8.6, 160));
            playlist2.playlistdepeliculas.Add(new Peliculas("Merlin", 2011, "Ruben", "Mexico", "Un hombre magico", "Magia", 5.6, 160));
            playlist2.playlistdepeliculas.Add(new Peliculas("SpaceJam", 1982, "Victor", "USA", "Michael Jordan juega cbasket con caricaturas", "Ficcion y Relatos de la vida", 5.6, 130));
            playlist2.playlistdepeliculas.Add(new Peliculas("ElOrigen", 2009, "Carlos", "USA", "Mens que entran en sueños", "Accion y Ciencia ficcion", 8.3, 90));
            playlist2.playlistdepeliculas.Add(new Peliculas("El padrino", 2005, "Jenny", "Grecia", "un men que es padrino", "Accion y misterio", 7.1, 120));
            playlist2.playlistdepeliculas.Add(new Peliculas("PerdidoEnElEspacio", 1975, "Cambell", "Mexico", "Un hombre perdido en el eswpacio", "Accion, Futuristica y ciencia ficcion", 3.5, 90));

            foreach (Playlist play in playlist)
            {
                Console.WriteLine("*" + play.Titulo + "-" + play.Descripcion);
                foreach (Peliculas peli in play.playlistdepeliculas)
                {
                    Console.WriteLine("1) *" + peli.Titulo);

                    try
                    {
                        peli.Año = peli.Año;
                        Console.WriteLine("año:" + peli.Año);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("el año no es correcto");
                    }

                }

                Console.Read();
            }

        }
    }
}
