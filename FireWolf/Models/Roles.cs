using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FireWolf.Models
{
    public class Roles
    {
        [Key]
        public int roleId { get; set; } // PK
        public string roleName { get; set; } // (customer, admin, employee)
        public ICollection<userRoles> userRoles { get; set; }
    }
}
