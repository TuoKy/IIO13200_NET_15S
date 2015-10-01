using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace tehtava7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        tongiKantaa etsiva = new tongiKantaa();

        public MainWindow()
        {
            InitializeComponent();

            new Thread(() =>
            {
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    comboBox.DataContext = etsiva.getStations();
                }
                ));
            }).Start();            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new Thread(() =>
            {
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    dataGrid.DataContext = etsiva.getTrains(comboBox.SelectedValue as string);
                }
                ));
            }).Start();            
        }
    }
}
