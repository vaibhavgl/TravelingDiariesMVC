using Microsoft.AspNetCore.Mvc;
using TravelingDiaries.Models;

namespace TravelingDiaries.Controllers
{
    public class PlaceController : Controller
    {
        private readonly IPlaceRepository placeRepository;

        public PlaceController(IPlaceRepository placeRepository)
        {
            this.placeRepository = placeRepository;
        }


        //to retrive all the places.
        public IActionResult GetAllPlaces() {
            var places=placeRepository.GetAllPlaces();
            return View(places);

        }
        //to get the details of single place
        public IActionResult PlaceDetail(int? id)
        {
            Place place = placeRepository.PlaceDetail(id);
            ViewData["ID"]= id;
            return View(place);

        }


    }
}
