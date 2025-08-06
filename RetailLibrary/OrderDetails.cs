using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailLibrary
{
    public class OrderDetails
    {

        public int OrderID { get; set; }
        public int EmpId { get; set; }
        public int ProductID { get; set; }


        public int Qty { get; set; }
        public int Price { get; set; }
    }
}
