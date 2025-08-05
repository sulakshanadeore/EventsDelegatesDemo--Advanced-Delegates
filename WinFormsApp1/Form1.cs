using System.IO.Pipes;

namespace WinFormsApp1
{
    //Step 1
    public delegate int SalaryCalculation(int bs);
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //method- 2 parameters object sender,EventArgs e
        //Name of the delegate is EventHandler
        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Button click event invoked");
            //brief way of working with delegate---Using Anonymous methods
            //Step 2 =assigning anonymous method to a reference varibale of delegate,
            //Anonymous method has the logic
            SalaryCalculation del = delegate (int sal)
            {
                //method----- anonymous method( ie method without name)
                int bonus = 0;
                if (sal > 0 && sal < 20000)
                {
                    bonus =Convert.ToInt32(sal * .10);

                }
                else if (sal > 20000 && sal < 50000)
                {
                    bonus =Convert.ToInt32(sal * .05);
                }
                else
                {
                    bonus = 0;
                }
                return bonus;
            };

            //Step 3--- Invoke the delegate using the reference variable and pass the required parameters.
            int bonusSalary=del(Convert.ToInt32(txtinput.Text));
            MessageBox.Show($" A salary of {txtinput.Text} , would get a bonus of Rs. {bonusSalary.ToString()}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
