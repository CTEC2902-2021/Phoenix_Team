﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Mvc;
using WebAppPremierLeague.Controllers;
using WebAppPremierLeague.Models;


namespace WebAppPremierLeagueTesting
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //arrange

            HomeController controller = new HomeController();

            //act

            ViewResult result = controller.Index() as ViewResult;

            //assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void TeamName()
        {
            //arrange
            HomeController controller = new HomeController();

            //act
            ViewResult viewresult = controller.Teams();
            TeamsModel result = viewresult.Model as TeamsModel;

            //assert
            Assert.AreEqual("Man City", result.TeamName);
        }

        [TestMethod]
        public void TeamHasWins()
        {
            //arrange
            HomeController controller = new HomeController();

            //act
            ViewResult result = controller.Teams();
            
            //assert
            Assert.AreEqual("This teams has loads of wins", result.ViewBag.Subtitle);
        }
    }
}
