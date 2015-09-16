using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Pelaaja
    {
        //snippetit, musita ens kerralla
        private string _eNimi, _sNimi, _seura, _sHinta;

        public Pelaaja(string eNimi, string sNimi, string seura, string sHinta)
        {
            _eNimi = eNimi;
            _sNimi = sNimi;
            _seura = seura;
            _sHinta = sHinta;
        }

        public string eNimi
        {
            get
            {
                return _eNimi;
            }
            set
            {
                _eNimi = value;
            }
        }

        public string sNimi
        {
            get
            {
                return _sNimi;
            }
            set
            {
                _sNimi = value;
            }
        }

        public string kNimi
        {
            get
            {
                return _eNimi + " " + _sNimi + " ," + _seura;
            }
        }

        public string seura
        {
            get
            {
                return _seura;
            }
            set
            {
                _seura = value;
            }
        }

        public string sHinta
        {
            get
            {
                return _sHinta;
            }
            set
            {
                _sHinta = value;
            }
        }



    }
}
