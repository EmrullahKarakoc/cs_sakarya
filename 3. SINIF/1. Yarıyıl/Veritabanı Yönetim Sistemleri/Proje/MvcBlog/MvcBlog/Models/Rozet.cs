using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBlog.Models
{
    public class Rozet
    {
        public Rozet()
        {
            this.Uye = new HashSet<Uye>();
        }
        public int Id { get; set; }
        public string Rozetadi { get; set; }
        public virtual ICollection<Uye> Uye { get; set; }

    }
}