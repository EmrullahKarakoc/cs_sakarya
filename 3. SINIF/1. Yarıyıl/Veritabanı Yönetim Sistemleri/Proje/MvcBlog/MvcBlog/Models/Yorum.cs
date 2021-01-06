namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        public int Yorumid { get; set; }

        [StringLength(500)]
        public string Icerik { get; set; }

        public int? Uyeid { get; set; }

        public int? Makaleid { get; set; }

        public DateTime? Tarih { get; set; }

        public virtual Makale Makale { get; set; }

        public virtual Uye Uye { get; set; }
    }
}
