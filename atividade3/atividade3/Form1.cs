namespace atividade3
{
    public partial class Form1 : Form
    {
        Double valorA, valorB, valorC;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(textBox1, "");
                this.valorA = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                errorProvider1.SetError(textBox1, "Valor A invalido!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider2.SetError(textBox2, "");
                this.valorB = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                errorProvider2.SetError(textBox2, "Valor B invalido!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider3.SetError(textBox3, "");
                this.valorC = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                errorProvider3.SetError(textBox3, "Valor C invalido!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (
                (valorA < (valorB + valorC)) &&
                (valorA > Math.Abs(valorB - valorC)) &&
                (valorB < (valorA + valorC)) &&
                (valorB > Math.Abs(valorA - valorC)) &&
                (valorC < (valorA + valorB)) &&
                (valorC > Math.Abs(valorA - valorB))
                ) // Valida se é um triangulo
            {
                if (valorA == valorB && valorA == valorC) // valida se é um equilatero 
                {
                    MessageBox.Show("É um equilatero");
                }
                else
                {
                    if (valorA == valorB || valorA == valorC || valorB == valorC) // valida se é isoseles
                    {
                        MessageBox.Show("É um isoceles");
                    }
                    else
                    {
                        MessageBox.Show("É um escaleno");
                    }
                }

            }
            else
            {
                MessageBox.Show("Não é um triangulo");
            }
        }
    }
}
