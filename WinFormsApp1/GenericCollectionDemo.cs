using RetailLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GenericCollectionDemo : Form
    {
        public GenericCollectionDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Stack
            Stack<int> ints = new Stack<int>();
            ints.Push(1);
            ints.Push(22);
            ints.Push(244);
            ints.Push(122);

            foreach (var item in ints)
            {
                listBox1.Items.Add(item);   
            }
            listBox1.Items.Add("--------");
            Queue<String> sq = new Queue<string>();
            sq.Enqueue("HEllo");
            sq.Enqueue("Welcome");
             sq.Enqueue("Greetings");
            sq.Enqueue("Good morning");
           


            foreach (var item in sq)
            {
                listBox1.Items.Add(item);
            }
            listBox1.Items.Add("--------");

            Queue<Employee> empQ = new Queue<Employee>();
            Employee e1 = new Employee();
            e1.Empid = 3;
            e1.EmpName = "Shashi";
            e1.City = "Chennai";
            empQ.Enqueue(e1);

            //Object initializer
            Employee e2 = new Employee {EmpName="Anil",Empid=1,City="Pune" };
            empQ.Enqueue(e2);

            empQ.Enqueue(new Employee {Empid=2,EmpName="Sunil",City="Mumbai" });

            List<Employee> list = empQ.ToList();
            list.Sort();
            Queue<Employee> sortedQueue = new Queue<Employee>(list);
            

            foreach (var item in sortedQueue)
            {
                listBox1.Items.Add(item.Empid + " " + item.EmpName + " " + item.City);

            }























            //Array-- Dynamic size
            //int[]---Collections Dynamic Size and Generic Collections----- Type d



        }

        private void GenericCollectionDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
