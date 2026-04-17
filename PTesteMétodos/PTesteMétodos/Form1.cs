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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("opção copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("opção colar");
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront();
            }

            else
            {
                frmExercicio2 FrmExercicio2 = new frmExercicio2();
                FrmExercicio2.MdiParent = this;
                FrmExercicio2.WindowState = FormWindowState.Maximized;
                FrmExercicio2.Show();
            }


        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }

            else
            {
                frmExercicio3 FrmExercicio3 = new frmExercicio3();
                FrmExercicio3.MdiParent = this;
                FrmExercicio3.WindowState = FormWindowState.Maximized;
                FrmExercicio3.Show();
            }
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }

            else
            {
                frmExercicio4 FrmExercicio4 = new frmExercicio4();
                FrmExercicio4.MdiParent = this;
                FrmExercicio4.WindowState = FormWindowState.Maximized;
                FrmExercicio4.Show();
            }
        }

        //private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
        //    {
        //        Application.OpenForms["frmExercicio5"].BringToFront();
        //    }

        //    else
        //    {
        //        frmExercicio5 FrmExercicio5 = new frmExercicio5();
        //        FrmExercicio5.MdiParent = this;
        //        FrmExercicio5.WindowState = FormWindowState.Maximized;
        //        FrmExercicio5.Show();
        //    }
        //}

        private void exercicio5ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                Application.OpenForms["frmExercicio5"].BringToFront();
            }

            else
            {
                frmExercicio5 FrmExercicio5 = new frmExercicio5();
                FrmExercicio5.MdiParent = this;
                FrmExercicio5.WindowState = FormWindowState.Maximized;
                FrmExercicio5.Show();
            }
        }
    }
    
}
