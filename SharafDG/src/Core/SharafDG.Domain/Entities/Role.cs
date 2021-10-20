using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SharafDG.Domain.Entities
{
   public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [MaxLength(30)]
        [DataType(DataType.Text)]
        public string RoleName { get; set; }
    }
}
