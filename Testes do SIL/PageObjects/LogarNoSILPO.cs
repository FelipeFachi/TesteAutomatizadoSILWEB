using OpenQA.Selenium;

namespace Testes_do_SIL.PageObjects
{
    public class LoginNoSILPO
    {
        private IWebDriver driver;
        private By byInputLogin;
        private By byInputSenha;
        private By byInputBotaook;
        private By bySelecionarCliente;
        private By byInputCliente;
        private By byAutenticarCliente;

        public LoginNoSILPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputLogin = By.Id("txtUser");
            byInputSenha = By.Id("txtPass");
            byInputBotaook = By.Id("btnAutenticar");
            byInputCliente = By.Id("txtCliente");
            bySelecionarCliente = By.LinkText("OPENTECH - TESTE | 10.887.479/0001-83");
            byAutenticarCliente = By.Id("btnValidarCliente");
        }


        public void Visitar()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://silpaineldesenv.opentechgr.com.br/Login.aspx");
        }

        public void PreencherCampos(
            string login,
            string senha)
        {
            driver.FindElement(byInputLogin).SendKeys(login);
            driver.FindElement(byInputSenha).SendKeys(senha);
        }
        public void BotaoOK()
        {
            driver.FindElement(byInputBotaook).Click();
        }

        public void PreencherCliente(
            string ClienteOpen)
        {
            driver.FindElement(byInputCliente).SendKeys(ClienteOpen);
        }
        public void SelecionarCliente()
        {
            driver.FindElement(bySelecionarCliente).Click();
        }
        public void AutenticarCliente()
        {
            driver.FindElement(byAutenticarCliente).Click();
        }
    }


}
