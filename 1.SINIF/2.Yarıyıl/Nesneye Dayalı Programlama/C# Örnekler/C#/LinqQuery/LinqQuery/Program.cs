using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> yeniListe = new List<Ogrenci>();

            Ogrenci ogr = new Ogrenci();
            ogr.bilgi.ad = "Çağlayan";
            ogr.bilgi.soyad = "Kaşdemir";
            ogr.bilgi.TC = "49342832870";
            ogr.notlar.Notlar = new List<decimal> { 100, 50, 75 };

            yeniListe.Add(ogr);

            Ogrenci ogr2 = new Ogrenci();
            ogr2.bilgi.ad = "Ayşe";
            ogr2.bilgi.soyad = "NDP";
            ogr2.bilgi.TC = "49342832754";
            ogr2.notlar.Notlar = new List<decimal> { 75, 75, 75 };
            yeniListe.Add(ogr2);

            var OgrenciBilgi = from ara in yeniListe
                               orderby ara.notlar.Notlar.Average() descending
                               select new
                               {
                                   OgrenciAdi = ara.bilgi.ad,
                                   OgrenciSoyadi = ara.bilgi.soyad,
                                   OgrenciTC = ara.bilgi.TC,
                                   Ortalama = ara.notlar.Notlar.Average()
                               };
            Console.WriteLine("TC\t\tAdı\t\tSoyadi\t\tOrtalama");
            foreach (var value in OgrenciBilgi)
            {
                Console.WriteLine(value.OgrenciTC + "\t" + value.OgrenciAdi + "\t" + value.OgrenciSoyadi + "\t" + value.Ortalama);
            }
        }
    }
}
