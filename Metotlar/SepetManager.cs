using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler," + product.Adi + " Sepete eklendi. " );
        }
        public void Ekle2(string Adi, string aciklama , double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler," + Adi + " Sepete eklendi. ");
        }
    }
}
