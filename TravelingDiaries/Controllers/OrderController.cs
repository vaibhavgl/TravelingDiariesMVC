using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using TravelingDiaries.Models;

namespace TravelingDiaries.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }


        //This is the form for details
        public IActionResult Checkout()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {


                ModelState.AddModelError("", "Your cart is empty add some pies");
            }
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);


                decimal price = order.OrderTotal;

                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete", new { id = price });

            }

            return View(order);
        }


        public IActionResult CheckoutComplete(decimal id)
        {
            double amounToPay =(double) id*0.13;

            var domain = "https://localhost:7276/";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
        {
          new SessionLineItemOptions
          {
            PriceData = new SessionLineItemPriceDataOptions
            {
              UnitAmount = (long)(amounToPay),
              Currency = "usd",
              ProductData = new SessionLineItemPriceDataProductDataOptions
              {
                Name = "Packages",
              },

            },
            Quantity = 1,
          },
        },
                Mode = "payment",
                SuccessUrl = "https://example.com/success",
                CancelUrl = "https://example.com/cancel",
            };

            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);



        }



    }

    }
