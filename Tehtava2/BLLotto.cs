using System;
using System.Collections.Generic;

namespace Tehtava2
{
    public class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x.CompareTo(y) != 0)
            {
                return x.CompareTo(y);
            }
            else
            {
                return 0;
            }
        }

    }
    
    public class BLLotto
    {
        public String Tyyppi;
        private int SuurinNro;
        private int NumeroLkm;

        Random rnd = new Random();

        public BLLotto()
        {
           
        }

        private List<int> laitaLuvut()
        {
            List<int> kaikkiNumerot = new List<int>();
            for (int i = 1; i < SuurinNro + 1; i++)
            {
                kaikkiNumerot.Add(i);
            }

            return kaikkiNumerot;
        }

        private List<int> valitseLuvut()
        {
            List<int> kaikkiNumerot = laitaLuvut();
            int valittu;
            List<int> numerotTemp = new List<int>();

            for (int i = 0; i < NumeroLkm; i++)
            {
                valittu = rnd.Next(0, kaikkiNumerot.Count);
                numerotTemp.Add(kaikkiNumerot[valittu]);
                kaikkiNumerot.Remove(kaikkiNumerot[valittu]);
            }
            numerotTemp.Sort(new Comparer());

            return numerotTemp;
        }
        
        public List<int> arvoRivi()
        {
            SuurinNro = 39;
            NumeroLkm = 7;
                                      
            return valitseLuvut();
        }

        public List<int> arvoRivi(String Tyyppi)
        {
            switch (Tyyppi)
            {
                case "Viking":
                    SuurinNro = 48;
                    NumeroLkm = 6;

                    return valitseLuvut();

                case "Euro":

                    SuurinNro = 50;
                    NumeroLkm = 5;

                    List<int> numerotTemp = valitseLuvut();

                    SuurinNro = 8;
                    NumeroLkm = 2;

                    numerotTemp.AddRange(valitseLuvut());

                    return numerotTemp;
            }

            return null;
        }

    }


}
