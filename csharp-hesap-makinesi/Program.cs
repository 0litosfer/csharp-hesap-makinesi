using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    { }
        namespace JaggedArray {
        class Program {
            static void Main(string[] args)
            {
                double sayi1, sayi2 = 0, sonuc = 0;
                string islem;

                Console.WriteLine("----------------------------------");
                Console.WriteLine("    C# BASİT HESAP MAKİNESİ");
                Console.WriteLine("----------------------------------");

                // 1. Kullanıcıdan birinci sayıyı al
                Console.Write("Birinci sayıyı giriniz: ");
                sayi1 = Convert.ToDouble(Console.ReadLine());

                // 2. Yapılacak işlemi sor
                Console.WriteLine("\nYapılacak işlemi seçiniz:");
                Console.WriteLine("Toplama: +");
                Console.WriteLine("Çıkarma: -");
                Console.WriteLine("Çarpma:  *");
                Console.WriteLine("Bölme:   /");
                Console.WriteLine("Karesini Alma: kare");
                Console.WriteLine("Karekökünü Alma: kok");
                Console.Write("Seçiminiz: ");
                islem = Console.ReadLine();

                // 3. İşleme göre ikinci sayıyı iste veya işlemi yap
                switch (islem)
                {
                    case "+":
                        Console.Write("İkinci sayıyı giriniz: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine($"\nSonuç: {sayi1} + {sayi2} = " + sonuc);
                        break;

                    case "-":
                        Console.Write("İkinci sayıyı giriniz: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine($"\nSonuç: {sayi1} - {sayi2} = " + sonuc);
                        break;

                    case "*":
                        Console.Write("İkinci sayıyı giriniz: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine($"\nSonuç: {sayi1} * {sayi2} = " + sonuc);
                        break;

                    case "/":
                        Console.Write("İkinci sayıyı giriniz: ");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                        // Sıfıra bölme hatasını kontrol et
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine($"\nSonuç: {sayi1} / {sayi2} = " + sonuc);
                        }
                        else
                        {
                            Console.WriteLine("\nHata: Bir sayı 0'a bölünemez!");
                        }
                        break;
                    
                    case "kare":
                        sonuc = sayi1 * sayi1;
                        Console.WriteLine($"\nSonuç: {sayi1} sayısının karesi = " + sonuc);
                        break;

                    case "kok":
                        if (sayi1 >= 0)
                        {
                            sonuc = Math.Sqrt(sayi1);
                            Console.WriteLine($"\nSonuç: {sayi1} sayısının karekökü = " + sonuc);
                        }
                        else
                        {
                             Console.WriteLine("\nHata: Negatif sayıların karekökü alınamaz!");
                        }
                        break;

                    default:
                        Console.WriteLine("\nHata: Geçersiz bir işlem seçtiniz.");
                        break;
                }

                // Programın hemen kapanmasını önlemek için bir tuşa basılmasını bekle
                Console.WriteLine("\nÇıkmak için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }
}