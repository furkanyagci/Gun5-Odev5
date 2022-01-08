using System;

namespace Gun5_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "ENGİN";
            gamer.LastName = "DEMİROĞ";
            gamer.IdentityNumber = 12345678901;

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345678901 });//gamer

            

            CampaignManager campaignManager = new CampaignManager();
            
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaingName = "Black Friday";
            campaign1.Description = "Tüm ürünlerde %20 indirim";

            Campaign campaign2 = new Campaign();
            campaign2.Id = 1;
            campaign2.CampaingName = "Welcome Gamer";
            campaign2.Description = "Yeni kayıt olanlara tüm oyunlarda %10 indirim";
            
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            Game game = new Game();
            game.Id = 1;
            game.GameName = "GTA";

            SalesManager salesManager = new SalesManager();

            salesManager.Sale(game, gamer, campaign1);

            Console.WriteLine("Hello World!");
        }
    }
}
