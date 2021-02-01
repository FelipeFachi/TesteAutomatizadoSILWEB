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
    public class VincularDocumento
    {
        private IWebDriver driver;

        public VincularDocumento(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void VincularUmDocumento()
        {
            var VincularDocumentoPO = new VincularDocumentoPO(driver);
            var ConfigPaginas = new ConfigPaginas(driver);

            ConfigPaginas.LoginNoSil.EfetuarLoginCorretamente();

            VincularDocumentoPO.AbrirJanelaVincularDocumento();

            ConfigPaginas.Frame();

            VincularDocumentoPO.VincularDocumento("20050026", DateTime.Now, DateTime.Now.AddDays(28), "04368185000142");

            ConfigPaginas.Frame3();

            VincularDocumentoPO.FecharJanela();
        }
    }
}
