using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareDikdortgenYamuk
{
    class Dikdortgen:Sekil
    {
        public Dikdortgen(int kisa, int uzun)
            : base(kisa, uzun)
        {
        }
        public override int AlanHesapla()
        {
            return kenarKisa * kenarUzun;
        }
    }
}
