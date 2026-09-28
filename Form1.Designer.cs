namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSubtract = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(12, 20);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(296, 50);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(50, 50, 50);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(12, 160);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 60);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(50, 50, 50);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(89, 160);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 60);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(50, 50, 50);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(166, 160);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 60);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(60, 60, 60);
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(243, 90);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(65, 60);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(50, 50, 50);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(12, 230);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 60);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(50, 50, 50);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(89, 230);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 60);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(50, 50, 50);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(166, 230);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 60);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(60, 60, 60);
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(243, 160);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(65, 60);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(50, 50, 50);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(12, 300);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 60);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(50, 50, 50);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(89, 300);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 60);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(50, 50, 50);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(166, 300);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 60);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(60, 60, 60);
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.White;
            btnSubtract.Location = new Point(243, 230);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(65, 60);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(50, 50, 50);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(12, 370);
            btn0.Name = "btn0";
            btn0.Size = new Size(142, 60);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(50, 50, 50);
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDot.ForeColor = Color.White;
            btnDot.Location = new Point(166, 370);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(65, 60);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Blue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(12, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 60);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.FromArgb(70, 70, 70);
            btnBackspace.FlatAppearance.BorderSize = 0;
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBackspace.ForeColor = Color.White;
            btnBackspace.Location = new Point(127, 90);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(104, 60);
            btnBackspace.TabIndex = 18;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(60, 60, 60);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(243, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 60);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(0, 122, 204);
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(243, 370);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(65, 60);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(320, 445);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btnBackspace);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculatorApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
    }
}