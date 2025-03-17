namespace SimpleFormsAppWithComboBox
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
            panel1 = new Panel();
            checkedListBox = new CheckedListBox();
            panel2 = new Panel();
            listBox = new ListBox();
            comboBox = new ComboBox();
            sBtn = new Button();
            addBtn = new Button();
            rmvBtn = new Button();
            clrBtn = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 173, 96);
            panel1.Controls.Add(checkedListBox);
            panel1.Location = new Point(341, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 383);
            panel1.TabIndex = 0;
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.Sienna;
            checkedListBox.Font = new Font("Algerian", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox.ForeColor = SystemColors.Info;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(31, 25);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(401, 334);
            checkedListBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 173, 96);
            panel2.Controls.Add(listBox);
            panel2.Location = new Point(852, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 383);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // listBox
            // 
            listBox.BackColor = Color.Sienna;
            listBox.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox.ForeColor = SystemColors.Info;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 22;
            listBox.Location = new Point(32, 30);
            listBox.Name = "listBox";
            listBox.Size = new Size(402, 312);
            listBox.TabIndex = 0;
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.FromArgb(255, 173, 96);
            comboBox.FlatStyle = FlatStyle.Popup;
            comboBox.Font = new Font("Algerian", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(37, 120);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(231, 44);
            comboBox.TabIndex = 0;
            // 
            // sBtn
            // 
            sBtn.BackColor = Color.FromArgb(255, 173, 96);
            sBtn.Cursor = Cursors.Hand;
            sBtn.FlatStyle = FlatStyle.Popup;
            sBtn.Font = new Font("Algerian", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sBtn.Location = new Point(37, 230);
            sBtn.Name = "sBtn";
            sBtn.Size = new Size(231, 44);
            sBtn.TabIndex = 2;
            sBtn.Text = "Select";
            sBtn.UseVisualStyleBackColor = false;
            sBtn.Click += sBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(255, 173, 96);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.Black;
            addBtn.Location = new Point(457, 537);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(217, 44);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // rmvBtn
            // 
            rmvBtn.BackColor = Color.FromArgb(255, 173, 96);
            rmvBtn.Cursor = Cursors.Hand;
            rmvBtn.FlatStyle = FlatStyle.Popup;
            rmvBtn.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rmvBtn.Location = new Point(849, 546);
            rmvBtn.Name = "rmvBtn";
            rmvBtn.Size = new Size(218, 44);
            rmvBtn.TabIndex = 4;
            rmvBtn.Text = "Remove";
            rmvBtn.UseVisualStyleBackColor = false;
            rmvBtn.Click += rmvBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.FromArgb(255, 173, 96);
            clrBtn.Cursor = Cursors.Hand;
            clrBtn.FlatStyle = FlatStyle.Popup;
            clrBtn.Font = new Font("Algerian", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(1113, 546);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(204, 44);
            clrBtn.TabIndex = 5;
            clrBtn.Text = "Clear All";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 173, 96);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(341, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(976, 84);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.food;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(17, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(942, 65);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Sienna;
            label1.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(571, 45);
            label1.TabIndex = 0;
            label1.Text = "Favorite Food Picker App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(81, 101);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 7;
            label2.Text = "Cuisine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Algerian", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(479, 106);
            label3.Name = "label3";
            label3.Size = new Size(152, 31);
            label3.TabIndex = 8;
            label3.Text = "Food List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Algerian", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(910, 106);
            label4.Name = "label4";
            label4.Size = new Size(346, 31);
            label4.TabIndex = 9;
            label4.Text = "My Favorite Food List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.food;
            ClientSize = new Size(1350, 633);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(clrBtn);
            Controls.Add(rmvBtn);
            Controls.Add(addBtn);
            Controls.Add(sBtn);
            Controls.Add(comboBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Food App";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox;
        private Button sBtn;
        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Button addBtn;
        private Button rmvBtn;
        private Button clrBtn;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
