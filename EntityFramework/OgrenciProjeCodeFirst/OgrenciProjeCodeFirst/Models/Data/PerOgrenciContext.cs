using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web.DynamicData;

namespace OgrenciProjeCodeFirst.Models.Data
{
    public class PerOgrenciContext : DbContext
    {
        // Your context has been configured to use a 'PerOgrenciContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OgrenciProjeCodeFirst.Models.Data.PerOgrenciContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PerOgrenciContext' 
        // connection string in the application configuration file.
        public PerOgrenciContext()
            : base("Baglanti")
        {
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
    }
    
    public class Student : Base
    {
        
    }

    public class Teacher : Base
    {
        public int Salary { get; set; }
    }

    abstract public class Base
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int CityId { get; set; }
        public string MotherName { get; set; }
        [ForeignKey("CityId")]//bunun anlamı city id city'den al ve student içerisinde eşleştir.
        public virtual City City { get; set; }//foreign key bu bağlantının üzerinde olmak zorundadır.
        public string FullName()
        {
            return Name + " " + SurName;
        }
    }

    public class City
    {
        public City()//.net core da buna ihtiyaç olmayacak.
        {
            this.Students = new HashSet<Student>();//ICollection null dönmemesi için constructor içerisinde nesne oluşturulmalıdır.
            this.Teachers = new HashSet<Teacher>();
        }
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public ICollection<Student> Students { get; set; }//bunun anlamı bir şehre birden fazla öğrenci dahil olabilir.
        public ICollection<Teacher> Teachers { get; set; }
    }
}