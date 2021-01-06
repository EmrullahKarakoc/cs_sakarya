using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlog.Models
{
    public class Ulke
    {
        public int Id { get; set; }
        public string Ulkeadi { get; set; }
        public List<Uye> Uye { get; set; }
    }
}