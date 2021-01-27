using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.PageObjects
{
    public class CadastroPerfilProfissionalPO
    {
        private IWebDriver driver;

        //Abrir Janela Cadastro de Profissional
        private By byAbaCadastro;
        private By byAbaProfissional;
        private By byAbaCadastroPerfilProfissional;

        //Aba Documentos
        private By byCPF;
        private By byRG;
        private By byOrgaoExpididor;
        private By byDataEmissaoRG;
        private By byProfissao;
        private By byVinculo;
        private By byDataContratacao;
        private By byNumeroMatricula;
        private By byNumeroCNH;
        private By byNumeroRegistro;
        private By byUF;
        private By byDataEmissaoCNH;
        private By byDtVencimentoCNH;
        private By byCategoriaCNH;
        private By byDataVenciomentoMOPP;
        private By byNumeroRegistroMOPP;
        private By byEntidadeEmissoraMOPP;


        //Aba Referencias
        private By byAbaReferencias;
        private By byNomeReferencia;
        private By byTipoRelacionamento;
        private By byLogadouroReferencia;
        private By byCidadeReferencia;
        private By byDDDReferencia;
        private By byTelefoneReferencia;
        private By byInserirReferencia;
        private By bySelecionarCidade;
        private By bySelecionarReferencia;
        private By byEditarReferencia;
        private By bySalvarReferencia;

        //Aba Dados Pessoais 
        private By byAbaDadosPessoais;
        private By byNome;
        private By byApelido;
        private By byNaturalidade;
        private By byDataNascimento;
        private By bySexo;
        private By byNomePai;
        private By byNomeMae;
        private By byLogadouro;
        private By byNumeroCasa;
        private By byBairro;
        private By byCidade;
        private By byDDD;
        private By byTelefone;

        //Aba Especialidades
        private By byAbaEspecialidades;
        private By byInserirEspecialidade;
        private By bySelecionarEspecialidade;
        private By byValidadeEspecialidade;
        private By bySalvarEspecialidade;
        private By byExcluirEspecialidade;
        private By byConfirmarExclusaoEspecialidade;
        private By bySelecionarEspecialidadeParaExcluir;

        //Aba Foto
        private By byAbaFoto;
        private By byUpFoto;
        private By byImportarFoto;

        //Aba Anexar Arquivo
        private By byAbaAnexarDocumento;
        private By byUpArquivo;
        private By byIdentificacaoArquivo;
        private By byAnexarArquivo;
        private By byFecharConfirmacao;
        private By bySelecionarArquivoParaExcluir;
        private By byExcluirArquivo;
        private By byConfirmarExclusao;

        //Enviar para Pesquisa
        private By byEnviarParaPesquisa;        
        private By bySelecionarTipoPesquisaExpressa;
        private By byBotaoSim;
        private By byBotaoNao;

        // Fechar Janela 
        private By byFecharConfirmacao1;
        private By byFecharJanela;


        public CadastroPerfilProfissionalPO(IWebDriver driver)
        {
            this.driver = driver;

            //Abrir Janela
            byAbaCadastro = By.LinkText("Cadastro");
            byAbaProfissional = By.LinkText("Profissional");
            byAbaCadastroPerfilProfissional = By.LinkText("Cadastro perfil profissional");

            //Aba Documentos
            byCPF = By.Id("txtCPF");
            byRG = By.Id("txtRG");
            byOrgaoExpididor = By.Id("cmbOrgaoExp");
            byDataEmissaoRG = By.Id("edtDataEmissao");
            byProfissao = By.Id("cmbProfissao");
            byVinculo = By.Id("cmbVinculo");
            byDataContratacao = By.Id("edtContratacao");
            byNumeroMatricula = By.Id("txtMatricula");
            byNumeroCNH = By.Id("txtNrDoc");
            byNumeroRegistro = By.Id("txtNrReg");
            byUF = By.Id("cmbUF");
            byDataEmissaoCNH = By.Id("edtEmissaoHab");
            byDtVencimentoCNH = By.Id("edtVencimentoHab");
            byCategoriaCNH = By.Id("cmbCategoria");
            byDataVenciomentoMOPP = By.Id("edtVencimento");
            byNumeroRegistroMOPP = By.Id("txtNrRegMOPP");
            byEntidadeEmissoraMOPP = By.Id("cmbEntidade");

            //Aba Referencias
            byAbaReferencias = By.Id("ui-id-2");
            byNomeReferencia = By.Id("txtNomeReferencia");
            byTipoRelacionamento = By.Id("cmbTipoRelacionamento");
            byLogadouroReferencia = By.Id("txtLogradouroReferencia");
            byCidadeReferencia = By.Id("txtCidRef");
            byDDDReferencia = By.Id("txtDDDFone1");
            byTelefoneReferencia = By.Id("txtTelefoneReferencia");
            byInserirReferencia = By.Id("tlbEspecialidade_tlbEspecialidadeBtnAppend_CD");
            bySelecionarCidade = By.LinkText("JOINVILLE/SC");
            bySelecionarReferencia = By.Id("lstReferencia_LBI3T0");
            byEditarReferencia = By.Id("tlbEspecialidade_tlbEspecialidadeBtnEdit_CD");
            bySalvarReferencia = By.Id("tlbEspecialidade_btnSalvarReferencia_CD");

            //Aba Dados Pessoais 
            byAbaDadosPessoais = By.Id("ui-id-3");
            byNome = By.Id("txtNome");
            byApelido = By.Id("txtApelido");
            byNaturalidade = By.Id("txtNat");
            byDataNascimento = By.Id("txtNascimento");
            bySexo = By.Id("cmbSexo");
            byNomePai = By.Id("txtPai");
            byNomeMae = By.Id("txtMae");
            byLogadouro = By.Id("txtLogradouro");
            byNumeroCasa = By.Id("txtNumero");
            byBairro = By.Id("txtBairro");
            byCidade = By.Id("txtCid");
            byDDD = By.Id("txtDDDFixo");
            byTelefone = By.Id("txtTelefone");

            //Aba Especialidades
            byAbaEspecialidades = By.Id("ui-id-4");
            byInserirEspecialidade = By.Id("tlbEspecialidades_tlbEspecialidadesBtnAppend_CD");
            bySelecionarEspecialidade = By.Id("winEspecialidade_cmbEspecialidade");
            byValidadeEspecialidade = By.Id("winEspecialidade_dteValidade");
            bySalvarEspecialidade = By.Id("winEspecialidade_tblEspecialidadePopup_btnSalvarPopup_CD");
            bySelecionarEspecialidadeParaExcluir = By.Id("lstEspecialidade_LBI0T0");
            byExcluirEspecialidade = By.Id("tlbEspecialidades_tlbEspecialidadesBtnDelete_CD");
            byConfirmarExclusaoEspecialidade = By.XPath("/html/body/div[9]/div[3]/div/button[1]/span");

            //Aba Foto
            byAbaFoto = By.Id("ui-id-5");
            byUpFoto = By.Id("UpFoto");
            byImportarFoto = By.Id("tlbUpload_btnFoto_CD");

            //Aba Anexar Documento
            byAbaAnexarDocumento = By.Id("ui-id-6");
            byUpArquivo = By.Id("UpFile_TextBox0_Input");
            byIdentificacaoArquivo = By.Id("ddlIdentificacao");
            byAnexarArquivo = By.Id("tlbUpload_btnAnexar_CD");
            byFecharConfirmacao = By.XPath("/html/body/div[4]/div[3]/div/button/span");
            bySelecionarArquivoParaExcluir = By.Id("lstArquivos_LBI1T0");
            byExcluirArquivo = By.Id("tlbArquivos_btnExcluir_CD");
            byConfirmarExclusao = By.XPath("/html/body/div[8]/div[3]/div/button[1]");

            //Enviar para pesquisa
            byEnviarParaPesquisa = By.Id("tlbPrincipal_btnSalvar_CD");
            bySelecionarTipoPesquisaExpressa = By.Id("lstPesquisaExpressa");
            byBotaoSim = By.XPath("/html/body/div[6]/div[3]/div/button[1]/span");
            byBotaoNao = By.XPath("/html/body/div[6]/div[3]/div/button[2]/span");

            // Fechar Janela
            byFecharConfirmacao1 = By.XPath("/html/body/div[3]/div[3]/div/button");
            byFecharJanela = By.Id("OpenPopup_ctl00_HCB0");
        }
        public void AbrirJanelaCadastrodePerfilProfissional()
        {
            driver.FindElement(byAbaCadastro).Click();
            driver.FindElement(byAbaProfissional).Click();
            driver.FindElement(byAbaCadastroPerfilProfissional).Click();
        }
        public void PreencherAbaDocumentos(
            string DataEmissaoRG,
            string Profissao,
            string Vinculo,
            string UF,
            string DataContratacao,
            string DataEmissaoCNH,
            string DataVenciomentoCNH,
            string CategoriaCNH,
            string DataVencimentoMOPP,
            string NumeroRegistroMOPP,
            string EntidadeEmissoraMOPP)
        {
            Thread.Sleep(2000);
            driver.FindElement(byCPF).SendKeys(ConfigPaginas.GerarCpf());
            Thread.Sleep(2000);
            driver.FindElement(byCPF).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byRG).SendKeys(ConfigPaginas.NumeroRandomico(7));
            driver.FindElement(byDataEmissaoRG).SendKeys(DataEmissaoRG);
            driver.FindElement(byProfissao).SendKeys(Profissao);
            driver.FindElement(byVinculo).SendKeys(Vinculo);
            driver.FindElement(byDataContratacao).SendKeys(DataContratacao);
            driver.FindElement(byNumeroMatricula).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byNumeroCNH).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byNumeroRegistro).SendKeys(ConfigPaginas.NumeroRandomico(8));
            driver.FindElement(byUF).SendKeys(UF);
            driver.FindElement(byDataEmissaoCNH).SendKeys(DataEmissaoCNH);
            driver.FindElement(byDtVencimentoCNH).SendKeys(DataVenciomentoCNH);
            driver.FindElement(byCategoriaCNH).SendKeys(CategoriaCNH);
            driver.FindElement(byDataVenciomentoMOPP).SendKeys(DataVencimentoMOPP);
            driver.FindElement(byNumeroRegistroMOPP).SendKeys(NumeroRegistroMOPP);
            driver.FindElement(byEntidadeEmissoraMOPP).SendKeys(EntidadeEmissoraMOPP);
        }

        public void TrocarParaAbaReferencias()
        {
            driver.FindElement(byAbaReferencias).Click();
        }
        public void PreencherAbaReferencias(
            string Nome,
            string TipoRelacionamento,
            string Rua,
            string Cidade)
        {
            driver.FindElement(byNomeReferencia).SendKeys(Nome);
            driver.FindElement(byTipoRelacionamento).SendKeys(TipoRelacionamento);
            driver.FindElement(byLogadouroReferencia).SendKeys(Rua);
            driver.FindElement(byCidadeReferencia).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byDDDReferencia).SendKeys(ConfigPaginas.NumeroRandomico(2));
            driver.FindElement(byTelefoneReferencia).SendKeys(ConfigPaginas.NumeroRandomico(9));
            driver.FindElement(byInserirReferencia).Click();
        }

        public void TrocarParaAbaDadosPessoais()
        {
            driver.FindElement(byAbaDadosPessoais).Click();
        }

        public void PreencherAbaDadosPessoais(
            string Nome,
            string Apelido,
            string Naturalidade,
            string DataNascimento,
            string Sexo,
            string NomePai,
            string NomeMae,
            string Rua,
            string Bairro,
            string Cidade)
        {
            driver.FindElement(byNome).SendKeys(Nome);
            driver.FindElement(byApelido).SendKeys(Apelido);
            driver.FindElement(byNaturalidade).SendKeys(Naturalidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byDataNascimento).SendKeys(DataNascimento);
            driver.FindElement(bySexo).SendKeys(Sexo);
            driver.FindElement(byNomePai).SendKeys(NomePai);
            driver.FindElement(byNomeMae).SendKeys(NomeMae);
            driver.FindElement(byLogadouro).SendKeys(Rua);
            driver.FindElement(byNumeroCasa).SendKeys(ConfigPaginas.NumeroRandomico(5));
            driver.FindElement(byBairro).SendKeys(Bairro);
            driver.FindElement(byCidade).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byDDD).SendKeys(ConfigPaginas.NumeroRandomico(2));
            driver.FindElement(byTelefone).SendKeys(ConfigPaginas.NumeroRandomico(9));
        }
        public void TrocarParaAbaEspecialidades()
        {
            driver.FindElement(byAbaEspecialidades).Click();
        }

        public void PreencherAbaEspecialidadesa(
            string Especialidade1,
            string Validade1,
            string Especialidade2,
            string Validade2)
        {
            driver.FindElement(byInserirEspecialidade).Click();
            driver.FindElement(bySelecionarEspecialidade).SendKeys(Especialidade1);
            driver.FindElement(byValidadeEspecialidade).SendKeys(Validade1);
            driver.FindElement(bySalvarEspecialidade).Click();
            driver.FindElement(byInserirEspecialidade).Click();
            driver.FindElement(bySelecionarEspecialidade).SendKeys(Especialidade2);
            driver.FindElement(byValidadeEspecialidade).SendKeys(Validade2);
            driver.FindElement(bySalvarEspecialidade).Click();
            Thread.Sleep(1000);
            driver.FindElement(bySelecionarEspecialidadeParaExcluir).Click();
            driver.FindElement(byExcluirEspecialidade).Click();
            driver.FindElement(byConfirmarExclusaoEspecialidade).Click();
        }
        public void TrocarParaAbaFoto()
        {
            driver.FindElement(byAbaFoto).Click();
        }
        public void PreencherCamposAbaFoto(
            string Foto)
        {
            driver.FindElement(byUpFoto).SendKeys(Foto);
            driver.FindElement(byImportarFoto).Click();
        }
        public void TrocarParaAbaAnexarDocumento()
        {
            driver.FindElement(byAbaAnexarDocumento).Click();
        }

        public void PreencherCamposAbaAnexarDocumento(
            string Arquivo1,
            string IdentificacaoArquivo1,
            string Arquivo2,
            string IdentificacaoArquivo2)
        {
            driver.FindElement(byUpArquivo).SendKeys(Arquivo1);
            driver.FindElement(byIdentificacaoArquivo).SendKeys(IdentificacaoArquivo1);
            driver.FindElement(byAnexarArquivo).Click();
            Thread.Sleep(1000);
            driver.FindElement(byFecharConfirmacao).Click();
            driver.FindElement(byUpArquivo).SendKeys(Arquivo2);
            driver.FindElement(byIdentificacaoArquivo).SendKeys(IdentificacaoArquivo2);
            driver.FindElement(byAnexarArquivo).Click();
            Thread.Sleep(1000);
            driver.FindElement(byFecharConfirmacao).Click();
            driver.FindElement(bySelecionarArquivoParaExcluir).Click();
            driver.FindElement(byExcluirArquivo).Click();
            Thread.Sleep(1000);
            driver.FindElement(byConfirmarExclusao).Click();
            Thread.Sleep(1000);
            driver.FindElement(byFecharConfirmacao).Click();
        }
        public void EnviarParaPesquisa()
        {
            driver.FindElement(byEnviarParaPesquisa).Click();
            driver.FindElement(bySelecionarTipoPesquisaExpressa).Click();
            Thread.Sleep(1000);
            driver.FindElement(byBotaoSim).Click();
            //driver.FindElement(byBotaoNao).Click(); 
            Thread.Sleep(1000);
        }

        public void FecharJanela()
        {
            driver.Navigate().GoToUrl("http://silpaineldesenv.opentechgr.com.br/Default.aspx");
        }

        public void AlterarCamposAbaDocumento(
            string CPF)
        {
            driver.FindElement(byCPF).SendKeys(CPF);
            driver.FindElement(byCPF).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byRG).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byRG).SendKeys(ConfigPaginas.NumeroRandomico(7));
        }

        public void AlterarCamposAbaReferencias(
            string CPF)
        {
            driver.FindElement(byCPF).SendKeys(CPF);
            driver.FindElement(byCPF).SendKeys(Keys.Tab);
            driver.FindElement(byAbaReferencias).Click();
            driver.FindElement(bySelecionarReferencia).Click();
            driver.FindElement(byEditarReferencia).Click();
            driver.FindElement(byNomeReferencia).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byNomeReferencia).SendKeys(ConfigPaginas.LetraRandomica(7));
            driver.FindElement(bySalvarReferencia).Click();
        }

        public void AlterarCamposAbaDadosPessoais(
            string CPF)
        {            
            driver.FindElement(byCPF).SendKeys(CPF);
            driver.FindElement(byCPF).SendKeys(Keys.Tab);
            driver.FindElement(byAbaDadosPessoais).Click();
            driver.FindElement(byLogadouro).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byLogadouro).SendKeys(ConfigPaginas.LetraRandomica(8));
        }
    }
}



