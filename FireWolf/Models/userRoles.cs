using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace FireWolf.Models
{
    public class userRoles
    {
        public int Id { get; set; }

        [ForeignKey("roles")]
        public int roleId { get; set; }
        public Roles roles { get; set; }

        [ForeignKey("users")]
        public int userId { get; set; }
        public Users users { get; set; }
    }
}
