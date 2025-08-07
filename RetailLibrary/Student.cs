using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    public class Course
    {
        public string CrsName { get; set; }
        public List<Student> Students { get; set; }

    }

    public class Customer
    {
        public int Csutid { get; set; }
        public string Csutname { get; set; }

        public string City { get; set; }


    }

    public class Loans
    {



        public int LoanID { get; set; } 
        public string LoanType { get; set; }

        public double LoanAmt { get; set; }
        public List<Customer> CustomerList { get;set; }
    }




}
