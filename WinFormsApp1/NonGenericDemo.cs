using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NonGenericDemo : Form
    {
        public NonGenericDemo()
        {
            InitializeComponent();


        }
        Stack s = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {

            s.Push(100);
            s.Push(200);
            s.Push("Hello");
            s.Push('A');
            s.Push(72332.3234d);
            s.Push(1111.000m);
            DateTime dt = new DateTime(2025, 08, 05);
            s.Push(dt);

            foreach (var element in s)
            {
                listBox1.Items.Add(element);
            }


            bool ans = s.Contains(100);
            MessageBox.Show(ans.ToString());
            //   s.Clear();//Clears the stack/empty
            object valueOnPeek = s.Peek();
            MessageBox.Show(valueOnPeek.ToString());
            object[] objarr = new object[s.Count];
            s.CopyTo(objarr, 0);

            foreach (var item in objarr)
            {
                MessageBox.Show(item.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            object o = s.Pop();
            MessageBox.Show(o.ToString());
        }

        Queue q = new Queue();
        private void button3_Click(object sender, EventArgs e)
        {
            q.Enqueue(10);
            q.Enqueue(true);
            q.Enqueue('A');
            q.Enqueue("Hello");


            foreach (var item in q)
            {
                listBox1.Items.Add(item);


            }

            object objQ=q.Dequeue();
            MessageBox.Show(objQ.ToString());


        }
    }
}
