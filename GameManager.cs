using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class GameManager : IGameService
    {
        public void Buy(Game game)
        {
            Console.WriteLine(game.GameId +" : " + game.GameName + " ==> " + game.GamePrice +
                "Oyun Satın Alındı. İYİ EĞLENCELER !!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameId + " : " + game.GameName + " ==> " + game.GamePrice +
                "Oyun Kaldırıldı !!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameId + " : " + game.GameName + " ==> " + game.GamePrice +
                "Oyun Güncellenemesi Tamamlandı. İYİ EĞLENCELER !!");
        }
    }
}
