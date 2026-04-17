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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text) == 0) 
            {
                MessageBox.Show("As palavras digitadas são iguais");   
            }
            else 
            {
                MessageBox.Show("As palavras digitadas são diferentes");
            }
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            string 
            MessageBox.Show("")
        }
    }
}
