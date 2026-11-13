using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        double segundoNumero = 0;
        double resultado = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

      

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text=txtResultado.Text +"1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ",";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacion = "+";
            
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacion = "-";

        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacion = "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacion = "/";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(txtResultado.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero == 0) 
                    { 
                        MessageBox.Show("Error. No se puede realizar division para 0", "Error", MessageBoxButtons.OK);
                        resultado = 0;
                    }
                    else 
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    break;
                default:
                    resultado = segundoNumero; // Por si presionan igual sin elegir operación
                    break;
            }
            
            txtResultado.Text = resultado.ToString();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            primerNumero = 0;
            segundoNumero = 0;
            resultado = 0;
            txtResultado.Text = "";

        }

       
    }
}
