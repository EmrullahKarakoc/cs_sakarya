using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareDikdortgenYamuk
{
    class Kare:Sekil
    {
        public Kare(int kisa)
            : base(kisa, kisa)
        {

        }
        public override int AlanHesapla()
        {
            return this.kenarKisa * this.kenarUzun;
        }
    }
}
