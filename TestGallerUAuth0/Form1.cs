using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestGallerUAuth0
{
    public partial class Form1 : Form
    {
        private static IWebDriver? driver;
        string url = "https://blue-field-01c0eaf03.3.azurestaticapps.net/";

        public Form1()
        {
            InitializeComponent();
        }
        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Pause();
            IWebElement loginBtn = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));
            if (loginBtn != null)
            {
                loginBtn.Click();
                Pause();
            }
            else Console.WriteLine("Login Button wasn't available");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Pause();
            IWebElement loginBtn = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));
            if (loginBtn != null)
            {
                loginBtn.Click();
                Pause();
            }
            IWebElement SignUp = driver.FindElement(By.CssSelector("a[class='c8d123439 ce1bebd2d']"));
            if (SignUp != null)
            {
                try
                {
                    SignUp.Click();

                    Pause();
                }
                catch
                {
                    Console.WriteLine("SignUp wasn't clicked");
                }
            }
            IWebElement EmailInput = driver.FindElement(By.CssSelector("input[name='email']"));
            if (EmailInput != null)
            {
                try
                {
                    EmailInput.SendKeys("sleem123@gmail.com");

                }
                catch
                {
                    Console.WriteLine("Wrong email");
                }
            }
            IWebElement Continue = driver.FindElement(By.CssSelector("button[type='submit']"));
            if (Continue != null)
            {
                try
                {
                    Continue.Click();

                }
                catch
                {
                    Console.WriteLine("Falid");
                }


            }
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys("Test123456!!!");

                }
                catch
                {
                    Console.WriteLine("Falid");
                }
            }
            IWebElement submitBtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            if (submitBtn != null)
            {
                try
                {
                    submitBtn.Click();
                    Console.WriteLine(" Account Button was clicked");
                    Pause();

                }
                catch
                {
                    Console.WriteLine("Create Account Button wasn't clicked");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Pause();
            IWebElement loginBtn = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));
            if (loginBtn != null)
            {
                loginBtn.Click();
                Pause();
            }
            IWebElement emailInput = driver.FindElement(By.Id("username"));
            IWebElement submitBtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            if (emailInput != null)
            {
                try
                {
                    string email = "sleem123@gmail.com";
                    string uncorrectName = email.Replace("@", "");
                    emailInput.SendKeys(uncorrectName);
                    submitBtn.Click();
                }
                catch
                {
                    Console.WriteLine("falid");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Pause();
            IWebElement loginBtn = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));
            if (loginBtn != null)
            {
                loginBtn.Click();
                Pause();
            }
            IWebElement emailInput = driver.FindElement(By.Id("username"));
            IWebElement submitBtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            if (emailInput != null)
            {
                try
                {
                    string email = "sleem123@gmail.com";

                    emailInput.SendKeys(email);
                    submitBtn.Click();
                }
                catch
                {
                    Console.WriteLine("falid");
                }
            }
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            IWebElement Continue = driver.FindElement(By.CssSelector("button[type='submit']"));

            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys("Test1256!!!");
                    Continue.Click();

                }
                catch
                {
                    Console.WriteLine("Falid");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
           
            IWebElement loginBtn = driver.FindElement(By.CssSelector("button[class='button-0-2-2']"));
            if (loginBtn != null)
            {
                loginBtn.Click();
                Pause();
            }
            IWebElement emailInput = driver.FindElement(By.Id("username"));
            IWebElement submitBtn = driver.FindElement(By.CssSelector("button[type='submit']"));
            if (emailInput != null)
            {
                try
                {
                    string email = "sleem123@gmail.com";

                    emailInput.SendKeys(email);
                    submitBtn.Click();
                }
                catch
                {
                    Console.WriteLine("falid");
                }
            }
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[name='password']"));
            IWebElement Continue = driver.FindElement(By.CssSelector("button[type='submit']"));

            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys("Test123456!!!");
                    Continue.Click();

                }
                catch
                {
                    Console.WriteLine("Falid");
                }
            }
        }
       
    }
}