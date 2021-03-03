using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.PageObjects
{
    public class CadastroPerfilProfissionalResumidoPO
    {
        private IWebDriver driver;

        // Abrir Janela

        private By byAbaCadastro;
        private By byAbaProfissional;
        private By byAbaPerfilProfissionalResumido;

        // Aba Dados

        private By byCPF;
        private By byConfirmarConsentimento;
        private By byNome;
        private By byDtNascimento;
        private By byCidade;
        private By bySelecionarCidade;
        private By byDDD;
        private By byTelefone;
        private By byRg;
        private By byOrgaoExpedidor;
        private By byDtEmissao;
        private By byVinculo;
        private By byNumeroMatricula;
        private By byProfissao;
        private By byNumeroCNH;
        private By byNumeroRegistro;
        private By byUF;
        private By byDtEmissaoCNH;
        private By byDtVencimentoCNH;
        private By byCategoriaCNH;
        private By byDtVencimentoMOPP;
        private By byNumeroRegistroMOPP;
        private By byEntidadeEmissoraMOPP;

        // Aba Especialidades

        private By byAbaEspecialidades;
        private By byInserirEspecialidade;
        private By byEspecialidade;
        private By byValidadeEspecialidade;
        private By bySalvarEspecialidade;
        private By bySelecionarEspecialidade;
        private By byExcluirEspecialidade;
        private By byConfirmarExclusao;
        

        // Fechar Janela

        private By byFecharJanela;



        public CadastroPerfilProfissionalResumidoPO(IWebDriver driver)
        {
            this.driver = driver;

            // Abrir Janela

            byAbaCadastro = By.LinkText("Cadastro");
            byAbaProfissional = By.LinkText("Profissional");
            byAbaPerfilProfissionalResumido = By.LinkText("Cadastro perfil profissional – resumido");

            // Aba Dados

            byCPF = By.Id("txtCPF");
            byConfirmarConsentimento = By.XPath("/html/body/div[4]/div[3]/div/button[2]/span");
            byNome = By.Id("txtNome");
            byDtNascimento = By.Id("edtNascimento");
            byCidade = By.Id("txtCidadeComplete");
            bySelecionarCidade = By.LinkText("JOINVILLE/SC");
            byDDD = By.Id("txtDDD1");
            byTelefone = By.Id("txtTelefone");
            byRg = By.Id("txtRG");
            byOrgaoExpedidor = By.Id("cmbOrgaoExp");
            byDtEmissao = By.Id("edtDataEmissao");
            byVinculo = By.Id("cmbVinculo");
            byNumeroMatricula = By.Id("txtMatricula");
            byProfissao = By.Id("cmbProfissao");
            byNumeroCNH = By.Id("txtNrDoc");
            byNumeroRegistro = By.Id("txtNrReg");
            byUF = By.Id("cmbUF");
            byDtEmissaoCNH = By.Id("edtEmissaoHab");
            byDtVencimentoCNH = By.Id("edtVencimentoHab");
            byCategoriaCNH = By.Id("cmbCategoria");
            byDtVencimentoMOPP = By.Id("edtVencimento");
            byNumeroRegistroMOPP = By.Id("txtNrRegMOPP");
            byEntidadeEmissoraMOPP = By.Id("cmbEntidade");

            // Aba Especialidades
            byAbaEspecialidades = By.Id("ui-id-3");
            byInserirEspecialidade = By.Id("tlbEspecialidade_tlbEspecialidadeBtnAppend_CD");
            byEspecialidade = By.Id("winEspecialidade_cmbEspecialidade");
            byValidadeEspecialidade = By.Id("winEspecialidade_dteValidade");
            bySalvarEspecialidade = By.Id("winEspecialidade_tblEspecialidadePopup_btnSalvarPopup_CD");
            bySelecionarEspecialidade = By.Id("lstEspecialidade_LBI0T0");
            byExcluirEspecialidade = By.Id("tlbEspecialidade_tlbEspecialidadeBtnDelete_CD");
            byConfirmarExclusao = By.XPath("/html/body/div[6]/div[3]/div/button[1]/span");
            

            // Fechar Janela

            byFecharJanela = By.Id("OpenPopup_ctl00_HCB0");

        }
        public void AbrirJanelaCadastroPerfilProfissionalResumido()
        {
            driver.FindElement(byAbaCadastro).Click();
            driver.FindElement(byAbaProfissional).Click();
            driver.FindElement(byAbaPerfilProfissionalResumido).Click();
        }
        public void PreencherAbaDados(
            string Nome,
            string DtNascimento,
            string Cidade,
            string OrgaoExpedidor,
            string DtEmissao,
            string Vinculo,
            string Profissao,
            string UF,
            string DtEmissaoCNH,
            string DtVencimentoCNH,
            string CategoriaCNH,
            string DtVencimentoMOPP,
            string EntidadeMOPP)
        {
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.Frame();
            driver.FindElement(byCPF).SendKeys(ConfigPaginas.GerarCpf());
            driver.FindElement(byCPF).SendKeys(Keys.Tab);
            Thread.Sleep(1000);
            ConfigPaginas.Frame3();
            driver.FindElement(byConfirmarConsentimento).Click();
            ConfigPaginas.Frame();
            Thread.Sleep(1000);
            driver.FindElement(byNome).SendKeys(Nome);
            driver.FindElement(byDtNascimento).SendKeys(DtNascimento);
            driver.FindElement(byCidade).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byDDD).SendKeys(ConfigPaginas.NumeroRandomico(2));
            driver.FindElement(byTelefone).SendKeys(ConfigPaginas.NumeroRandomico(9));
            driver.FindElement(byRg).SendKeys(ConfigPaginas.NumeroRandomico(7));
            driver.FindElement(byOrgaoExpedidor).SendKeys(OrgaoExpedidor);
            driver.FindElement(byDtEmissao).SendKeys(DtEmissao);
            driver.FindElement(byVinculo).SendKeys(Vinculo);
            driver.FindElement(byNumeroMatricula).SendKeys(ConfigPaginas.NumeroRandomico(8));
            driver.FindElement(byProfissao).SendKeys(Profissao);
            driver.FindElement(byNumeroCNH).SendKeys(ConfigPaginas.NumeroRandomico(11));
            driver.FindElement(byNumeroRegistro).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byUF).SendKeys(UF);
            driver.FindElement(byDtEmissaoCNH).SendKeys(DtEmissaoCNH);
            driver.FindElement(byDtVencimentoCNH).SendKeys(DtVencimentoCNH);
            driver.FindElement(byCategoriaCNH).SendKeys(CategoriaCNH);
            driver.FindElement(byDtVencimentoMOPP).SendKeys(DtVencimentoMOPP);
            driver.FindElement(byNumeroRegistroMOPP).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byEntidadeEmissoraMOPP).SendKeys(EntidadeMOPP);
        }
        public void PreencherAbaEspecialidades(
            string Especialidade,
            string DtValidadeEspecialidade)
        {
            driver.FindElement(byAbaEspecialidades).Click();
            driver.FindElement(byInserirEspecialidade).Click();
            driver.FindElement(byEspecialidade).SendKeys(Especialidade);
            Thread.Sleep(1000);
            driver.FindElement(byValidadeEspecialidade).SendKeys(Keys.Control + "A");
            driver.FindElement(byValidadeEspecialidade).SendKeys(DtValidadeEspecialidade);
            
            driver.FindElement(bySalvarEspecialidade).Click();
            Thread.Sleep(1000);
            driver.FindElement(bySelecionarEspecialidade).Click();
            driver.FindElement(byExcluirEspecialidade).Click();
            driver.FindElement(byConfirmarExclusao).Click();
        }       

        public void FecharJanela()
        {
            var ConfigPaginas = new ConfigPaginas(driver);
            ConfigPaginas.Frame3();
            driver.FindElement(byFecharJanela).Click();
        }

        public void AlterarCamposAbaDados(
            string CPF)
        {
            driver.FindElement(byCPF).SendKeys(CPF);
            driver.FindElement(byCPF).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byRg).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byRg).SendKeys(ConfigPaginas.NumeroRandomico(7));
        }
    }
      
}
