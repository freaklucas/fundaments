using System.ComponentModel.DataAnnotations;

namespace MVCFilms.Models
{
    public class Films
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public decimal Price { get; set;}
    }
}
