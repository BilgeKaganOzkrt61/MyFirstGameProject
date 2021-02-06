using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1;
            gamer1.FirstName = "Bilge Kağan";
            gamer1.LastName = "Özkurt";
            gamer1.CreditCartNumber = 1234567890123456;
            gamer1.UserName = "bilgekagan61";
            gamer1.BirthYear = "2004";
            gamer1.IdentityNumber = 98765432111;

            Gamer gamer2 = new Gamer();
            gamer2.GamerId = 2;
            gamer2.FirstName = "Yusuf Taha";
            gamer2.LastName = "Çebi";
            gamer2.CreditCartNumber = 3456210987654321;
            gamer2.UserName = "yusuftaha34";
            gamer2.BirthYear = "1995";
            gamer2.IdentityNumber = 12345678999;

            Gamer gamer3 = new Gamer();
            gamer3.GamerId = 5;
            gamer3.FirstName = "Metehan";
            gamer3.LastName = "Babacan";
            gamer3.CreditCartNumber = 4567891234564321;
            gamer3.UserName = "metehanbabacan38";
            gamer3.BirthYear = "1999";
            gamer3.IdentityNumber = 45678912333;

            Game game1 = new Game();
            game1.GameId = 3;
            game1.GameName = "Call Of Duty:Black Ops";
            game1.GamePrice = "100 $";

            Game game2 = new Game();
            game2.GameId = 4;
            game2.GameName = "PUBG ";
            game2.GamePrice = "60 $";

            Campaign campaign1 = new Campaign() { GameId = 4,CampaignName="Yılbaşı İndirimi" , 
                RateOfDiscount= 25 };

            Campaign campaign2 = new Campaign() { GameId = 3,CampaignName="Süper Cuma" , 
                RateOfDiscount= 45 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Delete(campaign2);
            campaignManager.Add(campaign1);

            GamerCheckService gamerCheckService = new GamerCheckService();
            gamerCheckService.ChecktheGamer(gamer3);

            Sales sales1 = new Sales();
            sales1.Game= game1.GameName + gamer2.UserName;

            Sales sales2 = new Sales();
            sales2.Game = game2.GameName + gamer1.UserName;

            SalesManagement salesManagement = new SalesManagement();
            salesManagement.Buy(game2, gamer1);







        }
    }
}
