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

namespace Sec8_Switch_To_Tag
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
            chromeDriver.FindElementByClassName("icontgdd-bct").Click();
            //Lấy các cửa sổ hiện có
            IReadOnlyCollection<String> windowHandels = chromeDriver.WindowHandles;

            //Lấy cửa sổ đầu tiên
            String firstTab = windowHandels.First();

            //Lấy cửa sổ sau cùng
            String lastTab = windowHandels.Last();

            chromeDriver.SwitchTo().Window(firstTab);
            //MessageBox.Show(chromeDriver.Title);
            chromeDriver.SwitchTo().Window(lastTab);
        }
    }
}
