using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiOrnek
{
    class Kisi
    {
        private string isim;
        private int boy;
        private int yas;
        private int kilo;
        private int cinsiyet;
        public Kisi()
        {
            setIsim("");
            setBoy(0);
            setYas(0);
            setKilo(0);
            cinsiyet = 1;
        }
        public Kisi(string isim,int boy,int yas,int kilo,int cinsiyet)
        {
            setIsim(isim);
            setBoy(boy);
            setYas(yas);
            setKilo(kilo);
            if (cinsiyet < 1 || cinsiyet > 2) setCinsiyet();
            else this.cinsiyet = cinsiyet;
        }
        public void bilgiGir()
        {
            Console.Write("İsminiz : ");
            setIsim(Console.ReadLine());
            Console.Write("Boyunuz : ");
            int boy = int.Parse(Console.ReadLine());
            setBoy(boy);
            Console.Write("Yaşınız : ");
            setYas(int.Parse(Console.ReadLine()));
            Console.Write("Kilonuz : ");
            setKilo(int.Parse(Console.ReadLine()));
            setCinsiyet();
        }
        public void bilgiYaz()
        {
            Console.WriteLine("Sayın " + isim);
            Console.WriteLine("Boyunuz : " + boy);
            Console.WriteLine("Yaşınız : " + yas);
            Console.WriteLine("Kilonuz : " + kilo);
            Console.WriteLine("Cinsiyetiniz : " + getCinsiyet());
            Console.WriteLine("İdeal Kilonuz : " + getIdealKilo());

        }
        public void setIsim(string isim)
        {
            this.isim = isim;
            if (isim == " ") this.isim = "Yok";
            else if (isim.Length < 2) this.isim = "Yok";
            else if (isim.Length > 15) this.isim = isim.Substring(0, 14);
        }
        public void setBoy(int boy)
        {
            this.boy = boy;
            if (boy < 150) this.boy = 150;
            else if (boy > 250) this.boy = 250;
        }
        public void setYas(int yas)
        {
            if (yas < 18) yas = 18;
            else if (yas > 80) yas = 80;
            this.yas = yas;
        }
        public void setKilo(int kilo)
        {
            if (kilo < 30) kilo = 30;
            else if (kilo > 120) kilo = 120;
            this.kilo = kilo;
        }
        public void setCinsiyet()
        {
            int c = 0;
            do
            {
                Console.Write("Cinsiyetiniz (Kadın,Erkek): ");
                string cinsiyet = Console.ReadLine();
                if (cinsiyet.ToLower() == "kadin" || cinsiyet.ToLower() == "kadın")
                    c = 1;
                else if (cinsiyet.ToLower() == "erkek")
                    c = 2;
            } while (c == 0);
            this.cinsiyet = c;
        }
        public string getCinsiyet()
        {
            if (cinsiyet == 1) return "Kadın";
            return "Erkek";
        }
        public int getIdealKilo()
        {
            if (cinsiyet==1)
                return int.Parse(Math.Round((boy - 100) * 0.8 + (yas / 10.0)).ToString());
            return int.Parse(Math.Round((boy - 100) * 0.9 + (yas / 10.0)).ToString());

        }
    }
}
