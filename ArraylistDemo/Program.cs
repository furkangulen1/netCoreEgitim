using HalkBank.Collections;
using HalkBank.Collections.Generics;
using System.Collections;

namespace ArraylistDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();

            HalkBankList.MaxElemanSayisi = 20;

            var liste = new HalkBankList(10);
            //liste.MaxElemanSayisi = 10;

            liste.Ekle("Salih");
            liste.Ekle(100);
            liste.Ekle(false);
            liste.Ekle("Ahmet");
            liste.Ekle("Mustafa");
            liste.Ekle("Mustafa 2");

            //liste.Count = 50;

            Console.WriteLine("Eleman Sayısı: {0}", liste.ElemanSayisi);

            liste[1] = "Mehmet";

            //liste.RemoveAll(eleman => eleman == "Salih");
            Console.WriteLine("İlk Eleman: {0}", liste[0]);

            liste.Sil(2);

            //for (int i = 0; i < liste.ElemanSayisi; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}

            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            liste.Temizle();

            var sayilar = new HalkBankList();
            //sayilar.MaxElemanSayisi = 10;

            Console.WriteLine("Eleman Sayısı: {0}", liste.ElemanSayisi);

            Console.WriteLine("*****************");
            HalkBankList<string> isimler = new HalkBankList<string>();
            isimler.Ekle("Salih");
            isimler.Ekle("Mustafa");
            isimler.Ekle("Ahmet");
            isimler.Ekle("Mustafa");
            isimler.Ekle("Mustafa 2");

            string ilkIsim = isimler[0];
            Console.WriteLine("-------------------");

            isimler.RemoveAll(eleman => eleman == "Salih");
            isimler.Ekle("Furkan");
            isimler.Reverse();
            Console.WriteLine("Furkanın indexi: {0}", isimler.IndexOf("Furkan"));
            Console.WriteLine("Mustafanın son indexi: {0}", isimler.LastIndexOf("Mustafa"));
            isimler.RemoveAll(eleman => eleman == "Mustafa");

            foreach (var eleman in isimler)
            {
                Console.WriteLine(eleman);
            }

        }

        private static void ArrayListDemo()
        {
            ArrayList liste = new ArrayList();
            liste.Add("Salih");
            liste.Add(100);
            liste.Add(false);

            //liste.Count = 50;

            Console.WriteLine("Eleman Sayısı: {0}", liste.Count);

            liste[1] = "Mehmet";

            Console.WriteLine("İlk Eleman: {0}", liste[0]);

            liste.RemoveAt(2);

            liste.Clear();
        }
    }
}