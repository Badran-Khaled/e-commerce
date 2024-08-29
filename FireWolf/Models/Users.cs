using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FireWolf.Models
{
    public class Users
    {
        [Key]
        public int userId { get; set; } // PK

        [MaxLength(4,ErrorMessage ="Max length can't exceed 50 chars")]
        [Required(ErrorMessage ="please Enter the User Name")]
        public string userName { get; set; }

        [Required(ErrorMessage ="please Enter the password")]
        public string password { get; set; }
        public string email { get; set; }
        //List<Orders> orders { get; set; }
        public ICollection<Orders> orders { get; set; } // navigation property [one side]- [parent side]
        public ICollection<userRoles> userRoles { get; set; }

    }
}
