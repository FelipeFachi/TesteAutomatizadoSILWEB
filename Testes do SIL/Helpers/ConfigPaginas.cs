using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Testes_do_SIL.Fixtures;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
using Testes_do_SIL.PageObjects;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Linq;

namespace Testes_do_SIL.Helpers
{
    public class ConfigPaginas
    {
        private IWebDriver driver;

        public EfetuarLogin LoginNoSil { get; }
        public ConfigPaginas(IWebDriver driver)
        {
            this.driver = driver;
            LoginNoSil = new EfetuarLogin(driver);
        }

        // Paginas

        public void PaginaInicialSIL()
        {
            driver.Navigate().GoToUrl("http://silpaineldesenv.opentechgr.com.br/Default.aspx");
        }
               
        //Frames

        public void Frame()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id("frawinActive_0")));
        }
        public void Frame2()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id("fraPrincipal")));
        }
        public void Frame3()
        {
            driver.SwitchTo().ParentFrame();
        }

        public void Frame4()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id("winPrincipalRs_CIF-1")));
        }

        public void Frame5()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id("frawinActive_1")));
        }

        // Gerador de numeros / Placas

        private static Random random = new Random();
        public static string NumeroRandomico(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }
        public static string LetraRandomica(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        public static string PlacaRandomica()
        {
            string retorno = LetraRandomica(3) + NumeroRandomico(4);
            return retorno;
        }

        // Gerador de CPF 
        public static String GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;
        }
    }
}
