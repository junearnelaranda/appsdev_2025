namespace EyeWear
{
    partial class User
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            textBox1 = new TextBox();
            panel4 = new Panel();
            Uemail = new TextBox();
            panel3 = new Panel();
            Ulname = new TextBox();
            panel2 = new Panel();
            Ufname = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(279, 145);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 757);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(323, 555);
            label5.Name = "label5";
            label5.Size = new Size(238, 27);
            label5.TabIndex = 15;
            label5.Text = "Enter Your NickName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 422);
            label4.Name = "label4";
            label4.Size = new Size(282, 27);
            label4.TabIndex = 14;
            label4.Text = "Enter Your Email Address";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(362, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 126);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 295);
            label3.Name = "label3";
            label3.Size = new Size(239, 27);
            label3.TabIndex = 13;
            label3.Text = "Enter Your Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(323, 169);
            label2.Name = "label2";
            label2.Size = new Size(245, 27);
            label2.TabIndex = 12;
            label2.Text = "Enter Your First Name";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(272, 568);
            panel5.Name = "panel5";
            panel5.Size = new Size(344, 79);
            panel5.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(29, 19);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 44);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(Uemail);
            panel4.Location = new Point(272, 436);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 79);
            panel4.TabIndex = 10;
            // 
            // Uemail
            // 
            Uemail.BackColor = Color.White;
            Uemail.BorderStyle = BorderStyle.None;
            Uemail.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Uemail.Location = new Point(29, 20);
            Uemail.Margin = new Padding(3, 4, 3, 4);
            Uemail.Multiline = true;
            Uemail.Name = "Uemail";
            Uemail.Size = new Size(303, 44);
            Uemail.TabIndex = 6;
            Uemail.TextChanged += email_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Ulname);
            panel3.Location = new Point(272, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 79);
            panel3.TabIndex = 9;
            // 
            // Ulname
            // 
            Ulname.BackColor = Color.White;
            Ulname.BorderStyle = BorderStyle.None;
            Ulname.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ulname.Location = new Point(29, 19);
            Ulname.Margin = new Padding(3, 4, 3, 4);
            Ulname.Multiline = true;
            Ulname.Name = "Ulname";
            Ulname.Size = new Size(303, 44);
            Ulname.TabIndex = 6;
            Ulname.TextChanged += lname_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Ufname);
            panel2.Location = new Point(272, 183);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 79);
            panel2.TabIndex = 8;
            // 
            // Ufname
            // 
            Ufname.BackColor = Color.White;
            Ufname.BorderStyle = BorderStyle.None;
            Ufname.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ufname.Location = new Point(29, 20);
            Ufname.Margin = new Padding(3, 4, 3, 4);
            Ufname.Multiline = true;
            Ufname.Name = "Ufname";
            Ufname.Size = new Size(303, 44);
            Ufname.TabIndex = 6;
            Ufname.TextChanged += fname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 57);
            label1.Name = "label1";
            label1.Size = new Size(968, 52);
            label1.TabIndex = 3;
            label1.Text = "Find the Perfect Frames for Your Unique Face Shape";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1445, 1015);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += User_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private TextBox Ufname;
        private Panel panel3;
        private TextBox Ulname;
        private Panel panel4;
        private TextBox Uemail;
        private Panel panel5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
