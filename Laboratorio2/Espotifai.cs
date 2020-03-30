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
    }
}