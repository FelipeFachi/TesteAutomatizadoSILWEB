using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testes_do_SIL.Fixtures
{ 
    [CollectionDefinition("Chrome Driver")]
    public class CollectionFixture : ICollectionFixture<TestFixture>
    {
    }
}
