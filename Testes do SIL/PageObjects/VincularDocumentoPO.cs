using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.PageObjects
{
    public class VincularDocumentoPO
    {
        private IWebDriver driver;

        // Abrir janela 

        private By byAbaOperacao;
        private By byAbaDocumento;
        private By byAbaVincularDocumento;

        //  Prencher dados

        private By byNumeroAE;
        private By byNovoDocumento;
        private By byDtInicial;
        private By byDtFinal;
        private By byCNPJDestinatario;
        private By byPesquisarDoc;
        private By bySelecionarDoc;
        private By byInserirDoc;
        private By byGravar;

        // Fechar janela

        private By byFecharConfirmacao;
        private By byFecharJanela;

        public VincularDocumentoPO(IWebDriver driver)
        {
            this.driver = driver;

            // Abrir janela 

            byAbaOperacao = By.LinkText("Operação");
            byAbaDocumento = By.LinkText("Documento");
            byAbaVincularDocumento = By.LinkText("Vincular documento");

            //  Prencher dados

            byNumeroAE = By.Id("edtAE");
            byNovoDocumento = By.Id("tlbSecundario_tlbSecundarioBtnAppend_CD");
            byDtInicial = By.Id("txtDataHoraInicial");
            byDtFinal = By.Id("txtDataHoraFinal");
            byCNPJDestinatario = By.Id("edtCNPJdest");
            byPesquisarDoc = By.Id("tlbPrincipal_tlbPrincipalBtnAtualizar_CD");
            bySelecionarDoc = By.Id("grdPrincipal_DXSelBtn0_D");
            byInserirDoc = By.Id("tlbPrincipal_btnOK_CD");
            byGravar = By.Id("tlbPrincipal_tlbPrincipalBtnGravar_CD");

            // Fechar janela

            byFecharConfirmacao = By.XPath("/html/body/div[4]/div[3]/div/button/span");
            byFecharJanela = By.Id("OpenPopup_ctl00_HCB0");   

        }


        public void AbrirJanelaVincularDocumento()
        {
            driver.FindElement(byAbaOperacao).Click();
            driver.FindElement(byAbaDocumento).Click();
            driver.FindElement(byAbaVincularDocumento).Click();
        }

        public void VincularDocumento(
            string AE,
            DateTime DtInicial,
            DateTime DtFinal,
            string CNPJ)
        {
            var ConfigPaginas = new ConfigPaginas(driver);

            driver.FindElement(byNumeroAE).SendKeys(AE);
            driver.FindElement(byNumeroAE).SendKeys(Keys.Tab);
            driver.FindElement(byNovoDocumento).Click();
            ConfigPaginas.Frame3();
            ConfigPaginas.Frame5();
            driver.FindElement(byDtInicial).SendKeys(DtInicial.ToString("dd,MM,yyyy"));
            driver.FindElement(byDtFinal).SendKeys(DtFinal.ToString("dd,MM,yyyy, HH, mm"));
            driver.FindElement(byCNPJDestinatario).SendKeys(CNPJ);
            driver.FindElement(byPesquisarDoc).Click();
            driver.FindElement(bySelecionarDoc).Click();
            driver.FindElement(byInserirDoc).Click();
            ConfigPaginas.Frame3();
            ConfigPaginas.Frame();
            driver.FindElement(byGravar).Click();
            Thread.Sleep(5000);
        }

        public void FecharJanela()
        {
            driver.FindElement(byFecharConfirmacao).Click();
            driver.FindElement(byFecharJanela).Click();
        }
    }
}
