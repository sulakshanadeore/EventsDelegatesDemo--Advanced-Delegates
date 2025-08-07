using RetailLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class QuerySyntaxDemos : Form
    {
        public QuerySyntaxDemos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[] { 1, 23, 42, 563, 2566, 255, 345, 78, 90, 133, 334 };
            var evenNos = from n in numbers
                          orderby n descending
                          where n % 2 == 0
                          select n;

            numbers[0] = 100;
            numbers[1] = 120;

            foreach (var item in evenNos)
            {
                listBox1.Items.Add(item);
            }

        }
        List<Employee> employees = new List<Employee>();
        private void button2_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee { Empid = 10, EmpName = "Sara", City = "Pune", Salary = 20000, Deptno = 10 });
            employees.Add(new Employee { Empid = 11, EmpName = "Piya", City = "Chennai", Salary = 30000, Deptno = 20 });
            employees.Add(new Employee { Empid = 12, EmpName = "Kia", City = "Bangalore", Salary = 5000, Deptno = 30 });
            employees.Add(new Employee { Empid = 13, EmpName = "Hari", City = "Pune", Deptno = 10 });
            employees.Add(new Employee { Empid = 14, EmpName = "Simran", City = "Pune", Deptno = 10 });
            employees.Add(new Employee { Empid = 15, EmpName = "Raj", City = "Pune", Deptno = 20 });


            //var grouped = from e1 in employees
            //              group e1 by e1.Deptno into g
            //              select new 
            //              {
            //                  Department=g.Key, 
            //                  EmpCount=g.Count(), 
            //                  emplist=from edata in g
            //                             select new {EmployeeID= edata.Empid, EmployeeName=edata.EmpName }
            //              };

            // select g;


            var grouped = employees.GroupBy(e1 => e1.Deptno).
                Select(e1 => new
                {
                    Department = e1.Key,
                    EmpCount = e1.Count(),
                    emplist = e1.Select(y1 => new
                    {
                        EmployeeID = y1.Empid,
                        EmployeeName = y1.EmpName
                   ,
                        EmpSalary = y1.Salary
                    })
                });

            employees.Add(new Employee { Empid = 16, EmpName = "Vishal", City = "Pune", Deptno = 10 });
            employees.Add(new Employee { Empid = 17, EmpName = "Rima", City = "Pune", Deptno = 20 });


            foreach (var item in grouped)
            {
                listBox1.Items.Add("Deptno=" + item.Department + " and Employees= " + item.EmpCount);
                //    listBox1.Items.Add("Deptno=" + item.Key + " and Employees= " + item.Count());
                foreach (var item1 in item.emplist)
                {
                    // listBox1.Items.Add(item1.Empid + " " + item1.EmpName + item1.Salary);
                    listBox1.Items.Add(item1.EmployeeID + " " + item1.EmployeeName + " " + item1.EmpSalary);
                }



            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Student> C_Crs_Students = new List<Student>() 
            { 
              new Student{Name="Archana",Marks=50 },
                new Student{Name="Simran",Marks=70 },
                new Student{Name="Gita",Marks=80 }
            };
            List<Student> Cpp_Crs_Students = new List<Student>()
            {
                new Student{Name="Mitali",Marks=45 },
                new Student{Name="Gauri",Marks=50 },
                new Student{Name="Hari",Marks=60 }
            
            };

            List<Student> CSharp_Students = new List<Student>() {
                new Student{Name="John",Marks=67 },
                new Student{Name="Jim",Marks=87  },
                new Student{Name="Tim",Marks=77  } 
            };

            var CourseData = new List<Course> {

                new Course{CrsName="C Programming", Students=C_Crs_Students },
                new Course{CrsName="C++ Programming", Students=Cpp_Crs_Students },
                new Course{CrsName="CSharp",Students=CSharp_Students }
                                                 };


            

            var allNamesData=CourseData.SelectMany(x => x.Students);

            foreach (var item in allNamesData)
            {
                listBox1.Items.Add(item.Name);
            }
            listBox1.Items.Add("--------------");

            var DataFiltered = CourseData.SelectMany(c => c.Students,
                (c1, s) => new { studentName = s.Name, AchievedMarks=(s.Marks*3)/100, CrName = c1.CrsName });

            foreach (var item in DataFiltered)
            {
                listBox1.Items.Add(item.CrName + " " + item.studentName + item.AchievedMarks);
            }

            var skipWhile = allNamesData.SkipWhile(a => a.Name.StartsWith('S'));

            //foreach (var item in skipWhile)
            //{
            //    listBox2.Items.Add(item.Name);
            //}

            int[] numberData = new int[] { 11, 121, 3, 7,342, 22221, 34, 17, 7654 };
            var numbers = numberData.SkipWhile(n => n < 50).Take(1);
            foreach (var item in numbers)
            {
                listBox2.Items.Add(item);
            }


        }
    }
}
