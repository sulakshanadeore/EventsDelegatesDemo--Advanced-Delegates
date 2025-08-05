namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtinput = new TextBox();
            btnSendDisplay = new Button();
            txtDeptno = new TextBox();
            txtDeptname = new TextBox();
            txtcity = new TextBox();
            txtoutput = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 136);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtinput
            // 
            txtinput.Location = new Point(82, 56);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(125, 27);
            txtinput.TabIndex = 1;
            // 
            // btnSendDisplay
            // 
            btnSendDisplay.Location = new Point(443, 283);
            btnSendDisplay.Name = "btnSendDisplay";
            btnSendDisplay.Size = new Size(200, 29);
            btnSendDisplay.TabIndex = 2;
            btnSendDisplay.Text = "Send And Display";
            btnSendDisplay.UseVisualStyleBackColor = true;
            btnSendDisplay.Click += btnSendDisplay_Click;
            // 
            // txtDeptno
            // 
            txtDeptno.Location = new Point(479, 26);
            txtDeptno.Name = "txtDeptno";
            txtDeptno.Size = new Size(125, 27);
            txtDeptno.TabIndex = 3;
            // 
            // txtDeptname
            // 
            txtDeptname.Location = new Point(479, 78);
            txtDeptname.Name = "txtDeptname";
            txtDeptname.Size = new Size(125, 27);
            txtDeptname.TabIndex = 4;
            // 
            // txtcity
            // 
            txtcity.Location = new Point(479, 138);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(125, 27);
            txtcity.TabIndex = 5;
            txtcity.TextChanged += textBox3_TextChanged;
            // 
            // txtoutput
            // 
            txtoutput.Location = new Point(479, 198);
            txtoutput.Name = "txtoutput";
            txtoutput.Size = new Size(125, 27);
            txtoutput.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtoutput);
            Controls.Add(txtcity);
            Controls.Add(txtDeptname);
            Controls.Add(txtDeptno);
            Controls.Add(btnSendDisplay);
            Controls.Add(txtinput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtinput;
        private Button btnSendDisplay;
        private TextBox txtDeptno;
        private TextBox txtDeptname;
        private TextBox txtcity;
        private TextBox txtoutput;
    }
}
