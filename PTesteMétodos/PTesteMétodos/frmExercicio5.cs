using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMétodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int Numero1, Numero2;

            if (!int.TryParse(txtNumero1.Text, out Numero1) || (Numero1 < 0))
            {
                MessageBox.Show("Numero 1 inválido!");
                txtNumero1.Focus();
            }

            else if (!int.TryParse(txtNumero2.Text, out Numero2) || (Numero2 < 0))
            {
                MessageBox.Show("Numero 2 inválido!");
                txtNumero2.Focus();
            }

            else if(Numero1 > Numero2)
            {
                MessageBox.Show("Numero 1 é maior que Numero 2");
                txtNumero1.Focus();
            }

  

            else 
            { 
                Random objR = new Random();
                int sorteado = objR.Next(Numero1, Numero2);
                MessageBox.Show(sorteado.ToString());
            }
        }
    }
}
