using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenQuestionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SORULAR

          
            Question[] sorular = new Question[10];

            Question soru1 = new Question();
            soru1.metin = "Ampulü kim icat etimiştir?";
            soru1.A = "Thomas Edison";
            soru1.B = "Nikola Tesla";
            soru1.C = "Isac Newton";
            soru1.D = "James Watt";
            soru1.dogruCvp = "A";
            sorular[0] = soru1;

            Question soru2 = new Question();
            soru2.metin = "Bilge Kül Kağan hangi Türk devletinin kurucusudur?";
            soru2.A = "Hazar Kağanlığı";
            soru2.B = "Büyük Selçuklu Devleti";
            soru2.C = "Göktürk Kağanlığı";
            soru2.D = "Uygur Kağanlığı";
            soru2.dogruCvp = "D";
            sorular[1] = soru2;
            
            Question soru3 = new Question();
            soru3.metin = "Daktilo kullanılarak yazılan ilk kitap hangisidir?";
            soru3.A = "Gizemli Yabancı";
            soru3.B = "Martin Eden";
            soru3.C = "Tom Sawyer'in Maceraları";
            soru3.D = "Hazreti Süleyman'ın Hazineleri";
            soru3.dogruCvp = "C";
            sorular[2] = soru3;

            Question soru4 = new Question();
            soru4.metin = "Dünyanın en derin gölü hangisidir?";
            soru4.A = "Baykal Gölü";
            soru4.B = "Vostok Gölü";
            soru4.C = "Tanganika Gölü";
            soru4.D = "Van Gölü";
            soru4.dogruCvp = "A";
            sorular[3] = soru4;

            Question soru5 = new Question();
            soru5.metin = "Dünya'nın 7 Harikası'ndan biri olan \"Halikarnas Mozolesi\" nerededir?";
            soru5.A = "Mısır";
            soru5.B = "Türkiye";
            soru5.C = "İtalya";
            soru5.D = "Yunanistan";
            soru5.dogruCvp = "B";
            sorular[4] = soru5;

            Question soru6 = new Question();
            soru6.metin = "İlk kişisel bilgisayar(PC) ne zaman icat edildi?";
            soru6.A = "1975";
            soru6.B = "1987";
            soru6.C = "1995";
            soru6.D = "1981";
            soru6.dogruCvp = "D";
            sorular[5] = soru6;

            Question soru7 = new Question();
            soru7.metin = "Çanakkale Zaferi’nin dahil olduğu savaş hangisidir?";
            soru7.A = "1. Dünya Savaşı";
            soru7.B = "1. Balkan Savaşı";
            soru7.C = "2. Balkan Savaşı";
            soru7.D = "Kurtuluş Savaşı";
            soru7.dogruCvp = "A";
            sorular[6] = soru7;

            Question soru8= new Question();
            soru8.metin = "Işık ne kadar hızlıdır?";
            soru8.A = "200.000 kilometre/saniye";
            soru8.B = "150.000 kilometre/saat";
            soru8.C = "1.000.000 kilometre/saniye";
            soru8.D = "300.000 kilometre/saniye";
            soru8.dogruCvp = "D";
            sorular[7] = soru8;

            Question soru9 = new Question();
            soru9.metin ="Dünyanın en kalabalık başkenti neresidir?";
            soru9.A = "İstanbul";
            soru9.B = "Tokyo";
            soru9.C = "Pekin";
            soru9.D = "Washington";
            soru9.dogruCvp = "B";
            sorular[8] = soru9;

            Question soru10 = new Question();
            soru10.metin = "2002 Dünya Kupası 3.lük maçında Türkiye'nin galip gelmesini sağlayan altın golü kim atmıştır?";
            soru10.A = "İlhan Mansız";
            soru10.B = "Hakan Şükür";
            soru10.C = "Nihat Kahveci";
            soru10.D = "Arif Erdem";
            soru10.dogruCvp = "A";
            sorular[9] = soru10;


            #endregion

            #region SORU YAZDIRMA-PUAN HESAPLAMA

            int dogrucevap = 0;
            int yanliscevap = 0;
            for (int i = 0; i < sorular.Length; i++)
            {


                Console.WriteLine((i+1)+". " + sorular[i].metin + "\nA) " + sorular[i].A + "\nB) " + sorular[i].B + "\nC) " + sorular[i].C + "\nD) " + sorular[i].D);
                Console.WriteLine("Verdiğiniz Cevap: ");
                sorular[i].verilenCvp = Console.ReadLine();
                sorular[i].verilenCvp = sorular[i].verilenCvp.ToUpper();

                if (sorular[i].verilenCvp == sorular[i].dogruCvp)
                {
                    dogrucevap++;

                }
                else
                {
                    yanliscevap++;
                }
            }
            Console.WriteLine("Doğru cevap sayısı : " + dogrucevap + "\nYanlış cevap sayısı: " + yanliscevap);
            #endregion
        }

    }
}
