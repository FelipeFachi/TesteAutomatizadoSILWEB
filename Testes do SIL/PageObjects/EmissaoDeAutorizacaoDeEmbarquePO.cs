using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.PageObjects
{
    public class EmissaoDeAutorizacaoDeEmbarquePO
    {
        private IWebDriver driver;

        // Abrir janela 

        private By byAbaOperacao;
        private By byAbaClipasNet;
        private By byAutorizacaoDeEmbarque;
        private By byEmissaoDeAutorizacaoDeEmbarque;

        // Aba Viagem > Dados Do Motorista

        private By byCPFMot1;
        private By byCPFMot2;

        // Aba Viagem > Dados Cavalo/Carretas
        private By byAbaDadosCavaloCarretas;
        private By byPlaca1;
        private By byPlaca2;

        // Aba Viagem > Dados Da Viagem
        private By byAbaDadosDaViagem;
        private By byEmbarcador;
        private By byBat;
        private By byCttResponsavel;
        private By byTelResponsavel;
        private By byTecnologiaIscaTrava;
        private By byIdIscaTrava;
        private By bySiteIscaTrava;
        private By byLoginIscaTrava;
        private By bySenhaIscaTrava;
        private By byInserirIscaTrava;
        private By byTipo;

        // Aba Documentos > Dados Do Documento
        private By byAbaDocumentos;
        private By byNumeroDoc;
        private By byTipoDoc;
        private By byDataPrevChegada;
        private By byDataPrevSaida;
        private By byCNPJOrigem;
        private By byCNPJDestino;

        // Aba Documento > Dados Complementares
        private By byAbaDadosComplementares;
        private By byProduto;
        private By bySelecionarProduto;
        private By byValorProduto;
        private By byInserirProduto;
        private By byIncluirDocumento;

        // Aba Sensores de Temperatura
        private By byAbaSensoresDeTemperatura;
        private By byTipoSensor1;
        private By byClick2;

        // Aba Rota
        private By byAbaRota;
        private By byCidadeOrigem;
        private By byCidadeDestino;
        private By bySelecionarCidade;
        private By bySelecionarRotaModelo;
        private By byCriarRotaModelo;
        private By byRotaModelo;
        private By bySelecionarRota;
        private By byClick;
        private By byAplicarRota;
        private By byConfirmarAplicacaoRota;
        private By byFecharJanelaRota;

        // Criar Viagem

        private By byGravarAE;
        private By byFecharAlerta;
        private By byFecharConfirmacaoDeCriacao;

        // Fechar janela

        private By byFecharJanela;

        public EmissaoDeAutorizacaoDeEmbarquePO(IWebDriver driver)
        {
            this.driver = driver;

            // Abrir janela 

            byAbaOperacao = By.LinkText("Operação");
            byAbaClipasNet = By.LinkText("Clipas Net"); 
            byAutorizacaoDeEmbarque = By.LinkText("Autorização de embarque");
            byEmissaoDeAutorizacaoDeEmbarque = By.LinkText("Emissão de Autorização de embarque");

            // Aba Viagem > Dados Do Motorista

            byCPFMot1 = By.Id("txtCPFMot1");
            byCPFMot2 = By.Id("txtCPFMot2");

            // Aba Viagem > Dados Cavalo/Carretas
            byAbaDadosCavaloCarretas = By.Id("ui-id-13");
            byPlaca1 = By.Id("txtPlacaCav1");
            byPlaca2 = By.Id("txtPlacaCar1");

            // Aba Viagem > Dados da Viagem
            byAbaDadosDaViagem = By.Id("ui-id-14");
            byEmbarcador = By.Id("cmbEmbarcador");
            byBat = By.Id("txtMontado");
            byCttResponsavel = By.Id("txtContato");
            byTelResponsavel = By.Id("txtFoneResponsavel1");
            byTecnologiaIscaTrava = By.Id("cmbEmpRastreamento");
            byIdIscaTrava = By.Id("txtIsca");
            bySiteIscaTrava = By.Id("txtSite");
            byLoginIscaTrava = By.Id("txtLogin");
            bySenhaIscaTrava = By.Id("txtSenha");
            byInserirIscaTrava = By.Id("btnAddIsca");
            byTipo = By.Id("cmbTipo");

            // Aba Documentos > Dados do Documento
            byAbaDocumentos = By.Id("ui-id-7");
            byNumeroDoc = By.Id("txtNrDocumento");
            byTipoDoc = By.Id("cmbTpDocumento");
            byDataPrevChegada = By.Id("txtPrevChegada");
            byDataPrevSaida = By.Id("txtPrevSaida");
            byCNPJOrigem = By.Id("txtCPFCNPJEmitente");
            byCNPJDestino = By.Id("txtCPFCNPJ");

            // Aba Documentos > Dados Complementares
            byAbaDadosComplementares = By.Id("ui-id-11");
            byProduto = By.Id("edtProdutoDoc");
            bySelecionarProduto = By.LinkText("ARROZ");
            byValorProduto = By.Id("txtValProdDoc");
            byInserirProduto = By.Id("tlbProdutosDoc_tlbProdutosDocBtnAppend_CD");
            byIncluirDocumento = By.Id("tlbSalvarDoc_btnSalvarDoc_CD");

            // Aba Sensores de Temperatura 
            byAbaSensoresDeTemperatura = By.Id("ui-id-8");
            byTipoSensor1 = By.Id("cmbTipo1");
            byClick2 = By.Id("cmbTipo2");

            // Aba Rota 

            byAbaRota = By.Id("ui-id-9");
            byCidadeOrigem = By.Id("edtbtnCidadeOrigem");
            byCidadeDestino = By.Id("edtbtnCidadeDestino");
            bySelecionarCidade = By.LinkText("JOINVILLE/SC");
            bySelecionarRotaModelo = By.Id("cmbRota");
            byCriarRotaModelo = By.Id("linkRoterizador");
            byRotaModelo = By.XPath("/html/body/form/div[4]/div[2]/div[2]/div/div[1]/div[1]/span/a/span[1]");
            bySelecionarRota = By.LinkText("teste 1234");
            byClick = By.Id("txtCdRotaCli");
            byAplicarRota = By.XPath("/html/body/form/div[4]/div[2]/div[2]/h1/div/span[1]");
            byConfirmarAplicacaoRota = By.XPath("/html/body/form/div[4]/div[2]/div[2]/h1/div/span[1]/i");
            byFecharJanelaRota = By.Id("winPrincipalRs_HCB-1");

            // Criar Viagem
            byGravarAE = By.Id("tlbPrincipal_btnSalvar_CD");
            byFecharAlerta = By.XPath("/html/body/div[4]/div[3]/div/button/span");
            byFecharConfirmacaoDeCriacao = By.XPath("/html/body/div[7]/div[3]/div/button[2]/span");

            // Fechar Janela

            byFecharJanela = By.Id("OpenPopup_ctl00_PWH0");
        }
                

        public void AbrirJanelaEmissaoAE()
        {           
            driver.FindElement(byAbaOperacao).Click();
            driver.FindElement(byAbaClipasNet).Click();
            driver.FindElement(byAutorizacaoDeEmbarque).Click();
            driver.FindElement(byEmissaoDeAutorizacaoDeEmbarque).Click();
        } 
        public void PreencherAbaViagemDadosDoMotorista(
            string CPF1,
            string CPF2)
        {
            Thread.Sleep(2000);
            driver.FindElement(byCPFMot1).SendKeys(CPF1);
            driver.FindElement(byCPFMot1).SendKeys(Keys.Tab);
            Thread.Sleep(3000);
            driver.FindElement(byCPFMot2).SendKeys(CPF2);
            driver.FindElement(byCPFMot2).SendKeys(Keys.Tab);
            Thread.Sleep(3000);
        }
        
        public void PreencherAbaViagemDadosCavaloCarreta(
            string Placa1,
            string Placa2)
        {
            driver.FindElement(byAbaDadosCavaloCarretas).Click();
            Thread.Sleep(2000);
            driver.FindElement(byPlaca1).SendKeys(Placa1);
            driver.FindElement(byPlaca1).SendKeys(Keys.Tab);
            Thread.Sleep(3000);
            driver.FindElement(byPlaca2).SendKeys(Placa2);
            driver.FindElement(byPlaca2).SendKeys(Keys.Tab);
            Thread.Sleep(3000);
        }
        public void PreencherAbaViagemDadosdaViagem(
            string Embarcador,
            string TecnologiaIsca,
            string Site,
            string Tipo,
            string TecnologiaTrava)
        {
            driver.FindElement(byAbaDadosDaViagem).Click();
            driver.FindElement(byEmbarcador).SendKeys(Embarcador);
            driver.FindElement(byBat).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byCttResponsavel).SendKeys(ConfigPaginas.LetraRandomica(10));
            driver.FindElement(byTelResponsavel).SendKeys(ConfigPaginas.NumeroRandomico(11));
            driver.FindElement(byTecnologiaIscaTrava).SendKeys(TecnologiaIsca);
            driver.FindElement(byTecnologiaIscaTrava).Click();
            Thread.Sleep(2000);
            driver.FindElement(byIdIscaTrava).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(bySiteIscaTrava).SendKeys(Site);
            driver.FindElement(byLoginIscaTrava).SendKeys(ConfigPaginas.LetraRandomica(8));
            driver.FindElement(bySenhaIscaTrava).SendKeys(ConfigPaginas.LetraRandomica(8));
            driver.FindElement(byInserirIscaTrava).Click();
            driver.FindElement(byTipo).SendKeys(Tipo);
            driver.FindElement(byTipo).SendKeys(Keys.Tab);
            driver.FindElement(byTecnologiaIscaTrava).Click();
            driver.FindElement(byTecnologiaIscaTrava).SendKeys(TecnologiaTrava);
            driver.FindElement(byTecnologiaIscaTrava).SendKeys(Keys.Tab);
            driver.FindElement(byIdIscaTrava).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(bySiteIscaTrava).SendKeys(Site);
            driver.FindElement(byLoginIscaTrava).SendKeys(ConfigPaginas.LetraRandomica(8));
            driver.FindElement(bySenhaIscaTrava).SendKeys(ConfigPaginas.LetraRandomica(8));
            driver.FindElement(byInserirIscaTrava).Click();
        }

        public void PreencherAbaDocumentosDadosdoDocumento(
            string TipoDoc,
            DateTime DtChegada,          
            DateTime DtSaida,
            string CNPJ)

        {
            driver.FindElement(byAbaDocumentos).Click();
            driver.FindElement(byNumeroDoc).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byTipoDoc).SendKeys(TipoDoc);
            driver.FindElement(byTipoDoc).SendKeys(Keys.Tab);
            driver.FindElement(byDataPrevChegada).SendKeys(DtChegada.ToString("dd,MM,yyyy, HH, mm"));
            driver.FindElement(byDataPrevChegada).SendKeys(Keys.Tab);
            driver.FindElement(byDataPrevSaida).SendKeys(DtSaida.ToString("dd,MM,yyyy, HH, mm"));
            driver.FindElement(byDataPrevSaida).SendKeys(Keys.Tab);            
            driver.FindElement(byCNPJOrigem).SendKeys(CNPJ);
            driver.FindElement(byCNPJOrigem).SendKeys(Keys.Tab);            
            Thread.Sleep(2000);
            driver.FindElement(byCNPJDestino).SendKeys(CNPJ);
            driver.FindElement(byCNPJDestino).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
        }
         public void PreencherAbaDocumentosDadosComplementares(
             string Produto)
         {
            driver.FindElement(byAbaDadosComplementares).Click();
            driver.FindElement(byProduto).SendKeys(Produto);
            driver.FindElement(bySelecionarProduto).Click();
            driver.FindElement(byValorProduto).SendKeys(ConfigPaginas.NumeroRandomico(4));
            driver.FindElement(byInserirProduto).Click();
            driver.FindElement(byIncluirDocumento).Click();
         }   

        public void PreencherAbaSensordeTemperatura(
            string TipoSensor)
        {
            driver.FindElement(byAbaSensoresDeTemperatura).Click();            
            driver.FindElement(byTipoSensor1).SendKeys(TipoSensor);            
            driver.FindElement(byTipoSensor1).SendKeys(Keys.Tab);
            Thread.Sleep(3000);
            driver.FindElement(byTipoSensor1).SendKeys(Keys.Tab);
            driver.FindElement(byClick2).Click();
        } 

        public void PreencherAbaRota(
            string Cidade)
        {
            var ConfigPaginas = new ConfigPaginas(driver);
            
            driver.FindElement(byAbaRota).Click();            
            driver.FindElement(byCidadeOrigem).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byCidadeDestino).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byCidadeDestino).SendKeys(Keys.Tab);            
            Thread.Sleep(2000);
            driver.FindElement(byCriarRotaModelo).Click();
            ConfigPaginas.Frame3();
            Thread.Sleep(3000);
            ConfigPaginas.Frame4();
            driver.FindElement(byRotaModelo).Click();            
            driver.FindElement(bySelecionarRota).Click();            
            driver.FindElement(byAplicarRota).Click();
            Thread.Sleep(4000);
            driver.FindElement(byConfirmarAplicacaoRota).Click();
            ConfigPaginas.Frame3();
            driver.FindElement(byFecharJanelaRota).Click();
            ConfigPaginas.Frame();
        }

        public void CriarViagem()
        {
            var ConfigPaginas = new ConfigPaginas(driver);

            driver.FindElement(byGravarAE).Click();
            Thread.Sleep(20000);
            ConfigPaginas.Frame3();
            driver.FindElement(byFecharAlerta).Click();
            ConfigPaginas.Frame();
            driver.FindElement(byFecharConfirmacaoDeCriacao).Click();
        }

        public void FecharJanela()
        {
            driver.FindElement(byFecharJanela).Click();
        }
    }     
}