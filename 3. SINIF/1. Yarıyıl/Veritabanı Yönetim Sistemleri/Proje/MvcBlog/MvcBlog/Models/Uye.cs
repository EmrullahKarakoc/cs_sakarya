namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uye")]
    public partial class Uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uye()
        {
            Makales = new HashSet<Makale>();
            Yorums = new HashSet<Yorum>();
            Rozets = new HashSet<Rozet>();

        }

        public int Uyeid { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        //[StringLength(50)]
        //public string emailAdress { get; set; }

        [StringLength(20)]
        public string Sifre { get; set; }

        [StringLength(50)]
        public string AdSoyad { get; set; }

        [StringLength(250)]
        public string Foto { get; set; }

        public int? Yetkiid { get; set; }
        public int? UlkeId { get; set; }
        public Ulke Ulke { get; set; }
        public int? SehirId { get; set; }
        public Sehir Sehir { get; set; }
        public int? IlceId { get; set; }
        public Ilce Ilce { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makales { get; set; }
        public virtual ICollection<Rozet> Rozets { get; set; }

        public virtual Yetki Yetki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}
