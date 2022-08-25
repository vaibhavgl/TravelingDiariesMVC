using System.ComponentModel.DataAnnotations;

namespace TravelingDiaries.Models
{
    public class HotelMini
    {
        [Key]
        public int HotelId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        
    }
}
