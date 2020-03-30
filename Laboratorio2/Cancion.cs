using System;
using System.Collections.Generic;
namespace Laboratorio2
{
    public class Cancion
    {
        private string name;
        private string album;
        private string artist;
        private string gender;

        public Cancion(string name, string album, string artist, string gender)
        {
            this.name = name;
            this.album = album;
            this.artist = artist;
            this.gender = gender;
        }

        public String Informacion()
        {
            return $" genero: {gender}, artista: {artist}, album: {album}, nombre: {name}";
        }

        public String Name
        {
            get { return name; }
        }

        public String Album
        {
            get { return album; }
        }

        public String Artist
        {
            get { return artist; }
        }

        public String Gender
        {
            get { return gender; }
        }
    }
    
}
