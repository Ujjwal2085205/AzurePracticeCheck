using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruYum_AzureCloud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {

        // MenuItemController va = Items;

        List<MenuItem> NewItem = new List<MenuItem>() {
        new MenuItem{Id=1, Name="Paneer Tikka", freeDelivery=true,Active=true,dateOfLaunch=Convert.ToDateTime("2015-12-31")},
        new MenuItem{Id=2,Name="Chicken Tikka", freeDelivery=true,Active=true,dateOfLaunch=Convert.ToDateTime("2009-02-11")},
        new MenuItem{Id=3,Name="Paneer Biryani", freeDelivery=true,Active=true,dateOfLaunch=Convert.ToDateTime("2011-08-09")},
        new MenuItem{Id=4,Name="Chicken Biryani", freeDelivery=true,Active=true,dateOfLaunch=Convert.ToDateTime("2002-07-30")},
        new MenuItem{Id=5,Name="Masala Dosa", freeDelivery=true,Active=true,dateOfLaunch=Convert.ToDateTime("2005-12-01")},
        new MenuItem{Id=6,Name="Idli Sambhar", freeDelivery=true,Active=true,dateOfLaunch=Convert.ToDateTime("1990-11-30")},
        new MenuItem{Id=10,Name="Aloo Paratha", freeDelivery=true,Active=true,dateOfLaunch=Convert.ToDateTime("1992-02-28")},
        new MenuItem{Id=88,Name="Palak Paneer", freeDelivery=true,Active=false,dateOfLaunch=Convert.ToDateTime("2021-08-18")}

        };

        [HttpPost("{id}")]
        public Cart InstanceCart(int id)
        {

            MenuItem obj = NewItem.SingleOrDefault(item => item.Id == id);

            Cart Carts = new Cart() { menuItemId = id, Id = 1, userId = 1,menuItemName=obj.Name };
            return Carts;
        }
    }
}
