namespace WinFormsApp1
{
    partial class GenericCollectionDemo
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(64, 107);
            button1.Name = "button1";
            button1.Size = new Size(164, 75);
            button1.TabIndex = 0;
            button1.Text = "Stack,Queue,List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(286, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 304);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(55, 226);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Dictionary";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GenericCollectionDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "GenericCollectionDemo";
            Text = "GenericCollectionDemo";
            Load += GenericCollectionDemo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
    }
}