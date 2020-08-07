using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSharpProject.Models
{
   public class Cart
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime WithdrawalDate { get; set; }
    }
}
