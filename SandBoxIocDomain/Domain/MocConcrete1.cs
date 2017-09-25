using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxIocDomain.Domain
{
    public class MocConcrete1 : IShippingType
    {
        public Shipping GetShipping()
        {
            return new Shipping() { ShippingName = "Moc Delivery", SupportPrioroty = false, Rate = 0.1f };
        }
    }
}
