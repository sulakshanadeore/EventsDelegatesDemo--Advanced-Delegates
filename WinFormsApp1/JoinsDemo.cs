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
    public partial class JoinsDemo : Form
    {
        public JoinsDemo()
        {
            InitializeComponent();
        }

        List<Dept> deptlist = new List<Dept>()
        {
            new Dept {Deptno=10,Dname="HR" },
           new Dept {Deptno=20,Dname="Marketing" },
           new Dept {Deptno=30,Dname="Sales" },
          new Dept {Deptno=40,Dname="Advertising" }

        };


        List<Employee> emplist = new List<Employee>() {
        new Employee{ Empid=1,EmpName="Anita",Salary=10000,City="Pune",Deptno=10},
        new Employee{ Empid=2,EmpName="Sunita",Salary=10000,City="Pune",Deptno=20},
        new Employee{ Empid=3,EmpName="Vinita",Salary=10000,City="Pune",Deptno=30},
        new Employee{ Empid=4,EmpName="Gunita",Salary=10000,City="Pune",Deptno=10},
        new Employee{ Empid=5,EmpName="Pranita",Salary=10000,City="Pune",Deptno=20},
        new Employee{ Empid=6,EmpName="Ankita",Salary=10000,City="Pune",Deptno=20},
        new Employee{ Empid=7,EmpName="Antara",Salary=10000,City="Pune",Deptno=10},
        new Employee{ Empid=8,EmpName="Pari",Salary=10000,City="Pune",Deptno=50}
               };
        private void button1_Click(object sender, EventArgs e)
        {
            var result = from e1 in emplist
                         join d1 in deptlist
                        on e1.Deptno equals d1.Deptno
                         select new { e1.EmpName, Deptname = d1.Dname };
            foreach (var item in result)
            {
                listBox1.Items.Add(item.EmpName + " " + item.Deptname);
            }
            listBox1.Items.Add("---------------");
            var result1 = emplist.Join(deptlist,
                emp => emp.Deptno, dept => dept.Deptno,
                (emp, dept) => new
                {
                    emp.EmpName,
                    Deptname = dept.Dname
                });

            foreach (var item in result1)
            {
                listBox1.Items.Add(item.EmpName + " " + item.Deptname);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = from emp in emplist
                         join dept in deptlist
                       on emp.Deptno equals dept.Deptno into empDeptGroup
                         from dept in empDeptGroup.DefaultIfEmpty()
                         select new { emp.EmpName, 
                             Deptname = dept != null ? dept.Dname : "No Such Department found" };
        foreach (var item in result)
    	{
                listBox1.Items.Add(item.EmpName + "----" + item.Deptname);
	    }
            listBox1.Items.Add("---------------");

            var result1 = emplist.GroupJoin(deptlist,
                emp => emp.Deptno, dept => dept.Deptno,
                (emp, empdeptgroup) => new { emp, empdeptgroup })
                .SelectMany(x => x.empdeptgroup.DefaultIfEmpty(),
                (x, dept) => new 
                { x.emp.EmpName, 
                    Deptname = dept != null ? dept.Dname : "No Such Department found" });

            foreach (var item in result1)
            {
                listBox1.Items.Add(item.EmpName + "----" + item.Deptname);
            }



        }
    }
}
