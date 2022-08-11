using MernisCoffeeShopAutomation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MernisCoffeeShopAutomation.Entities
{
    public class Customer :IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateYear { get; set; }
        public long NationalityId { get; set; }
        public int StarPoint { get; set; }
    }
}
