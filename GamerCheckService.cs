using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class GamerCheckService : IGamerCheckService
    {
        public void ChecktheGamer(Gamer gamer)
        {
            if (gamer.FirstName == "Bilge Kağan" & gamer.LastName == "Özkurt" & gamer.IdentityNumber == 12345678999 ||
                gamer.FirstName == "Yusuf Taha" & gamer.LastName == "Çebi" & gamer.IdentityNumber == 98765432111) 
            {
                Console.WriteLine("Kullanıcı Doğrulandı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Doğrulanamadı.Lütfen Bilgilerinizi Kontrol Ediniz.");
            }


        }

    }

}

