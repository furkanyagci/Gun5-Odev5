using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5
{
    class SalesManager : ISalesManager
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Oyun : " + game.GameName + " oyuncu : " + gamer.FirstName + " kampanya : " + campaign.CampaingName);
        }
    }
}
