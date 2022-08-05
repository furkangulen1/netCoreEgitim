using HalkBank.Collections;
using HalkBank.Collections.Generics;
using System.Collections;

namespace ArraylistDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayListDemo();

            HalkbankListDemo();

            GenericHalkbankListDemo();
            
        }

        private static void ArrayListDemo()
        {
            Console.WriteLine("ArrayListDemo --------");
            ArrayList liste = new ArrayList();
            liste.Add("Salih");
            liste.Add(100);
            liste.Add(false);

            //liste.Count = 50;

            Console.WriteLine("Eleman Sayısı(3): {0}", liste.Count);

            liste[1] = "Mehmet";

            Console.WriteLine("İlk Eleman(Salih): {0}", liste[0]);

            liste.RemoveAt(2);
                         
            Console.WriteLine("Aşağıda Olması Gereken: Salih, Mehmet");
            foreach (object eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            liste.Clear();
            liste.Add("Furkan");
            liste.Add("Ahmet");
            liste.Add("Furkan");
            liste.Add("Ali");
            Console.WriteLine("Furkan' ın ilk indexi(0): {0}", liste.IndexOf("Furkan"));
            Console.WriteLine("Furkan' ın son indexi(2): {0}", liste.LastIndexOf("Furkan"));
            Console.WriteLine("ArrayListDemo bitti ---------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        private static void HalkbankListDemo()
        {
            Console.WriteLine("HalkbankListDemo ---------------");

            HalkBankList.MaxElemanSayisi = 20;

            var liste = new HalkBankList(10);
            
            liste.Ekle("Salih");
            liste.Ekle(100);
            liste.Ekle(false);
            liste.Ekle("Ahmet");
            liste.Ekle("Mustafa");
            liste.Ekle("Salih");
            liste.Ekle("Mustafa 2");

            Console.WriteLine("Eleman Sayısı(7): {0}", liste.ElemanSayisi);

            liste[1] = "Mehmet";

            liste.RemoveAll(eleman => eleman.ToString() == "Salih");
            Console.WriteLine("İlk Eleman(Mehmet): {0}", liste[0]);

            liste.Sil(1);

            Console.WriteLine("Aşağıda Olması Gereken: Mehmet, Ahmet, Mustafa, Mustafa 2");
            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            liste.Temizle();
            Console.WriteLine("Eleman Sayısı(0): {0}", liste.ElemanSayisi);

            liste.Ekle("Furkan");
            liste.Ekle("Ahmet");
            liste.Ekle("Furkan");
            liste.Ekle("Ali");

            liste.Reverse();
            Console.WriteLine("- HalkbankList ters çevrildi -");

            Console.WriteLine("Furkan' ın ilk indexi(1): {0}", liste.IndexOf("Furkan"));
            Console.WriteLine("Furkan' ın son indexi(3): {0}", liste.LastIndexOf("Furkan"));
            Console.WriteLine("HalkbankListDemo bitti ---------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            

        }

        private static void GenericHalkbankListDemo()
        {
            Console.WriteLine("Generic HalkbankListDemo --------");
            //HalkBankList.MaxElemanSayisi = 20;

            HalkBankList<string> liste = new HalkBankList<string>();

            //var liste = new HalkBankList(10);

            liste.Ekle("Furkan");
            liste.Ekle("Salih");
            liste.Ekle("Ahmet");
            liste.Ekle("Mustafa");
            liste.Ekle("Salih");
            liste.Ekle("Mustafa 2");

            Console.WriteLine("Eleman Sayısı(6): {0}", liste.ElemanSayisi);

            liste[2] = "Mehmet";

            liste.RemoveAll(eleman => eleman.ToString() == "Salih");
            Console.WriteLine("İlk Eleman(Furkan): {0}", liste[0]);

            liste.Sil(1);

            Console.WriteLine("Aşağıda Olması Gereken: Furkan, Mustafa, Mustafa 2");
            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            liste.Temizle();
            Console.WriteLine("Eleman Sayısı(0): {0}", liste.ElemanSayisi);

            liste.Ekle("Furkan");
            liste.Ekle("Ahmet");
            liste.Ekle("Furkan");
            liste.Ekle("Ali");

            liste.Reverse();
            Console.WriteLine("- Generic HalkbankList ters çevrildi -");

            Console.WriteLine("Furkan' ın ilk indexi(1): {0}", liste.IndexOf("Furkan"));
            Console.WriteLine("Furkan' ın son indexi(3): {0}", liste.LastIndexOf("Furkan"));
            Console.WriteLine("Generic HalkbankListDemo bitti ---------------");

        }


    }
}