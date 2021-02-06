using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class SalesManagement : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + "-->" + "  Adlı kullanıcı  " + game.GameName + "   Adlı oyunu   " +
                game.GamePrice + " a satın aldı.İyi Eğlenceler!!");
        }
    }
}
