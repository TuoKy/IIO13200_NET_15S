﻿using System;
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

namespace Tehtava2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BLLotto lotto = new BLLotto();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            DrawnNumbers.Text = "";
            List<int> tempRivi;
            int montako;

            try
            {
                 montako = Int32.Parse(NumberOfDraws.Text);
            }
            catch
            {
                 montako = 1;
            }

            try
            {
                if (comboBox.Text == "Suomi")
                {
                    for (int i = 0; i < montako; i++)
                    {
                        tempRivi = lotto.arvoRivi();
                        foreach (int numero in tempRivi)
                        {
                            DrawnNumbers.Text = DrawnNumbers.Text + " " + numero;
                        }
                        DrawnNumbers.Text = DrawnNumbers.Text + "\n";
                    }
                }
                else
                {
                    for (int i = 0; i < montako; i++)
                    {
                        tempRivi = lotto.arvoRivi(comboBox.Text);
                        foreach (int numero in tempRivi)
                        {
                            DrawnNumbers.Text = DrawnNumbers.Text + " " + numero;
                        }
                        DrawnNumbers.Text = DrawnNumbers.Text + "\n";
                    }
                }

            }
            catch
            {
                MessageBox.Show("Valitse peli");
            }

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            DrawnNumbers.Text = "";
        }
    }
}
