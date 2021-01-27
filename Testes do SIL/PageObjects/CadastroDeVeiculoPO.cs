using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;
using Testes_do_SIL.Helpers;


namespace Testes_do_SIL.PageObjects
{
    public class CadastroDeVeiculoPO
    {
        private IWebDriver driver;

        //Abrir Janela Cadastro de Veiculo
        private By byAbaCadastro;
        private By byAbaVeiculo;
        private By byAbaCadastroVeiculo;

        //Aba Dados do Veiculo         
        private By byPlaca;
        private By byRenavam;
        private By byMarca;
        private By bySelecionarMarca;
        private By byModeloDoVeiculo;
        private By byVinculo;
        private By byTipoVeiculo;
        private By byCorVeiculo;
        private By byclick;
        private By byTipoCarroceria;
        private By byCombustivel;
        private By byCidade;
        private By bySelecionarCidade;
        private By byDataEmissaoLincenciamento;
        private By byDataTransferencia;
        private By byAnoModelo;
        private By byAnoFabricacao;
        private By byUnidadeResponsalve;

        //Aba Proprietario
        private By byAbaProprietario;
        private By byclick2;
        private By byPaisDeOrigem;
        private By byCPFCNPJ;
        private By byNome;
        private By byANTT;
        private By byValidadeANTT;
        private By byDataNascimento;
        private By byNacionalidade;
        private By byNaturalizade;
        private By byRG;
        private By byOrgaoExpedidor;
        private By byDataEmissao;
        private By byNomeDoPai;
        private By byNomeDaMae;
        private By byLogadouro;
        private By byNumeroCasa;
        private By byComplemento;
        private By byBairro;
        private By byCidadeDoProprietario;
        private By byCEP;
        private By byDDD;
        private By byTelFixo;

        //Aba Rastreador/Acessórios/Características
        private By byAbaRastreadorAcessoriosCaracteristicas;
        private By byRastreadorPrincipal;
        private By byImobilizador;
        private By byIdRastreador;
        private By byTipoRastreador1;
        private By byIdImobilizador;
        private By bySegundoRastreador;
        private By byIdSegundoRastreador;
        private By bySiteImobilizador;
        private By byUsuarioImobilizador;
        private By bySenhaImobilizador;
        private By byTipoAcessorio;
        private By byInserirAcessorio;
        private By byExcluirAcessorio;
        private By byCaracteristica1;
        private By byCaracteristica2;
        private By byListaAcessorios;

        //Aba Foto
        private By byAbaFoto;
        private By byUpFoto;
        private By byImportarFoto;

        //Aba Anexar Documento
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

        //Fechar Janela
        private By byFecharJanela;
        private By byFecharConfirmacao2;
        
        
        public CadastroDeVeiculoPO(IWebDriver driver)
        {
            this.driver = driver;

            //Abrir Janela Cadastro de Veiculo
            byAbaCadastro = By.LinkText("Cadastro");
            byAbaVeiculo = By.LinkText("Veículo");
            byAbaCadastroVeiculo = By.LinkText("Cadastro de veículo");

            //Aba Dados Do Veiculo
            byPlaca = By.Id("txtPlaca");
            byRenavam = By.Id("txtRenavam");
            byMarca = By.Id("txtMarca");
            bySelecionarMarca = By.LinkText("SCANIA/R124");
            byModeloDoVeiculo = By.Id("cmbModelo");
            byVinculo = By.Id("cmbVinculo");
            byTipoVeiculo = By.Id("cmbTpVeiculo");
            byCorVeiculo = By.Id("cmbCor");
            byTipoCarroceria = By.Id("cmbTpCarroceria");
            byCombustivel = By.Id("cmbCombustivel");
            byCidade = By.Id("txtCidadeVeiculo");
            bySelecionarCidade = By.LinkText("JOINVILLE/SC");
            byclick = By.Id("txtFrota");
            byDataEmissaoLincenciamento = By.Id("edtDataEmissao");
            byDataTransferencia = By.Id("edtTransferencia");
            byAnoModelo = By.Id("txtAnoMod");
            byAnoFabricacao = By.Id("txtAnoFab");
            byUnidadeResponsalve = By.Id("cmbUnidadeResp");

            //Aba Proprietario
            byAbaProprietario = By.Id("ui-id-12");
            byclick2 = By.Id("razaoAlienador");
            byPaisDeOrigem = By.Id("cmbPaisOrig");
            byCPFCNPJ = By.Id("txtCPFCNPJ");
            byNome = By.Id("txtNome");
            byANTT = By.Id("txtAntt");
            byValidadeANTT = By.Id("edtValidadeRNTRC");
            byDataNascimento = By.Id("edtNascimento");
            byNacionalidade = By.Id("cmbNacionalidade");
            byNaturalizade = By.Id("txtCidadeNaturalidade");
            byRG = By.Id("txtRG");
            byOrgaoExpedidor = By.Id("cmbOrgaoExp");
            byDataEmissao = By.Id("edtEmissaoDoc");
            byNomeDoPai = By.Id("txtPai");
            byNomeDaMae = By.Id("txtMae");
            byLogadouro = By.Id("txtLogradouro");
            byNumeroCasa = By.Id("txtNumero");
            byComplemento = By.Id("txtComplemento");
            byBairro = By.Id("txtBairro");
            byCidadeDoProprietario = By.Id("txtCid");
            bySelecionarCidade = By.LinkText("JOINVILLE/SC");
            byCEP = By.Id("txtCep");
            byDDD = By.Id("txtDDDTelFixo");
            byTelFixo = By.Id("txtTelefone");

            //Aba Rastreador/Acessórios/Características
            byAbaRastreadorAcessoriosCaracteristicas = By.Id("ui-id-13");
            byRastreadorPrincipal = By.Id("cmbEmpresa1");
            byImobilizador = By.Id("cmbEmpRastreamento");
            byIdRastreador = By.Id("txtNrRast1");
            byTipoRastreador1 = By.Id("chkSatelital");
            byIdImobilizador = By.Id("txtImobilizador");
            bySegundoRastreador = By.Id("cmbEmpresa2");
            byIdSegundoRastreador = By.Id("txtNrRast2");
            bySiteImobilizador = By.Id("txtSite");
            byUsuarioImobilizador = By.Id("txtLogin");
            bySenhaImobilizador = By.Id("txtSenha");
            byTipoAcessorio = By.Id("cmbAcessorio");
            byInserirAcessorio = By.Id("tlbAcessorio_tlbAcessorioBtnAppend_CD");
            byExcluirAcessorio = By.Id("tlbAcessorio_tlbAcessorioBtnDelete_CD");
            byCaracteristica1 = By.Id("cbCaracteristicas_0");
            byCaracteristica2 = By.Id("cbCaracteristicas_4");
            byListaAcessorios = By.Id("lstAcessorio");

            //Aba Foto
            byAbaFoto = By.Id("ui-id-14");
            byUpFoto = By.Id("UpFoto");
            byImportarFoto = By.Id("tlbUpload_btnFoto_CD");

            //Aba Anexar Documento
            byAbaAnexarDocumento = By.Id("ui-id-15");
            byUpArquivo = By.Id("UpFile_TextBox0_Input");
            byIdentificacaoArquivo = By.Id("ddlIdentificacao");
            byAnexarArquivo = By.Id("tlbUpload_btnAnexar_CD");
            byFecharConfirmacao = By.XPath("/html/body/div[10]/div[3]/div/button/span");
            bySelecionarArquivoParaExcluir = By.Id("lstArquivos_LBI1T0");
            byExcluirArquivo = By.Id("tlbArquivos_btnExcluir_CD");
            byConfirmarExclusao = By.XPath("/html/body/div[9]/div[3]/div/button[1]/span");

            //Enviar para pesquisa
            byEnviarParaPesquisa = By.Id("tlbPrincipal_btnSalvar_CD");
            bySelecionarTipoPesquisaExpressa = By.Id("lstPesquisaExpressa");
            byBotaoSim = By.XPath("/html/body/div[8]/div[3]/div/button[1]/span");
            byBotaoNao = By.XPath("/html/body/div[8]/div[3]/div/button[2]/span");

            //Fechar Janela
            byFecharJanela = By.Id("OpenPopup_ctl00_HCB0");
            byFecharConfirmacao2 = By.XPath("/html/body/div[4]/div[3]/div/button/span");
        }


        public void AbrirJanelaCadastrodeVeículo()
        {
            driver.FindElement(byAbaCadastro).Click();
            driver.FindElement(byAbaVeiculo).Click();
            driver.FindElement(byAbaCadastroVeiculo).Click();
        }



        public void PreencherCamposAbaDadosDoVeiculo(
            string Marca,
            string Modelo,
            string Vinculo,
            string TipoVeiculo,
            string CorVeiculo,
            string Carroceria,
            string Combustivel,
            string Cidade,
            string DataLicenciamento,
            string DataTransferencia,
            string AnoModelo,
            string AnoFabricacao,
            string UnidadeResponsavel
            )
        {
            driver.FindElement(byPlaca).SendKeys(ConfigPaginas.PlacaRandomica());
            driver.FindElement(byclick).Click();
            Thread.Sleep(1000);
            driver.FindElement(byRenavam).SendKeys(ConfigPaginas.NumeroRandomico(10));
            Thread.Sleep(1000);
            driver.FindElement(byMarca).SendKeys(Marca);
            Thread.Sleep(1000);
            driver.FindElement(bySelecionarMarca).Click();
            driver.FindElement(byModeloDoVeiculo).SendKeys(Modelo);
            driver.FindElement(byVinculo).SendKeys(Vinculo);
            driver.FindElement(byTipoVeiculo).SendKeys(TipoVeiculo);
            driver.FindElement(byCorVeiculo).SendKeys(CorVeiculo);
            Thread.Sleep(3000);
            driver.FindElement(byTipoCarroceria).SendKeys(Carroceria);
            driver.FindElement(byCombustivel).SendKeys(Combustivel);
            driver.FindElement(byCidade).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byDataEmissaoLincenciamento).SendKeys(DataLicenciamento);
            driver.FindElement(byDataTransferencia).SendKeys(DataTransferencia);
            driver.FindElement(byAnoModelo).SendKeys(AnoModelo);
            driver.FindElement(byAnoFabricacao).SendKeys(AnoFabricacao);
            driver.FindElement(byUnidadeResponsalve).SendKeys(UnidadeResponsavel);

        }
        public void TrocarParaAbaProprietario()
        {
            driver.FindElement(byAbaProprietario).Click();
        }

        public void PreencherCamposAbaProprietario(
            string PaisDeOrigem,
            string Nome,
            string Validade,
            string DataNascimento,
            string Nacionalidade,
            string Naturalidade,
            string OrgãoExpedidor,
            string DataEmissão,
            string NomeDoPai,
            string NomeDaMae,
            string Logradouro,
            string NumeroCasa,
            string Complemento,
            string Bairro,
            string Cidade,
            string CEP,
            string DDD,
            string Telefone
            )
        {
            driver.FindElement(byPaisDeOrigem).SendKeys(PaisDeOrigem);
            driver.FindElement(byCPFCNPJ).SendKeys(ConfigPaginas.GerarCpf()); 
            Thread.Sleep(1000);
            driver.FindElement(byCPFCNPJ).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byNome).SendKeys(Nome);
            driver.FindElement(byANTT).SendKeys(ConfigPaginas.NumeroRandomico(8));
            driver.FindElement(byValidadeANTT).SendKeys(Validade);
            driver.FindElement(byDataNascimento).SendKeys(DataNascimento);
            driver.FindElement(byNacionalidade).SendKeys(Nacionalidade);
            driver.FindElement(byNaturalizade).SendKeys(Naturalidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byRG).SendKeys(ConfigPaginas.NumeroRandomico(7));
            driver.FindElement(byOrgaoExpedidor).SendKeys(OrgãoExpedidor);
            driver.FindElement(byDataEmissao).SendKeys(DataEmissão);
            driver.FindElement(byNomeDoPai).SendKeys(NomeDoPai);
            driver.FindElement(byNomeDaMae).SendKeys(NomeDaMae);
            driver.FindElement(byLogadouro).SendKeys(Logradouro);
            driver.FindElement(byNumeroCasa).SendKeys(NumeroCasa);
            driver.FindElement(byComplemento).SendKeys(Complemento);
            driver.FindElement(byBairro).SendKeys(Bairro);
            driver.FindElement(byCidadeDoProprietario).SendKeys(Cidade);
            driver.FindElement(bySelecionarCidade).Click();
            driver.FindElement(byCEP).SendKeys(CEP);
            driver.FindElement(byDDD).SendKeys(DDD);
            driver.FindElement(byTelFixo).SendKeys(Telefone);

        }
        public void TrocarParaAbaRastreadorAcessoriosCaracteristicas()
        {
            driver.FindElement(byAbaRastreadorAcessoriosCaracteristicas).Click();
        }

        public void PreencherCamposAbaRastreadorAcessoriosCaracteristicas(

            string TecnologiaRastreador1,
            string TecnologiaImobilizador,
            string SiteImobilizador,
            string UsuarioImobilizador,
            string TecnologiaRastreador2,
            string TipoDeAcessorio1,
            string TipoDeAcessorio2
            )

        {
            driver.FindElement(byRastreadorPrincipal).SendKeys(TecnologiaRastreador1);
            driver.FindElement(byIdRastreador).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byImobilizador).SendKeys(TecnologiaImobilizador);
            driver.FindElement(byIdImobilizador).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(bySiteImobilizador).SendKeys(SiteImobilizador);
            driver.FindElement(byUsuarioImobilizador).SendKeys(UsuarioImobilizador);
            driver.FindElement(bySenhaImobilizador).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(bySegundoRastreador).SendKeys(TecnologiaRastreador2);
            driver.FindElement(byIdSegundoRastreador).SendKeys(ConfigPaginas.NumeroRandomico(10));
            driver.FindElement(byTipoAcessorio).SendKeys(TipoDeAcessorio1);
            driver.FindElement(byInserirAcessorio).Click();
            driver.FindElement(byTipoAcessorio).SendKeys(TipoDeAcessorio2);
            driver.FindElement(byInserirAcessorio).Click();
            driver.FindElement(byListaAcessorios).Click();
            driver.FindElement(byListaAcessorios).SendKeys(Keys.ArrowDown);
            driver.FindElement(byExcluirAcessorio).Click();
            driver.FindElement(byCaracteristica1).Click();
            driver.FindElement(byCaracteristica2).Click();
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
            driver.FindElement(byFecharConfirmacao).Click();
            driver.FindElement(byUpArquivo).SendKeys(Arquivo2);
            driver.FindElement(byIdentificacaoArquivo).SendKeys(IdentificacaoArquivo2);
            driver.FindElement(byAnexarArquivo).Click();
            driver.FindElement(byFecharConfirmacao).Click();
            driver.FindElement(bySelecionarArquivoParaExcluir).Click();
            driver.FindElement(byExcluirArquivo).Click();
            driver.FindElement(byConfirmarExclusao).Click();
            Thread.Sleep(2000);
            driver.FindElement(byFecharConfirmacao).Click();
        }
        public void EnviarParaPesquisa()
        {
            driver.FindElement(byEnviarParaPesquisa).Click();
            driver.FindElement(bySelecionarTipoPesquisaExpressa).Click();
            driver.FindElement(byBotaoSim).Click();
            //driver.FindElement(byBotaoNao).Click(); 
        }

        public void FecharJanela()
        {
            driver.FindElement(byFecharConfirmacao2).Click();
            driver.FindElement(byFecharJanela).Click();
        }

        public void EnviarParaPesquisaAlteracao()
        {
            driver.FindElement(byEnviarParaPesquisa).Click();
            driver.FindElement(bySelecionarTipoPesquisaExpressa).Click();
            //.FindElement(byBotaoSim).Click();
            driver.FindElement(byBotaoNao).Click(); 
        }

        public void FecharJanelaAlteracao()
        {            
            driver.FindElement(byFecharJanela).Click();
        }

        public void AlterarAbaDadadosDoVeiculo(
            string Placa)
        {
            driver.FindElement(byPlaca).SendKeys(Placa);
            driver.FindElement(byPlaca).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byRenavam).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byRenavam).SendKeys(ConfigPaginas.NumeroRandomico(8));
        }

        public void AlterarAbaProprietario(
            string Placa)
        {
            driver.FindElement(byPlaca).SendKeys(Placa);
            driver.FindElement(byPlaca).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byAbaProprietario).Click();
            driver.FindElement(byANTT).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byANTT).SendKeys(ConfigPaginas.NumeroRandomico(8));
        }

        public void AlterarAbaRastreadorAcessoriosCaracteristicas(
            string Placa)
        {
            driver.FindElement(byPlaca).SendKeys(Placa);
            driver.FindElement(byPlaca).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            driver.FindElement(byAbaRastreadorAcessoriosCaracteristicas).Click();
            driver.FindElement(byIdRastreador).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(byIdRastreador).SendKeys(ConfigPaginas.NumeroRandomico(10));

        }
    }
}
