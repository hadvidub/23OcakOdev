using System;
using System.Collections.Generic;
using System.Text;

namespace _23OcakOdev
{
    interface ICampaignService
    {
        void DiscountAdd(Game game, Campaign campaign, Gamer gamer,bool valid);
        void DiscountUpdate(Game game, Campaign campaign, Gamer gamer, bool valid);
        void DiscountDelete(Game game, Campaign campaign, Gamer gamer, bool valid);
    }
}
