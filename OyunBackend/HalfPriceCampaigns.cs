using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackend
{
    class HalfPriceCampaigns
    {
        class HalfPriceCampain : ICampaignsManager
        {
            public void AddCampain()
            {
                Console.WriteLine("Kampanya Eklendi.");
            }

            public void DeleteCampain()
            {
                Console.WriteLine("Kampanya Silindi");
            }

            public void UpdateCampain()
            {
                Console.WriteLine("Kampanya Güncellendi.");
            }
        }
    }
}
