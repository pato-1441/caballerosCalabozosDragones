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
            this.lbEstado = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbCaballeroAzul = new System.Windows.Forms.PictureBox();
            this.pbCaballeroRojo = new System.Windows.Forms.PictureBox();
            this.pbCaballeroAmarillo = new System.Windows.Forms.PictureBox();
            this.pbCaballeroVerde = new System.Windows.Forms.PictureBox();
            this.pbTablero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTablero)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstado
            // 
            this.lbEstado.FormattingEnabled = true;
            this.lbEstado.Location = new System.Drawing.Point(12, 13);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(309, 355);
            this.lbEstado.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.Location = new System.Drawing.Point(35, 518);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(258, 53);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // pbCaballeroAzul
            // 
            this.pbCaballeroAzul.BackColor = System.Drawing.Color.Transparent;
            this.pbCaballeroAzul.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroAzul;
            this.pbCaballeroAzul.Location = new System.Drawing.Point(367, 209);
            this.pbCaballeroAzul.Name = "pbCaballeroAzul";
            this.pbCaballeroAzul.Size = new System.Drawing.Size(39, 38);
            this.pbCaballeroAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballeroAzul.TabIndex = 6;
            this.pbCaballeroAzul.TabStop = false;
            // 
            // pbCaballeroRojo
            // 
            this.pbCaballeroRojo.BackColor = System.Drawing.Color.Transparent;
            this.pbCaballeroRojo.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroRojo;
            this.pbCaballeroRojo.Location = new System.Drawing.Point(344, 209);
            this.pbCaballeroRojo.Name = "pbCaballeroRojo";
            this.pbCaballeroRojo.Size = new System.Drawing.Size(39, 38);
            this.pbCaballeroRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballeroRojo.TabIndex = 5;
            this.pbCaballeroRojo.TabStop = false;
            // 
            // pbCaballeroAmarillo
            // 
            this.pbCaballeroAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.pbCaballeroAmarillo.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroAmarillo;
            this.pbCaballeroAmarillo.Location = new System.Drawing.Point(389, 209);
            this.pbCaballeroAmarillo.Name = "pbCaballeroAmarillo";
            this.pbCaballeroAmarillo.Size = new System.Drawing.Size(39, 38);
            this.pbCaballeroAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballeroAmarillo.TabIndex = 4;
            this.pbCaballeroAmarillo.TabStop = false;
            // 
            // pbCaballeroVerde
            // 
            this.pbCaballeroVerde.BackColor = System.Drawing.Color.Transparent;
            this.pbCaballeroVerde.Image = global::JuegoCaballerosCalabozosDragones.Properties.Resources.caballeroVerde;
            this.pbCaballeroVerde.Location = new System.Drawing.Point(330, 209);
            this.pbCaballeroVerde.Name = "pbCaballeroVerde";
            this.pbCaballeroVerde.Size = new System.Drawing.Size(39, 38);
            this.pbCaballeroVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaballeroVerde.TabIndex = 3;
            this.pbCaballeroVerde.TabStop = false;
            // 
            // pbTablero
            // 
            this.pbTablero.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.Tablero;
            this.pbTablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbTablero.Image = ((System.Drawing.Image)(resources.GetObject("pbTablero.Image")));
            this.pbTablero.Location = new System.Drawing.Point(327, 13);
            this.pbTablero.Name = "pbTablero";
            this.pbTablero.Size = new System.Drawing.Size(1034, 592);
            this.pbTablero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTablero.TabIndex = 2;
            this.pbTablero.TabStop = false;
            // 
            // FormTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 615);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.pbCaballeroAzul);
            this.Controls.Add(this.pbCaballeroRojo);
            this.Controls.Add(this.pbCaballeroAmarillo);
            this.Controls.Add(this.pbCaballeroVerde);
            this.Controls.Add(this.pbTablero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormTablero";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablero";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballeroVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTablero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbTablero;
        public System.Windows.Forms.ListBox lbEstado;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.PictureBox pbCaballeroVerde;
        public System.Windows.Forms.PictureBox pbCaballeroAmarillo;
        public System.Windows.Forms.PictureBox pbCaballeroRojo;
        public System.Windows.Forms.PictureBox pbCaballeroAzul;
    }
}