using Microsoft.AspNetCore.Mvc;
using TravelingDiaries.Models;


namespace TravelingDiaries.Components
{
    public class CM:ViewComponent
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public CM(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public IViewComponentResult Invoke()
        {

            string Userid = httpContextAccessor.HttpContext.User.Identity.Name;
            ViewBag.admin = 0;
            if (Userid == "admin@gmail.com")
            {
                ViewBag.admin = 1;
            }

            return View();
        }


    }
}
