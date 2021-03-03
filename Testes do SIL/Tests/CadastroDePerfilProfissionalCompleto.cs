using OpenQA.Selenium;
using System.Threading;
using Testes_do_SIL.Fixtures;
using Testes_do_SIL.PageObjects;
using Xunit;
using System;
using Testes_do_SIL.Helpers;

namespace Testes_do_SIL.Tests
{
    [Collection("Chrome Driver")]
    public class CadastroPerfilProfissionalCompleto
    {
        private IWebDriver driver;
        public CadastroPerfilProfissionalCompleto(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]

        public void CadadatrarUmProfissionalCompletoCorretamente()
        {
            var CadastroPerfilProfissionalCompletoPO = new CadastroPerfilProfissionalCompletoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalCompletoPO.AbrirJanelaCadastrodePerfilProfissionalCompleto();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalCompletoPO.PreencherAbaDocumentos("SSP-AR", "04062019", "MOTORISTA", "AGREGADO", "SC", "08092018", "05052020", "05052025", "AE", "08082025", "8523657", "CNH");
            CadastroPerfilProfissionalCompletoPO.TrocarParaAbaReferencias();

            CadastroPerfilProfissionalCompletoPO.PreencherAbaReferencias("teste2", "Amigo", "Teste", "Joinville/SC");

            CadastroPerfilProfissionalCompletoPO.TrocarParaAbaDadosPessoais();

            CadastroPerfilProfissionalCompletoPO.PreencherAbaDadosPessoais("Teste32", "teste0", "Joinville/sc", "04121997", "Masculino", "testeA", "TesteM", "Testeee", "teste2", "Joinville/sc");

            CadastroPerfilProfissionalCompletoPO.TrocarParaAbaEspecialidades();

            CadastroPerfilProfissionalCompletoPO.PreencherAbaEspecialidadesa("Bitrem", "24072022", "rodotrem", "17/04/2025");

            CadastroPerfilProfissionalCompletoPO.TrocarParaAbaFoto();

            ConfigPaginas.Frame2();

            CadastroPerfilProfissionalCompletoPO.PreencherCamposAbaFoto("C:\\Teste.jpg");

            ConfigPaginas.Frame3();

            CadastroPerfilProfissionalCompletoPO.TrocarParaAbaAnexarDocumento();

            CadastroPerfilProfissionalCompletoPO.PreencherCamposAbaAnexarDocumento("C:\\Teste.jpg", "CNH DO PROFISSIONAL", "C:\\Teste.jpg", "FICHA DE REGISTRO");

            CadastroPerfilProfissionalCompletoPO.EnviarParaPesquisa();

            CadastroPerfilProfissionalCompletoPO.FecharJanela();         

        }

        [Fact]
        public void AlterarDadosAbaDocumentos()
        {
            var CadastroPerfilProfissionalCompletoPO = new CadastroPerfilProfissionalCompletoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalCompletoPO.AbrirJanelaCadastrodePerfilProfissionalCompleto();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalCompletoPO.AlterarCamposAbaDocumento("93387202091");

            CadastroPerfilProfissionalCompletoPO.EnviarParaPesquisa();

            CadastroPerfilProfissionalCompletoPO.FecharJanela();
        }

        [Fact]
        public void AlterarCamposAbaReferencias()
        {
            var CadastroPerfilProfissionalCompletoPO = new CadastroPerfilProfissionalCompletoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalCompletoPO.AbrirJanelaCadastrodePerfilProfissionalCompleto();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalCompletoPO.AlterarCamposAbaReferencias("93387202091");

            CadastroPerfilProfissionalCompletoPO.EnviarParaPesquisa();

            CadastroPerfilProfissionalCompletoPO.FecharJanela();
        }

        [Fact]
        public void AlterarCamposAbaDadosPessoais()
        {
            var CadastroPerfilProfissionalCompletoPO = new CadastroPerfilProfissionalCompletoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalCompletoPO.AbrirJanelaCadastrodePerfilProfissionalCompleto();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalCompletoPO.AlterarCamposAbaDadosPessoais("93387202091");

            CadastroPerfilProfissionalCompletoPO.EnviarParaPesquisa();

            CadastroPerfilProfissionalCompletoPO.FecharJanela();
        }        
    }
}

