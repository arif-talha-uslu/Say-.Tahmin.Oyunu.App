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

            byte puan = 0;//PUAN DEĞERİNİ TUTACAK DEĞİŞKEN

            Console.WriteLine("------Tahmin Et Kazan'a HOŞ GELDİNİZ--------\n");
            Console.WriteLine("NASIL OYNANIR: Aklımdan bir sayı tutacağım sen de tahmin etmeye çalışacaksın bu kadar basit");
            Console.WriteLine("NOT: \n--Oyunda doğru tahminlerinizle puan kazanacaksınız. \n--Her oyun sonunda yeniden seviye seçebilirsiniz.");
            Console.WriteLine("--Sayı tahmini yaparken 'Sayı' dışında bir değer girilirse Seçimler menüsüne yönlendirilirsiniz.");
            Console.WriteLine("--Oyundan çıkmak için 'SEÇİMLER MENÜSÜ' geldiğinde 'çıkış' yazabilirsiniz");

            for (; ; )//"OYUN ÇIKIŞ YAPILANA KADAR DEVAM ETSİN" DÖNGÜSÜ.
            {
                try
                {
                    Console.WriteLine("-----------------\n SEÇİMLER MENÜSÜ");
                    Console.WriteLine("\n'Kolay' = 1 ve 5 arasında sayı tahmini 2 deneme hakkı(Doğru cevap= '1' Puan)");
                    Console.WriteLine("'Orta' = 1 ve 10 arasında sayı tahmini 3 deneme hakkı(Doğru cevap= '3' Puan)");
                    Console.WriteLine("'Zor' = 1 ve 20 arasında sayı tahmini 5 deneme hakkı(Doğru cevap= '6' Puan)");
                    Console.WriteLine("'Çıkış' = Oyunu sonlandır\n");
                    Console.WriteLine("Seçiniz:");

                    string seviye = Console.ReadLine().ToLower();
                    Console.WriteLine("-----------------");

                    Random rnd5 = new Random();
                    int random5 = rnd5.Next(5);
                    Random rnd10 = new Random();
                    int random10 = rnd10.Next(10);
                    Random rnd20 = new Random();
                    int random20 = rnd20.Next(20);

                    if (seviye == "çıkış")
                    {
                        Console.WriteLine($"YİNE BEKLERİZ SKORUNUZ = {puan}");
                        break;
                    }
                    else if (seviye == "kolay")//KOLAY SEVİYEDE OYUN DÖNGÜSÜ
                    {
                        #region KOLAY SEVİYE 1-5
                        byte hak5 = 2;
                        Console.WriteLine("ZORLUK KOLAY 1-5 arasında bir sayı... DoğruCevap:1puan");
                        Console.WriteLine($"TAHMİN ET({hak5} deneme hakkınız kaldı):");
                        for (int i = 0; i < 2; i++)
                        {
                            byte deneme1 = byte.Parse(Console.ReadLine());

                            if (deneme1 == random5)
                            {
                                puan++;
                                Console.WriteLine($"-----------------\nİyi atış... \nToplam puanınız:{puan}\n");
                                Console.WriteLine("SEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                                Console.ReadKey();
                                break;
                            }
                            else if (i == 1)
                            {
                                Console.WriteLine($"-----------------\nHakkınız bitti... Tuttuğum sayı şuydu = '{random5}' \nToplam puanınız:{puan}\n");
                                Console.WriteLine("SEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                                Console.ReadKey();
                                break;
                            }
                            else if (deneme1 - random5 == 1 || deneme1 - random5 == -1)
                            {//EĞER TUTULAN SAYIYA 1 ADIM YAKINSANIZ "ÇOK YAKLAŞTIN" MESAJI ALIRSINIZ
                                hak5--;
                                Console.WriteLine($"ÇOK YAKLAŞTIN - Tekrar Dene({hak5} deneme hakkınız kaldı):");
                            }
                            else
                            {
                                hak5--;
                                Console.WriteLine($"Tekrar Dene({hak5} deneme hakkınız kaldı):");
                            }
                        }
                        #endregion
                    }
                    else if (seviye == "orta")//ORTA SEVİYEDE OYUN DÖNGÜSÜ
                    {
                        #region ORTA SEVİYE 1-10
                        byte hak10 = 3;
                        Console.WriteLine("ZORLUK ORTA 1-10 arasında bir sayı... DoğruCevap:3puan");
                        Console.WriteLine($"TAHMİN ET({hak10} deneme hakkınız kaldı):");
                        for (int i = 0; i < 3; i++)
                        {
                            byte deneme2 = byte.Parse(Console.ReadLine());

                            if (deneme2 == random10)
                            {
                                puan += 3;
                                Console.WriteLine($"-----------------\nİyi atış... \nToplam puanınız:{puan}\n");
                                Console.WriteLine("SEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                                Console.ReadKey();
                                break;
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine($"-----------------\nHakkınız bitti... Tuttuğum sayı şuydu = '{random10}' \nToplam puanınız:{puan}\n");
                                Console.WriteLine("SEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                                Console.ReadKey();
                                break;
                            }
                            else if (deneme2 - random10 == 1 || deneme2 - random10 == -1 || deneme2 - random10 == 2 || deneme2 - random10 == -2)
                            {//EĞER TUTULAN SAYIYA 2 ADIM YAKINSANIZ "ÇOK YAKLAŞTIN" MESAJI ALIRSINIZ
                                hak10--;
                                Console.WriteLine($"ÇOK YAKLAŞTIN - Tekrar Dene({hak10} deneme hakkınız kaldı):");
                            }
                            else
                            {
                                hak10--;
                                Console.WriteLine($"Tekrar Dene({hak10}deneme hakkınız kaldı):");
                            }
                        }
                        #endregion
                    }
                    else if (seviye == "zor")//ZOR SEVİYEDE OYUN DÖNGÜSÜ
                    {
                        #region ZOR SEVİYE 1-20
                        byte hak20 = 5;
                        Console.WriteLine("ZORLUK ZOR 1-20 arasında bir sayı... DoğruCevap:6puan");
                        Console.WriteLine($"TAHMİN ET({hak20} deneme hakkınız kaldı):");
                        for (int i = 0; i < 5; i++)
                        {
                            byte deneme3 = byte.Parse(Console.ReadLine());

                            if (deneme3 == random20)
                            {
                                puan += 6;
                                Console.WriteLine($"-----------------\nİyi atış... \nToplam puanınız:{puan}\n");
                                Console.WriteLine("SEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                                Console.ReadKey();
                                break;
                            }
                            else if (i == 4)
                            {
                                Console.WriteLine($"-----------------\nHakkınız bitti... Tuttuğum sayı şuydu = '{random20}' \nToplam puanınız:{puan}\n");
                                Console.WriteLine("SEÇİMLER menüsüne dönmek için 'ENTER'\n-----------------");
                                Console.ReadKey();
                                break;
                            }
                            else if (deneme3 - random20 == 1 || deneme3 - random20 == -1 || deneme3 - random20 == 2 || deneme3 - random20 == -2)
                            {//EĞER TUTULAN SAYIYA 2 ADIM YAKINSANIZ "ÇOK YAKLAŞTIN" MESAJI ALIRSINIZ
                                hak20--;
                                Console.WriteLine($"ÇOK YAKLAŞTIN - Tekrar Dene({hak20} deneme hakkınız kaldı):");
                            }
                            else
                            {
                                hak20--;
                                Console.WriteLine($"Tekrar Dene(Kalan Hak Sayısı:{hak20}):");
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        Console.WriteLine("-----------------\nSadece 'kolay' / 'orta' / 'zor' / 'çıkış' seçebilirsiniz\n-----------------");//SEÇİMLERDE YANLIŞ YAPILIRSA MESAJI
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("!--YANLIŞ DEĞER GİRİLDİ--! \n- SEÇİMLER MENÜSÜNE DÖNMEK İÇİN HER HANGİ BİR TUŞA BASIN");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}

