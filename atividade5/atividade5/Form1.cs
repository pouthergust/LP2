using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double num3 = double.Parse(textBox3.Text);

                double[] numeros = { num1, num2, num3 };
                Array.Sort(numeros);

                textBox4.Text = numeros[0].ToString() + ", " + numeros[1].ToString() + ", " + numeros[2].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira numeros validos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double preco = double.Parse(textBox5.Text);
                double desconto = double.Parse(textBox6.Text);

                double valorDesconto = preco * (desconto / 100);
                double precoFinal = preco - valorDesconto;

                textBox7.Text = valorDesconto.ToString("F2");
                textBox8.Text = precoFinal.ToString("F2");
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira valores validos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}