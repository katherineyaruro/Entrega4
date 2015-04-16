namespace AppOperaciones
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.rdbSumar = new System.Windows.Forms.RadioButton();
            this.rdbRestar = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(24, 24);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(56, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Numero 1:";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(27, 61);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(56, 13);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Numero 2:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(109, 24);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 2;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(109, 61);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // rdbSumar
            // 
            this.rdbSumar.AutoSize = true;
            this.rdbSumar.Location = new System.Drawing.Point(56, 133);
            this.rdbSumar.Name = "rdbSumar";
            this.rdbSumar.Size = new System.Drawing.Size(55, 17);
            this.rdbSumar.TabIndex = 4;
            this.rdbSumar.TabStop = true;
            this.rdbSumar.Text = "Sumar";
            this.rdbSumar.UseVisualStyleBackColor = true;
            // 
            // rdbRestar
            // 
            this.rdbRestar.AutoSize = true;
            this.rdbRestar.Location = new System.Drawing.Point(153, 133);
            this.rdbRestar.Name = "rdbRestar";
            this.rdbRestar.Size = new System.Drawing.Size(56, 17);
            this.rdbRestar.TabIndex = 5;
            this.rdbRestar.TabStop = true;
            this.rdbRestar.Text = "Restar";
            this.rdbRestar.UseVisualStyleBackColor = true;
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(56, 171);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(54, 17);
            this.rdbDividir.TabIndex = 6;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(153, 171);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdbMultiplicar.TabIndex = 7;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(97, 204);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(75, 23);
            this.txtResultado.TabIndex = 8;
            this.txtResultado.Text = "Resultado";
            this.txtResultado.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(109, 237);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.rdbMultiplicar);
            this.Controls.Add(this.rdbDividir);
            this.Controls.Add(this.rdbRestar);
            this.Controls.Add(this.rdbSumar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.RadioButton rdbSumar;
        private System.Windows.Forms.RadioButton rdbRestar;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.Button txtResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}

