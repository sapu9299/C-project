using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShop.Entity.Models
{
   public class Category
    {
        [Key]
        public int CatergoryId { get; set; }
        public string CategoryName { get; set; }
       public  List<Product> products { get; set; }

        
    }
}
