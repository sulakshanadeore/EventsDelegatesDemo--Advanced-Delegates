using RetailLibrary;
using System.IO.Pipes;

namespace WinFormsApp1
{
    
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
            Employee emp = new Employee();
            int bonusSalary=emp.CalculateSalary(Convert.ToInt32(txtinput.Text));
            MessageBox.Show($" A salary of {txtinput.Text} , would get a bonus of Rs. {bonusSalary.ToString()}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
