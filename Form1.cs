using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
            AttachEvents();
        }

        private void AttachEvents()
        {
            // Rəqəmlər və nöqtə
            btn0.Click += Number_Click;
            btn1.Click += Number_Click;
            btn2.Click += Number_Click;
            btn3.Click += Number_Click;
            btn4.Click += Number_Click;
            btn5.Click += Number_Click;
            btn6.Click += Number_Click;
            btn7.Click += Number_Click;
            btn8.Click += Number_Click;
            btn9.Click += Number_Click;
            btnDot.Click += Number_Click;

            // Əməliyyat düymələri
            btnAdd.Click += Operator_Click;
            btnSubtract.Click += Operator_Click;
            btnMultiply.Click += Operator_Click;
            btnDivide.Click += Operator_Click;

            // Bərabər, Təmizləmə və Tək-tək silmə
            btnEqual.Click += BtnEqual_Click;
            btnClear.Click += BtnClear_Click;
            btnBackspace.Click += BtnBackspace_Click;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((txtDisplay.Text == "0") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;

            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    if (string.IsNullOrEmpty(txtDisplay.Text))
                        txtDisplay.Text = "0.";
                    else
                        txtDisplay.Text += ".";
                }
            }
            else
            {
                txtDisplay.Text += button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);
                isOperationPerformed = true;
            }
        }

        // Hər şeyi təmizləyən C düyməsi
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
        }

        // Son simvolu tək-tək silən (⌫) düymə metodu
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0 && !isOperationPerformed)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }

            // Əgər ekranda heç nə qalmazsa və ya təkcə "-" qalarsa "0" yazılır
            if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text == "-")
            {
                txtDisplay.Text = "0";
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double currentDisplayValue = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            switch (operationPerformed)
            {
                case "+":
                    resultValue = resultValue + currentDisplayValue;
                    break;
                case "-":
                    resultValue = resultValue - currentDisplayValue;
                    break;
                case "*":
                    resultValue = resultValue * currentDisplayValue;
                    break;
                case "/":
                    if (currentDisplayValue != 0)
                    {
                        resultValue = resultValue / currentDisplayValue;
                    }
                    else
                    {
                        MessageBox.Show("Sıfıra bölmək olmaz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDisplay.Text = "0";
                        resultValue = 0;
                        operationPerformed = "";
                        return;
                    }
                    break;
                default:
                    break;
            }

            txtDisplay.Text = resultValue.ToString(CultureInfo.InvariantCulture);
            operationPerformed = "";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}