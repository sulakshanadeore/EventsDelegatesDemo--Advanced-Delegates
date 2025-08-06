using RetailLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CustomerOrder : Form
    {
        public CustomerOrder()
        {
            InitializeComponent();
        }

        List<OrderDetails> orderList = new List<OrderDetails>();
        private void CustomerOrder_Load(object sender, EventArgs e)
        {


            orderList.Add(new OrderDetails { OrderID = 1, ProductID = 10, Qty = 100, Price = 5, EmpId = 11 });
            orderList.Add(new OrderDetails { OrderID = 1, ProductID = 11, Qty = 50, Price = 15, EmpId = 11 });
            orderList.Add(new OrderDetails { OrderID = 1, ProductID = 12, Qty = 50, Price = 15, EmpId = 11 });
            orderList.Add(new OrderDetails { OrderID = 1, ProductID = 13, Qty = 50, Price = 15, EmpId = 11 });
            orderList.Add(new OrderDetails { OrderID = 1, ProductID = 14, Qty = 50, Price = 15, EmpId = 11 });


            orderList.Add(new OrderDetails { OrderID = 2, ProductID = 5, Qty = 100, Price = 5, EmpId = 12 });
            orderList.Add(new OrderDetails { OrderID = 2, ProductID = 7, Qty = 50, Price = 15, EmpId = 12 });
            orderList.Add(new OrderDetails { OrderID = 2, ProductID = 10, Qty = 50, Price = 15, EmpId = 12 });


            orderList.Add(new OrderDetails { OrderID = 3, ProductID = 10, Qty = 100, Price = 5, EmpId = 11 });
            orderList.Add(new OrderDetails { OrderID = 3, ProductID = 11, Qty = 50, Price = 15, EmpId = 11 });
            orderList.Add(new OrderDetails { OrderID = 3, ProductID = 5, Qty = 100, Price = 5, EmpId = 11 });
            orderList.Add(new OrderDetails { OrderID = 3, ProductID = 7, Qty = 50, Price = 15, EmpId = 11 });



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(textBox1.Text);

            var orderCount = orderList.Where(emp => emp.EmpId == empid).Select(p => new { p.OrderID }).Distinct().Count();
            MessageBox.Show(orderCount.ToString());

        }

        private void btnProductCount_Click(object sender, EventArgs e)
        {
            int ordid = Convert.ToInt32(txtOrderID.Text);
            var ProdCount = orderList.Where(o => o.OrderID == ordid).Select(p => p.ProductID).Count();
            MessageBox.Show(ProdCount + " Number of Products");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int prodid=Convert.ToInt32(textBox2.Text);
            var ProdCount = orderList.Where(o => o.ProductID == prodid).Select(p => p.Qty).Sum();
            MessageBox.Show(ProdCount + " Number of Products");

            //Select sum(Qty) from orderdetails
            //                where productid=10
        }
    }
}
