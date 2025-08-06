namespace WinFormsApp1
{
    partial class CustomerOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtOrderID = new TextBox();
            btnProductCount = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 79);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter EmployeeID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(288, 120);
            button1.Name = "button1";
            button1.Size = new Size(175, 29);
            button1.TabIndex = 2;
            button1.Text = "Count the Orders";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 184);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter  Orderid:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(263, 181);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(125, 27);
            txtOrderID.TabIndex = 4;
            // 
            // btnProductCount
            // 
            btnProductCount.Location = new Point(263, 238);
            btnProductCount.Name = "btnProductCount";
            btnProductCount.Size = new Size(247, 29);
            btnProductCount.TabIndex = 5;
            btnProductCount.Text = "Count The Products In the Order";
            btnProductCount.UseVisualStyleBackColor = true;
            btnProductCount.Click += btnProductCount_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 325);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 6;
            label3.Text = "Enter Productid";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 318);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(263, 364);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Count";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CustomerOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(btnProductCount);
            Controls.Add(txtOrderID);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CustomerOrder";
            Text = "CustomerOrder";
            Load += CustomerOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox txtOrderID;
        private Button btnProductCount;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
    }
}