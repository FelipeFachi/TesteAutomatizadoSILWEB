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
    public class EmissaoDeAutorizacaoDeEmbarque
    {
        private IWebDriver driver;
        public EmissaoDeAutorizacaoDeEmbarque(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]

        public void EmitirUmaAeCorretamente()
        {
            var EmissaoDeAutorizacaoDeEmbarquePO = new EmissaoDeAutorizacaoDeEmbarquePO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();            

            EmissaoDeAutorizacaoDeEmbarquePO.AbrirJanelaEmissaoAE();

            ConfigPaginas.Frame();

            EmissaoDeAutorizacaoDeEmbarquePO.PreencherAbaViagemDadosDoMotorista("93387202091", "34543118537");

            EmissaoDeAutorizacaoDeEmbarquePO.PreencherAbaViagemDadosCavaloCarreta("ABC0512", "BBB1111");

            EmissaoDeAutorizacaoDeEmbarquePO.PreencherAbaViagemDadosdaViagem("3PL BRASIL LOGISTICA S.A.", "POSITRON", "https://teste.com.br", "TRAVA", "TESTE FACHI");

            EmissaoDeAutorizacaoDeEmbarquePO.PreencherAbaDocumentosDadosdoDocumento("Nota Fiscal", DateTime.Now.AddDays(11), DateTime.Now.AddDays(12), "04368185000142");

            EmissaoDeAutorizacaoDeEmbarquePO.PreencherAbaDocumentosDadosComplementares("Arroz");

            EmissaoDeAutorizacaoDeEmbarquePO.PreencherAbaSensordeTemperatura("Congelado");

            EmissaoDeAutorizacaoDeEmbarquePO.PreencherAbaRota("Joinville");

            EmissaoDeAutorizacaoDeEmbarquePO.CriarViagem();

            ConfigPaginas.Frame3();

            EmissaoDeAutorizacaoDeEmbarquePO.FecharJanela();

        }
    }
}
