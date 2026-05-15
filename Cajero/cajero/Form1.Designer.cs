namespace cajero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsusario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.btnIng = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsusario
            // 
            this.txtUsusario.Location = new System.Drawing.Point(446, 189);
            this.txtUsusario.Name = "txtUsusario";
            this.txtUsusario.Size = new System.Drawing.Size(100, 20);
            this.txtUsusario.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(311, 187);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(340, 262);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(39, 20);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "NIP:";
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(446, 262);
            this.txtCont.Name = "txtCont";
            this.txtCont.PasswordChar = '♠';
            this.txtCont.Size = new System.Drawing.Size(100, 20);
            this.txtCont.TabIndex = 3;
            this.txtCont.TextChanged += new System.EventHandler(this.txtCont_TextChanged);
            // 
            // btnIng
            // 
            this.btnIng.Image = global::cajero.Properties.Resources.sangre;
            this.btnIng.Location = new System.Drawing.Point(471, 405);
            this.btnIng.Name = "btnIng";
            this.btnIng.Size = new System.Drawing.Size(75, 23);
            this.btnIng.TabIndex = 5;
            this.btnIng.Text = "Ingresar";
            this.btnIng.UseVisualStyleBackColor = true;
            this.btnIng.Click += new System.EventHandler(this.btnIng_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Image = global::cajero.Properties.Resources.sangre;
            this.btnCanc.Location = new System.Drawing.Point(296, 405);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 6;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cajero.Properties.Resources.PASD3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(829, 531);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnIng);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsusario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsusario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.Button btnIng;
        private System.Windows.Forms.Button btnCanc;
    }
}

