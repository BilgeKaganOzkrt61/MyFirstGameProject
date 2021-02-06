using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "  Kampanyası Başladı.KAÇIRMAYIN ! !");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "  Kampanyası Sona Erdi.İndirimler Devam Edecek ! !");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("PATRON ÇILDIRDI !!.Kampanyada artık 1 Alana 1 Bedava .KAÇIRMAYIN ! !  :" +
                campaign.CampaignName);
        }
    }
}
