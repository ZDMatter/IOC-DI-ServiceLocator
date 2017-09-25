using SandBoxIocDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandBoxIoc.ViewModel
{
    public class ShippingToWho
    {
        public Shipping ShippingType { get; set; }
        public IPerson ShipTo { get; set; }
    }
}