﻿using System;
using NUnit.Framework;
using UnitTestProject1.SeleniumComum;
using UnitTestProject1.SeleniumPageObjects;

namespace UnitTestProject1
{

    public class Tests1 : WebDriver
    {
      

        [Test]
        [Category("CT")]
        public void MyFirstTest()
        {

            HomePageObjects homePageObjects = new HomePageObjects();
            homePageObjects.SearchGoogle();

            Assert.IsTrue(homePageObjects.btSearch.Displayed);

        }


    
    }
}
