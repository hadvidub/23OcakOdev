using System;
using System.Collections.Generic;
using System.Text;


namespace _23OcakOdev
{
    class CampaignManager : ICampaignService
    {
        public void DiscountAdd(Game game, Campaign campaign, Gamer gamer,bool valid)
        {
            if (valid==true)
            {
                Console.WriteLine("{0} {1} isimli oyuncu {2} oyununu {3}TL'ye alarak {4} kampanyası kazandı", gamer.Isim, gamer.Soyisim, game.GameName, campaign.DiscountwithhBuy, campaign.CampaignName);
            }
            else
            {
                Console.WriteLine("Üzgünüm bu kampanyadan yararlanamazsınız");
            }
           
        }

        public void DiscountDelete(Game game, Campaign campaign, Gamer gamer, bool valid)
        {
            if (valid == true)
            {
                Console.WriteLine("{0} {1} isimli oyuncu {2} oyununu {3}TL'ye alarak {4} kazandığı kampanya silindi", gamer.Isim, gamer.Soyisim, game.GameName, campaign.DiscountwithhBuy, campaign.CampaignName);
            }
            else
            {
                Console.WriteLine("Hesabınızda bu kampanya bulunmamaktadır");
            }
        }

        public void DiscountUpdate(Game game, Campaign campaign, Gamer gamer, bool valid)
        {
            if (valid == true)
            {
                Console.WriteLine("{0} {1} isimli oyuncu {2} oyununu {3}TL'ye alarak {4} kazandığı kampanya güncellendi", gamer.Isim, gamer.Soyisim, game.GameName, campaign.DiscountwithhBuy, campaign.CampaignName);
               
            }
            else
            {
                Console.WriteLine("Hesabınızda bu kampanya bulunmamaktadır");
            }
        }
    }
}
