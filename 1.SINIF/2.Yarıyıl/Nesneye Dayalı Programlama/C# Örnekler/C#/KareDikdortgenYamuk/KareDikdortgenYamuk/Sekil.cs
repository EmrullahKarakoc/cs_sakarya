using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareDikdortgenYamuk
{
    abstract class Sekil
    {
        protected int kenarKisa;
        protected int kenarUzun;
        
        public Sekil(int kenarKisa, int kenarUzun)
        {
            this.kenarKisa = kenarKisa;
            this.kenarUzun = kenarUzun;
        }
        
        // abstract metotların gövdesi boştur...
        public abstract int AlanHesapla();

        
    }
}
