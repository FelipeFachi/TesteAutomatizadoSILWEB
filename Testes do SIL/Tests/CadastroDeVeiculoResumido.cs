using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Testes_do_SIL.PageObjects;
using Xunit;
using Testes_do_SIL.Helpers;
using Testes_do_SIL.Fixtures;
using System.Threading;

namespace Testes_do_SIL.Tests
{
    [Collection("Chrome Driver")]
    public class CadastroDeVeiculoResumido
    {
        private IWebDriver driver;
        public CadastroDeVeiculoResumido(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void CadastrarUmVeiculoCorretamente()
        {
            var CadastroDeVeiculoResumidoPO = new CadastroDeVeiculoResumidoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();
            
            CadastroDeVeiculoResumidoPO.AbrirJanelaCadastrodeVeículoResumido();

            ConfigPaginas.Frame();

            CadastroDeVeiculoResumidoPO.PreencherCamposAbaDadosDoVeiculo("Joinville/SC", "SCANIA", "114GA-4X2NZ 340", "FROTA", "Cavalo", "AZUl", "FECHADA", "2011", "ONIXSAT RASTREAMENTO DE VEÍCULOS LTDA - JABUR", "TESTE FACHI", "TESTE.COM.BR");

            CadastroDeVeiculoResumidoPO.TrocarParaAbaAcessoriosCaracteristicas();

            CadastroDeVeiculoResumidoPO.PreencherAbaAbaAcessoriosCaracteristicas("BLOQUEADOR", "BOTAO DE PANICO");
            
            CadastroDeVeiculoResumidoPO.EnviarParaPesquisa();
                      
            CadastroDeVeiculoResumidoPO.FecharJanela();            

        }
        [Fact]
        public void AlteracaoAbaDadosDoVeiculo()
        {
            var CadastroDeVeiculoResumidoPO = new CadastroDeVeiculoResumidoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            CadastroDeVeiculoResumidoPO.AbrirJanelaCadastrodeVeículoResumido();

            ConfigPaginas.Frame();

            CadastroDeVeiculoResumidoPO.AlterarAbaDadadosDoVeiculo("AAA0512");

            CadastroDeVeiculoResumidoPO.EnviarParaPesquisa();

            ConfigPaginas.Frame3();

            CadastroDeVeiculoResumidoPO.FecharJanela();
        }
    }
}
