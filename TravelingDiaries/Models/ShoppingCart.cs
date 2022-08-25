using Microsoft.EntityFrameworkCore;

namespace TravelingDiaries.Models
{
    public class ShoppingCart
    {
       
        //We need to talk to the Db 
        private readonly AppDbContext appDbContext;
        public string ShoppingCartId { get; set; }


        //List of cartItems
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

    
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }










        //All normal methods needed
        //1.Method Add to basket
        public void AddToCart(Place place,int amount) {
            var shoppingCartItem =
            appDbContext.shoppingCartItems.SingleOrDefault(
                s => s.Place.PlaceID == place.PlaceID && s.ShoppingCartId == ShoppingCartId);
            //if it is the first time they are adding apple pie, then shoppingCartItem should be null


            if (shoppingCartItem == null)
            {
                //shoppingcartitem object and add it to customer bag
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Place = place,
                    Amount = 1
                };

                appDbContext.shoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            appDbContext.SaveChanges();


        }



        
        public int RemoveFromCart(Place place)
        {
            var shoppingCartItem =
             appDbContext.shoppingCartItems.SingleOrDefault(
                 s => s.Place.PlaceID == place.PlaceID && s.ShoppingCartId == ShoppingCartId);

            int localValue = 0;

            if (shoppingCartItem != null) {
                if (shoppingCartItem.Amount > 1)
                {

                    shoppingCartItem.Amount--;
                    localValue = shoppingCartItem.Amount;
                }
                else
                {
                    appDbContext.shoppingCartItems.Remove(shoppingCartItem);
                }
               
            }
            appDbContext.SaveChanges();
            return localValue;





        }


        public List<ShoppingCartItem> GetShoppingCartItems()
        {

            return ShoppingCartItems ??
                (ShoppingCartItems = appDbContext.shoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Place).ToList());
         


        }

        public void ClearCart()
        {
            var cartItems = appDbContext.shoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId);
            appDbContext.shoppingCartItems.RemoveRange(cartItems);

            appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            decimal amount = appDbContext.shoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).Select(s => s.Place.PackagePrice * s.Amount).Sum();
            return amount;

        }


    }
}
