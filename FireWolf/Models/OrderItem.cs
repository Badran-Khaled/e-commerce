using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FireWolf.Models
{
    public class OrderItem
    {
        [Key]
        public int orderItemId { get; set; } // PK
        public int quantity { get; set; }
        public int price { get; set; }

        [ForeignKey("orders")] 
        public int orderId { get; set; } // FK
        public Orders orders { get; set; }

        [ForeignKey("products")]
        public int productId { get; set; } // FK
        public Products products { get; set; }

    }
}
