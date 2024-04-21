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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Model, Configuration>());
            StaticClass.Model.Database.Initialize(force: true);
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
                //var databasePath = GetDatabasePath();
                //var dataBaseFileName = Path.GetFileName(DatabaseLocalPath());
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
            return Path.Combine(GetCurrentDirectory(), DatabaseLocalPath());
        }

        private static string DatabaseLocalPath()
        {
            return @"Database\Database.sdf";
        }

        private static string GetCurrentDirectory()
        {
            return Environment.CurrentDirectory;
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
    }
}
