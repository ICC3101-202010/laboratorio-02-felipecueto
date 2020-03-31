using System;
using System.Collections.Generic;
namespace Laboratorio2
{
    public class Espotifai
    {
        List<Cancion> Songs = new List<Cancion>();
        List<PlayList> playLists = new List<PlayList>();

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


        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)

        {
                foreach (PlayList playList in playLists)
                {
                   
                    if (playList.Nombre == nombrePlaylist)
                    {
               
                        Console.WriteLine("Ya existe una Playlist con este nombre...");
                        System.Threading.Thread.Sleep(1000);
                        return false;
                    }
                }

              
                List<Cancion> cancionesEnCriterio = CancionesPorCriterio(criterio, valorCriterio);

                if (cancionesEnCriterio.Count < 1)
                {
                    
                    Console.WriteLine("No hay canciones que cumplan con este criterio...");
                    System.Threading.Thread.Sleep(1000);
                    return false;
                }

                PlayList nuevaLista = new PlayList(nombrePlaylist, cancionesEnCriterio);
                playLists.Add(nuevaLista);
                return true;
        }

        public String VerMisPlaylists()
        {
                String infoPlaylist = "";

                foreach (PlayList playList in playLists)
                {
                    infoPlaylist += $"Nombre Playlist: {playList.Nombre}\n";

                    foreach (Cancion cancion in playList.Canciones)
                    {
                        infoPlaylist += $"- {cancion.Informacion()} \n";
                    }
                }

                return infoPlaylist;
        }
    }
}