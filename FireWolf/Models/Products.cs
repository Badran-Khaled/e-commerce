using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FireWolf.Models
{
    public class Products
    {
        [Key]
        public int productId { get; set; } // PK
        public string proudctName { get; set; }
        public int price { get; set; }
        public int stockQuantity { get; set; }
        public ICollection<OrderItem> items { get; set; }
    }
}
