namespace AppTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbnNumero1 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnNumero1
            // 
            this.lbnNumero1.AutoSize = true;
            this.lbnNumero1.Location = new System.Drawing.Point(38, 26);
            this.lbnNumero1.Name = "lbnNumero1";
            this.lbnNumero1.Size = new System.Drawing.Size(56, 13);
            this.lbnNumero1.TabIndex = 0;
            this.lbnNumero1.Text = "Numero 1:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(101, 26);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 1;
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Location = new System.Drawing.Point(41, 62);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(56, 13);
            this.lbNumero2.TabIndex = 2;
            this.lbNumero2.Text = "Numero 2:";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(101, 54);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(41, 115);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(101, 138);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lbnNumero1);
            this.Name = "Form1";
            this.Text = "Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnNumero1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSumar;
    }
}

