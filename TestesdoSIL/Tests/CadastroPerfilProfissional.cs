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
    public class CadastroPerfilProfissional
    {
        private IWebDriver driver;
        public  CadastroPerfilProfissional(TestFixture fixture)
        {  
            driver = fixture.Driver;
        }
            
         [Fact]

         public void CadadatrarUmProfissionalCorretamente()
         {
             var CadastroPerfilProfissionalPO = new CadastroPerfilProfissionalPO(driver);
             var ConfigPaginas = new ConfigPaginas(driver);              
              
              ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();              

              CadastroPerfilProfissionalPO.AbrirJanelaCadastrodePerfilProfissional();
             
              ConfigPaginas.Frame();             
                            
              CadastroPerfilProfissionalPO.PreencherAbaDocumentos("04062019" ,"MOTORISTA","AGREGADO","SC" ,"08092018", "05052020","05052025", "AE","08082025", "8523657", "CNH");             
              CadastroPerfilProfissionalPO.TrocarParaAbaReferencias();                

              CadastroPerfilProfissionalPO.PreencherAbaReferencias("teste2","Amigo", "Teste", "Joinville/SC");                

              CadastroPerfilProfissionalPO.TrocarParaAbaDadosPessoais();
              
              CadastroPerfilProfissionalPO.PreencherAbaDadosPessoais("Teste32", "teste0", "Joinville/sc", "04121997", "Masculino", "testeA", "TesteM", "Testeee", "teste2","Joinville/sc");

              CadastroPerfilProfissionalPO.TrocarParaAbaEspecialidades();

              CadastroPerfilProfissionalPO.PreencherAbaEspecialidadesa("Bitrem", "24072022", "rodotrem", "17/04/2025");

              CadastroPerfilProfissionalPO.TrocarParaAbaFoto();

              ConfigPaginas.Frame2();

              CadastroPerfilProfissionalPO.PreencherCamposAbaFoto("C:\\Teste.jpg");

              ConfigPaginas.Frame3();

              CadastroPerfilProfissionalPO.TrocarParaAbaAnexarDocumento();

              CadastroPerfilProfissionalPO.PreencherCamposAbaAnexarDocumento("C:\\Teste.jpg", "CNH DO PROFISSIONAL", "C:\\Teste.jpg", "FICHA DE REGISTRO");

              CadastroPerfilProfissionalPO.EnviarParaPesquisa();

              CadastroPerfilProfissionalPO.FecharJanela();            

         }

        [Fact]
        public void AlterarDadosAbaDocumentos()
        {
            var CadastroPerfilProfissionalPO = new CadastroPerfilProfissionalPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalPO.AbrirJanelaCadastrodePerfilProfissional();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalPO.AlterarCamposAbaDocumento("93387202091");

            CadastroPerfilProfissionalPO.EnviarParaPesquisa();

            CadastroPerfilProfissionalPO.FecharJanela();
        }

        [Fact]
        public void AlterarCamposAbaReferencias()
        {
            var CadastroPerfilProfissionalPO = new CadastroPerfilProfissionalPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalPO.AbrirJanelaCadastrodePerfilProfissional();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalPO.AlterarCamposAbaReferencias("93387202091");

            CadastroPerfilProfissionalPO.EnviarParaPesquisa();

            CadastroPerfilProfissionalPO.FecharJanela();
        }

        [Fact]
        public void AlterarCamposAbaDadosPessoais()
        {
            var CadastroPerfilProfissionalPO = new CadastroPerfilProfissionalPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalPO.AbrirJanelaCadastrodePerfilProfissional();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalPO.AlterarCamposAbaDadosPessoais("93387202091");

            CadastroPerfilProfissionalPO.EnviarParaPesquisa();

            CadastroPerfilProfissionalPO.FecharJanela();
        }
    }
}

