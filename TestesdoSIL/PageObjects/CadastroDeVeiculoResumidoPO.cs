using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.PageObjects
{
    public class CadastroDeVeiculoResumidoPO
    {
        private IWebDriver driver;

        // Abrir janela
        private By byAbaCadastro;
        private By byAbaVeiculo;
        private By byAbaCadastroVeiculoResumido;

        // Aba Dados do veiculo
        private By byPlaca;
        private By byFrota;
        private By byTecRastreadorPrincipal;
        private By byMarca;
        private By bySelecionarMarca;
        private By byModeloDoVeiculo;
        private By byVinculo;
        private By byTipoVeiculo;
        private By byCorVeiculo;
        private By byIdRastreadorPrincipal;
        private By byTipoCarroceria;
        private By bySenhaImobilizador;
        private By byCidade;
        private By bySelecionarCidade;
        private By byTecImobilizador;
        private By byIdImobilizador;
        private By bySiteImobilizador;
        private By byAnoFabricacao;
        private By byUsuarioImoblizador;
        private By byAntenaVeiculo;

        // Aba Acessorios/Caracteristicas
        private By byAbaAcessoriosCaracteristicas;
        private By byTipoAcessorio;
        private By byInserirAcessorio;
        private By bySelecionarAcessorio;
        private By byExcluirAcessorio;
        private By bySelecionarCaracteristica1;
        private By bySelecionarCaracteristica2;

        //Enviar para Pesquisa
        private By byEnviarParaPesquisa;        
        private By byBotaoFechar;

        //Fechar Janela
        private By byFecharJanela;
        

        public CadastroDeVeiculoResumidoPO(IWebDriver driver)
        {
            this.driver = driver;

            // Abrir janela
            byAbaCadastro = By.LinkText("Cadastro");
            byAbaVeiculo = By.LinkText("Veículo");
            byAbaCadastroVeiculoResumido = By.LinkText("Cadastro de veículo – resumido");

            // Aba Dados do Veiculo

            byPlaca = By.Id("txtPlaca");
            byFrota = By.Id("txtFrota");
            byCidade = By.Id("txtCidade");
            bySelecionarCidade = By.LinkText("JOINVILLE/SC");
            byMarca = By.Id("txtMarca");
            bySelecionarMarca = By.LinkText("SCANIA/R124");
            byModeloDoVeiculo = By.Id("cmbModelo");
            byVinculo = By.Id("cmbVinculo");
            byTipoVeiculo = By.Id("cmbTpVeiculo");
            byCorVeiculo = By.Id("cmbCor");
            byTipoCarroceria = By.Id("cmbTpCarroceria");
            byAnoFabricacao = By.Id("txtAnoFab");
            byTecRastreadorPrincipal = By.Id("cmbEmpresa1");
            byIdRastreadorPrincipal = By.Id("txtNrRast1");
            byTecImobilizador = By.Id("cmbEmpRastreamento");
            byIdImobilizador = By.Id("txtImobilizador");
            bySiteImobilizador = By.Id("txtSite");
            byUsuarioImoblizador = By.Id("txtLogin");
            bySenhaImobilizador = By.Id("txtSenha");
            byAntenaVeiculo = By.Id("chkGPRS");

            // Aba Acessorios/Caracteristicas

            byAbaAcessoriosCaracteristicas = By.Id("ui-id-4");
            byTipoAcessorio = By.Id("cmbAcessorio");
            byInserirAcessorio = By.Id("tlbAcessorio_tlbAcessorioBtnAppend_CD");
            bySelecionarAcessorio = By.LinkText("BOTAO DE PANICO");
            byExcluirAcessorio = By.Id("tlbAcessorio_tlbAcessorioBtnDelete_CD");
            bySelecionarCaracteristica1 = By.Id("cbCaracteristicas_0");
            bySelecionarCaracteristica2 = By.Id("cbCaracteristicas_1");

            // Enviar para pesquisa

            byEnviarParaPesquisa = By.Id("tlbPrincipal_btnSalvar_CD");
            byBotaoFechar = By.XPath("/html/body/div[4]/div[3]/div/button/span");

            //Fechar Janela
            byFecharJanela = By.Id("OpenPopup_ctl00_HCB0");

        }
        public void AbrirJanelaCadastrodeVeículoResumido()
        {
            driver.FindElement(byAbaCadastro).Click();
            driver.FindElement(byAbaVeiculo).Click();
            driver.FindElement(byAbaCadastroVeiculoResumido).Click();
        }
        public void PreencherCamposAbaDadosDoVeiculo(
            string Cidade,
            string Marca,
            string Modelo,
            string Vinculo,
            string TipoVeiculo,
            string Cor,
            string TipoCarroceria,
            string AnoFabricacao,
            string TecRastreador,
            string TecImobilizador,
            string SiteImobilizador
            )
        {
            driver.FindElement(byPlaca).SendKeys(ConfigPaginas.PlacaRandomica());
            driver.FindElement(byPlaca).SendKeys(Keys.Tab);            
            Thread.Sleep(1000);
            driver.FindElement(byCidade).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byMarca).SendKeys(Marca);
            driver.FindElement(bySelecionarMarca).Click();
            driver.FindElement(byModeloDoVeiculo).SendKeys(Modelo);
            driver.FindElement(byVinculo).SendKeys(Vinculo);
            driver.FindElement(byTipoVeiculo).SendKeys(TipoVeiculo);
            driver.FindElement(byCorVeiculo).SendKeys(Cor);
            driver.FindElement(byTipoCarroceria).SendKeys(TipoCarroceria);
            driver.FindElement(byAnoFabricacao).SendKeys(AnoFabricacao);
            driver.FindElement(byTecRastreadorPrincipal).SendKeys(TecRastreador);
            driver.FindElement(byIdRastreadorPrincipal).SendKeys(ConfigPaginas.NumeroRandomico(8));
            driver.FindElement(byTecImobilizador).SendKeys(TecImobilizador);
            driver.FindElement(byIdImobilizador).SendKeys(ConfigPaginas.NumeroRandomico(8));
            driver.FindElement(bySiteImobilizador).SendKeys(SiteImobilizador);
            driver.FindElement(byUsuarioImoblizador).SendKeys(ConfigPaginas.LetraRandomica(8));
            driver.FindElement(bySenhaImobilizador).SendKeys(ConfigPaginas.NumeroRandomico(5));
            driver.FindElement(byAntenaVeiculo).Click();
        }
        public void TrocarParaAbaAcessoriosCaracteristicas()
        {
            driver.FindElement(byAbaAcessoriosCaracteristicas).Click();
        }

        public void PreencherAbaAbaAcessoriosCaracteristicas(
            string TipoAcessorio1,
            string TipoAcessorio2)
        {
            driver.FindElement(byTipoAcessorio).SendKeys(TipoAcessorio1);
            driver.FindElement(byInserirAcessorio).Click();
            Thread.Sleep(1000);
            driver.FindElement(byTipoAcessorio).SendKeys(TipoAcessorio2);
            driver.FindElement(byInserirAcessorio).Click();            
            driver.FindElement(bySelecionarCaracteristica1).Click();
            driver.FindElement(bySelecionarCaracteristica2).Click();
        }

        public void EnviarParaPesquisa()
        {
            driver.FindElement(byEnviarParaPesquisa).Click();
            driver.SwitchTo().ParentFrame();
            driver.FindElement(byBotaoFechar).Click();
        }

        public void FecharJanela()
        {
            driver.FindElement(byFecharJanela).Click();
        }

        public void AlterarAbaDadadosDoVeiculo(
            string Placa)
        {
            driver.FindElement(byPlaca).SendKeys(Placa);
            driver.FindElement(byPlaca).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byFrota).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byFrota).SendKeys(ConfigPaginas.NumeroRandomico(8));

        }
    }
}