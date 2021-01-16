using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // büyük harfle başlması naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+ urun);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }
    }
}
