namespace SimpleFormsAppWithCheckedListBox
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
            checkedListBox = new CheckedListBox();
            listBox = new ListBox();
            addBtn = new Button();
            dltBtn = new Button();
            clrBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = SystemColors.GradientActiveCaption;
            checkedListBox.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(41, 98);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(293, 290);
            checkedListBox.TabIndex = 0;
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.GradientActiveCaption;
            listBox.BorderStyle = BorderStyle.None;
            listBox.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(427, 101);
            listBox.Name = "listBox";
            listBox.Size = new Size(304, 280);
            listBox.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.GradientActiveCaption;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(41, 416);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(107, 39);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add movie";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dltBtn
            // 
            dltBtn.BackColor = SystemColors.GradientActiveCaption;
            dltBtn.FlatStyle = FlatStyle.Popup;
            dltBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dltBtn.Location = new Point(427, 416);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(110, 39);
            dltBtn.TabIndex = 3;
            dltBtn.Text = "Delete";
            dltBtn.UseVisualStyleBackColor = false;
            dltBtn.Click += dltBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = SystemColors.GradientActiveCaption;
            clrBtn.FlatStyle = FlatStyle.Popup;
            clrBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(624, 416);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(107, 39);
            clrBtn.TabIndex = 4;
            clrBtn.Text = "Clear All";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Baskerville Old Face", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(140, 25);
            label1.Name = "label1";
            label1.Size = new Size(466, 39);
            label1.TabIndex = 5;
            label1.Text = "My Favorite Movie Picker App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(41, 76);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 6;
            label2.Text = "Movies / Series List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(427, 78);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 7;
            label3.Text = "My Movies List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(777, 487);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clrBtn);
            Controls.Add(dltBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox);
            Controls.Add(checkedListBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Button addBtn;
        private Button dltBtn;
        private Button clrBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
