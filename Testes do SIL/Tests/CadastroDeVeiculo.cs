using OpenQA.Selenium;
using System.Threading;
using Testes_do_SIL.Fixtures;
using Testes_do_SIL.Helpers;
using Testes_do_SIL.PageObjects;
using Xunit;

namespace Testes_do_SIL.Tests
{
    
    [Collection("Chrome Driver")]
    public class CadastroDeVeiculo 
    {
        private IWebDriver driver;
        public CadastroDeVeiculo(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void CadastrarUmVeiculoCorretamente()
        {
            var CadastroDeVeiculoPO = new CadastroDeVeiculoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoPO.AbrirJanelaCadastrodeVeículo();

            ConfigPaginas.Frame();

            CadastroDeVeiculoPO.PreencherCamposAbaDadosDoVeiculo("SCANIA/R124", "T113H", "AGREGADO", "Cavalo", "AZUL", "S.REBOQUE/C.FECHADA", "GASOLINA", "JOINVILLE", "05121991",
                "05122000", "2014", "2015", "OPENTECH - TESTE");

            CadastroDeVeiculoPO.TrocarParaAbaProprietario();

            CadastroDeVeiculoPO.PreencherCamposAbaProprietario("BRASIL", "Teste Nome", "10102045", "10101991", "BRASILEIRO", "JOINVILLE", "SSP-SP", "02122020", "teste Pai", "teste Mae", "Teste Rua", "587", "TESTE COMPLEMENTO", "Teste Bairro", "JOINVILLE", "12235654", "11", "1234567897");

            CadastroDeVeiculoPO.TrocarParaAbaRastreadorAcessoriosCaracteristicas();

            CadastroDeVeiculoPO.PreencherCamposAbaRastreadorAcessoriosCaracteristicas(
                "ONIXSAT RASTREAMENTO DE VEÍCULOS LTDA - JABUR", "TESTE FACHI", "TESTE.COM.BR", "TESTE", "SASCAR TECNOLOGIA E SEGURANCA", "SIRENE", "BLOQUEADOR");

            CadastroDeVeiculoPO.TrocarParaAbaFoto();

            ConfigPaginas.Frame2();

            CadastroDeVeiculoPO.PreencherCamposAbaFoto("C:\\Teste.jpg");

            ConfigPaginas.Frame3();

            CadastroDeVeiculoPO.TrocarParaAbaAnexarDocumento();

            CadastroDeVeiculoPO.PreencherCamposAbaAnexarDocumento("C:\\Teste.jpg", "DOCUMENTO DO PROPRIETÁRIO", "C:\\Teste.jpg", "DOCUMENTO DO VEÍCULO");

            CadastroDeVeiculoPO.EnviarParaPesquisa();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoPO.FecharJanela();
           
        }

        [Fact]
        public void AlteracaoAbaDadosDoVeiculo()
        {
            var CadastroDeVeiculoPO = new CadastroDeVeiculoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoPO.AbrirJanelaCadastrodeVeículo();

            ConfigPaginas.Frame();

            CadastroDeVeiculoPO.AlterarAbaDadadosDoVeiculo("AAA0512");

            CadastroDeVeiculoPO.EnviarParaPesquisaAlteracao();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoPO.FecharJanelaAlteracao();
        }

        [Fact]
        public void AlterarAbaProprietario()
        {
            var CadastroDeVeiculoPO = new CadastroDeVeiculoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoPO.AbrirJanelaCadastrodeVeículo();

            ConfigPaginas.Frame();

            CadastroDeVeiculoPO.AlterarAbaProprietario("AAA0512");

            CadastroDeVeiculoPO.EnviarParaPesquisaAlteracao();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoPO.FecharJanelaAlteracao();
        }

        [Fact]
        public void AlterarAbaRastreadorAcessoriosCaracteristicas()
        {
            var CadastroDeVeiculoPO = new CadastroDeVeiculoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoPO.AbrirJanelaCadastrodeVeículo();

            ConfigPaginas.Frame();

            CadastroDeVeiculoPO.AlterarAbaRastreadorAcessoriosCaracteristicas("AAA0512");

            CadastroDeVeiculoPO.EnviarParaPesquisaAlteracao();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoPO.FecharJanelaAlteracao();
        }
    }
 }

