namespace ViewLecture.Models
{
    public class TourDate
    {
        public string ShowDate {get;set;}
        public string ShowCity {get;set;}

        public TourDate(string date, string city)
        {
            this.ShowDate = date;
            this.ShowCity = city;
        }
    }
}