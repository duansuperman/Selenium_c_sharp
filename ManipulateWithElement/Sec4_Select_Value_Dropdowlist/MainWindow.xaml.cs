using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

namespace Sec4_Select_Value_Dropdowlist
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://dev-chms.trinity.demo-application.net/public_form/add/join_cg_card");
            // chromeDriver.ExecuteAsyncScript("jQuery('.select-custom').val('13-21');");
            //chromeDriver.FindElementByXPath("").SendKeys("Any Connect Group");
            chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[4]/div/input").SendKeys("duan");
            //chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[6]/div/div/div/div/ul");
            chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[6]/div/div/div/div/ul/li[2]").Click();
            chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[8]/div/input").SendKeys("1234");
        }
    }
}
