
using System;

namespace _23OcakOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Isim = "Murat";
            gamer1.Soyisim = "Turan";
            gamer1.GamerId = 1;
            gamer1.TcNo = "111111";
            gamer1.BirthYear = "2000";

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameType = "FPS";
            game1.GamePrice = "100";
            game1.GameName = "Mu";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.GameId = game1.GameId;
            campaign1.CampaignName = "Şubat İndirimi";
            campaign1.DiscountwithhBuy = "50";

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            Console.WriteLine("------------------------------");

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);
            Console.WriteLine("------------------------------");

            ValidationManager validationManager = new ValidationManager();
            bool gamerValid=validationManager.Validation(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.DiscountAdd(game1, campaign1, gamer1,gamerValid);
            campaignManager.DiscountUpdate(game1, campaign1, gamer1, gamerValid);
            campaignManager.DiscountDelete(game1, campaign1, gamer1, gamerValid);



        }
    }
}
