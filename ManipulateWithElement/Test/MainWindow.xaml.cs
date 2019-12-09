using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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

namespace Test
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

        private void Click_Event(object sender, RoutedEventArgs e)
        {
            //ChromeDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://uitestpractice.com/");
            //Actions actions = new Actions(driver);
            //var bt_Double = driver.FindElementByCssSelector("body > div.container.body-content > div:nth-child(1) > div.container.red > button");
            //actions.DoubleClick(bt_Double).Perform();

            ChromeDriver driver = new ChromeDriver();
            //Acess to home page of tiki
            driver.Navigate().GoToUrl("https://tiki.vn/");

            MessageBox.Show(driver.Title);

            driver.FindElementByXPath("//*[@id=\"__next\"]/div/footer/div[2]/div/div[2]/a[7]").Click();


            driver.SwitchTo().Window(driver.WindowHandles.Last());

            MessageBox.Show(driver.Title);

            driver.FindElementByXPath("//*[@id=\"footer\"]/div[2]/div/div[2]/div/a[8]").Click();

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            MessageBox.Show(driver.Title);

            driver.SwitchTo().Window(driver.WindowHandles.ElementAt(1));

            MessageBox.Show(driver.Title);

        }
    }
}
