using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelper.Executavel);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void Dispose()
        {
            Driver.Quit();              
        }
    }
}    
