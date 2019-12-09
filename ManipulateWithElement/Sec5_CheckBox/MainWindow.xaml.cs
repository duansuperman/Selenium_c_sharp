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

namespace Sec5_CheckBox
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
            driver.Url = "https://the-internet.herokuapp.com/checkboxes";
            driver.Navigate();
            driver.FindElementByXPath("//*[@id=\"checkboxes\"]/input[2]").Click();
            driver.FindElementByXPath("//*[@id=\"checkboxes\"]/input[1]").Click();

        }
    }
}
