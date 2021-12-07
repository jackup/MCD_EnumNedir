using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_EnumNedir
{
    public class VirtualDatabase
    {
        ArrayList sanalDB = new ArrayList();

        public MusteriReturnValue MusteriYeniKayit(Musteri m)
        {
            //parametre kontrol
            //kayıt kontrol

            sanalDB.Add(m);
            return MusteriReturnValue.kayitBasarili;
        }
    }
}
