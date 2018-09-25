using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.SeleniumUteis;

namespace UnitTestProject1.SeleniumComum
{
    class DriverFactory
    {

        public static IWebDriver INSTANCE { get; set; } = null;

        public static void CreateInstance()
        {

     

            if (INSTANCE == null)
            {
                
                        INSTANCE = new ChromeDriver(SeleniumPatch.getPathSeleniumDriver());
                        //Criei um método que retorna o path do driver: SeleniumUteis.SeleniumUteis.getPathSeleniumDriver
                        INSTANCE.Manage().Window.Maximize();
 
                }



        }
        

        public static void QuitInstace()
        {
            INSTANCE.Quit();
            INSTANCE = null;
        }





    }
}
