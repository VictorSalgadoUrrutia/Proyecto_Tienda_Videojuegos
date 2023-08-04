using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_majo.Entities
{
    public class Roles
    {
        [Key]
        public int IdRoles { get; set; }
        public string RoleName { get; set; }

        

    }
}
