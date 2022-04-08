using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_2022_Classwork.Models
{
    class ProductItem
    {
        public int Id { get; set; }
        public Product Products { get; set; }
        public double TotalPrice { get => Products.Price * Count; }
        public int Count { get; set; }
        public ProductItem()
        {

        }
    }
}
