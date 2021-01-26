using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackend
{
    interface IGameManager
    {
        void AddGame(Games game);

        void DeleteGame(Games game);

        void SellGame(List<Games> games, List<Gamers> gamer, List<Campaigns> campaigns);
    }
}
