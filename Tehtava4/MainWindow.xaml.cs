﻿using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Tehtava4
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

        private void bXml_Click(object sender, RoutedEventArgs e)
        {
            Viinikellari1 vk = new Viinikellari1();
            vk.kayttaja = "Jaska Jokunen";
            vk.fileLocation = ConfigurationManager.AppSettings["k1"];
            vk.purkka(); // en ole ylpeä tästä mutten keksiny miten muuten saan sourcen app.cogigista xmldataproviderille
            vk.ShowDialog();
        }
    }
}
