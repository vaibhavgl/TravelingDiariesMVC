namespace TravelingDiaries.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightName { get; set; }

        public string From { get; set; }

        public string To { get; set; }



        public TimeSpan Time { get; set; }
    }
}
