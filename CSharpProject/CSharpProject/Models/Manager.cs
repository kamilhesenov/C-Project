using System.ComponentModel.DataAnnotations;


namespace CSharpProject.Models
{
   public class Manager
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
       public override string ToString()
        {
            return Name;
        }
    }
}
