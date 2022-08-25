namespace TravelingDiaries.Models
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly AppDbContext appDbContext;

        public PlaceRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public IEnumerable<Place> GetAllPlaces()
        {
            var places = appDbContext.place.ToList();
            return places;

        }


        //return a single place details
        public Place PlaceDetail(int? id)
        {
            var place = appDbContext.place.FirstOrDefault(s => s.PlaceID == id);
            return place;

        }

        //Add place to the Database
        public void AddPlace(Place p)
        {
            appDbContext.place.Add(p);
            appDbContext.SaveChanges();

            
        }

        public void EditPlace(Place p)
        {
            appDbContext.place.Update(p);
            appDbContext.SaveChanges();
        }

        public void RemovePlace(int? id)
        {
            var place=appDbContext.place.FirstOrDefault(s => s.PlaceID == id);
            appDbContext.place.Remove(place);
            appDbContext.SaveChanges();
        }
    }
}
