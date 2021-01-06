using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlog.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public string Sehiradi { get; set; }
        public Ulke Ulke { get; set; }
        public List <Ilce> Ilce { get; set; }
        public List<Uye> Uye { get; set; }

    }
}