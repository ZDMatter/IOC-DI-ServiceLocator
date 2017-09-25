using Microsoft.Practices.Unity;
using SandBoxIocDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SandBoxIoc.Controllers
{
    public class ShippingController : ApiController
    {
        private IShippingType homeDelivery;

        public ShippingController()
        {
            homeDelivery = new Concrete1();
        }

        public ShippingController([Dependency("Concrete1")]IShippingType homeDelivery)
        {
            this.homeDelivery = homeDelivery;
        }

        public Shipping Get()
        {
            return homeDelivery.GetShipping();
        }
    }
}
