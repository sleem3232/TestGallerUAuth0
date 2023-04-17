using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGallerUAuth0
{
    internal abstract class BaseAuth0
    {
        protected static IWebDriver? driver;
       
        public void Pause(int mili = 3000)
        {
            System.Threading.Thread.Sleep(mili);
        }
        public void LoginBtnStartBrowser()
        {
            string url = "https://blue-field-01c0eaf03.3.azurestaticapps.net/";
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
     
        public void SignUp(string email,string password )
        {
            LoginBtnStartBrowser();
            IWebElement SignUp = driver.FindElement(By.CssSelector("a[class='c8d123439 ce1bebd2d']"));
            if (SignUp != null)
            {
                try
                {
                    SignUp.Click();


                }
                catch
                {
                    Console.WriteLine("SignUp wasn't clicked");
                }
            }
            IWebElement EmailInput = findEmail();
            if (EmailInput != null)
            {
                try
                {
                    EmailInput.SendKeys(email);

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
            IWebElement passwordInput = findPassword();

            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(password);

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
        public void Login(string username, string password)
        {
            LoginBtnStartBrowser();

          
            IWebElement emailInput = findUsername();
            IWebElement submitBtn = Submitbtn();
            if (emailInput != null)
            {
                try
                {
                   

                    emailInput.SendKeys(username);
                    submitBtn.Click();
                }
                catch
                {
                    Console.WriteLine("falid");
                }
            }
            IWebElement passwordInput = findPassword();
            IWebElement Continue = Submitbtn();

            if (passwordInput != null)
            {
                try
                {
                    passwordInput.SendKeys(password);
                    Continue.Click();

                }
                catch
                {
                    Console.WriteLine("Falid");
                }
            }
        }

        public abstract IWebElement findEmail();
        public abstract IWebElement findPassword();
        public abstract IWebElement findUsername();

        public abstract IWebElement Submitbtn();



    }
}
