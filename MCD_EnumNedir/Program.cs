using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.musteriNumara = "MSN001";
            m1.isim = "Gülben";
            m1.soyisim = "Ergen";
            m1.emailAdres = "gülbenergen@hotmail.com";

            VirtualDatabase VB = new VirtualDatabase();
            MusteriReturnValue musteriKayitSonuc = VB.MusteriYeniKayit(m1);

            int enumInt = (int)MusteriReturnValue.kayitBasarili;
            Console.WriteLine(enumInt);
        }
    }
}
