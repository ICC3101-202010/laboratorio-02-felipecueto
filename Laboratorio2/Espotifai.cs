using System;
using System.Collections.Generic;
namespace Laboratorio2
{
    public class Espotifai
    {
        List<Cancion> Songs = new List<Cancion>();

        public bool AgregarCancion(Cancion Newsong)
        {
            foreach (Cancion song in Songs)
            {
                if (song.Name == Newsong.Name &&
                    song.Album == Newsong.Album &&
                    song.Artist == Newsong.Artist)
                {
                    return false;
                }
                else
                {
                    Songs.Add(Newsong);
                    return true;
                }
            }

            Songs.Add(Newsong);
            return true;
        }

        public void VerCanciones()
        {
            foreach (Cancion song in Songs)
            {
                Console.WriteLine(song.Informacion());
            }
        }

        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> cancionesEnCriterio = new List<Cancion>();

            foreach (Cancion song in Songs)
            {
                switch (criterio)
                {
                    case "Album":
                        if (song.Album == valor)
                        {
                            cancionesEnCriterio.Add(song);
                        }
                        break;
                    case "Artista":
                        if (song.Artist == valor)
                        {
                            cancionesEnCriterio.Add(song);
                        }
                        break;
                    case "Genero":
                        if (song.Gender == valor)
                        {
                            cancionesEnCriterio.Add(song);
                        }

                        break;

                    default:

                        return cancionesEnCriterio;
                }
            }

            return cancionesEnCriterio;
        }
    }
}