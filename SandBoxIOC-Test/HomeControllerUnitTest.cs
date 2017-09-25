using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using SandBoxIoc.Controllers;
using System.Web.Mvc;
using SandBoxIocDomain.Domain;
using Moq.AutoMock;
using SandBoxIoc.ViewModel;

namespace SandBoxIOC_Test
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        private IShippingType homeDelivery;
        private IShippingType upsDelivery;
        private IPerson personMock;

        [TestInitialize]
        public void Initialize()
        {
            var mocker = new AutoMocker();
            homeDelivery = mocker.CreateInstance<Concrete1>();
            upsDelivery = mocker.CreateInstance<Concrete2>();
            personMock = mocker.CreateInstance<Person>();
        }

        [TestMethod]
        public void HomeDeliveryUnitTest()
        {
            //Arrange - Sending actual 
            IShippingType hd = new Concrete1();
            IShippingType up = new Concrete2();
            IPerson person = new Person();
            HomeController controller = new HomeController(hd, up, person);

            //Act
            ViewResult result = controller.HomeDelivery() as ViewResult;

            var model = result.Model as ShippingToWho;
            //Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual("Home Delivery Service", model.ShippingType.ShippingName);
        }

        [TestMethod]
        public void UpsDeliveryUnitTest()
        {
            //Arrange - Now send moq
            HomeController controller = new HomeController(homeDelivery, upsDelivery, personMock);

            //Act
            ViewResult result = controller.UpsDelivery() as ViewResult;
            var model = result.Model as Shipping;

            //Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual("Ups Shipping", model.ShippingName);
        }
    }
}
