using System;
using System.Collections.Generic;
using System.Text;

namespace _23OcakOdev
{
    class GamerManager:IPerson
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("{0} {1} isimli oyuncu sisteme eklendi", gamer.Isim,gamer.Soyisim) ;
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} {1} isimli oyuncunun sistemde bilgileri güncellendi", gamer.Isim, gamer.Soyisim);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} isimli oyuncu sistemden silindi", gamer.Isim, gamer.Soyisim);
        }
    }
}
