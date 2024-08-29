using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireWolf.Models
{
    public class Orders
    {
        [Key]
        public int orderId { get; set; } // PK
        public DateTime orderDate { get; set; }
        public int totalAmount { get; set; }
        public string orderState { get; set; } // supposed to be enum

        [ForeignKey("users")]
        public int userId { get; set; } // FK
        public Users users { get; set; } // [many side]- [child side]
        public ICollection<OrderItem> items { get; set; }

    }
}
