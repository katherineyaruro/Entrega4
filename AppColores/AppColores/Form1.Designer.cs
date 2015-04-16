namespace AppColores
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
            this.chkOpcion1 = new System.Windows.Forms.CheckBox();
            this.chkOpcion2 = new System.Windows.Forms.CheckBox();
            this.chkOpcion3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkOpcion1
            // 
            this.chkOpcion1.AutoSize = true;
            this.chkOpcion1.Location = new System.Drawing.Point(38, 31);
            this.chkOpcion1.Name = "chkOpcion1";
            this.chkOpcion1.Size = new System.Drawing.Size(51, 17);
            this.chkOpcion1.TabIndex = 0;
            this.chkOpcion1.Text = "Rosa";
            this.chkOpcion1.UseVisualStyleBackColor = true;
            // 
            // chkOpcion2
            // 
            this.chkOpcion2.AutoSize = true;
            this.chkOpcion2.Location = new System.Drawing.Point(38, 67);
            this.chkOpcion2.Name = "chkOpcion2";
            this.chkOpcion2.Size = new System.Drawing.Size(46, 17);
            this.chkOpcion2.TabIndex = 1;
            this.chkOpcion2.Text = "Azul";
            this.chkOpcion2.UseVisualStyleBackColor = true;
            // 
            // chkOpcion3
            // 
            this.chkOpcion3.AutoSize = true;
            this.chkOpcion3.Location = new System.Drawing.Point(38, 103);
            this.chkOpcion3.Name = "chkOpcion3";
            this.chkOpcion3.Size = new System.Drawing.Size(48, 17);
            this.chkOpcion3.TabIndex = 2;
            this.chkOpcion3.Text = "Rojo";
            this.chkOpcion3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkOpcion3);
            this.Controls.Add(this.chkOpcion2);
            this.Controls.Add(this.chkOpcion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOpcion1;
        private System.Windows.Forms.CheckBox chkOpcion2;
        private System.Windows.Forms.CheckBox chkOpcion3;
        private System.Windows.Forms.Button button1;
    }
}

