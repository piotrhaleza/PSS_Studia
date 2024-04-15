using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class User:BaseModel<int>
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
