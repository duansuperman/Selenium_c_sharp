using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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


namespace AutoJoinCG
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
            
            for(int i = 0; i <= 1000; i++)
            {
                ChromeDriver chromeDriver = new ChromeDriver();
                chromeDriver.Url = "https://dev-chms.trinity.demo-application.net/public_form/add/join_cg_card";
                chromeDriver.Navigate();
                chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

                

                string familyName = "f" + i;
                string givenName = "g" + i;


              

                string numberPhone = "8" + (1000000 + i).ToString();
                //chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[4]/div/input").SendKeys(familyName);
                chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[5]/div/input").SendKeys(givenName);
                chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[8]/div/input").SendKeys(numberPhone);
               // chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
              
                chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[9]/div/input").SendKeys("new_member@mailinator.com");
                //chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

                chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[11]/div/div/input").SendKeys("Privet Driver");
                chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[12]/div/input").SendKeys("123456");
               
                //chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

                var name = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[2]/div[11]/div/div/input");
               // chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

                Actions action = new Actions(chromeDriver);
                action.MoveToElement(name).Perform();

                //chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                //chromeDriver.Manage().Window.Maximize();
                try
                {
                    chromeDriver.ExecuteAsyncScript("jQuery('#edit-next').click();");
                }
                catch
                {

                }
                //chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[2]/div[3]/div/div/div/div/div[3]/div[2]/form/div[3]/input").Click();


                try
                {
                    chromeDriver.ExecuteAsyncScript("jQuery('#edit-submit').click();");
                }
                catch
                {

                }
                chromeDriver.Close();
            }
        }
    }
}
