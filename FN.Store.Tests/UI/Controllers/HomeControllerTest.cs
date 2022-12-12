using aula.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace FN.Store.Tests.UI.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        //dado o HomeController 

        [TestMethod,TestCategory("Controller/HomeController")]
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            //arrange 
            var homeController = new HomeController();

            //act
            var result = homeController.Index();

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }



    }
}
