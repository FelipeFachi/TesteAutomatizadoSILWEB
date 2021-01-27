using OpenQA.Selenium;

namespace Testes_do_SIL.Helpers
{
    public class SilNaoLogadoPO
    {
        private IWebDriver driver;
        private By byPaginaInicialDoSil;

        public SilNaoLogadoPO(IWebDriver driver)
        {
            this.driver = driver;
            byPaginaInicialDoSil = By.Id("div_sair");
        }

        public bool SIlNAOLOGADO
        {
            get
            {              
                try
                {
                    var PaginaInicial = driver.FindElement(byPaginaInicialDoSil);
                    return PaginaInicial.Displayed;                     
                }
                catch (System.Exception)
                { 
                    return false;                    
                }
                
            }
        }
    }
}
