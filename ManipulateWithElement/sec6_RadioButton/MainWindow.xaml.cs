using OpenQA.Selenium.Chrome;
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

namespace sec6_RadioButton
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

        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Url = "https://dev-chms.trinity.demo-application.net/public_form/add/join_cg_card";
            driver.Navigate();
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            // driver.FindElementByXPath("//*[@id=\"comment\"]/div[1]/div[3]/div[2]/span[3]/i").Click();
            var radioGender = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div/div/div/div/div/div/div[2]/form/div[2]/div[7]/fieldset/div/div/div[1]/label/span[1]");
            bool radioDisplay = radioGender.Displayed;
            if (radioDisplay == false)
            {
                MessageBox.Show("fail");
            }
            else
            {
                radioGender.Click();
            }
        }
    }
}
