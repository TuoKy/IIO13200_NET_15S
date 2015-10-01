using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava7
{
    class station
    {
        public string stationName { get; set; }

        public string stationShortCode { get; set; }
    }

    class train
    {

        public string trainType { get; set; }
        public string trainnumber { get; set; }

        public bool cancelled { get; set; }

        public string departureDate { get; set; }

        
    }
}
