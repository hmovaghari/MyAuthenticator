using MyAuthenticator.FramworkData.Context;
using MyAuthenticator.FramworkData.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
            var databasePath = GetDatabasePath();
            File.Copy(databasePath, backupPath, true);
        }

        public static void Restore(string backupPath)
        {
            var databasePath = GetDatabasePath();
            File.Copy(backupPath, databasePath, true);
        }

        private static string GetDatabasePath()
        {
            return Path.Combine(GetCurrentDirectory(), @"Database\Database.sdf");
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
