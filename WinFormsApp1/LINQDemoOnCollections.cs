using RetailLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LINQDemoOnCollections : Form
    {
        public LINQDemoOnCollections()
        {
            InitializeComponent();
        }
        List<Employee> employees = new List<Employee>();
        private void LINQDemoOnCollections_Load(object sender, EventArgs e)
        {
            //SingleORDefault
            //FirstOrDefault
            //Skip and Take
            //ORder by
            //where
            //group by



            employees.Add(new Employee { Empid = 10, EmpName = "Sara", City = "Pune", Salary = 20000, Deptno = 10 });
            employees.Add(new Employee { Empid = 11, EmpName = "Piya", City = "Chennai", Salary = 30000, Deptno = 20 });
            employees.Add(new Employee { Empid = 12, EmpName = "Kia", City = "Bangalore", Salary = 5000, Deptno = 30 });
            employees.Add(new Employee { Empid = 13, EmpName = "Hari", City = "Pune", Deptno = 10 });
            employees.Add(new Employee { Empid = 14, EmpName = "Simran", City = "Pune", Deptno = 10 });
            employees.Add(new Employee { Empid = 15, EmpName = "Raj", City = "Pune", Deptno = 20 });


            //Key --- group----group/ed Key


            var empdata = employees.GroupBy(t => t.Deptno).
                Select(y => new
                {
                    DepartmentNo = y.Key,
                    EmployeeDetails = y.Select(y1 => new { y1.EmpName, y1.Salary }),
                    Count = y.Count()
                });

            string data = "";
            foreach (var item in empdata)
            {
                listBox1.Items.Add($" Deptno=  {item.DepartmentNo} and  {item.Count} employees");

                foreach (var item2 in item.EmployeeDetails)
                {

                    listBox1.Items.Add(item2.EmpName + " " + item2.Salary);


                }
            }





            //ORder by --ascending
            //var emplistBySal=employees.OrderBy(s => s.Salary).ToList();
            //   var emplistBySal = employees.OrderByDescending(s => s.Salary).ToList();

            //foreach (var item in emplistBySal)
            //{
            //   listBox1.Items.Add( item.Empid +  " "  +  item.Salary);
            //}




            //var data = employees.Where(e1 => e1.Empid == 10).SingleOrDefault();
            //textBox1.Text += string.Concat(data.Empid, data.EmpName, data.City);

            //foreach (var item in data)
            //{
            //    textBox1.Text += string.Concat(item.Empid, item.EmpName, item.City);
            //}






        }

        private void button1_Click(object sender, EventArgs e)
        {
            //personobj anonymous object --- personName etc are implicitly defined types with datatypes string,int,int
            // var personObj = new {personName="Praj",PersonAge=19,Persondid=12 };

            StudentData s = new StudentData();
            List<string> all=s.AllData;
            foreach (var item in all)
            {
                MessageBox.Show(item);
            }


            List<string> passedStudData=s.Passed;
            foreach (var item in passedStudData)
            {
                MessageBox.Show(item + " Passed");
            }

            List<string> failedStudData = s.Failed;
            foreach (var item in failedStudData)
            {
                MessageBox.Show(item + " Failed");
            }





        }
    }
}

