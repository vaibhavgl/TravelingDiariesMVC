using AutoMapper;

namespace TravelingDiaries.Models
{
    public class HotelProfile:Profile
    {
        public HotelProfile()
        {
            this.CreateMap<Hotel, HotelMini>();
        }
    }
}
