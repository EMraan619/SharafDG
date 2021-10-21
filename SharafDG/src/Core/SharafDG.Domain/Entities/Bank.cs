using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SharafDG.Domain.Entities
{
    public class Bank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BankId { get; set; }
        public string BankName { get; set; }
        public string AccountHolderName { get; set; }
        public long AccountNumber { get; set; }
        public string IfscCode { get; set; }
    }
}
