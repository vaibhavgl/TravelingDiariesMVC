using Microsoft.AspNetCore.Mvc;
using TravelingDiaries.Models;

namespace TravelingDiaries.Controllers
{
    public class ContentManagementController : Controller
    {
        private readonly IPlaceRepository placeRepository;

        public ContentManagementController(IPlaceRepository placeRepository)
        {
            this.placeRepository = placeRepository;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}


        //CM page view
        public IActionResult CM()
        {
            var places= placeRepository.GetAllPlaces();
            return View(places);
        }


        //for the create form
        public IActionResult Create()
        {
            return View();
        }
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        //to apply changes to db
        public IActionResult Create(Place place)
        {
            if (ModelState.IsValid) {
                placeRepository.AddPlace(place);            
            }
            TempData["Success"] = "Great! Created a new place.";
            return RedirectToAction("CM");
        }



        public IActionResult EditPlace(int id)
        {
            Place p=placeRepository.GetAllPlaces().FirstOrDefault(s => s.PlaceID == id);

            return View(p);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPlace(Place place)
        {
            if (ModelState.IsValid)
            {
                placeRepository.EditPlace(place);
            }
            TempData["Success"] = "Great! Edited the place.";
            return RedirectToAction("CM");
        }


        //To show the form of delete
        public IActionResult Delete(int id)
        {
            var place = placeRepository.GetAllPlaces().FirstOrDefault(s=>s.PlaceID==id);
            ViewData["ID"]= id;
            return View(place);
        }

        //to remove from the db
        public IActionResult DeletePlace(int? id)
        {
           placeRepository.RemovePlace(id);
            TempData["Success"] = "Great! Place has been deleted.";
            return RedirectToAction("CM");
        }
    }
}
