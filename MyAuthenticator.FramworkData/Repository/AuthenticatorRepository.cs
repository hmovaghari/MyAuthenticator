using MyAuthenticator.FramworkData.Context;
using MyAuthenticator.FramworkData.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserSettings = MyAuthenticator.FramworkData.Properties.Settings;

namespace MyAuthenticator.FramworkData.Repository
{
    public class AuthenticatorRepository
    {
        public static void GetNewModel()
        {
            StaticClass.Model = new Model();
        }

        public static void Migration()
        {
            try
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<Model, Configuration>());
                StaticClass.Model.Database.Initialize(force: true);
            }
            catch (Exception ex) { }
        }

        public static void Backup(string backupPath)
        {
            var databaseDirectory = GetDirectoryName(GetDatabasePath());
            ZipFile.CreateFromDirectory(databaseDirectory, backupPath);
        }

        public static void Restore(string backupPath)
        {
            using (ZipArchive zip = ZipFile.Open(backupPath, ZipArchiveMode.Read))
            {
                var databaseDirectory = GetDirectoryName(GetDatabasePath());
                DeleteDatabase();
                zip.ExtractToDirectory(databaseDirectory);
            }
        }

        private static string GetDirectoryName(string fileName)
        {
            return Path.GetDirectoryName(fileName);
        }

        private static string GetDatabasePath()
        {
            return UserSettings.Default.DataSource;
        }

        public static void DeleteDatabase()
        {
            var databasePath = GetDatabasePath();
            File.Delete(databasePath);
        }

        public static void CreateDatabase()
        {
            StaticClass.Model.Database.Create();
        }

        public static void MoveDatabase(string source, string destination)
        {
            File.Move(source, destination);
            GetNewModel();
        }

        public static string GetUserDataSource()
        {
            var dataSource = UserSettings.Default.DataSource;
            return string.IsNullOrEmpty(dataSource) ? null : dataSource;
        }

        public static string GetUserDatabaseFolder()
        {
            return Path.GetDirectoryName(GetUserDataSource());
        }

        public static void ChageUserDataSource(string dataSource)
        {
            UserSettings.Default.DataSource = dataSource;
            UserSettings.Default.Save();
        }
    }
}
