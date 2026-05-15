namespace cajero
{
    partial class Custodio
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
            this.txtUsus = new System.Windows.Forms.TextBox();
            this.txtContr = new System.Windows.Forms.TextBox();
            this.lblUsus = new System.Windows.Forms.Label();
            this.lblContr = new System.Windows.Forms.Label();
            this.btnIng = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsus
            // 
            this.txtUsus.Location = new System.Drawing.Point(226, 130);
            this.txtUsus.Name = "txtUsus";
            this.txtUsus.Size = new System.Drawing.Size(100, 20);
            this.txtUsus.TabIndex = 6;
            this.txtUsus.TextChanged += new System.EventHandler(this.txtUsus_TextChanged);
            // 
            // txtContr
            // 
            this.txtContr.Location = new System.Drawing.Point(226, 196);
            this.txtContr.Name = "txtContr";
            this.txtContr.PasswordChar = '♦';
            this.txtContr.Size = new System.Drawing.Size(100, 20);
            this.txtContr.TabIndex = 7;
            this.txtContr.TextChanged += new System.EventHandler(this.txtContr_TextChanged);
            // 
            // lblUsus
            // 
            this.lblUsus.AutoSize = true;
            this.lblUsus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsus.Location = new System.Drawing.Point(96, 128);
            this.lblUsus.Name = "lblUsus";
            this.lblUsus.Size = new System.Drawing.Size(68, 20);
            this.lblUsus.TabIndex = 8;
            this.lblUsus.Text = "Usuario:";
            // 
            // lblContr
            // 
            this.lblContr.AutoSize = true;
            this.lblContr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContr.Location = new System.Drawing.Point(105, 183);
            this.lblContr.Name = "lblContr";
            this.lblContr.Size = new System.Drawing.Size(39, 20);
            this.lblContr.TabIndex = 9;
            this.lblContr.Text = "NIP:";
            // 
            // btnIng
            // 
            this.btnIng.Image = global::cajero.Properties.Resources.sangre;
            this.btnIng.Location = new System.Drawing.Point(251, 267);
            this.btnIng.Name = "btnIng";
            this.btnIng.Size = new System.Drawing.Size(75, 23);
            this.btnIng.TabIndex = 10;
            this.btnIng.Text = "Ingresar";
            this.btnIng.UseVisualStyleBackColor = true;
            this.btnIng.Click += new System.EventHandler(this.btnIng_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::cajero.Properties.Resources.sangre;
            this.btnCancel.Location = new System.Drawing.Point(109, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Custodio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cajero.Properties.Resources.PASD2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIng);
            this.Controls.Add(this.lblContr);
            this.Controls.Add(this.lblUsus);
            this.Controls.Add(this.txtContr);
            this.Controls.Add(this.txtUsus);
            this.Name = "Custodio";
            this.Text = "r";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsus;
        private System.Windows.Forms.TextBox txtContr;
        private System.Windows.Forms.Label lblUsus;
        private System.Windows.Forms.Label lblContr;
        private System.Windows.Forms.Button btnIng;
        private System.Windows.Forms.Button btnCancel;
    }
}