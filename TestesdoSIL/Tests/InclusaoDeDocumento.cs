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
    public class InclusaoDeDocumento
    {
        private IWebDriver driver;
        
        public InclusaoDeDocumento(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]

        public void IncluirUmDocumento()
        {
            var InclusaoDeDocumentoPO = new InclusaoDeDocumentoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            InclusaoDeDocumentoPO.AbrirJanelaInclusaoDocumento();

            ConfigPaginas.Frame();

            InclusaoDeDocumentoPO.PreencherAbaDadosDoDocumento("Nota Fiscal", DateTime.Now.AddDays(11), DateTime.Now.AddDays(12), "04368185000142", "Transferência");

            InclusaoDeDocumentoPO.PreencherAbaProdutos("Arroz", "ZINCO EM BARRA");

            InclusaoDeDocumentoPO.GravarDocumento();

            ConfigPaginas.Frame3();

            InclusaoDeDocumentoPO.FecharJanela();

        }
    }
}
