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
using Newtonsoft.Json;
using System.Net;
using System.Threading;

namespace demoJSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string json = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Methods

        private void Demo1()
        {
            //Haetaan kamaa
            json = getSimpleJson();
            //muunnetaan se olioksi
            List<Person> persoonat = JsonConvert.DeserializeObject<List<Person>>(json);
            //näytetään UI:ssa
            txtJson.Text = json;
            dgData.DataContext = persoonat;
        }
        private void Demo2()
        {
            //Haetaan kamaa
            json = GetJson();
            //muunnetaan se olioksi
            List<politic> persoonat = JsonConvert.DeserializeObject<List<politic>>(json);
            //näytetään UI:ssa
            txtJson.Text = json;
            dgData.DataContext = persoonat;
        }

        private void demo2ASync()
        {
            //haetaan JSON oiekasti webistä omassa threadissa
            new Thread(() =>
            {
                string result = GetJson();
                Dispatcher.BeginInvoke((Action)(() =>
                {
                    txtJson.Text = result;
                    List<politic> persoonat = JsonConvert.DeserializeObject<List<politic>>(result);
                    dgData.DataContext = persoonat;
                }
                ));
            }).Start();
            txtJson.Text = "haetaan dataa webistä";
        }

        private string getSimpleJson()
        {
            return @"[{'Name':'Ahmed Ahne','Gender':'not defined','Birthday':'1995-12-24'},
                    {'Name':'Herra Sulttaani','Gender':'Attack helicopter','Birthday':'1995-12-24'}]";
        }

        #endregion

        private string GetJson()
        {
            try
            {               
                using (WebClient wc = new WebClient())
                {
                    return wc.DownloadString("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
                }
            }
            catch
            {

            }

            return "homo";
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            demo2ASync();
        }
    }
}
