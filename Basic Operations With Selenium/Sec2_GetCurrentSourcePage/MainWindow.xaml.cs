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

namespace Sec2_GetCurrentSourcePage
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
            chromeDriver.Url = "https://www.thegioididong.com/";
            chromeDriver.Navigate();
            var searchBar = chromeDriver.FindElementById("search-keyword");
            searchBar.SendKeys("iPhone 7");
            var btnSearch = chromeDriver.FindElementByClassName("btntop");
            btnSearch.Click();
            String pageSource = chromeDriver.PageSource;
            
            MessageBox.Show(pageSource);
        }
    }
}
