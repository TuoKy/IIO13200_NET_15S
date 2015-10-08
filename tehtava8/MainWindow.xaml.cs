using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace tehtava8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BisnesLogiikka raah = new BisnesLogiikka();


        public MainWindow()
        {
            InitializeComponent();

            var xml = XDocument.Load(Properties.Settings.Default.FileLoacation).Root;
            palautteet.DataContext = xml;  
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (pvm.Text.Length > 0 &&
                nimi.Text.Length > 0 &&
                oppinut.Text.Length > 0 &&
                haluan.Text.Length > 0 &&
                hyvaa.Text.Length > 0 &&
                parannettavaa.Text.Length > 0 &&
                parannettavaa.Text.Length > 0)
            {
                try
                {
                    raah.luoPalaute(pvm.Text,
                    nimi.Text,
                    oppinut.Text,
                    haluan.Text,
                    hyvaa.Text,
                    parannettavaa.Text,
                    parannettavaa.Text);
                }
                catch
                {
                    throw;
                }
            }
            var xml = XDocument.Load(Properties.Settings.Default.FileLoacation).Root;
            palautteet.DataContext = xml;
        }







    }
}
