namespace padaria.Models
{
    public class Padaria
    {
        public int PadariaId { get; set; }
        public string PadariaName { get; set; }
        public string PadariaDesc { get; set; }
        public string PadariaLongDesc { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbUrl { get; set; }
        public bool LancheFavorite { get; set; }
        public bool Estoque { get; set; }


        public int categoryId { get; set; }
        public virtual Category Category { get; set; }




    }
}
