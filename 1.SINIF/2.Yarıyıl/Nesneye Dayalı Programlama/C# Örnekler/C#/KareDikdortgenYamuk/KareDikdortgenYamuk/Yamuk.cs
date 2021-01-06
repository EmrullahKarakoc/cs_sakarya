using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareDikdortgenYamuk
{
    class Yamuk : Sekil
    {
        private int yukseklik;
        public Yamuk(int kisa, int uzun, int yukseklik)
            : base(kisa, uzun)
        {
            this.yukseklik = yukseklik;
        }
        public override int AlanHesapla()
        {
            return (this.kenarKisa + this.kenarUzun) * this.yukseklik / 2;
        }
        public override void Yazdir()
        {
            Console.WriteLine(this.yukseklik * (this.kenarKisa + this.kenarUzun) / 2);
        }
    }
}
