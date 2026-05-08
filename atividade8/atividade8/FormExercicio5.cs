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
    public partial class FormExercicio5 : Form
    {
        public FormExercicio5()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                double temperatura = double.Parse(textBox1.Text);
                string escala = comboBox1.SelectedItem.ToString();
                double resultado = 0;
                string resultadoEscala = "";

                if (escala == "Celsius")
                {
                    double celsius = temperatura;
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    double kelvin = celsius + 273.15;
                    resultadoEscala = $"Fahrenheit: {fahrenheit.ToString("F2")}°F\nKelvin: {kelvin.ToString("F2")}K";
                }
                else if (escala == "Fahrenheit")
                {
                    double fahrenheit = temperatura;
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    double kelvin = celsius + 273.15;
                    resultadoEscala = $"Celsius: {celsius.ToString("F2")}°C\nKelvin: {kelvin.ToString("F2")}K";
                }
                else if (escala == "Kelvin")
                {
                    double kelvin = temperatura;
                    double celsius = kelvin - 273.15;
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    resultadoEscala = $"Celsius: {celsius.ToString("F2")}°C\nFahrenheit: {fahrenheit.ToString("F2")}°F";
                }

                textBox2.Text = resultadoEscala;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}