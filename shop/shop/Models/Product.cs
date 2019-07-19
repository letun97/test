using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class Product
    {
        //список товаров
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; } // количество
        public int TypeProduct { get; set; } //тип товара
        public string Company { get; set; } //компания
    }
}
