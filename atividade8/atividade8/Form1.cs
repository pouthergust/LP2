using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double num3 = double.Parse(textBox3.Text);

                double[] numeros = { num1, num2, num3 };
                Array.Sort(numeros);

                MessageBox.Show("Números ordenados: " + numeros[0] + ", " + numeros[1] + ", " + numeros[2],
                    "Exercício 1 - Ordenar Números", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            try
            {
                double preco = double.Parse(textBox4.Text);
                double desconto = double.Parse(textBox5.Text);

                double valorDesconto = preco * (desconto / 100);
                double precoFinal = preco - valorDesconto;

                MessageBox.Show("Valor do desconto: R$ " + valorDesconto.ToString("F2") +
                    "\nPreço final: R$ " + precoFinal.ToString("F2"),
                    "Exercício 2 - Calcular Desconto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox6.Text);

                if (numero % 2 == 0)
                {
                    MessageBox.Show("O número " + numero + " é PAR.", "Exercício 3 - Par ou Ímpar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O número " + numero + " é ÍMPAR.", "Exercício 3 - Par ou Ímpar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira um número inteiro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            FormExercicio4 form4 = new FormExercicio4();
            form4.ShowDialog();
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            FormExercicio5 form5 = new FormExercicio5();
            form5.ShowDialog();
        }
    }
}