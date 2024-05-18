namespace Tic_Tac_Toe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            bottomLeft = new Button();
            bottomMiddle = new Button();
            bottomRight = new Button();
            topLeft = new Button();
            topMiddle = new Button();
            topRight = new Button();
            middleLeft = new Button();
            middleMiddle = new Button();
            middleRight = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = SystemColors.Desktop;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.18182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.81818F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(bottomLeft, 0, 2);
            tableLayoutPanel1.Controls.Add(bottomMiddle, 0, 2);
            tableLayoutPanel1.Controls.Add(bottomRight, 0, 2);
            tableLayoutPanel1.Controls.Add(topLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(topMiddle, 1, 0);
            tableLayoutPanel1.Controls.Add(topRight, 2, 0);
            tableLayoutPanel1.Controls.Add(middleLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(middleMiddle, 1, 1);
            tableLayoutPanel1.Controls.Add(middleRight, 2, 1);
            tableLayoutPanel1.ForeColor = SystemColors.Info;
            tableLayoutPanel1.Location = new Point(250, 75);
            tableLayoutPanel1.MaximumSize = new Size(300, 300);
            tableLayoutPanel1.MinimumSize = new Size(300, 300);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(300, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // bottomLeft
            // 
            bottomLeft.Anchor = AnchorStyles.None;
            bottomLeft.BackColor = SystemColors.Desktop;
            bottomLeft.FlatStyle = FlatStyle.Popup;
            bottomLeft.Font = new Font("Segoe UI", 40F);
            bottomLeft.ForeColor = SystemColors.Info;
            bottomLeft.Location = new Point(1, 203);
            bottomLeft.Margin = new Padding(0);
            bottomLeft.MaximumSize = new Size(94, 94);
            bottomLeft.MinimumSize = new Size(94, 94);
            bottomLeft.Name = "bottomLeft";
            bottomLeft.Size = new Size(94, 94);
            bottomLeft.TabIndex = 8;
            bottomLeft.UseVisualStyleBackColor = false;
            bottomLeft.Click += bottomLeft_Click;
            // 
            // bottomMiddle
            // 
            bottomMiddle.Anchor = AnchorStyles.None;
            bottomMiddle.BackColor = SystemColors.Desktop;
            bottomMiddle.FlatStyle = FlatStyle.Popup;
            bottomMiddle.Font = new Font("Segoe UI", 40F);
            bottomMiddle.ForeColor = SystemColors.Info;
            bottomMiddle.Location = new Point(99, 203);
            bottomMiddle.Margin = new Padding(0);
            bottomMiddle.MaximumSize = new Size(94, 94);
            bottomMiddle.MinimumSize = new Size(94, 94);
            bottomMiddle.Name = "bottomMiddle";
            bottomMiddle.RightToLeft = RightToLeft.No;
            bottomMiddle.Size = new Size(94, 94);
            bottomMiddle.TabIndex = 7;
            bottomMiddle.UseVisualStyleBackColor = false;
            bottomMiddle.Click += bottomMiddle_Click;
            // 
            // bottomRight
            // 
            bottomRight.Anchor = AnchorStyles.None;
            bottomRight.BackColor = SystemColors.Desktop;
            bottomRight.FlatStyle = FlatStyle.Popup;
            bottomRight.Font = new Font("Segoe UI", 40F);
            bottomRight.ForeColor = SystemColors.Info;
            bottomRight.Location = new Point(201, 203);
            bottomRight.Margin = new Padding(0);
            bottomRight.MaximumSize = new Size(94, 94);
            bottomRight.MinimumSize = new Size(94, 94);
            bottomRight.Name = "bottomRight";
            bottomRight.Size = new Size(94, 94);
            bottomRight.TabIndex = 6;
            bottomRight.UseVisualStyleBackColor = false;
            bottomRight.Click += bottomRight_Click;
            // 
            // topLeft
            // 
            topLeft.Anchor = AnchorStyles.None;
            topLeft.BackColor = SystemColors.Desktop;
            topLeft.FlatStyle = FlatStyle.Popup;
            topLeft.Font = new Font("Segoe UI", 40F);
            topLeft.ForeColor = SystemColors.Info;
            topLeft.Location = new Point(1, 3);
            topLeft.Margin = new Padding(0);
            topLeft.MaximumSize = new Size(94, 94);
            topLeft.MinimumSize = new Size(94, 94);
            topLeft.Name = "topLeft";
            topLeft.Size = new Size(94, 94);
            topLeft.TabIndex = 0;
            topLeft.UseVisualStyleBackColor = false;
            topLeft.Click += topLeft_Click;
            // 
            // topMiddle
            // 
            topMiddle.Anchor = AnchorStyles.None;
            topMiddle.BackColor = SystemColors.Desktop;
            topMiddle.FlatStyle = FlatStyle.Popup;
            topMiddle.Font = new Font("Segoe UI", 40F);
            topMiddle.ForeColor = SystemColors.Info;
            topMiddle.Location = new Point(99, 3);
            topMiddle.Margin = new Padding(0);
            topMiddle.MaximumSize = new Size(94, 94);
            topMiddle.MinimumSize = new Size(94, 94);
            topMiddle.Name = "topMiddle";
            topMiddle.Size = new Size(94, 94);
            topMiddle.TabIndex = 1;
            topMiddle.UseVisualStyleBackColor = false;
            topMiddle.Click += topMiddle_Click;
            // 
            // topRight
            // 
            topRight.Anchor = AnchorStyles.None;
            topRight.BackColor = SystemColors.Desktop;
            topRight.FlatStyle = FlatStyle.Popup;
            topRight.Font = new Font("Segoe UI", 40F);
            topRight.ForeColor = SystemColors.Info;
            topRight.Location = new Point(201, 3);
            topRight.Margin = new Padding(0);
            topRight.MaximumSize = new Size(94, 94);
            topRight.MinimumSize = new Size(94, 94);
            topRight.Name = "topRight";
            topRight.Size = new Size(94, 94);
            topRight.TabIndex = 2;
            topRight.UseVisualStyleBackColor = false;
            topRight.Click += topRight_Click;
            // 
            // middleLeft
            // 
            middleLeft.Anchor = AnchorStyles.None;
            middleLeft.BackColor = SystemColors.Desktop;
            middleLeft.FlatStyle = FlatStyle.Popup;
            middleLeft.Font = new Font("Segoe UI", 40F);
            middleLeft.ForeColor = SystemColors.Info;
            middleLeft.Location = new Point(1, 103);
            middleLeft.Margin = new Padding(0);
            middleLeft.MaximumSize = new Size(94, 94);
            middleLeft.MinimumSize = new Size(94, 94);
            middleLeft.Name = "middleLeft";
            middleLeft.Size = new Size(94, 94);
            middleLeft.TabIndex = 3;
            middleLeft.UseVisualStyleBackColor = false;
            middleLeft.Click += middleLeft_Click;
            // 
            // middleMiddle
            // 
            middleMiddle.Anchor = AnchorStyles.None;
            middleMiddle.BackColor = SystemColors.Desktop;
            middleMiddle.FlatStyle = FlatStyle.Popup;
            middleMiddle.Font = new Font("Segoe UI", 40F);
            middleMiddle.ForeColor = SystemColors.Info;
            middleMiddle.Location = new Point(99, 103);
            middleMiddle.Margin = new Padding(0);
            middleMiddle.MaximumSize = new Size(94, 94);
            middleMiddle.MinimumSize = new Size(94, 94);
            middleMiddle.Name = "middleMiddle";
            middleMiddle.Size = new Size(94, 94);
            middleMiddle.TabIndex = 4;
            middleMiddle.UseVisualStyleBackColor = false;
            middleMiddle.Click += middleMiddle_Click;
            // 
            // middleRight
            // 
            middleRight.Anchor = AnchorStyles.None;
            middleRight.BackColor = SystemColors.Desktop;
            middleRight.FlatStyle = FlatStyle.Popup;
            middleRight.Font = new Font("Segoe UI", 40F);
            middleRight.ForeColor = SystemColors.Info;
            middleRight.Location = new Point(201, 103);
            middleRight.Margin = new Padding(0);
            middleRight.MaximumSize = new Size(94, 94);
            middleRight.MinimumSize = new Size(94, 94);
            middleRight.Name = "middleRight";
            middleRight.Size = new Size(94, 94);
            middleRight.TabIndex = 5;
            middleRight.UseVisualStyleBackColor = false;
            middleRight.Click += middleRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.Info;
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button topLeft;
        private Button bottomLeft;
        private Button bottomMiddle;
        private Button bottomRight;
        private Button topMiddle;
        private Button topRight;
        private Button middleLeft;
        private Button middleMiddle;
        private Button middleRight;
    }
}
