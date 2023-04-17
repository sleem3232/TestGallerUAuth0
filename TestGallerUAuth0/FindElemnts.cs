using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGallerUAuth0
{
    internal class FindElemnts : BaseAuth0
    {
        public override IWebElement findEmail()
        {
            return driver.FindElement(By.CssSelector("input[name='email']"));
        }

        public override IWebElement findPassword()
        {
          return driver.FindElement(By.CssSelector("input[name='password']"));
        }

        public override IWebElement findUsername()
        {
            return driver.FindElement(By.Id("username"));
        }

        public override IWebElement Submitbtn()
        {
            return driver.FindElement(By.CssSelector("button[type='submit']"));
        }
    }
}
