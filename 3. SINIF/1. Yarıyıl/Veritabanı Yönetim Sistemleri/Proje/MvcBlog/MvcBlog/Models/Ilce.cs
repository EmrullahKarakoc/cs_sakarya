using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlog.Models
{
    public class Ilce
    {
        public int Id { get; set; }
        public string Ilceadi { get; set; }
        public int Sehirid { get; set; }
        public Sehir Sehir { get; set; }
        public List<Uye> Uye { get; set; }


    }
}