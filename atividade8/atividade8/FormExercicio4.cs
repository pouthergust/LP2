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
    public partial class FormExercicio4 : Form
    {
        public FormExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                string operacao = comboBox1.SelectedItem.ToString();
                double num2 = double.Parse(textBox2.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                        {
                            MessageBox.Show("Não é possível dividir por zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }

                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira valores válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}