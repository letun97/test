using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class History
    {
        //история покупок
       // public Guid IdHistory { get; set; }
       // public Guid IdProduct { get; set; }
        public DateTime? DataBuy { get; set; }
        public DateTime? DataDelivery { get; set; }
        public Byte Status { get; set; } //0-товар в пути, 1- товар доставлен, 2-товар возвращен, 3-товар потерян, 4-товар арестован

    }
}
