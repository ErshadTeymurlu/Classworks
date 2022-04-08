using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_2022_Classwork.Models
{
    class Order
    {
        public int Id { get; set; }
        public List<ProductItem> ProductItems { get; set; }
        public int OrderPrice { get; set; }
        public Order(List<ProductItem> items)
        {
            ProductItems = items;
        }
    }
}
