using MernisCoffeeShopAutomation.Abstract;
using MernisCoffeeShopAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisCoffeeShopAutomation.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
        public override void Buy(Customer customer, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
