using TravelingDiaries.Controllers;

namespace TravelingDiaries.Models
{
    public interface IPlaceRepository
    {

        //Retrive all the available places
        IEnumerable<Place> GetAllPlaces();


        //Retrive place details
        public Place PlaceDetail(int? id);
        
        public void AddPlace(Place p);

        public void EditPlace(Place p);
        public void RemovePlace(int? id);



    }
}
