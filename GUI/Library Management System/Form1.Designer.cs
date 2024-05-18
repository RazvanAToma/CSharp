namespace Library_Management_System
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
            memberID_label = new Label();
            selfcheckout_lable = new Label();
            memberName_label = new Label();
            returnBy_label = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // memberID_label
            // 
            memberID_label.AutoSize = true;
            memberID_label.Location = new Point(30, 125);
            memberID_label.Name = "memberID_label";
            memberID_label.Size = new Size(84, 20);
            memberID_label.TabIndex = 0;
            memberID_label.Text = "Member ID";
            // 
            // selfcheckout_lable
            // 
            selfcheckout_lable.AutoSize = true;
            selfcheckout_lable.Font = new Font("Segoe UI", 16F);
            selfcheckout_lable.Location = new Point(30, 48);
            selfcheckout_lable.Name = "selfcheckout_lable";
            selfcheckout_lable.Size = new Size(178, 37);
            selfcheckout_lable.TabIndex = 1;
            selfcheckout_lable.Text = "Self Checkout";
            // 
            // memberName_label
            // 
            memberName_label.AutoSize = true;
            memberName_label.Location = new Point(30, 175);
            memberName_label.Name = "memberName_label";
            memberName_label.Size = new Size(109, 20);
            memberName_label.TabIndex = 2;
            memberName_label.Text = "Member Name";
            // 
            // returnBy_label
            // 
            returnBy_label.AutoSize = true;
            returnBy_label.Location = new Point(30, 225);
            returnBy_label.Name = "returnBy_label";
            returnBy_label.Size = new Size(72, 20);
            returnBy_label.TabIndex = 3;
            returnBy_label.Text = "Return By";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 268);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(returnBy_label);
            Controls.Add(memberName_label);
            Controls.Add(selfcheckout_lable);
            Controls.Add(memberID_label);
            Name = "Form1";
            Text = "Library Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberID_label;
        private Label selfcheckout_lable;
        private Label memberName_label;
        private Label returnBy_label;
        private DateTimePicker dateTimePicker1;
    }
}
