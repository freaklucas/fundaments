using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilms.Models
{
    public class Films
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        [Display(Name="Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name="Value")] public decimal Price { get; set;}
    }
}
