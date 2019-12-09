using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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

namespace Sec3_Get_Attribute
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
            chromeDriver.Url= "https://tiki.vn/dien-thoai-samsung-galaxy-a80-128gb-8gb-hang-chinh-hang-p14380981.html?src=recently-viewed&spid=14380983&utm_expid=.nQFRzANBRd6g9IFUqkkl8g.0&utm_referrer=https%3A%2F%2Ftiki.vn%2F";
            chromeDriver.Navigate();

            //Set during time to wait displayed loading page
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            var element = chromeDriver.FindElementByXPath("/html/body/div[10]/div[2]/div[1]/div[2]/div/div[2]/div[1]/div/div/div[1]/p[3]/span[1]");

            //Get value attribute of css
            MessageBox.Show(element.GetAttribute("class"));

            //Get value css of element
            MessageBox.Show(element.GetCssValue("line-height"));
        }
    }
}
