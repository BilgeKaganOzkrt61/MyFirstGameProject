using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IGameService
    {
        void Buy(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
