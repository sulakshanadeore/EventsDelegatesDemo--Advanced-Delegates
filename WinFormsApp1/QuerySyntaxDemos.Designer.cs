namespace WinFormsApp1
{
    partial class QuerySyntaxDemos
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
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 38);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 0;
            button1.Text = "Working witht Array";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(42, 87);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(421, 224);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(287, 38);
            button2.Name = "button2";
            button2.Size = new Size(176, 29);
            button2.TabIndex = 2;
            button2.Text = "Working With List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 341);
            button3.Name = "button3";
            button3.Size = new Size(159, 29);
            button3.TabIndex = 3;
            button3.Text = "Select Many";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(510, 106);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 244);
            listBox2.TabIndex = 4;
            // 
            // QuerySyntaxDemos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "QuerySyntaxDemos";
            Text = "QuerySyntaxDemos";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
    }
}