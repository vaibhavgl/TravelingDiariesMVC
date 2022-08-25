namespace TravelingDiaries.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int DestinationId { get; set; }
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public bool IsRoomEmpty { get; set; }


    }
}
