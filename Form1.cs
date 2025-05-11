using System;
using System.Windows.Forms;

namespace Calculadora_Compleja
{
    public partial class Form1 : Form
    {
        Calculo calculo = new Calculo();

        public Form1()
        {
            InitializeComponent();
        }

        private bool InputsValidos(out double num1, out double num2)
        {
            num1 = 0;
            num2 = 0;

            if (string.IsNullOrWhiteSpace(TxtBoxNum1.Text) || string.IsNullOrWhiteSpace(TxtBoxNum2.Text))
            {
                MessageBox.Show("No se pueden dejar los campos vacíos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool esNum1 = double.TryParse(TxtBoxNum1.Text, out num1);
            bool esNum2 = double.TryParse(TxtBoxNum2.Text, out num2);

            if (!esNum1 || !esNum2)
            {
                MessageBox.Show("Ambos campos deben contener números válidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (InputsValidos(out double num1, out double num2))
            {
                calculo.Plus(num1, num2);
                TxtBoxResult.Text = calculo.result.ToString();
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            if (InputsValidos(out double num1, out double num2))
            {
                calculo.Substraction(num1, num2);
                TxtBoxResult.Text = calculo.result.ToString();
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (InputsValidos(out double num1, out double num2))
            {
                calculo.Multiplication(num1, num2);
                TxtBoxResult.Text = calculo.result.ToString();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (InputsValidos(out double num1, out double num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                calculo.Division(num1, num2);
                TxtBoxResult.Text = calculo.result.ToString();
            }
        }

        private void TxtBox1_TextChanged(object sender, EventArgs e) { }

        private void TxtBox2_TextChanged(object sender, EventArgs e) { }
    }
}