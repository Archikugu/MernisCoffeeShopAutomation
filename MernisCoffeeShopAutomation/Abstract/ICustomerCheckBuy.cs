using MernisCoffeeShopAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisCoffeeShopAutomation.Abstract
{
    public interface ICustomerCheckBuy
    {
        bool CheckBuy(Product product);
    }
}
