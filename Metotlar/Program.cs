using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.fiyati = 15;
            product1.aciklama = "Niğde Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.fiyati = 60;
            product2.aciklama = "Diyarbakır karpuzu";

            Product product3 = new Product();
            product3.Adi = "Kayısı";
            product3.fiyati = 50;
            product3.aciklama = "Malatya kayısısı";

            Product[] products = new Product[] {product1,product2,product3 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi );
                Console.WriteLine(product.fiyati );
                Console.WriteLine(product.aciklama);
                Console.WriteLine("----------------------");
                //cw yaz tap tap console writeline kısmını yazar
            }

            Console.WriteLine("--------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);
          


        }
    }
}
