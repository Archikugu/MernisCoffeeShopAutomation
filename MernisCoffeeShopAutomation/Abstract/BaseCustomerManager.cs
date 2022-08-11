using MernisCoffeeShopAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisCoffeeShopAutomation.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {


        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName + " : " + customer.NationalityId);
        }
        public abstract void Buy(Customer customer, Product product);
        public void GiveStar(Customer customer)
        {
            Console.WriteLine("Gived star " + customer.FirstName);
        }
    }
}
