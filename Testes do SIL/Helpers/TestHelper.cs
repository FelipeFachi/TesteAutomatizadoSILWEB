using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Testes_do_SIL.Helpers
{
    public static class TestHelper
    {
        public static string Executavel => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
    }
}
