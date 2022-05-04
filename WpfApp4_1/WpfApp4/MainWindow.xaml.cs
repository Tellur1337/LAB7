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
using OpenQA.Selenium;
using System.Net;
using OpenQA.Selenium.Chrome;


namespace WpfApp4
{
   
    public partial class MainWindow : Window
    {
        IWebDriver driver;     
        public MainWindow()
        {
            InitializeComponent();
            Uri url = new Uri("https://www.google.ru/");
          
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.chess.com/");
                
            driver.Manage().Window.Maximize();



            IWebElement elem = driver.FindElement(By.XPath("//*[@id='sb']/div[3]/a[9]/span[2]"));
            elem.Click();


            elem = driver.FindElement(By.XPath("//*[@id='username']"));

            elem.SendKeys(tb_log.Text);
                
                                      
            elem = driver.FindElement(By.XPath("//*[@id='password']"));

            elem.SendKeys(pass.Password);

            elem = driver.FindElement(By.XPath("//*[@id='login']"));

            elem.Click();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            WebClient wc = new WebClient();
            string url = "https://www.sports.ru/";
            string path = "E:\\уч0ба\\Proga\\Lab4.txt";
            wc.DownloadFile(url, path);
        }
    }
}
