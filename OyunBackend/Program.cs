using System;
using System.Collections.Generic;

namespace OyunBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaigns halfPriceCampain = new Campaigns() { };
            GamersManager gamersManager = new GamersManager() { };
            GamesManager gamesManager = new GamesManager() { };
            Games game = new Games() { };
            Gamers gamer = new Gamers() { };
            gamer.GamerTc = "1234567890";
            gamer.GamerName = "Türker Özakıncı";
            gamer.GamerPhone = "5555554433";
            game.GameName = "Codemino";
            

            gamesManager.AddGame(game);
            gamersManager.TcKontrol(gamer);
            List<Games> games = new List<Games>() { game };
            List<Gamers> gamers = new List<Gamers>() { gamer };
            List<Campaigns> campains = new List<Campaigns>() { halfPriceCampain };

            gamesManager.SellGame(games, gamers, campains);
        }
    }
}
