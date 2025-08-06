namespace RetailLibrary
{
    //Step 1
    public delegate int SalaryCalculation(int bs);
    public class Employee:IComparable<Employee>
    {

        public int Empid { get; set; }
        public string EmpName { get; set; }

        public string City { get; set; }


        public int CalculateSalary(int bs)
        {
            //Step 2 =assigning anonymous method to a reference varibale of delegate,
            //Anonymous method has the logic
            SalaryCalculation del = delegate (int sal)
            {
                //method----- anonymous method( ie method without name)
                int bonus = 0;
                if (sal > 0 && sal < 20000)
                {
                    bonus = Convert.ToInt32(sal * .10);

                }
                else if (sal > 20000 && sal < 50000)
                {
                    bonus = Convert.ToInt32(sal * .05);
                }
                else
                {
                    bonus = 0;
                }
                return bonus;
            };


            //brief way of working with delegate---Using Anonymous methods
            //Step 3--- Invoke the delegate using the reference variable and pass the required parameters.
            int bonusSalary = del(bs);
            return bonusSalary;

        }

        public int CompareTo(Employee? other)
        {
            //throw new NotImplementedException();
            if (other == null) return 1;
            return this.Empid.CompareTo(other.Empid);
            
        }
    }
}
