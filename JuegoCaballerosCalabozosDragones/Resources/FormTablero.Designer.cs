namespace JuegoCaballerosCalabozosDragones.Resources
{
    partial class FormTablero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablero));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTirarDado = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbEstado = new System.Windows.Forms.ListBox();
            this.btnTermino = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 531);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 72);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTirarDado
            // 
            this.btnTirarDado.Location = new System.Drawing.Point(12, 400);
            this.btnTirarDado.Name = "btnTirarDado";
            this.btnTirarDado.Size = new System.Drawing.Size(230, 108);
            this.btnTirarDado.TabIndex = 1;
            this.btnTirarDado.Text = "Tirar Dado";
            this.btnTirarDado.UseVisualStyleBackColor = true;
            this.btnTirarDado.Click += new System.EventHandler(this.btnTirarDado_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroAzul;
            this.pictureBox5.Location = new System.Drawing.Point(290, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroRojo;
            this.pictureBox4.Location = new System.Drawing.Point(267, 86);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroAmarillo;
            this.pictureBox3.Location = new System.Drawing.Point(312, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroVerde;
            this.pictureBox2.Location = new System.Drawing.Point(253, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.Tablero;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbEstado
            // 
            this.lbEstado.FormattingEnabled = true;
            this.lbEstado.Location = new System.Drawing.Point(12, 13);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(230, 381);
            this.lbEstado.TabIndex = 7;
            // 
            // btnTermino
            // 
            this.btnTermino.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTermino.Enabled = false;
            this.btnTermino.Location = new System.Drawing.Point(130, 531);
            this.btnTermino.Name = "btnTermino";
            this.btnTermino.Size = new System.Drawing.Size(112, 72);
            this.btnTermino.TabIndex = 8;
            this.btnTermino.Text = "Listo";
            this.btnTermino.UseVisualStyleBackColor = true;
            // 
            // FormTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 615);
            this.ControlBox = false;
            this.Controls.Add(this.btnTermino);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTirarDado);
            this.Controls.Add(this.btnSalir);
            this.MaximizeBox = false;
            this.Name = "FormTablero";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tablero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Button btnTirarDado;
        public System.Windows.Forms.Button btnTermino;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.ListBox lbEstado;
    }
}