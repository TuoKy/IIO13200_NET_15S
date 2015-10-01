using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tehtava7
{
  class tongiKantaa
    {
        string json;

        public List<station> getStations()
        {
            //Haetaan kamaa
            json = GetStuffFromWeb("http://rata.digitraffic.fi/api/v1/metadata/station");
            //muunnetaan se olioksi
            List <station> asemat = JsonConvert.DeserializeObject<List<station>>(json);
            return asemat;            
        }

        public List<train> getTrains(string paikka)
        {
            //Haetaan kamaa
            json = GetStuffFromWeb("http://rata.digitraffic.fi/api/v1/live-trains?station=" + paikka);
            //muunnetaan se olioksi
            List<train> trains = JsonConvert.DeserializeObject<List<train>>(json);
            return trains;
        }

        private string GetStuffFromWeb(string url)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    return wc.DownloadString(url);
                }
            }
            catch
            {

            }

            return "ne nauro mulle";
        }



    }
}
