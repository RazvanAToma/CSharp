namespace GUI_Oppgave_2
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
            radiusTextBox = new TextBox();
            areaTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            circumferenceTextBox = new TextBox();
            SuspendLayout();
            // 
            // radiusTextBox
            // 
            radiusTextBox.Location = new Point(90, 93);
            radiusTextBox.Name = "radiusTextBox";
            radiusTextBox.Size = new Size(125, 27);
            radiusTextBox.TabIndex = 0;
            // 
            // areaTextBox
            // 
            areaTextBox.Location = new Point(90, 142);
            areaTextBox.Name = "areaTextBox";
            areaTextBox.Size = new Size(125, 27);
            areaTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 96);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Radius:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 145);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Areal:";
            // 
            // button1
            // 
            button1.Location = new Point(234, 93);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Regn ut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 93);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 5;
            label3.Text = "Sirkel Areal Formel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 142);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 6;
            label4.Text = "Sirkel Omkrets Formel:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(597, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            textBox3.Text = "πr^2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(597, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            textBox4.Text = "2πr";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 197);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 10;
            label5.Text = "Omkrets:";
            // 
            // circumferenceTextBox
            // 
            circumferenceTextBox.Location = new Point(90, 194);
            circumferenceTextBox.Name = "circumferenceTextBox";
            circumferenceTextBox.Size = new Size(125, 27);
            circumferenceTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(circumferenceTextBox);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(areaTextBox);
            Controls.Add(radiusTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox radiusTextBox;
        private TextBox areaTextBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox circumferenceTextBox;
    }
}
