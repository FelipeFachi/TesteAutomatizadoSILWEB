using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Testes_do_SIL.Fixtures;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
using Testes_do_SIL.PageObjects;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL
{
    [Collection("Chrome Driver")]
    public class EfetuarLogin
    {
        private IWebDriver driver;        
        public EfetuarLogin(TestFixture fixture)
        {
            driver = fixture.Driver;
        }
        
        public EfetuarLogin(IWebDriver driver)
        {
            this.driver = driver;          
        }

                
        public void EfetuarLoginCorretamente()
        {
            var LoginNoSILPO = new LoginNoSILPO(driver);
            var SilNaoLogadoPO = new SilNaoLogadoPO(driver);             
                        
            if (!SilNaoLogadoPO.SIlNAOLOGADO)        
            {
                LoginNoSILPO.Visitar();

                LoginNoSILPO.PreencherCampos(
                  "fachi",
                  "##epilef05");

                LoginNoSILPO.BotaoOK();

                LoginNoSILPO.PreencherCliente("10.887.479/0001-83");

                LoginNoSILPO.SelecionarCliente();

                LoginNoSILPO.AutenticarCliente();               

            }         
            if (SilNaoLogadoPO.SIlNAOLOGADO)
            {
                driver.Navigate().GoToUrl("http://silpaineldesenv.opentechgr.com.br/Default.aspx");
            }
        }
    }
}