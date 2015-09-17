using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Configuration;

namespace Tehtava3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection <Pelaaja> pelaajaLista = new ObservableCollection<Pelaaja>();
        List<string> seurat;
        Pelaaja temp;
        


        public MainWindow()
        {
            seurat = new List<string> {"Blues","HIFK","HPK",
            "Ilves","JYP","KalPa","KooKoo","Kärpät"};

            string tempS = ConfigurationManager.AppSettings["k1"];

            InitializeComponent();
            
            if (tempS.Length > 0)
                luePelaajat(tempS);

            seura.ItemsSource = seurat;
            luodutPelaajat.ItemsSource = pelaajaLista;
            luodutPelaajat.DisplayMemberPath = "kNimi";

        }

        private bool onkoPelaajaa(Pelaaja temp)
        {
            foreach(Pelaaja p in pelaajaLista)
            {
                if(temp.eNimi == p.eNimi && temp.sNimi == p.sNimi)
                {
                    return true;
                }
            }
            return false;
        }

        private bool katsoOnkoSyottoValid()
        {
            if (!eNimi.Text.Contains(" ") && !sNimi.Text.Contains(" "))
            {
                float testi;
                if (float.TryParse(sHinta.Text, out testi) && eNimi.Text.Length > 0 && sNimi.Text.Length > 0 &&
                        seura.Text.Length > 0 && sHinta.Text.Length > 0)
                    return true;
            }

            return false;
        }

        private void bLuoPelaaja_Click(object sender, RoutedEventArgs e)
        {

            if (katsoOnkoSyottoValid())
            {
                try
                {
                    temp = new Pelaaja(eNimi.Text, sNimi.Text, seura.Text, sHinta.Text);

                    if (!onkoPelaajaa(temp))
                    {
                        pelaajaLista.Add(temp);
                        statusTeksti.Text = "Pelaaja lisätty";
                        
                    }
                    else
                    {
                        statusTeksti.Text = "Pelaaja olemassa";
                    }
                }
                catch
                {
                    statusTeksti.Text = "Syöte Virheellinen";
                }

                tyhjaaKohdat();
            }
            else
                statusTeksti.Text = "Syöte Virheellinen";
        }



        private void bTallennaPelaaja_Click(object sender, RoutedEventArgs e)
        {
            

            if (katsoOnkoSyottoValid())
            {
                try
                {
                    temp = (Pelaaja)luodutPelaajat.SelectedItem;
                    temp.eNimi = eNimi.Text;
                    temp.sNimi = sNimi.Text;
                    temp.seura = seura.Text;
                    temp.sHinta = sHinta.Text;

                    statusTeksti.Text = "Pelaaja tallennettu";

                    luodutPelaajat.Items.Refresh();
                }
                catch
                {
                    statusTeksti.Text = "Jokin meni vikaan tallennuksessa";
                }

                tyhjaaKohdat();
            }
            else
                statusTeksti.Text = "Syöte Virheellinen";
        }

        private void bPoistaPelaaja_Click(object sender, RoutedEventArgs e)
        {
            temp = (Pelaaja)luodutPelaajat.SelectedItem; 
            pelaajaLista.Remove(temp);

            statusTeksti.Text = "Pelaaja poistettu";

            tyhjaaKohdat();
        }

        private void bKirjoitaPelaajat_Click(object sender, RoutedEventArgs e)
        {
            string tempString = "";

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Text documents (.txt)|*.txt";

            if (save.ShowDialog() == true)
            {
                foreach (Pelaaja p in pelaajaLista)
                {
                    tempString = tempString + p.eNimi + " " + p.sNimi + " "
                        + p.seura + " " + p.sHinta + System.Environment.NewLine;
                }

                string filename = save.FileName;
                StreamWriter sr = File.CreateText(@filename);
                sr.Write(tempString);
                sr.Close();

                UpdateSetting("k1", filename);
      
                statusTeksti.Text = "Pelaajalista tallennettu tiedostoon";
            }

        }

        private void tyhjaaKohdat()
        {
            eNimi.Text = "";
            sNimi.Text = "";
            sHinta.Text = "";
            seura.Text = "";
            Console.WriteLine("raah");
        }

        private void bLopetus_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void luodutPelaajat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                temp = (Pelaaja)luodutPelaajat.SelectedItem;

                eNimi.Text = temp.eNimi;
                sNimi.Text = temp.sNimi;
                sHinta.Text = temp.sHinta;
                seura.Text = temp.seura;
            }
            catch
            {
                tyhjaaKohdat();
            }
        }

        private void luePelaajat(string filu)
        {
            try
            {
                StreamReader reader = File.OpenText(filu);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    temp = new Pelaaja(words[0], words[1], words[2], words[3]);
                    pelaajaLista.Add(temp);
                }
                reader.Close();
            }
            catch
            {

            }

        }



        private static void UpdateSetting(string key, string value)
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
                settings[key].Value = value;

            configFile.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
