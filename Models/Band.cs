using System;

namespace ViewLecture.Models
{
    public class Band
    {
        public string BandName {get; set;}
        public string BandGenre {get; set;}

        public Band(string name, string genre)
        {
            this.BandName = name;
            this.BandGenre = genre;
        }
    }
}