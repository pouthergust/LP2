namespace PTesteMétodos
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnContaNum = new System.Windows.Forms.Button();
            this.btnContaLetras = new System.Windows.Forms.Button();
            this.btnCaracterBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(160, 12);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(390, 236);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnContaNum
            // 
            this.btnContaNum.Location = new System.Drawing.Point(70, 282);
            this.btnContaNum.Name = "btnContaNum";
            this.btnContaNum.Size = new System.Drawing.Size(176, 108);
            this.btnContaNum.TabIndex = 1;
            this.btnContaNum.Text = "Conta Numeros";
            this.btnContaNum.UseVisualStyleBackColor = true;
            this.btnContaNum.Click += new System.EventHandler(this.btnContaNum_Click);
            // 
            // btnContaLetras
            // 
            this.btnContaLetras.Location = new System.Drawing.Point(511, 282);
            this.btnContaLetras.Name = "btnContaLetras";
            this.btnContaLetras.Size = new System.Drawing.Size(179, 108);
            this.btnContaLetras.TabIndex = 2;
            this.btnContaLetras.Text = "Conta Letras";
            this.btnContaLetras.UseVisualStyleBackColor = true;
            this.btnContaLetras.Click += new System.EventHandler(this.btnContaLetras_Click);
            // 
            // btnCaracterBranco
            // 
            this.btnCaracterBranco.Location = new System.Drawing.Point(288, 282);
            this.btnCaracterBranco.Name = "btnCaracterBranco";
            this.btnCaracterBranco.Size = new System.Drawing.Size(190, 108);
            this.btnCaracterBranco.TabIndex = 3;
            this.btnCaracterBranco.Text = "Localiza 1º Caracter em branco";
            this.btnCaracterBranco.UseVisualStyleBackColor = true;
            this.btnCaracterBranco.Click += new System.EventHandler(this.btnCaracterBranco_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.btnCaracterBranco);
            this.Controls.Add(this.btnContaLetras);
            this.Controls.Add(this.btnContaNum);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnContaNum;
        private System.Windows.Forms.Button btnContaLetras;
        private System.Windows.Forms.Button btnCaracterBranco;
    }
}