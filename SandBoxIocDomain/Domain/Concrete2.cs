using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxIocDomain.Domain
{
    public class Concrete2 : IShippingType
    {
        public Shipping GetShipping()
        {
            return new Shipping() { ShippingName = "Ups Shipping", SupportPrioroty = true, Rate = 12.33f };
        }
    }
}
