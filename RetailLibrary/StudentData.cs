using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailLibrary
{
   public class StudentData
    {

        public  List<string> AllData = new List<string>();
        public List<String> Passed=new List<string>();
        public List<string> Failed = new List<string>();

        public StudentData()
        {
            var students = new[] 
            {
                new  {StudentName="Arpit", Marks=39 },
                new  {StudentName="Smita", Marks=59 },
                new  {StudentName="Dinesh", Marks=70 },
                new  {StudentName="Tina", Marks=20 },
            };

            var result = students.Select(s =>new {s.StudentName,Status=s.Marks>40 ? "Pass":"Fail" });
            var passedStudents = result.Where(r => r.Status == "Pass").Select(p => p.StudentName);
            var failedStudents = result.Where(r => r.Status == "Fail").Select(p => p.StudentName);
          

            foreach (var item in result)
            {
                AllData.Add(item.StudentName);

            }

            foreach (var item in passedStudents)
            {
                Passed.Add(item);
            }

            foreach (var item in failedStudents)
            {
                Failed.Add(item);
            }


        }


    }
}
