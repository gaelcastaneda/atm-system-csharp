namespace cajero
{
    partial class Menu
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
            this.btnCustodio = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustodio
            // 
            this.btnCustodio.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCustodio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustodio.Image = global::cajero.Properties.Resources.sangre;
            this.btnCustodio.Location = new System.Drawing.Point(83, 234);
            this.btnCustodio.Name = "btnCustodio";
            this.btnCustodio.Size = new System.Drawing.Size(75, 23);
            this.btnCustodio.TabIndex = 0;
            this.btnCustodio.Text = "Desposito";
            this.btnCustodio.UseVisualStyleBackColor = false;
            this.btnCustodio.Click += new System.EventHandler(this.btnCustodio_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiro.Image = global::cajero.Properties.Resources.sangre;
            this.btnRetiro.Location = new System.Drawing.Point(256, 234);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 1;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::cajero.Properties.Resources.red;
            this.btnSalir.Location = new System.Drawing.Point(171, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cajero.Properties.Resources.Pasd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 375);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnCustodio);
            this.Name = "Menu";
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustodio;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnSalir;
    }
}