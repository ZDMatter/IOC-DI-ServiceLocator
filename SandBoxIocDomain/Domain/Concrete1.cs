using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxIocDomain.Domain
{
    public class Concrete1 : IShippingType
    {
        public Shipping GetShipping()
        {
            return new Shipping() { ShippingName = "Home Delivery Service", SupportPrioroty = false, Rate = 25.00f };
        }
    }
}
