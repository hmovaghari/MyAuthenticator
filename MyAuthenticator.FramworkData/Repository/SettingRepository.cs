using MyAuthenticator.FramworkData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAuthenticator.FramworkData.Repository
{
    public class SettingRepository
    {
        private static Model model = new Model();
        private static string PasswordKey => "Password";
        private static string EmptyKey => (new Guid()).ToString();
        private static string NullKey => "Null";
        private static string SaltKey => "Salt";
        private static string IsGetPasswordForShowSecretKey => "IsGetPasswordForShowSecretKey";
        private static string IsGetPasswordForShowDynamicPasswordKey => "IsGetPasswordForShowDynamicPassword";
        private static string IsGetPasswordForRestoreBackupKey => "IsGetPasswordForRestoreBackup";
        private static string LanguageKey => "Language";
        private static string IsCheckUpdateKey => "IsCheckUpdate";
        public static List<Language> LanguageList => new List<Language>
        {
            Language.English,
            Language.Farsi
        };

        public static List<Setting> Get(Setting setting = null)
        {
            if (setting == null)
            {
                return StaticClass.Model.Settings.ToList();
            }
            return StaticClass.Model.Settings.Where(s => s.SettingID == setting.SettingID).ToList();
        }

        private static Setting Get(string name)
        {
            return StaticClass.Model.Settings.FirstOrDefault(s => s.Name == name);
        }

        public static void InserDefaultValue()
        {
            var settins = Get();
            var isEmpty = (settins?.Count ?? 0) == 0;
            var insertList = new List<Setting>();

            if (isEmpty || settins.FirstOrDefault(s => s.Name == SaltKey) == null)
            {
                insertList.Add(new Setting { Name = SaltKey, Value = Guid.NewGuid().ToString() });
            }

            if (isEmpty || settins.FirstOrDefault(s => s.Name == PasswordKey) == null)
            {
                insertList.Add(new Setting { Name = PasswordKey, Value = NullKey });
            }

            if (isEmpty || settins.FirstOrDefault(s => s.Name == IsGetPasswordForShowSecretKey) == null)
            {
                insertList.Add(new Setting { Name = IsGetPasswordForShowSecretKey, Value = true.ToString() });
            }

            if (isEmpty || settins.FirstOrDefault(s => s.Name == IsGetPasswordForShowDynamicPasswordKey) == null)
            {
                insertList.Add(new Setting { Name = IsGetPasswordForShowDynamicPasswordKey, Value = true.ToString() });
            }

            if (isEmpty || settins.FirstOrDefault(s => s.Name == IsGetPasswordForRestoreBackupKey) == null)
            {
                insertList.Add(new Setting { Name = IsGetPasswordForRestoreBackupKey, Value = true.ToString() });
            }

            if (isEmpty || settins.FirstOrDefault(s => s.Name == LanguageKey) == null)
            {
                insertList.Add(new Setting { Name = LanguageKey, Value = Language.English.Name() });
            }

            if (isEmpty || settins.FirstOrDefault(s => s.Name == IsCheckUpdateKey) == null)
            {
                insertList.Add(new Setting { Name = IsCheckUpdateKey, Value = true.ToString() });
            }

            if (insertList.Count > 0)
            {
                StaticClass.Model.Settings.AddRange(insertList);
                StaticClass.Model.SaveChanges();
            }
        }

        public static PasswordMode GetPasswordMode()
        {
            var password = Get(PasswordKey).Value;
            if (password == NullKey)
            {
                return PasswordMode.Null;
            }
            else if (password == EmptyKey)
            {
                return PasswordMode.Empty;
            }
            else
            {
                return PasswordMode.HasData;
            }
        }

        public static bool IsLogin(string passwordString)
        {
            var password = Get(PasswordKey);
            var salt = Get(SaltKey).Value;
            if (password.Value == EmptyKey && string.IsNullOrEmpty(passwordString))
            {
                return true;
            }
            else if (string.Equals(password.Value, CreateMD5(GeneratePassword(passwordString, salt))))
            {
                return true;
            }
            return false;
        }

        private static string GeneratePassword(string passwordString, string salt)
        {
            var salt1 = salt.Substring(0, salt.Length / 2);
            var sult2 = salt.Substring(salt.Length / 2, salt1.Length);
            return $"{salt1}{passwordString}{sult2}";
        }

        public static void UpdatePassword(string passwordString)
        {
            var password = Get(PasswordKey);
            var salt = Get(SaltKey).Value;
            if (string.IsNullOrEmpty(passwordString))
            {
                password.Value = EmptyKey;
            }
            else
            {
                password.Value = CreateMD5(GeneratePassword(passwordString, salt));
            }
            StaticClass.Model.SaveChanges();
        }

        private static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                //return Convert.ToHexString(hashBytes); // .NET 5 +

                // Convert the byte array to hexadecimal string prior to .NET 5
                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static bool IsGetPasswordForShowSecretKeys()
        {
            var isGetPasswordForShowSecretKey = Get(IsGetPasswordForShowSecretKey);

            return isGetPasswordForShowSecretKey?.Value == true.ToString();
        }

        public static void UpdateIsGetPasswordForShowSecretKeys(bool isGetPassword)
        {
            var isGetPasswordForShowSecretKey = Get(IsGetPasswordForShowSecretKey);
            isGetPasswordForShowSecretKey.Value = isGetPassword.ToString();
            StaticClass.Model.SaveChanges();
        }

        public static bool IsGetPasswordForShowDynamicPasswords()
        {
            var isGetPasswordForShowDynamicPasswordKey = Get(IsGetPasswordForShowDynamicPasswordKey);

            return isGetPasswordForShowDynamicPasswordKey?.Value == true.ToString();
        }

        public static void UpdateIsGetPasswordForShowDynamicPasswords(bool isGetPassword)
        {
            var isGetPasswordForShowDynamicPasswordKey = Get(IsGetPasswordForShowDynamicPasswordKey);
            isGetPasswordForShowDynamicPasswordKey.Value = isGetPassword.ToString();
            StaticClass.Model.SaveChanges();
        }

        public static bool IsGetPasswordForRestoreBackup()
        {
            var isGetPasswordForRestoreBackupKey = Get(IsGetPasswordForRestoreBackupKey);

            return isGetPasswordForRestoreBackupKey?.Value == true.ToString();
        }

        public static void UpdateIsGetPasswordForRestoreBackup(bool isGetPassword)
        {
            var isGetPasswordForRestoreBackupKey = Get(IsGetPasswordForRestoreBackupKey);
            isGetPasswordForRestoreBackupKey.Value = isGetPassword.ToString();
            StaticClass.Model.SaveChanges();
        }

        public static Language GetLanguage()
        {
            Enum.TryParse(Get(LanguageKey).Value, out Language language);
            return language;
        }

        public static void UpdateLanguage(Language language)
        {
            var languageData = Get(LanguageKey);
            languageData.Value = language.ToString();
            StaticClass.Model.SaveChanges();
        }

        public static bool IsCheckUpdateYes()
        {
            var isCheckUpdateYes = Get(IsCheckUpdateKey);
            return isCheckUpdateYes?.Value == true.ToString();
        }

        public static void UpdateIsCheckUpdate(bool isCheck)
        {
            var isCheckUpdate = Get(IsCheckUpdateKey);
            isCheckUpdate.Value = isCheck.ToString();
            StaticClass.Model.SaveChanges();
        }
    }
}
