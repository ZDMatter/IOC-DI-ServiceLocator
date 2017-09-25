using Microsoft.Practices.Unity;
using SandBoxIoc.ViewModel;
using SandBoxIocDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandBoxIoc.Controllers
{
    public class HomeController : Controller
    {
        readonly IShippingType homeDelivery;
        readonly IShippingType upsDelivery;
        readonly IPerson person;

        IShippingType concrte3;

        public HomeController()
        { }

        public HomeController([Dependency("Concrete1")]IShippingType homeDelivery, [Dependency("Concrete2")]IShippingType upsDelivery, IPerson person)
        {
            this.homeDelivery = homeDelivery;
            this.upsDelivery = upsDelivery;
            this.person = person;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        /// <summary>
        /// Property injection
        /// </summary>
        [Dependency("Concrete3")]
        public IShippingType PropertyInjectDelivery
        {
            get { return concrte3; }
            set { concrte3 = value; }
        }

        public ActionResult HomeDelivery()
        {
            var shippingToWho = new ShippingToWho();
            person.ID = 1;
            person.Name = "Raj";

            shippingToWho.ShipTo = person;
            shippingToWho.ShippingType = homeDelivery.GetShipping();
            return View(shippingToWho);
        }

        public ActionResult UpsDelivery()
        {
            return View(upsDelivery.GetShipping());
        }

        public ActionResult InjectDelivery()
        {
            return View(concrte3.GetShipping());
        }
    }
}
