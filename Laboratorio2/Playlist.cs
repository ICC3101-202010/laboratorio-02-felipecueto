using System;
using System.Collections.Generic;
namespace Laboratorio2
{
    public class PlayList
    {
        private string name;
        List<Cancion> songs;

        public PlayList(string name, List<Cancion> songs)
        {
            this.name = name;
            this.songs = songs;
        }
        public String Nombre
        {
            get { return name; }
        }


        public List<Cancion> Canciones
        {
            get { return songs; }
        }
    }

}
