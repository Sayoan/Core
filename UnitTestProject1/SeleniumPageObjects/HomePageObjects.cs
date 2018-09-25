using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.SeleniumComum;
using UnitTestProject1.SeleniumUteis;

namespace UnitTestProject1.SeleniumPageObjects
{
    class HomePageObjects : WebDriver
    {

        public HomePageObjects()
        {
            //PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }

       


        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement tfSearch { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement btSearch { get; set; }


        public void SearchGoogle()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfSearch, "Teste1");
                Maps.ClicarBotao(btSearch);

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }

        }


    }
}
