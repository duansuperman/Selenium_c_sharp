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

namespace Location
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
            driver.Navigate().GoToUrl("https://dev-chms.trinity.demo-application.net/public_form/add/join_cg_card");

            //Select option Location CG
            driver.FindElementById("edit_field_i_would_like_to_join_chosen").Click();
            driver.FindElementByXPath("/html/body/div[1]/div/div/div/div/div/div/div/div/div/div[2]/form/div[2]/div[2]/div[1]/div/div/div/ul/li[3]").Click();
            //Set postal code 

        }
    }
}
