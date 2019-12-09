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

namespace FindElement
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
            chromeDriver.Navigate().GoToUrl("https://www.thegioididong.com/");

            //*Note: If there have many classname in the page, but you find wiht method "FindElement" not "s", the returning result 
            // is the first ClassName
            var element = chromeDriver.FindElementByClassName("price");
            MessageBox.Show(element.Text);

            var elements = chromeDriver.FindElementsByClassName("price");
            MessageBox.Show(elements.ElementAt(1).Text);
        }
    }
}
