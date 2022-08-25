using System.ComponentModel.DataAnnotations;

namespace TravelingDiaries.Models
{
    public class SearchFlight
    {
        [Key]
        public int Id { get; set; }
        public string From { get; set; }

        public string To { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
    }
}
