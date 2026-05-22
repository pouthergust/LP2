using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // matriz 7x5: 7 dias, 5 produtos
            decimal[,] compras = new decimal[7, 5];
            decimal[] totalPorDia = new decimal[7];

            string[] dias = new string[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bool ok = false;
                    while (!ok)
                    {
                        string prompt = string.Format("Informe o valor da compra para {0} - Produto {1}:", dias[i], j + 1);
                        string input = ShowInputBox(prompt, "Entrada de Valores", "0,00");

                        if (string.IsNullOrWhiteSpace(input))
                        {
                            // trata como zero
                            compras[i, j] = 0m;
                            ok = true;
                        }
                        else
                        {
                            // tenta converter considerando vírgula ou ponto
                            input = input.Trim();
                            input = input.Replace('.', ',');
                            decimal val;
                            if (decimal.TryParse(input, out val))
                            {
                                compras[i, j] = val;
                                ok = true;
                            }
                            else
                            {
                                var res = MessageBox.Show("Valor inválido. Deseja tentar novamente?", "Entrada inválida", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                                if (res == DialogResult.Cancel)
                                {
                                    compras[i, j] = 0m;
                                    ok = true;
                                }
                            }
                        }
                    }
                }
            }

            // calcula total por dia e total geral
            decimal totalGeral = 0m;
            for (int i = 0; i < 7; i++)
            {
                decimal soma = 0m;
                for (int j = 0; j < 5; j++)
                {
                    soma += compras[i, j];
                }
                totalPorDia[i] = soma;
                totalGeral += soma;
            }

            // exibe no listbox
            listBoxResults.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                listBoxResults.Items.Add(string.Format("{0} : {1:N2}", dias[i], totalPorDia[i]));
            }
            listBoxResults.Items.Add("---------------------");
            listBoxResults.Items.Add(string.Format("Total Geral: {0:N2}", totalGeral));
        }

        // Implementação simples de InputBox para não depender de Microsoft.VisualBasic
        private string ShowInputBox(string prompt, string title, string defaultValue)
        {
            using (Form form = new Form())
            {
                form.Width = 400;
                form.Height = 150;
                form.Text = title;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.MinimizeBox = false;
                form.MaximizeBox = false;

                Label lbl = new Label() { Left = 10, Top = 10, Text = prompt, AutoSize = true };
                TextBox txt = new TextBox() { Left = 10, Top = 35, Width = 360, Text = defaultValue };
                Button btnOk = new Button() { Text = "OK", Left = 220, Width = 70, Top = 70, DialogResult = DialogResult.OK };
                Button btnCancel = new Button() { Text = "Cancelar", Left = 300, Width = 70, Top = 70, DialogResult = DialogResult.Cancel };

                form.Controls.Add(lbl);
                form.Controls.Add(txt);
                form.Controls.Add(btnOk);
                form.Controls.Add(btnCancel);
                form.AcceptButton = btnOk;
                form.CancelButton = btnCancel;

                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    return txt.Text;
                else
                    return string.Empty;
            }
        }
    }
}
