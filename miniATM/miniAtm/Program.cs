using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silebilirsiin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM'ye Hoşgeldiniz.");
            Console.WriteLine("Hangi İşlemi Yapmak İstersiniz?");
            Console.WriteLine("Bakiye sorgulamak için: 1");
            Console.WriteLine("Para Çekmek için: 2");
            Console.WriteLine("Para Yatırmak için: 3");
            Console.WriteLine("Çıkış Yapmak için: q");
            Console.Write("İşleminiz:");
            int bakiye = 1000;
            string secim = Console.ReadLine();
            Console.WriteLine("Seçiminiz: "+secim);
            if (secim=="1")
            {
                Console.WriteLine("Bakiyeniz: "+bakiye);
                Console.WriteLine("Çıkmak için lütfen enter'a basınız.");
                Console.ReadLine();
            }
            else if (secim=="2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                int cekilecektutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecektutar>bakiye)
                {
                    Console.WriteLine("Yetersiz bakiye!");
                    Console.WriteLine("Çıkmak için lütfen enter'a basınız.");
                }
                else if (cekilecektutar<0)
                {
                    Console.WriteLine("Eksik bakiye çekemezsiniz!");
                    Console.WriteLine("Çıkmak için lütfen enter'a basınız.");

                }
                else
                {
                    Console.WriteLine("Kalan tutar: " + (bakiye - cekilecektutar));
                    Console.WriteLine("Çıkmak için lütfen enter'a basınız.");
                }
                Console.ReadLine();
            }
            else if (secim=="3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutar: ");
                int yatirma = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni tutar: "+ (yatirma+bakiye));
                Console.WriteLine("Çıkmak için lütfen enter'a basınız.");
                Console.ReadLine();
            }
            else if (secim=="q")
            {
                Console.WriteLine("Çıkış yapılıyor");
                Console.WriteLine("Çıkmak için lütfen enter'a basınız.");
                Console.ReadLine();
            }
            else if ((secim !="1")&&(secim!="2")&&(secim!="3")&&(secim!="q"))
            {
                Console.WriteLine("Yanlış seçim");
                Console.WriteLine("Çıkmak için lütfen enter'a basınız.");
                Console.ReadLine();
            }
            
        }
    }
}
