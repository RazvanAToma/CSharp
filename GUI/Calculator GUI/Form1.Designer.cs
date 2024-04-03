namespace Calculator_GUI
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
            display = new TextBox();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonMultiply = new Button();
            buttonMinus = new Button();
            buttonThree = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            buttonDivide = new Button();
            buttonNine = new Button();
            buttonEight = new Button();
            buttonSeven = new Button();
            buttonPlus = new Button();
            buttonEquals = new Button();
            buttonPeriod = new Button();
            buttonZero = new Button();
            buttonBackspace = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.Location = new Point(266, 111);
            display.Name = "display";
            display.Size = new Size(218, 27);
            display.TabIndex = 0;
            display.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(266, 220);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(50, 50);
            buttonFour.TabIndex = 1;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonFive
            // 
            buttonFive.Location = new Point(322, 220);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(50, 50);
            buttonFive.TabIndex = 2;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(378, 220);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(50, 50);
            buttonSix.TabIndex = 3;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(434, 220);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(50, 50);
            buttonMultiply.TabIndex = 4;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(434, 276);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 50);
            buttonMinus.TabIndex = 8;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(378, 276);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(50, 50);
            buttonThree.TabIndex = 7;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Location = new Point(322, 276);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(50, 50);
            buttonTwo.TabIndex = 6;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonOne
            // 
            buttonOne.Location = new Point(266, 276);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(50, 50);
            buttonOne.TabIndex = 5;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(434, 164);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(50, 50);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonNine
            // 
            buttonNine.Location = new Point(378, 164);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(50, 50);
            buttonNine.TabIndex = 15;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonEight
            // 
            buttonEight.Location = new Point(322, 164);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(50, 50);
            buttonEight.TabIndex = 14;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Location = new Point(266, 164);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(50, 50);
            buttonSeven.TabIndex = 13;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(434, 332);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 50);
            buttonPlus.TabIndex = 20;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(378, 332);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(50, 50);
            buttonEquals.TabIndex = 19;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonPeriod
            // 
            buttonPeriod.Location = new Point(322, 332);
            buttonPeriod.Name = "buttonPeriod";
            buttonPeriod.Size = new Size(50, 50);
            buttonPeriod.TabIndex = 18;
            buttonPeriod.Text = ".";
            buttonPeriod.UseVisualStyleBackColor = true;
            buttonPeriod.Click += buttonPeriod_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(266, 332);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(50, 50);
            buttonZero.TabIndex = 17;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Location = new Point(490, 111);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(50, 29);
            buttonBackspace.TabIndex = 21;
            buttonBackspace.Text = "C";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBackspace);
            Controls.Add(buttonPlus);
            Controls.Add(buttonEquals);
            Controls.Add(buttonPeriod);
            Controls.Add(buttonZero);
            Controls.Add(buttonDivide);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonMinus);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonMultiply;
        private Button buttonMinus;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonDivide;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
        private Button buttonPlus;
        private Button buttonEquals;
        private Button buttonPeriod;
        private Button buttonZero;
        private Button buttonBackspace;
    }
}
