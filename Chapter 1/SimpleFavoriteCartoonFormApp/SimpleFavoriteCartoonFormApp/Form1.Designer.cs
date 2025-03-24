namespace SimpleFavoriteCartoonFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            clrBtn = new Button();
            label1 = new Label();
            vwBtn = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 97);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg4;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(494, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 525);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(131, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 420);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // clrBtn
            // 
            clrBtn.FlatStyle = FlatStyle.Popup;
            clrBtn.Location = new Point(216, 314);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(153, 54);
            clrBtn.TabIndex = 1;
            clrBtn.Text = "-";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(315, 290);
            label1.Name = "label1";
            label1.Size = new Size(92, 37);
            label1.TabIndex = 3;
            label1.Text = "Clear";
            // 
            // vwBtn
            // 
            vwBtn.FlatStyle = FlatStyle.Popup;
            vwBtn.Location = new Point(216, 210);
            vwBtn.Name = "vwBtn";
            vwBtn.Size = new Size(153, 54);
            vwBtn.TabIndex = 4;
            vwBtn.Text = "-";
            vwBtn.UseVisualStyleBackColor = true;
            vwBtn.Click += vwBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(313, 181);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 5;
            label2.Text = "View";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(218, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 41);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(317, 64);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 7;
            label3.Text = "Select an Item:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Constantia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(501, 21);
            label5.Name = "label5";
            label5.Size = new Size(681, 41);
            label5.TabIndex = 9;
            label5.Text = "Simple Favorite Cartoon Character Picker";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1229, 609);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(vwBtn);
            Controls.Add(label1);
            Controls.Add(clrBtn);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button clrBtn;
        private Label label1;
        private Button vwBtn;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
