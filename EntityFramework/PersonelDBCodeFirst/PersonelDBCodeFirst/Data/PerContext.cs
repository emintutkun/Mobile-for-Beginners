using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web.DynamicData;

namespace PersonelDBCodeFirst.Data
{
    public class PerContext : DbContext
    {
        //Migration(veri tabanı güncelleme) eğer veri tabanı yoksa oluşturur.
        //Migration ile bağlantı sağlıyoruz.
        //1.Adım enable-migrations
        //2.Adım add-migration
        //3.Adım update-database
        //4.adım gerekli is 2.Adıma git(Column ekleme vs..)
        public PerContext()
            : base("Baglanti")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Personel> Personel { get; set; }
        
    }
    [TableName("Personel")]
    public class Personel
    {
        [Key] //altındaki property primary key olur
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}