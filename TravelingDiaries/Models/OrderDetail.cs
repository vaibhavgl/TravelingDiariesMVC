namespace TravelingDiaries.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PlaceId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Place Place { get; set; }
        public Order Order { get; set; }
    }
}
