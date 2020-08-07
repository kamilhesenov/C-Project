using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSharpProject.Models
{
   public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
