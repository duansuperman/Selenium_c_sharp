using OpenQA.Selenium;
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

namespace Sec10_Get_All_Cookie
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

            //Get all cookies
            //var cookies = chromeDriver.Manage().Cookies.AllCookies;
            //MessageBox.Show(cookies.ElementAt(0).Value);

            //Get cookie by name
            //var cookie = chromeDriver.Manage().Cookies.GetCookieNamed("SvID");
            //MessageBox.Show(cookie.Value);

            //Delete all cookie
            //chromeDriver.Manage().Cookies.DeleteAllCookies();

            //Delete one cookie
            chromeDriver.Manage().Cookies.DeleteCookieNamed("");

            //Add new cookie
            Cookie newCookie = new Cookie("AddCookie","Mới thêm");
            chromeDriver.Manage().Cookies.AddCookie(newCookie);


        }
    }
}
