namespace cajero
{
    partial class Ingretiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingretiro));
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lblDiner = new System.Windows.Forms.Label();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.txtDiner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetirar.BackgroundImage")));
            this.btnRetirar.Location = new System.Drawing.Point(321, 347);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 23);
            this.btnRetirar.TabIndex = 0;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // lblDiner
            // 
            this.lblDiner.AutoSize = true;
            this.lblDiner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiner.Location = new System.Drawing.Point(12, 127);
            this.lblDiner.Name = "lblDiner";
            this.lblDiner.Size = new System.Drawing.Size(261, 24);
            this.lblDiner.TabIndex = 1;
            this.lblDiner.Text = "Ingrese la cantidad monetaria:";
            // 
            // btn20
            // 
            this.btn20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn20.BackgroundImage")));
            this.btn20.Location = new System.Drawing.Point(478, 206);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 23);
            this.btn20.TabIndex = 2;
            this.btn20.Text = "$20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn50
            // 
            this.btn50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn50.BackgroundImage")));
            this.btn50.Location = new System.Drawing.Point(397, 203);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(75, 23);
            this.btn50.TabIndex = 3;
            this.btn50.Text = "$50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn100
            // 
            this.btn100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn100.BackgroundImage")));
            this.btn100.Location = new System.Drawing.Point(478, 177);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 4;
            this.btn100.Text = "$100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn200.BackgroundImage")));
            this.btn200.Location = new System.Drawing.Point(397, 174);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(75, 23);
            this.btn200.TabIndex = 5;
            this.btn200.Text = "$200";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn500
            // 
            this.btn500.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn500.BackgroundImage")));
            this.btn500.Location = new System.Drawing.Point(478, 145);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(75, 23);
            this.btn500.TabIndex = 6;
            this.btn500.Text = "$500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn1000
            // 
            this.btn1000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1000.BackgroundImage")));
            this.btn1000.Location = new System.Drawing.Point(397, 145);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(75, 23);
            this.btn1000.TabIndex = 7;
            this.btn1000.Text = "$1000";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // txtDiner
            // 
            this.txtDiner.Location = new System.Drawing.Point(126, 190);
            this.txtDiner.Name = "txtDiner";
            this.txtDiner.Size = new System.Drawing.Size(104, 20);
            this.txtDiner.TabIndex = 8;
            this.txtDiner.TextChanged += new System.EventHandler(this.txtDiner_TextChanged);
            // 
            // Ingretiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cajero.Properties.Resources.PASD5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiner);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.lblDiner);
            this.Controls.Add(this.btnRetirar);
            this.Name = "Ingretiro";
            this.Text = "Ingretiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lblDiner;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.TextBox txtDiner;
    }
}