using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun[] urunler = new Urun[6];

            Urun u1 = new Urun();
            u1.isim = "Domates";
            u1.birim = "Kg";
            u1.fiyat = 23.7;

            urunler[0] = u1;

            Urun u2 = new Urun();
            u2.isim = "Biber";
            u2.birim = "Kg";
            u2.fiyat = 13;

            urunler[1] = u2;

            Urun u3 = new Urun();
            u3.isim = "Yumurta";
            u3.birim = "Ad";
            u3.fiyat = 4.25;

            urunler[2] = u3;

            Urun u4 = new Urun();
            u4.isim = "Süt";
            u4.birim = "Lt";
            u4.fiyat = 32;

            urunler[3] = u4;

            Urun u5 = new Urun();
            u5.isim = "Soğan";
            u5.birim = "Kg";
            u5.fiyat = 17;

            urunler[4] = u5;

            Urun u6 = new Urun();
            u6.isim = "Çay";
            u6.birim = "Kg";
            u6.fiyat = 82;

            urunler[5] = u6;

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine((i+1)+ $") {urunler[i].isim} : \t {urunler[i].fiyat} TL");
            }

            string devammi = "e";
            double toplam = 0;
            while (devammi == "e")
            {
                Console.WriteLine("Sepete eklemek istediğiniz ürün numarasını giriniz;");
                int urunno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kaç " + urunler[urunno - 1].birim + " " + urunler[urunno - 1].isim + " alacaksınız?");
                int adet = Convert.ToInt32(Console.ReadLine());

                double urunfiyat = urunler[urunno - 1].fiyat;

                toplam += urunfiyat * adet;
                Console.Clear();
                Console.WriteLine("Alışverişe devam edilsin mi? e/h");

                devammi = Console.ReadLine();
            }
            Console.WriteLine("ALIŞVERİŞİNİZİN TOPLAM TUTARI = " + toplam + " TL");
        }
    }
}
