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
            this.btnJugar.Location = new System.Drawing.Point(345, 244);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(89, 49);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.BackColor = System.Drawing.Color.Transparent;
            this.rbBasico.Checked = true;
            this.rbBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBasico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbBasico.Location = new System.Drawing.Point(310, 329);
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
            this.rbIntermedio.Location = new System.Drawing.Point(394, 329);
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
            this.rbExperto.Location = new System.Drawing.Point(505, 329);
            this.rbExperto.Name = "rbExperto";
            this.rbExperto.Size = new System.Drawing.Size(84, 22);
            this.rbExperto.TabIndex = 3;
            this.rbExperto.Text = "Experto";
            this.rbExperto.UseVisualStyleBackColor = false;
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(452, 244);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(89, 49);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(406, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(345, 399);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(196, 37);
            this.btnRanking.TabIndex = 6;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
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

