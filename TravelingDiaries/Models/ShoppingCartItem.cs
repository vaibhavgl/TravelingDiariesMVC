using System.ComponentModel.DataAnnotations;

namespace TravelingDiaries.Models
{
    public class ShoppingCartItem
    {
      
        public int ShoppingCartItemId { get; set; }
        public Place Place { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
