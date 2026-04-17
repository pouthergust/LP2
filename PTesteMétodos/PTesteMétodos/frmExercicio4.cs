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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContaNum_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int contNum = 0;
            while (contador < rchtxtFrase.Text.Length)
            {
                if (char.IsNumber(rchtxtFrase.Text[contador]))
                {
                    contNum++;
                }

                contador++;
            }
            MessageBox.Show("a frase tem " + contNum + " números");
        }

        private void btnCaracterBranco_Click(object sender, EventArgs e)
        {
            int posicao = -1;
            for (int i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i]))
                {
                    posicao = i+1;
                    break;
                }
            }
            if (posicao > 0)
            {
                MessageBox.Show("1º caracter branco está na posição " + posicao);
            }

            else
                MessageBox.Show("não há espaços em branco");
        }

        private void btnContaLetras_Click(object sender, EventArgs e)
        {
            int contaLetra = 0;
            foreach (char c in rchtxtFrase.Text)
            {
                if (char.IsLetter(c))
                {
                    contaLetra++;
                }
            }
            MessageBox.Show($"a frase tem {contaLetra} Letras");
        }
    }
}
