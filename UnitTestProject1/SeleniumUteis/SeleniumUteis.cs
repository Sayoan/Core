using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.SeleniumComum;

namespace UnitTestProject1.SeleniumUteis
{
    class SeleniumUteis
    {
        public SeleniumUteis()
        {

            //PageFactory.InitElements(DriverFactory.INSTANCE, this);

        }
        public void ClicarBotao(IWebElement iwebelement)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
                iwebelement.Click();
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }

        }

        



        public void PreencherCampo(IWebElement iwebelement, String text)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
                iwebelement.Clear();
                iwebelement.SendKeys(text);

            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }


        }
        public void CBClick(IWebElement iwebelement, String text)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));


                iwebelement.Click();
                new SelectElement(iwebelement).SelectByText(text);
                iwebelement.Click();



            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }


        }

        public void CBClick_ElementoAusente(IWebElement iwebelement, String text)
        {

            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));



            SelectElement selectList = new SelectElement(iwebelement);
            IList<IWebElement> options = selectList.Options;
            int aux = options.Count;


            for (int i = 0; i < aux; i++)
            {


                if (options[i].Text.Trim().Equals(text))
                {

                    Assert.Fail();
                    break;
                }

            }




        }


        public void VerificarItem(IWebElement iwebelement, string text)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
                NUnit.Framework.Assert.AreEqual(text, iwebelement.Text);
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        public void PegarValor(IWebElement iwebelement, string label)
        {
            try
            {
                NUnit.Framework.Assert.AreEqual(label, iwebelement.Text);
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        public void LimparCampo(IWebElement iwebelement)
        {
            try
            {
                iwebelement.Clear();
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }
    }
}
