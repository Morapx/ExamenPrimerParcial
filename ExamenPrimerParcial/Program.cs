using System;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<playlist> playlist = new List<playlist>();

            playlist playlist1 = new playlist("Familiar", "Peliculas para toda la familia");
            playlist playlist2 = new playlist("Mayor", "Peliculas recomendadas a mayores de 12");

            playlist.Add(playlist1);
            playlist.Add(playlist2);

            playlist1.playlistdepeliculas.Add(new Peliculas("Nemo", "2000", "Pepe", "USA", "Pez pequeño perdido", "Aventura", "8", "220"));



        }
    }
}
