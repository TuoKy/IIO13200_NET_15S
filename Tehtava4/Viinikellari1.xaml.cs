﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Shapes;
using System.Xml;

namespace Tehtava4
{
    /// <summary>
    /// Interaction logic for Viinikellari1.xaml
    /// </summary>
    public partial class Viinikellari1 : Window
    {
        public string kayttaja { get; set; }

        public ObservableCollection<string> maat = new ObservableCollection<string>();

        public Viinikellari1()
        {            
            InitializeComponent();
            beatDownXml();
            comboBox.ItemsSource = maat;
        }

        private void beatDownXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\IIO13200_NET_15S\\Tehtava4\\Viinit.xml");

            foreach (XmlNode temp in doc.SelectNodes("/viinikellari/wine/maa"))
            {
                if (!maat.Contains(temp.InnerText)){
                    maat.Add(temp.InnerText);                                      
                }
            }

        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox.Text.Length > 0)
            {
                viinit
            }
        }
    }
}