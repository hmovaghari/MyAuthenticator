using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAuthenticator.FramworkData.Context
{
    [Table("Password")]
    public class Password
    {
        [Key]
        public Guid PasswordID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte[] SecretKey { get; set; }

        public decimal RowNumber { get; set; }
    }
}
