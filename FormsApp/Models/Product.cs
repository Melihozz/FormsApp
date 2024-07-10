using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }

        public bool IsAvtive { get; set; }

        public int CategoryId { get; set; } 
        
    }
    
}