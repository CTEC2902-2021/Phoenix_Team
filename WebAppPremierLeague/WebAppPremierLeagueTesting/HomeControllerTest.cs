using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppPremierLeague.Controllers;


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
    }
}
