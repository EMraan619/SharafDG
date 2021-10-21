using SharafDG.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SharafDG.Domain.Entities
{
   public class User : AuditableEntity
    {
        [Key]
        public Guid UserId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
