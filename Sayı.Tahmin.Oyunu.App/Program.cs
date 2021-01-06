using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahmin.App
{
    class Program
    {
        static void Main(string[] args)
        {//ARİF TALHA USLU 203801009 GAZİ ÜNİVERSİTESİ TUSAŞ KAZAN MYO

            byte aralik = 0;//PC NİN TUTACAĞI RANDOM ARALIKLARIN DEĞERLERİNİ TUTAN DEĞİŞKEN
            byte hak = 0;//FARKLI SEVİYELER İÇİN FARKLI DENEME SAYILARINI TUTACAK DEĞİŞKEN
            byte puan = 0;//PUAN DEĞERİNİ TUTACAK DEĞİŞKEN
            byte puanartismiktari = 0;//PUAN ARTARKEN FARKLI SEVİYELERDE FARKLI PUAN ARTIŞ DEĞERLERİNİ TUTAR
            byte seviye;//SEVİYE SEÇİMİNİ TUTACAK DEĞİŞKEN

            Console.WriteLine("------Tahmin Et Kazan'a HOŞ GELDİNİZ--------\n\nNASIL OYNANIR: Aklımdan bir sayı tutacağım sen de tahmin etmeye çalışacaksın bu kadar basit\nNOT: \n--Oyunda doğru tahminlerinizle puan kazanacaksınız. \n--Her oyun sonunda yeniden seviye seçebilirsiniz.\n--Sayı tahmini yaparken 'Sayı' dışında bir değer girilirse Seçimler menüsüne yönlendirilirsiniz.");
            for (; ; )
            {
                try
                {
                    do//SEÇİMLER MENÜSÜ:
                    {
                        Console.WriteLine("-----------------\n SEÇİMLER MENÜSÜ\n1-'Kolay' = 1 ve 5 arasında sayı tahmini 3 deneme hakkı(Doğru cevap= '1' Puan)\n2-'Orta' = 1 ve 10 arasında sayı tahmini 3 deneme hakkı(Doğru cevap= '3' Puan)\n3-'Zor' = 1 ve 20 arasında sayı tahmini 4 deneme hakkı(Doğru cevap= '6' Puan)\n\nSeçiniz:");
                        seviye = byte.Parse(Console.ReadLine());
                    } while (seviye != 1 && seviye != 2 && seviye != 3);

                    switch (seviye)//FARKLI SEVİYELER İÇİN DEĞİŞKEN DEĞERLERİ ATANIYOR...
                    {
                        case 1:
                            puanartismiktari = 1;
                            hak = 3;
                            aralik = 5;
                            Console.WriteLine("ZORLUK KOLAY 1-5 arasında bir sayı... DoğruCevap:1puan\nTAHMİN ET");
                            break;
                        case 2:
                            puanartismiktari = 3;
                            hak = 3;
                            aralik = 10;
                            Console.WriteLine("ZORLUK ORTA 1-10 arasında bir sayı... DoğruCevap:3puan\nTAHMİN ET");
                            break;
                        case 3:
                            puanartismiktari = 6;
                            hak = 4;
                            aralik = 20;
                            Console.WriteLine("ZORLUK ZOR 1-20 arasında bir sayı... DoğruCevap:6puan\nTAHMİN ET");
                            break;
                    }

                    Random rnd5 = new Random();
                    int rndm = rnd5.Next(aralik);

                    for (int i = 0; i < hak;)//OYUNUN DÖNGÜSÜNÜN İSKELETİ.
                    {
                        Console.WriteLine($"({hak} deneme hakkınız var):");
                        byte deneme = byte.Parse(Console.ReadLine());

                        if (deneme == rndm)
                        {
                            puan += puanartismiktari;
                            Console.WriteLine($"-----------------\nİyi atış.. \nToplam puanınız:{puan}\n\nSEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                            break;
                        }
                        else if (hak <= 1)
                        {
                            Console.WriteLine($"-----------------\nHakkınız bitti.. Tuttuğum sayı şuydu = '{rndm}' \nToplam puanınız:{puan}\n\nSEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                            break;
                        }
                        else if (deneme < rndm)
                        {//EĞER TUTULAN SAYIDAN KÜÇÜK SAYI YAZARSANIZ TAHMİN DEĞERİNİN DAHA BÜYÜK OLDUĞU İPUCUNU ALIRSINIZ.
                            hak--;
                            Console.WriteLine("TEKRAR DENE ---TUTTUĞUM SAYI DAHA BÜYÜK---");
                        }
                        else if (deneme > rndm)
                        {//EĞER TUTULAN SAYIDAN BÜYÜK SAYI YAZARSANIZ TAHMİN DEĞERİNİN DAHA KÜÇÜK OLDUĞU İPUCUNU ALIRSINIZ.
                            hak--;
                            Console.WriteLine("TEKRAR DENE ---TUTTUĞUM SAYI DAHA KÜÇÜK---");
                        }
                    }
                }
                catch (Exception)//KULLANICI HATASINDA PROGRAMI BAŞA DÖNDÜRÜYOR VE YANLIŞI MESAJ OLARAKVERİYOR
                {
                    Console.WriteLine("\n-----------------\n--HATA: YANLIŞ DEĞER GİRİLDİ SEÇİMLER MENÜSÜNE DÖNMEK İÇİN HER HANGİ BİR TUŞA BASIN--\n-----------------\n");
                }
                Console.ReadKey();
            }
        }
    }
}

