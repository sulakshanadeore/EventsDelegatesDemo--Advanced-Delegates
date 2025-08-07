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
    public partial class SelectManyExample : Form
    {
        public SelectManyExample()
        {
            InitializeComponent();
        }
        
        private void SelectManyExample_Load(object sender, EventArgs e)
        {
            List<Customer> CarLoanlist = new List<Customer>()
            {
                new Customer {Csutid=101,Csutname="John",City="Chennai" },
                new Customer { Csutid=102,Csutname="Lee", City="Bangalore"}
            };

            List<Customer> HomeLoanlist = new List<Customer>()
            {
                new Customer {Csutid=103,Csutname="Jim",City="Chennai" },
                new Customer { Csutid=104,Csutname="Tim", City="Bangalore"},
                  new Customer {Csutid=101,Csutname="John",City="Chennai" }
            };


            List<Customer> BikeLoanlist = new List<Customer>()
            {
                new Customer {Csutid=105,Csutname="Sia",City="Chennai" },
                new Customer { Csutid=106,Csutname="Ria", City="Bangalore"},
                  new Customer {Csutid=107,Csutname="Kia",City="Chennai" }
            };




             var LoansData = new List<Loans>
            {
                new Loans{
            LoanID=1,
                LoanType="car",
                LoanAmt=20000,
            CustomerList=CarLoanlist
                },

                new Loans{
                    LoanID=2,
                LoanType="Home",
                LoanAmt=20000,
                CustomerList=HomeLoanlist

                },
                new Loans {
                LoanID=3,
                LoanType="Bike",
                LoanAmt=20000,
                CustomerList=BikeLoanlist

                }
            };

            var customerListForLoans = LoansData.SelectMany(x => x.CustomerList);
            foreach (var item in customerListForLoans)
            {
                listBox1.Items.Add(item.Csutid + "  " + item.Csutname);
            }

            var allDataForLoans = LoansData.
                SelectMany(x => x.CustomerList,
                (l, c) => new { LoanTakenFor = l.LoanType, CustomerName = c.Csutname });

            foreach (var item in allDataForLoans)
            {
                listBox2.Items.Add(item.LoanTakenFor + " by the csutomer whose name =" + item.CustomerName);
            }


            var LoanAmts = LoansData.Select(x => new { LoanID=x.LoanID,amt = x.LoanAmt });


            foreach (var item in LoanAmts)
            {
                comboBox1.Items.Add(item.LoanID);
                //comboBox1.DisplayMember=item.amt.ToString();
                //comboBox1.Items.Add(item.amt.ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Customer> CarLoanlist = new List<Customer>()
            {
                new Customer {Csutid=101,Csutname="John",City="Chennai" },
                new Customer { Csutid=102,Csutname="Lee", City="Bangalore"}
            };

            List<Customer> HomeLoanlist = new List<Customer>()
            {
                new Customer {Csutid=103,Csutname="Jim",City="Chennai" },
                new Customer { Csutid=104,Csutname="Tim", City="Bangalore"},
                  new Customer {Csutid=101,Csutname="John",City="Chennai" }
            };


            List<Customer> BikeLoanlist = new List<Customer>()
            {
                new Customer {Csutid=105,Csutname="Sia",City="Chennai" },
                new Customer { Csutid=106,Csutname="Ria", City="Bangalore"},
                  new Customer {Csutid=107,Csutname="Kia",City="Chennai" }
            };




            var LoansData = new List<Loans>
            {
                new Loans{
            LoanID=1,
                LoanType="car",
                LoanAmt=20000,
            CustomerList=CarLoanlist
                },

                new Loans{
                    LoanID=2,
                LoanType="Home",
                LoanAmt=20000,
                CustomerList=HomeLoanlist

                },
                new Loans {
                LoanID=3,
                LoanType="Bike",
                LoanAmt=20000,
                CustomerList=BikeLoanlist

                }
            };

            int selectedValue = Convert.ToInt32(comboBox1.SelectedItem);
            //int i=comboBox1.SelectedIndex;


            var loanInfo = LoansData.Where(y => y.LoanID == selectedValue).SingleOrDefault();
            MessageBox.Show(loanInfo.LoanType);


        }
    }
}
