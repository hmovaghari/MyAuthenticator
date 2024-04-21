using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAuthenticator.FramworkData.Context;

namespace MyAuthenticator.FramworkApp
{
    public class PasswordDTO
    {
        public Guid PasswordID { get; set; }

        public string Title { get; set; }

        public byte[] SecretKey { get; set; }

        public string PasswordString { get; set; } = PasswordStar;

        public static string PasswordStar => "******";

        public decimal RowNumber { get; set; }

        public int? Counter { get; set; }

        public Password PasswordData => new Password()
        {
            PasswordID = PasswordID,
            RowNumber = RowNumber,
            Name = Title,
            SecretKey = SecretKey
        };
    }
}
