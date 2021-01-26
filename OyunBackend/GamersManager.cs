using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackend
{
    class GamersManager
    {
        public void AddGamer(Gamers gamer)
        {
            Console.WriteLine(gamer.GamerName + " oyuncusu için kayıt oluşturuldu...");
        }
        public void DeleteGamer(Gamers gamer)
        {

            Console.WriteLine(gamer.GamerTc + " " + gamer.GamerName + " " + gamer.GamerPhone + " " + " oyuncusu Silindi.");
        }

        public void TcKontrol(Gamers gamer)
        {

            Console.WriteLine("TC Kimlik no kontrolü yapıldı");

        }
    }
}
