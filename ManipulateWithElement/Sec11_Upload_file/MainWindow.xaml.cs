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

namespace Sec11_Upload_file
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

        private void Bt_click(object sender, RoutedEventArgs e)
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://uitestpractice.com/Students/Widgets");

            //enter the path file onto the file-selection input field
            var chooseFile = driver.FindElementById("image_file");
            chooseFile.SendKeys("C:\\Users\\Admin\\Downloads\\HDSD-chuyen-tien-qua-the-tren-ARCIB.pdf");

            //Click upload file button
            var btnUpload = driver.FindElementByXPath(".//input[@value='Upload']");
            btnUpload.Click();
            MessageBox.Show(chooseFile.GetAttribute("id"));

        }
    }
}
