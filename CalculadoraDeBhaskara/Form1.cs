using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeBhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            rbReais.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculadora de Bhaskara"
                + Environment.NewLine
                + "Versão 0.2"
                + Environment.NewLine
                + "Desenvolvedor: Daniel");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double a, b, c, x1, x2, delta;

            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);

                delta = b * b - 4 * a * c;
                if (delta < 0 & rbReais.Checked == true)
                {
                    lblX1.Text = "X1: Delta é negativo";
                    lblX2.Text = "X2: Delta é negativo";
                }
                else if(delta < 0 & rbComplexos.Checked == true)
                {
                    x1 = (-b + Math.Sqrt(-delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(-delta)) / (2 * a);
                    lblX1.Text = "X1: " + x1.ToString() + "i";
                    lblX2.Text = "X2: " + x2.ToString() + "i";
                }
                else 
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lblX1.Text = "X1: " + x1.ToString();
                    lblX2.Text = "X2: " + x2.ToString();
                }
            }


            catch
            {
                MessageBox.Show("Digite apenas números !!"
                    + Environment.NewLine
                    + "Probido campos em brancos e letras");
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
V 0.1
Calcula X1 e X2

V 0.1.1
Corrigiu o delta negativo

V 0.1.2
Corrigiu a mensagem do delta que aparecia junto à resposta anterior

V 0.1.3
Corrigiu os espaços em branco e letras digitadas como valores

V 0.2
Adicionada a possibilidade de escolher o conjunto numérico (reais e complexos)
para cálculo das raízes
*/
