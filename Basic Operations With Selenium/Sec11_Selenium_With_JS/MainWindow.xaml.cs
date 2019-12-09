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

namespace Sec11_Selenium_With_JS
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
            chromeDriver.Navigate().GoToUrl("https://www.sendo.vn/");

            //Get content by XPATH Full C#

            /*var elements = chromeDriver.FindElementsByXPath("/html/body/section/div[3]/div/div[1]/div/div[2]/div/a/h3");
            MessageBox.Show(elements.ElementAt(0).Text);*/

            //Execute with javascript C#

           // chromeDriver.ExecuteScript("var content = document.title;alert(content);");

            //Get content wth javascript c#

            IJavaScriptExecutor js = chromeDriver as IJavaScriptExecutor;
            String title = (String)js.ExecuteScript("return document.title");
            MessageBox.Show(title);
        }
    }
}
