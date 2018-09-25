using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.SeleniumComum
{
    public class WebDriver
    {


        [SetUp]
        public void Setup()
        {
            DriverFactory.CreateInstance();
            DriverFactory.INSTANCE.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"].ToString());
        }


        [TearDown]
        public void TearDown()
        {
            DriverFactory.QuitInstace();
        }

    }
}
