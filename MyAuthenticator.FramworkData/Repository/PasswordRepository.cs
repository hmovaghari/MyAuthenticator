using MyAuthenticator.FramworkData.Context;
using MyAuthenticator.FramworkData.Migrations;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAuthenticator.FramworkData.Repository
{
    public class PasswordRepository
    {
        public static List<Password> Get(Password password = null, decimal? rowNumber = null)
        {
            if (password == null && rowNumber == null)
            {
                return StaticClass.Model.Passwords.ToList();
            }
            if (password != null)
            {
                return StaticClass.Model.Passwords.Where(p => p.PasswordID == password.PasswordID).ToList();
            }
            return StaticClass.Model.Passwords.Where(p => p.RowNumber == rowNumber).ToList();
        }

        public static List<Password> Search(string name)
        {
            return StaticClass.Model.Passwords.Where(p => p.Name.Contains(name)).ToList();
        }

        public static bool IsDuplicate(string name, Guid passwordId)
        {
            var isNew = passwordId == new Guid();
            return StaticClass.Model.Passwords.Any(p => p.Name == name && (isNew || p.PasswordID != passwordId));
        }

        public static void ChangeRowNumber(Password password, decimal newRowNumber)
        {
            var dbData1 = Get(password).First();
            var dbData2 = Get(rowNumber: newRowNumber).FirstOrDefault();
            dbData1.RowNumber = newRowNumber;
            if (dbData2 != null)
            {
                dbData2.RowNumber = password.RowNumber;
            }
            StaticClass.Model.SaveChanges();
        }

        private static List<Password> GetUpDownRowsPassword(Password password, bool isUp)
        {
            return StaticClass.Model.Passwords.Where(p
                => (isUp && p.RowNumber < password.RowNumber) || (!isUp && p.RowNumber > password.RowNumber))
                .ToList();
        }

        public static decimal GetUpDownRowNumber(Password password, bool isUp)
        {
            var passwords = GetUpDownRowsPassword(password, isUp);
            if (passwords.Count > 0)
            {
                return isUp ? passwords.Max(p => p.RowNumber) : passwords.Min(p => p.RowNumber);
            }
            return 0;
        }

        public static List<decimal> GetAnotherRowNumbers(Password password)
        {
            return StaticClass.Model.Passwords.Where(p => p.RowNumber != password.RowNumber)
                .Select(p => p.RowNumber).OrderBy(p => p).ToList();
        }

        public static void AddOrEdit(Password password)
        {
            if (password.PasswordID == new Guid())
            {
                password.PasswordID = Guid.NewGuid();
                password.RowNumber = GenerateNewRowNumber();
                StaticClass.Model.Passwords.Add(password);
            }
            else
            {
                var dbData = Get(password).First();
                dbData.Name = password.Name;
                if (password.SecretKey != null)
                {
                    dbData.SecretKey = password.SecretKey;
                }
            }

            StaticClass.Model.SaveChanges();
        }

        private static decimal GenerateNewRowNumber()
        {
            var isEmpty = !StaticClass.Model.Passwords.Any();
            return !isEmpty ? (StaticClass.Model.Passwords.Max(p => p.RowNumber)) + 1 : 1;
        }

        public static void Delete(Password password)
        {
            var dbData = Get(password).FirstOrDefault();
            if (dbData != null)
            {
                StaticClass.Model.Passwords.Remove(dbData);
                StaticClass.Model.SaveChanges();
            }
        }

        public static List<Password> OrderByRowNumber(List<Password> passwords)
        {
            return passwords.OrderBy(p => p.RowNumber).ToList();
        }
    }
}
