using Microsoft.AspNetCore.Mvc;
using TravelingDiaries.Models;

namespace TravelingDiaries.Components
{
    public class CartValue:ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public CartValue(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {

            var Items = _shoppingCart.GetShoppingCartItems();

            return View(Items);



        }

    }
}
