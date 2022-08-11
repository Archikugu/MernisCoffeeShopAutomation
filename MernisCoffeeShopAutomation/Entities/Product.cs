using MernisCoffeeShopAutomation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisCoffeeShopAutomation.Entities
{
    public class Product :IEntity
    {
        public int ProductNo { get; set; }
        public string ProductName { get; set; }
    }
}
