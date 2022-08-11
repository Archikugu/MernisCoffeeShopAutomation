using MernisCoffeeShopAutomation.Abstract;
using MernisCoffeeShopAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisCoffeeShopAutomation.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService, ICustomerCheckBuy
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
        public bool CheckBuy(Product product)
        {
            if (product.ProductName == "Coffee")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
