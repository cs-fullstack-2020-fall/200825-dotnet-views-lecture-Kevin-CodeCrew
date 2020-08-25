using System.Collections.Generic;
using ViewLecture.Models;

namespace ViewLecture.ViewModels
{
    // Create a model with a band and a list of tour dates 
    public class BandTourDates
    {
        public Band Band {get; set;}
        public List<TourDate> TourDates = new List<TourDate>();
    }
}