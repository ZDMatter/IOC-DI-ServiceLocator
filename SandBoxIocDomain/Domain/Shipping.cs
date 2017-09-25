using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxIocDomain.Domain
{
    public class Shipping
    {
        public string ShippingName { get; set; }
        public float Rate { get; set; }
        public bool SupportPrioroty { get; set; }
    }
}
