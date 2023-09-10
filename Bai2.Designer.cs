namespace Lab04
{
    partial class Bai2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            postbtn = new Button();
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(606, 38);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(606, 38);
            textBox2.TabIndex = 1;
            // 
            // postbtn
            // 
            postbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            postbtn.Location = new Point(651, 12);
            postbtn.Name = "postbtn";
            postbtn.Size = new Size(122, 38);
            postbtn.TabIndex = 3;
            postbtn.Text = "POST";
            postbtn.UseVisualStyleBackColor = true;
            postbtn.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 137);
            listView1.Name = "listView1";
            listView1.Size = new Size(761, 301);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(651, 72);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
            button1.TabIndex = 5;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(postbtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Bai2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button postbtn;
        private ListView listView1;
        private Button button1;
    }
}