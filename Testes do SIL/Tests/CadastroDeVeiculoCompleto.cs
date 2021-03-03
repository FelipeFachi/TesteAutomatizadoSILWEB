using OpenQA.Selenium;
using System.Threading;
using Testes_do_SIL.Fixtures;
using Testes_do_SIL.Helpers;
using Testes_do_SIL.PageObjects;
using Xunit;

namespace Testes_do_SIL.Tests
{
    [Collection("Chrome Driver")]
    public class CadastroDeVeiculoCompleto
    {
        private IWebDriver driver;
        public CadastroDeVeiculoCompleto(TestFixture fixture)
        {
            driver = fixture.Driver;
        }            

         [Fact]
         public void CadastrarUmVeiculoCompletoCorretamente()
         {
             var CadastroDeVeiculoCompletoPO = new CadastroDeVeiculoCompletoPO(driver);
             var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoCompletoPO.AbrirJanelaCadastrodeVeículoCompleto();
                       
            ConfigPaginas.Frame();

            CadastroDeVeiculoCompletoPO.PreencherCamposAbaDadosDoVeiculo("SCANIA/R124", "T113H", "AGREGADO", "Cavalo", "AZUL", "S.REBOQUE/C.FECHADA", "GASOLINA", "JOINVILLE", "05121991",
                 "05122000", "08092030" ,"2014", "2015", "OPENTECH - TESTE");

            CadastroDeVeiculoCompletoPO.TrocarParaAbaProprietario();

            CadastroDeVeiculoCompletoPO.PreencherCamposAbaProprietario("BRASIL", "Teste Nome", "10102045", "10101991", "BRASILEIRO", "JOINVILLE", "SSP-SP", "02122020", "teste Pai", "testeMae","Test Rua", "587", "TESTE COMPLEMENTO", "Teste Bairro", "JOINVILLE", "12235654", "11", "1234567897");

            CadastroDeVeiculoCompletoPO.TrocarParaAbaRastreadorAcessoriosCaracteristicas();

            CadastroDeVeiculoCompletoPO.PreencherCamposAbaRastreadorAcessoriosCaracteristicas(
                "ONIXSAT RASTREAMENTO DE VEÍCULOS LTDA - JABUR", "TESTE FACHI", "TESTE.COM.BR", "TESTE", "SASCAR TECNOLOGIA E SEGURANCA", "SIRENE", "BLOQUEADOR");

            CadastroDeVeiculoCompletoPO.TrocarParaAbaFoto();

            ConfigPaginas.Frame2();

            CadastroDeVeiculoCompletoPO.PreencherCamposAbaFoto("C:\\Teste.jpg");

            ConfigPaginas.Frame3();

            CadastroDeVeiculoCompletoPO.TrocarParaAbaAnexarDocumento();

            CadastroDeVeiculoCompletoPO.PreencherCamposAbaAnexarDocumento("C:\\Teste.jpg", "DOCUMENTO DO PROPRIETÁRIO", "C:\\Teste.jpg", "DOCUMENTO DO VEÍCULO");

            CadastroDeVeiculoCompletoPO.EnviarParaPesquisa();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoCompletoPO.FecharJanela();                     
         }

        [Fact]
        public void AlteracaoAbaDadosDoVeiculo()
        {
            var CadastroDeVeiculoCompletoPO = new CadastroDeVeiculoCompletoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoCompletoPO.AbrirJanelaCadastrodeVeículoCompleto();

            ConfigPaginas.Frame();

            CadastroDeVeiculoCompletoPO.AlterarAbaDadadosDoVeiculo("AAA0512");

            CadastroDeVeiculoCompletoPO.EnviarParaPesquisaAlteracao();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoCompletoPO.FecharJanelaAlteracao();
        }

        [Fact]
        public void AlterarAbaProprietario()
        {
            var CadastroDeVeiculoCompletoPO = new CadastroDeVeiculoCompletoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoCompletoPO.AbrirJanelaCadastrodeVeículoCompleto();

            ConfigPaginas.Frame();

            CadastroDeVeiculoCompletoPO.AlterarAbaProprietario("AAA0512");

            CadastroDeVeiculoCompletoPO.EnviarParaPesquisaAlteracao();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoCompletoPO.FecharJanelaAlteracao();
        }

        [Fact]
        public void AlterarAbaRastreadorAcessoriosCaracteristicas()
        {
            var CadastroDeVeiculoCompletoPO = new CadastroDeVeiculoCompletoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoCompletoPO.AbrirJanelaCadastrodeVeículoCompleto();

            ConfigPaginas.Frame();

            CadastroDeVeiculoCompletoPO.AlterarAbaRastreadorAcessoriosCaracteristicas("AAA0512");

            CadastroDeVeiculoCompletoPO.EnviarParaPesquisaAlteracao();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoCompletoPO.FecharJanelaAlteracao();
        }
    }
}

