namespace AppCheckbox
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
            this.chkopcion1 = new System.Windows.Forms.CheckBox();
            this.chkOpcion2 = new System.Windows.Forms.CheckBox();
            this.chkOpcion3 = new System.Windows.Forms.CheckBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkopcion1
            // 
            this.chkopcion1.AutoSize = true;
            this.chkopcion1.Location = new System.Drawing.Point(33, 33);
            this.chkopcion1.Name = "chkopcion1";
            this.chkopcion1.Size = new System.Drawing.Size(99, 17);
            this.chkopcion1.TabIndex = 0;
            this.chkopcion1.Text = "Google Chrome";
            this.chkopcion1.UseVisualStyleBackColor = true;
            // 
            // chkOpcion2
            // 
            this.chkOpcion2.AutoSize = true;
            this.chkOpcion2.Location = new System.Drawing.Point(33, 67);
            this.chkOpcion2.Name = "chkOpcion2";
            this.chkOpcion2.Size = new System.Drawing.Size(92, 17);
            this.chkOpcion2.TabIndex = 1;
            this.chkOpcion2.Text = "Mozilla Firefox";
            this.chkOpcion2.UseVisualStyleBackColor = true;
            // 
            // chkOpcion3
            // 
            this.chkOpcion3.AutoSize = true;
            this.chkOpcion3.Location = new System.Drawing.Point(33, 109);
            this.chkOpcion3.Name = "chkOpcion3";
            this.chkOpcion3.Size = new System.Drawing.Size(103, 17);
            this.chkOpcion3.TabIndex = 2;
            this.chkOpcion3.Text = "Internet Explorer";
            this.chkOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(106, 161);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.chkOpcion3);
            this.Controls.Add(this.chkOpcion2);
            this.Controls.Add(this.chkopcion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkopcion1;
        private System.Windows.Forms.CheckBox chkOpcion2;
        private System.Windows.Forms.CheckBox chkOpcion3;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}

