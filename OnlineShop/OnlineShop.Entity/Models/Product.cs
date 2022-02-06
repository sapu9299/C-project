
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Entity.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Cost { get; set; }
        public bool InStock { get; set; }
       
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public byte[] ImgPoster { get; set; }

    }
}
