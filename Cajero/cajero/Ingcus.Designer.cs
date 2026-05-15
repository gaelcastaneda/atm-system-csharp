namespace cajero
{
    partial class Ingcus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingcus));
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btnDepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(136, 122);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(291, 24);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Ingrese la cantidad monetaria ";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(213, 191);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(130, 20);
            this.txtDep.TabIndex = 1;
            this.txtDep.TextChanged += new System.EventHandler(this.txtDep_TextChanged);
            // 
            // btn1000
            // 
            this.btn1000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1000.BackgroundImage")));
            this.btn1000.Location = new System.Drawing.Point(530, 104);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(75, 23);
            this.btn1000.TabIndex = 2;
            this.btn1000.Text = "$1000";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn500
            // 
            this.btn500.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn500.BackgroundImage")));
            this.btn500.Location = new System.Drawing.Point(627, 104);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(75, 23);
            this.btn500.TabIndex = 3;
            this.btn500.Text = "$500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn20
            // 
            this.btn20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn20.BackgroundImage")));
            this.btn20.Location = new System.Drawing.Point(627, 189);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 23);
            this.btn20.TabIndex = 4;
            this.btn20.Text = "$20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn100
            // 
            this.btn100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn100.BackgroundImage")));
            this.btn100.Location = new System.Drawing.Point(627, 148);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 5;
            this.btn100.Text = "$100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn200.BackgroundImage")));
            this.btn200.Location = new System.Drawing.Point(530, 148);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(75, 23);
            this.btn200.TabIndex = 6;
            this.btn200.Text = "$200";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn50
            // 
            this.btn50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn50.BackgroundImage")));
            this.btn50.Location = new System.Drawing.Point(530, 189);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(75, 23);
            this.btn50.TabIndex = 7;
            this.btn50.Text = "$50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btnDepo
            // 
            this.btnDepo.BackgroundImage = global::cajero.Properties.Resources.red;
            this.btnDepo.Location = new System.Drawing.Point(389, 306);
            this.btnDepo.Name = "btnDepo";
            this.btnDepo.Size = new System.Drawing.Size(75, 23);
            this.btnDepo.TabIndex = 8;
            this.btnDepo.Text = "Depositar";
            this.btnDepo.UseVisualStyleBackColor = true;
            this.btnDepo.Click += new System.EventHandler(this.btnDepo_Click);
            // 
            // Ingcus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cajero.Properties.Resources.PASD4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDepo);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.lblMarca);
            this.Name = "Ingcus";
            this.Text = "Ingcus";
            this.Load += new System.EventHandler(this.Ingcus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btnDepo;
    }
}