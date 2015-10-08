using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tehtava8
{
    class BisnesLogiikka
    {
        palautteet kaikkiPalautteet;

        public void luoPalaute(string a, string b, string c, string d, string e, string f, string g)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(palautteet));

            using (Stream inputStream = File.OpenRead(Properties.Settings.Default.FileLoacation))
                kaikkiPalautteet = (palautteet) xmlSerializer.Deserialize(inputStream);

            palaute uusiUljas = new palaute
            {
                pvm = a,
                tekija = b,
                opittu = c,
                haluanoppia = d,
                hyvaa = e,
                parannettavaa = f,
                muuta = g
            };
            kaikkiPalautteet.lPalautteet.Add(uusiUljas);

            using (Stream outputStream = File.OpenWrite(Properties.Settings.Default.FileLoacation))
                xmlSerializer.Serialize(outputStream, kaikkiPalautteet);

        }

    }
    [XmlRoot("palautteet")]
    public class palautteet
    {
        [XmlElement(ElementName = "palaute")]
        public List<palaute> lPalautteet { get; set; }
    }

    public class palaute
    {
        [XmlElement]
        public string pvm { get; set; }

        [XmlElement]
        public string tekija { get; set; }

        [XmlElement]
        public string opittu { get; set; }

        [XmlElement]
        public string haluanoppia { get; set; }

        [XmlElement]
        public string hyvaa { get; set; }

        [XmlElement]
        public string parannettavaa { get; set; }

        [XmlElement]
        public string muuta { get; set; }
    }


}
