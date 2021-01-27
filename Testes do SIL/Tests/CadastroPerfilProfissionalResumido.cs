using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Testes_do_SIL.Fixtures;
using Testes_do_SIL.Helpers;
using Testes_do_SIL.PageObjects;
using Xunit;

namespace Testes_do_SIL.Tests
{
    [Collection("Chrome Driver")]
    public class CadastroPerfilProfissionalResumido
    {
        private IWebDriver driver;
        public CadastroPerfilProfissionalResumido(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]

        public void CadastrarUmMotoristaResumidoCorretamente()
        {
            var CadastroPerfilProfissionalResumidoPO = new CadastroPerfilProfissionalResumidoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalResumidoPO.AbrirJanelaCadastroPerfilProfissionalResumido();

            CadastroPerfilProfissionalResumidoPO.PreencherAbaDados("Teste","08081990","Joinville/SC", "SJS-RS", "05012020", "Agregado", "Motorista", "AL", "04012020", "05012025", "AE", "05012025", "CNH");

            CadastroPerfilProfissionalResumidoPO.PreencherAbaEspecialidades("BITREM", "05012022");

            CadastroPerfilProfissionalResumidoPO.FecharJanela();
            

        }

        [Fact]
        public void AlterarCamposAbaDados()
        {
            var CadastroPerfilProfissionalResumidoPO = new CadastroPerfilProfissionalResumidoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroPerfilProfissionalResumidoPO.AbrirJanelaCadastroPerfilProfissionalResumido();

            ConfigPaginas.Frame();

            CadastroPerfilProfissionalResumidoPO.AlterarCamposAbaDados("93387202091");
            
            CadastroPerfilProfissionalResumidoPO.FecharJanela();
        }
    }
}
