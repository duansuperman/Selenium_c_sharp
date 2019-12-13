using OpenQA.Selenium.Chrome;
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

namespace Sec10_Change_Frame_Selenium
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
            // chuyển trang đến website howkteam.com
            driver.Url = "https://www.w3schools.com/html/tryit.asp?filename=tryhtml_youtubeiframe";
            driver.Navigate();

            // bắt ra trình play video của youtube có id là ytplayer
            var youtubePlayer = driver.FindElementById("iframeResult");
            youtubePlayer.Click();
            driver.SwitchTo().Frame(youtubePlayer);
            driver.SwitchTo().Frame(driver.FindElementByXPath("/html/body/iframe"));




            driver.FindElementByClassName("ytp-youtube-button").Click();

            // tìm ra nút youtube và nhấn vào nó để chuyển qua youtube
           
        }
    }
}
