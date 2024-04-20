using System;
using System.Data.Entity;
using System.Linq;

namespace MyAuthenticator.FramworkData.Context
{
    public class Model : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MyAuthenticator.FramworkData.Context.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Model()
            : base("name=Model")
        {
        }

        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }

        // Add a DbSet for each entity type that you want to include in your StaticClass.Model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Password>()
                //.HasIndex(e => new { e.Field1, e.Field2 })
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<Password>()
                .Property(e => e.RowNumber)
                .HasPrecision(38, 0);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}