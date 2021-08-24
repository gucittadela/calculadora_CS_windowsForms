using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_form
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(tbResultado.Text);

            if (operacao == "SOMA")
            {
                tbResultado.Text = Convert.ToString(valor1 + valor2);
            }
            if (operacao == "SUB")
            {
                tbResultado.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao == "DIV")
            {
                tbResultado.Text = Convert.ToString(valor1 / valor2);
            }
            if (operacao == "MULT")
            {
                tbResultado.Text = Convert.ToString(valor1 * valor2);
            }

            
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = double.Parse(tbResultado.Text);
            tbResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";

            } else
            {
                MessageBox.Show("Digite um Número!");
            }
        }

        private void btnMultiplic_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = double.Parse(tbResultado.Text);
                tbResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";

            }
            else
            {
                MessageBox.Show("Digite um Número!");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = double.Parse(tbResultado.Text);
                tbResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";

            }
            else
            {
                MessageBox.Show("Digite um Número!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text != "")
            {
                valor1 = double.Parse(tbResultado.Text);
                tbResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";

            }
            else
            {
                MessageBox.Show("Digite um Número!");
            }
        }
    }
}
