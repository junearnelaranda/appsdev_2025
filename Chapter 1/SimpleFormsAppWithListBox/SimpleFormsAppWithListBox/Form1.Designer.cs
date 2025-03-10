namespace SimpleFormsAppWithListBox
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
            listBox = new ListBox();
            textBox = new TextBox();
            addBtn = new Button();
            rmvBtn = new Button();
            clrBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 23;
            listBox.Location = new Point(21, 124);
            listBox.Name = "listBox";
            listBox.Size = new Size(313, 326);
            listBox.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(366, 124);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(163, 46);
            textBox.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(366, 222);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(163, 40);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // rmvBtn
            // 
            rmvBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rmvBtn.Location = new Point(366, 319);
            rmvBtn.Name = "rmvBtn";
            rmvBtn.Size = new Size(163, 42);
            rmvBtn.TabIndex = 3;
            rmvBtn.Text = "Remove";
            rmvBtn.UseVisualStyleBackColor = true;
            rmvBtn.Click += rmvBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(366, 411);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(163, 37);
            clrBtn.TabIndex = 4;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(394, 23);
            label1.TabIndex = 5;
            label1.Text = " List of Programming Language Names ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(label1);
            Controls.Add(clrBtn);
            Controls.Add(rmvBtn);
            Controls.Add(addBtn);
            Controls.Add(textBox);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private TextBox textBox;
        private Button addBtn;
        private Button rmvBtn;
        private Button clrBtn;
        private Label label1;
    }
}
