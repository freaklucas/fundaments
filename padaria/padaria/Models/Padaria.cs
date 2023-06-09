using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace padaria.Models
{
    [Table("Padaria")]
    public class Padaria
    {
        [Key]
        public int PadariaId { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório")]
        [Display(Name ="Nome do produto")]
        [StringLength(70, MinimumLength =10, ErrorMessage = "O {0} deve ser informado e ter no minimo {1} e no máximo {2}")]
        public string NameProduct { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [Display(Name = "Descrição do produto")]
        [MinLength(20, ErrorMessage ="Descrição deve ter pelo menos {1} caracteres")]
        [MaxLength(200, ErrorMessage ="Descrição deve ter ao menos {1 caracteres}")]
        public string PadariaDesc { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [Display(Name = "Descrição do produto")]
        [MinLength(60, ErrorMessage = "Descrição deve ter pelo menos {1} caracteres")]
        [MaxLength(400, ErrorMessage = "Descrição deve ter ao menos {1 caracteres}")]
        public string PadariaLongDesc { get; set; }

        [Required(ErrorMessage ="Informe o preço")]
        [Display(Name ="Preço")]
        [Column(TypeName="decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="O preço deve estar entre 1 - 999.99")]
        public decimal Price { get; set; }

        [Display(Name ="Caminho da imagem")]
        [StringLength(200, ErrorMessage ="O {0} deve ter ")]
        public string ImageUrl { get; set; }
        public string ImageThumbUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool LancheFavorite { get; set; }

        [Display(Name = "Estoque")]
        public bool Estoque { get; set; }


        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }




    }
}
