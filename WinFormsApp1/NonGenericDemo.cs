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

            object objQ = q.Dequeue();
            MessageBox.Show(objQ.ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "one");
            h.Add("1", "one String");
            h.Add(2.1, "Two");
            h.Add('A', "FirstCharacter");
            h.Add("LastCharacter", "Z");

            foreach (DictionaryEntry item in h)
            {
                listBox1.Items.Add(item.Key + " " + item.Value);
            }

            //h.Remove(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ArrayList al = new ArrayList(2);
            al.Add(12);
            al.Add(3.3333f);
            al.Add("hello");
            al.AddRange(arr);//adds at the end, after "hello"
            //---IEnumerator---- al.GetEnumerator() ---supports iteration over a collection(Arraylist)
            //IEnumerable exposes IEnumerator

           


            al.Insert(0, 10000);//particular value at index(position)


            al.InsertRange(1, arr);//insert range particular index(position)
            foreach (var item in al)
            {
                listBox1.Items.Add(item);
            }





        }

        private void NonGenericDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
