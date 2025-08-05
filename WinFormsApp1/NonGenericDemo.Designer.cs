namespace WinFormsApp1
{
    partial class NonGenericDemo
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(122, 104);
            button1.Name = "button1";
            button1.Size = new Size(186, 29);
            button1.TabIndex = 0;
            button1.Text = "Stack Working";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(403, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(135, 244);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(122, 139);
            button2.Name = "button2";
            button2.Size = new Size(211, 29);
            button2.TabIndex = 2;
            button2.Text = "remove From Stack(POP)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(582, 86);
            button3.Name = "button3";
            button3.Size = new Size(155, 29);
            button3.TabIndex = 3;
            button3.Text = "Queue Working";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // NonGenericDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "NonGenericDemo";
            Text = "NonGenericDemo";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}