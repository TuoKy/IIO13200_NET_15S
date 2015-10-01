using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoJSON
{
    class Person
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Birthday { get; set; }
    }

    class politic : Person
    {
        public string party { get; set; }
        //jos json atribuutit ja property atribuutit ovat eri niin käytä seuraavaa
        [JsonProperty("position")]
        public string virka { get; set; }
    }
}
