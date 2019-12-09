using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

namespace sec7_Select_Value_Dropdownlist
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
            driver.Url = "http://uitestpractice.com/Students/Select";
            driver.Navigate();
            driver.Manage().Window.Maximize();

            //----Select option with original jquery------
            //Resolve 1:
            //driver.FindElementById("countriesSingle").SendKeys("United states of America");

            //Resolve 2:
            /*step1: Get selector of select element
            var select = driver.FindElementById("countriesSingle");
            Step2: Get all options with instancing is object
            var options = new SelectElement(select);
            options.SelectByIndex(2);
            options.SelectByText("China");
            options.SelectByValue("china");*/

            //---Multiple select
            /*Resolve 1:
            driver.FindElementByXPath("//*[@id=\"countriesMultiple\"]/option[1]").Click();
            driver.FindElementByXPath("//*[@id=\"countriesMultiple\"]/option[2]").Click();*/
            //Resolve 2:
            /*var select = driver.FindElementById("countriesMultiple");
            var options = new SelectElement(select);
            options.SelectByValue("india");
            options.SelectByValue("usa");*/

            //------Dropdowlist using bootstrap
            driver.FindElementByXPath("/html/body/div[2]/div[1]/div[3]/div").Click();
            driver.FindElementByXPath("/html/body/div[2]/div[1]/div[3]/div/ul/li[2]/a").Click();
            
        }
    }
}
