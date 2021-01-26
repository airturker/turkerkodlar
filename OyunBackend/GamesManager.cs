using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackend
{
    class GamesManager: IGameManager
    {
        public void AddGame(Games game)
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public void DeleteGame(Games game)
        {
            Console.WriteLine("Oyun Silindi...");
        }

        public void SellGame(List<Games> games, List<Gamers> gamers, List<Campaigns> campaigns)
        {
            foreach (var gamer in gamers)
            {

                foreach (var game in games)
                {

                    foreach (var campaign in campaigns)
                    {

                        Console.WriteLine(gamer.GamerTc + "TC'li, " + gamer.GamerName + " isimli, " + game.GameName + " adlı Oyunu, " + game.GamePrice * campaign.CampaignDiscountRate + " fiyatına oyun satın aldı...");
                    }
                }


            }
            Console.WriteLine("Oyun Satıldı..");
        }
    }
}
