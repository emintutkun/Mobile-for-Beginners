using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace OgrenciProjeCodeFirst.Models.Data
{
    public class OgrenciContext : DbContext
    {
        // Your context has been configured to use a 'OgrenciContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OgrenciProjeCodeFirst.Models.Data.OgrenciContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OgrenciContext' 
        // connection string in the application configuration file.
        public OgrenciContext()
            : base("Baglanti")//Baglanti
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CityId { get; set; }

    }
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

    }
}