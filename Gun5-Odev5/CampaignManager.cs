using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi "+ campaign.CampaingName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi " + campaign.CampaingName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi " + campaign.CampaingName);
        }
    }
}
