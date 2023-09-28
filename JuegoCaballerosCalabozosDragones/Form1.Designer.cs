namespace JuegoCaballerosCalabozosDragones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnJugar = new System.Windows.Forms.Button();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbExperto = new System.Windows.Forms.RadioButton();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.botonJugar;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(32)))), ((int)(((byte)(1)))));
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Location = new System.Drawing.Point(309, 244);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(137, 94);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.BackColor = System.Drawing.Color.Transparent;
            this.rbBasico.Checked = true;
            this.rbBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBasico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbBasico.Location = new System.Drawing.Point(309, 335);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(78, 22);
            this.rbBasico.TabIndex = 1;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = false;
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.BackColor = System.Drawing.Color.Transparent;
            this.rbIntermedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIntermedio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbIntermedio.Location = new System.Drawing.Point(393, 335);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(105, 22);
            this.rbIntermedio.TabIndex = 2;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = false;
            // 
            // rbExperto
            // 
            this.rbExperto.AutoSize = true;
            this.rbExperto.BackColor = System.Drawing.Color.Transparent;
            this.rbExperto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExperto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbExperto.Location = new System.Drawing.Point(504, 335);
            this.rbExperto.Name = "rbExperto";
            this.rbExperto.Size = new System.Drawing.Size(84, 22);
            this.rbExperto.TabIndex = 3;
            this.rbExperto.Text = "Experto";
            this.rbExperto.UseVisualStyleBackColor = false;
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.Transparent;
            this.btnDemo.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.botonDemo;
            this.btnDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDemo.FlatAppearance.BorderSize = 0;
            this.btnDemo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(32)))), ((int)(((byte)(1)))));
            this.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo.Location = new System.Drawing.Point(452, 244);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(136, 94);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.UseVisualStyleBackColor = false;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.botonCDC;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(32)))), ((int)(((byte)(1)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(377, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 89);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.Transparent;
            this.btnRanking.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.botonRanking;
            this.btnRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRanking.FlatAppearance.BorderSize = 0;
            this.btnRanking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(32)))), ((int)(((byte)(1)))));
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Location = new System.Drawing.Point(377, 363);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(140, 89);
            this.btnRanking.TabIndex = 6;
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.Mesa_de_trabajo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 537);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.rbExperto);
            this.Controls.Add(this.rbIntermedio);
            this.Controls.Add(this.rbBasico);
            this.Controls.Add(this.btnJugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caballeros Dragones y Calabozos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.RadioButton rbExperto;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRanking;
    }
}

