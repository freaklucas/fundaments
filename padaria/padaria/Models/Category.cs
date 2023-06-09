using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace padaria.Models
{
    [Table("Categorias")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(100, ErrorMessage ="Tamanho máximo são 100 caracteres!")]
        [Required(ErrorMessage ="Nome da categoria é obrigatório!")]
        [Display(Name="Name")]

        public string CategoryName { get; set; }

        [StringLength(200, ErrorMessage = "Tamanho máximo são 200 caracteres!")]
        [Required(ErrorMessage = "Descrição é obrigatório!")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }


        public List<Padaria> Padarias { get; set; }

    }
}
