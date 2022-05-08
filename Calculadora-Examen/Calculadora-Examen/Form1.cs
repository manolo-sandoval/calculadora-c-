using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0;
        double num2 = 0;
        string operador;
        private void button0_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + "9";
        }

        private void buttonPts_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Text = textBoxMostrarResultado.Text + ".";
        }

        private void buttonsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBoxMostrarResultado.Text);
            textBoxMostrarResultado.Clear();
        }

        private void buttonresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBoxMostrarResultado.Text);
            textBoxMostrarResultado.Clear();
        }

        private void buttonmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBoxMostrarResultado.Text);
            textBoxMostrarResultado.Clear();
        }

        private void buttondivicion_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBoxMostrarResultado.Text);
            textBoxMostrarResultado.Clear();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBoxMostrarResultado.Text);

            switch (operador)
            {
                case "+":
                    textBoxMostrarResultado.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBoxMostrarResultado.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBoxMostrarResultado.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    textBoxMostrarResultado.Text = Convert.ToString(num1 /  num2);
                    break;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxMostrarResultado.Clear();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (textBoxMostrarResultado.Text.Length == 1)
                textBoxMostrarResultado.Text = "";
            else
                textBoxMostrarResultado.Text = textBoxMostrarResultado.Text.Substring(0, textBoxMostrarResultado.Text.Length - 1);
            //no dar clik si ya no hay mas cararteres porque da error jajaj

        }
    }
}
