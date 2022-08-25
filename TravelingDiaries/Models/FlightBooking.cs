using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TravelingDiaries.Models
{
    public class FlightBooking
    {
        [Key]
        public int PassengerId { get; set; }

        public string PassengerName { get; set; }


        [ValidateNever]
        public string CartID { get; set; }

        public string AdhaarId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfFlight { get; set; }

        public string Class { get; set; }

        public decimal TicketPrice { get; set; }

        public int FlightId { get; set; }
        public Flight FlightInfo { get; set; }
    }
}
