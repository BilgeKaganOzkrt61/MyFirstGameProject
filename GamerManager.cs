using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine( gamer.GamerId + gamer.FirstName, gamer.LastName, gamer.UserName +
                "Oyuncu Ekleme İşleme Tamamlandı. İYİ EĞLENCELER ! ! ");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerId + gamer.FirstName, gamer.LastName, gamer.UserName +
                "Oyuncu Silme İşlemi Tamamlandı. Gidişiniz Bizi Üzüyor ! !");
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerId + gamer.FirstName, gamer.LastName, gamer.UserName +
                "Oyuncu Bilgileri Güncelleme İşlemi Tamamlandı. İYİ EĞLENCELER ! ! ");
        
        }
    }
}
