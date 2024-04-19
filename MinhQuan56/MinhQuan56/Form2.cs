using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhQuan56
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btMQ_56_Click(object sender, EventArgs e)
        {
            ChromeDriverService MQ = ChromeDriverService.CreateDefaultService();
            MQ.HideCommandPromptWindow = true;

            IWebDriver minhquan_56 = new ChromeDriver(MQ);
            minhquan_56.Url = "https://demo.guru99.com/test/delete_customer.php";
            minhquan_56.Navigate();
            IWebElement MinhQuan = minhquan_56.FindElement(By.Name("cusid"));
            MinhQuan.SendKeys("56_Quan");
            IWebElement MinhQuan_56 = minhquan_56.FindElement(By.Name("submit"));
            MinhQuan_56.Click();
            minhquan_56.SwitchTo().Alert().Accept();
            minhquan_56.SwitchTo().Alert().Accept();



            // dieu huong man hinh
            //IWebDriver minhquan_56 = new ChromeDriver(MQ);
            //minhquan_56.Url = "https://en.wikipedia.org/wiki/I_Want_to_Love_You";
            //minhquan_56.Navigate();
            //if (txtMinhQuan.Text != "")
            //{
            //    // lấy đường dẫn từ textbox
            //    minhquan_56.Navigate().GoToUrl(txtMinhQuan.Text);
            //}
            //else
            //{
            //    //lấy đường dẫn từ code nếu textbox rỗng
            //    minhquan_56.Navigate().GoToUrl("https://en.wikipedia.org/wiki/I_Want_to_Love_You");
            //}



            //IWebElement ee = minhquan_56.FindElement(By.TagName("h2"));
            //ReadOnlyCollection<IWebElement> ee = minhquan_56.FindElements(By.TagName("h2"));
            //foreach (var element in ee)
            //{
            //    Console.WriteLine(element.Text);
            //}
            //// đóng trình duyệt
            //driver.Close();
            //// đóng mọi cửa sổ liên kết
            //driver.Quit();


            //// lấy URL
            //string MinhQuan_56 = driver.Url;
            //Console.WriteLine(MinhQuan_56);

            ////lấy title

            //string MinhQuan = driver.Title;
            //Console.WriteLine(MinhQuan);

            ////lay page source

            //string QuanMinh = driver.PageSource;
            //Console.WriteLine(QuanMinh);


            //driver.Navigate().Forward();
            //Thread.Sleep(1000);
            //driver.Navigate().Refresh();

            //// tự điền vào ô tìm kiếm
            //string s = txtMinhQuan_56.Text.ToString();
            //IWebElement minhquan_56 = driver.FindElement(By.Name("q"));
            //minhquan_56.SendKeys(s);

            //string s = txtUser.Text.ToString();
            //string str = txtPassword.Text.ToString();
            //IWebElement MinhQuan_user = driver.FindElement(By.Id("email"));
            //MinhQuan_user.SendKeys(s);
            //IWebElement MinhQuan_Pass = driver.FindElement(By.Name("pass"));
            //MinhQuan_Pass.SendKeys(str);

        }
    }
}
