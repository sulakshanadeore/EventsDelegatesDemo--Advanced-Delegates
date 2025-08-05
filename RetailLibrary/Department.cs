using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RetailLibrary
{
    public class Department
    {
        public int Deptno { private get; set; }
        public string DeptName { private get; set; }

        public string   City { private get; set; }


        public string   AllDataDept { get; private set; }

        public string DisplayData()
        {
            //First 3 are input(int,string,stringg) and last parameter is output(String)

            Func<int, String, String, String> deptData = (dno, dname, loc) => {

                string data=string.Concat(dno, dname, loc);
                    return data;
            };

            string Deptdata=deptData(Deptno, DeptName, City);
            return Deptdata;



        }
      public void ActionForDisplayData()
        { 
        
            Action<int,string,string> display= (dno, dname, loc) => {

                string data = string.Concat(dno, dname, loc);
                AllDataDept = data;                
            };

            display(Deptno, DeptName, City);

        }


        public bool IsValidDeptno(int deptno)
        {
            Predicate<int> isvalid = (deptno) => {
                bool status = false;
                if (deptno > 0) {
                    status = true;
                }
                return status;

            };

            return isvalid(Deptno);


        
        }


    }
}
