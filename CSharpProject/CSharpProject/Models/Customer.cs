using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CSharpProject.Models
{
   public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        [PasswordPropertyText]
        public string Password { get; set; }

        public ICollection<Cart> Carts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
