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

namespace Tehtava1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float iLeveys = float.Parse(ikkunanLeveys.Text);
                float iKorkeus = float.Parse(ikkunanKorkeus.Text);
                float kKorkeus = float.Parse(karmipuunLeveys.Text);
                float pintaAla = iLeveys * iKorkeus;
                float kPiiriTemp = iLeveys * 2 + iKorkeus * 2;
                float kAlaTemp = iKorkeus * kKorkeus * 2 + iLeveys * kKorkeus * 2;

                iAla.Text = pintaAla.ToString();
                kPiiri.Text = kPiiriTemp.ToString();
                kAla.Text = kAlaTemp.ToString();
            }
            catch
            {
                MessageBox.Show("Tyhmä, käytä oikeita lukuja tai korvaa piste pilkulla");
            }
        }
    }


}
