using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.PageObjects
{
    public class InclusaoDeDocumentoPO
    {
        private IWebDriver driver;

        // Abrir janela 

        private By byAbaOperacao;
        private By byAbaDocumento;
        private By byInclusaoDeDocumento;

        // Aba Dados Documento

        private By byNrDocumento;
        private By byTipoDocumento;
        private By byPrevChegada;
        private By byPrevSaida;
        private By byVolume;
        private By byQtde;
        private By byCubagem;
        private By byPeso;
        private By byPermiteSubstituir;
        private By byCNPJEmitente;
        private By byTipoOperacao;
        private By byCNPJDestinatario;

        // Aba Produtos

        private By byAbaProdutos;
        private By byProduto;
        private By bySelecionarProdutos1;
        private By bySelecionarProdutos2;
        private By byValorProduto;
        private By byInserirProduto;
        private By bySelecionarProduto;
        private By byExcluirProduto;

        // Gravar Documento 

        private By byGravarDoc;
        private By byBotaoSim;
        private By byBotaoNao;

        // Fechar Janela

        private By byFecharJanela;

        public InclusaoDeDocumentoPO(IWebDriver driver)
        {
            this.driver = driver;

           // Abrir janela 

            byAbaOperacao = By.LinkText("Operação");
            byAbaDocumento = By.LinkText("Documento");
            byInclusaoDeDocumento = By.LinkText("Inclusão de documento");
            
            // Aba Dados Documento
            
            byNrDocumento = By.Id("edtNrDocumento");
            byTipoDocumento = By.Id("cmbTipoDocumento");
            byPrevChegada = By.Id("dtPrevChegada");
            byPrevSaida = By.Id("dtPrevSaida");
            byVolume = By.Id("edtVolume");
            byQtde = By.Id("edtQuantidade");
            byCubagem = By.Id("txtVlCubagem");
            byPeso = By.Id("txtVlPeso");
            byPermiteSubstituir = By.Id("chkTrocaNota");
            byCNPJEmitente = By.Id("edtCNPJEmitente");
            byTipoOperacao = By.Id("cmbTipoOperacao");
            byCNPJDestinatario = By.Id("edtCNPJdest");
            
            // Aba Produtos
            
            byAbaProdutos = By.Id("ui-id-6"); 
            byProduto = By.Id("edtProduto");
            byValorProduto = By.Id("edtValorProduto");
            byInserirProduto = By.Id("tlbSecundario_btnInsereProduto_CD");
            bySelecionarProdutos1 = By.LinkText("ARROZ");
            bySelecionarProdutos2 = By.LinkText("ZINCO EM BARRA");
            bySelecionarProduto = By.Id("lstProdutos_LBI1T0");
            byExcluirProduto = By.Id("tlbSecundario_btnApagaProduto_CD");
            
            // Gravar Documento 
            
            byGravarDoc = By.Id("tlbPrincipal_tlbPrincipalBtnGravar_CD"); 
            byBotaoSim = By.XPath("/html/body/div[5]/div[3]/div/button[1]/span"); 
            byBotaoNao = By.XPath("/html/body/div[5]/div[3]/div/button[2]/span"); 
            
            // Fechar Janela
            
            byFecharJanela = By.Id("OpenPopup_ctl00_HCB0");
        } 

        public void AbrirJanelaInclusaoDocumento()
        {
            driver.FindElement(byAbaOperacao).Click();
            driver.FindElement(byAbaDocumento).Click();
            driver.FindElement(byInclusaoDeDocumento).Click();

        }

        public void PreencherAbaDadosDoDocumento(
            string TipoDoc,
            DateTime dtChegada,
            DateTime dtPrevSaida,
            string CNPJ,
            string TipoOperacao)
        {
            driver.FindElement(byNrDocumento).SendKeys(ConfigPaginas.NumeroRandomico(8));
            driver.FindElement(byNrDocumento).SendKeys(Keys.Tab);
            driver.FindElement(byTipoDocumento).SendKeys(TipoDoc);
            driver.FindElement(byPrevChegada).SendKeys(dtChegada.ToString("dd,MM,yyyy, HH, mm"));
            driver.FindElement(byPrevSaida).SendKeys(dtPrevSaida.ToString("dd,MM,yyyy, HH, mm"));
            driver.FindElement(byVolume).SendKeys(ConfigPaginas.NumeroRandomico(6));
            driver.FindElement(byQtde).SendKeys(ConfigPaginas.NumeroRandomico(3));
            driver.FindElement(byCubagem).SendKeys(ConfigPaginas.NumeroRandomico(4));
            driver.FindElement(byPeso).SendKeys(ConfigPaginas.NumeroRandomico(4));
            driver.FindElement(byPermiteSubstituir).Click();
            driver.FindElement(byCNPJEmitente).SendKeys(CNPJ);
            driver.FindElement(byCNPJEmitente).SendKeys(Keys.Tab);
            driver.FindElement(byTipoOperacao).SendKeys(TipoOperacao);
            driver.FindElement(byCNPJDestinatario).SendKeys(CNPJ);
            driver.FindElement(byCNPJDestinatario).SendKeys(Keys.Tab);
        }

        public void PreencherAbaProdutos(
            string Produto1,
            string Produto2)
        {
            driver.FindElement(byAbaProdutos).Click();
            driver.FindElement(byProduto).SendKeys(Produto1);
            driver.FindElement(bySelecionarProdutos1).Click();
            driver.FindElement(byValorProduto).SendKeys(ConfigPaginas.NumeroRandomico(3));
            driver.FindElement(byInserirProduto).Click();            
            driver.FindElement(byProduto).SendKeys(Produto2);
            driver.FindElement(bySelecionarProdutos2).Click();
            driver.FindElement(byValorProduto).SendKeys(ConfigPaginas.NumeroRandomico(3));
            driver.FindElement(byInserirProduto).Click();
            driver.FindElement(bySelecionarProduto).Click();
            driver.FindElement(byExcluirProduto).Click();
        }

        public void GravarDocumento()
        {
            driver.FindElement(byGravarDoc).Click();
            //driver.FindElement(byBotaoSim).Click();
            driver.FindElement(byBotaoNao).Click(); 
        }

        public void FecharJanela()
        {
            driver.FindElement(byFecharJanela).Click();
        }
    }
}
