namespace SimpleFormsAppWithMessageBoxes
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
            label1 = new Label();
            firstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            middleName = new TextBox();
            lastName = new TextBox();
            suffixName = new TextBox();
            submitBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(39, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // firstName
            // 
            firstName.Location = new Point(39, 111);
            firstName.Name = "firstName";
            firstName.Size = new Size(244, 23);
            firstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(39, 246);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(39, 340);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Suffix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(39, 161);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "Middle Name";
            // 
            // middleName
            // 
            middleName.Location = new Point(39, 194);
            middleName.Name = "middleName";
            middleName.Size = new Size(244, 23);
            middleName.TabIndex = 5;
            // 
            // lastName
            // 
            lastName.Location = new Point(39, 282);
            lastName.Name = "lastName";
            lastName.Size = new Size(244, 23);
            lastName.TabIndex = 6;
            // 
            // suffixName
            // 
            suffixName.Location = new Point(39, 377);
            suffixName.Name = "suffixName";
            suffixName.Size = new Size(243, 23);
            suffixName.TabIndex = 7;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = SystemColors.InactiveBorder;
            submitBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = SystemColors.ControlText;
            submitBtn.Location = new Point(39, 433);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(244, 23);
            submitBtn.TabIndex = 8;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(81, 21);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 9;
            label5.Text = "Simple Form Application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Acer_Wallpaper_02_3840x2400;
            ClientSize = new Size(336, 485);
            Controls.Add(label5);
            Controls.Add(submitBtn);
            Controls.Add(suffixName);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox middleName;
        private TextBox lastName;
        private TextBox suffixName;
        private Button submitBtn;
        private Label label5;
    }
}
