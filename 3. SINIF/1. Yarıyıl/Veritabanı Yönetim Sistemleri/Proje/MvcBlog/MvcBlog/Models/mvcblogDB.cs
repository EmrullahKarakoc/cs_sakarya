namespace MvcBlog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class mvcblogDB : DbContext
    {
        public mvcblogDB()
            : base("name=mvcblogDB")
        {
        }

        public virtual DbSet<Etiket> Etikets { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Makale> Makales { get; set; }
        public virtual DbSet<Uye> Uyes { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }
        public virtual DbSet<Yorum> Yorums { get; set; }
        public virtual DbSet<Rozet> Rozets { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etiket>()
                .HasMany(e => e.Makales)
                .WithMany(e => e.Etikets)
                .Map(m => m.ToTable("MakaleEtiket").MapLeftKey("Etiketid").MapRightKey("Makaleid"));
        }

        public System.Data.Entity.DbSet<MvcBlog.Models.Ulke> Ulkes { get; set; }

        public System.Data.Entity.DbSet<MvcBlog.Models.Ilce> Ilces { get; set; }

        public System.Data.Entity.DbSet<MvcBlog.Models.Sehir> Sehirs { get; set; }
    }
}
