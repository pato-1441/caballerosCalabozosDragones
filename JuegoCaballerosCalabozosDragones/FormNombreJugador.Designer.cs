namespace JuegoCaballerosCalabozosDragones
{
    partial class FormNombreJugador
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbAmarillo = new System.Windows.Forms.RadioButton();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.nudCantJugadores = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.botonAceptar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 98);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(18, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(165, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.BackColor = System.Drawing.Color.Transparent;
            this.rbRojo.Checked = true;
            this.rbRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRojo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbRojo.Location = new System.Drawing.Point(18, 127);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(59, 21);
            this.rbRojo.TabIndex = 3;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = false;
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.BackColor = System.Drawing.Color.Transparent;
            this.rbAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAzul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbAzul.Location = new System.Drawing.Point(18, 150);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(57, 21);
            this.rbAzul.TabIndex = 5;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = false;
            // 
            // rbAmarillo
            // 
            this.rbAmarillo.AutoSize = true;
            this.rbAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.rbAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAmarillo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbAmarillo.Location = new System.Drawing.Point(98, 127);
            this.rbAmarillo.Name = "rbAmarillo";
            this.rbAmarillo.Size = new System.Drawing.Size(84, 21);
            this.rbAmarillo.TabIndex = 4;
            this.rbAmarillo.Text = "Amarillo";
            this.rbAmarillo.UseVisualStyleBackColor = false;
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.BackColor = System.Drawing.Color.Transparent;
            this.rbVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVerde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbVerde.Location = new System.Drawing.Point(98, 150);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(69, 21);
            this.rbVerde.TabIndex = 6;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = false;
            // 
            // nudCantJugadores
            // 
            this.nudCantJugadores.Location = new System.Drawing.Point(18, 82);
            this.nudCantJugadores.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCantJugadores.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantJugadores.Name = "nudCantJugadores";
            this.nudCantJugadores.Size = new System.Drawing.Size(120, 20);
            this.nudCantJugadores.TabIndex = 2;
            this.nudCantJugadores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // FormNombreJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.fondoNombreJugador;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(195, 238);
            this.Controls.Add(this.nudCantJugadores);
            this.Controls.Add(this.rbVerde);
            this.Controls.Add(this.rbAmarillo);
            this.Controls.Add(this.rbAzul);
            this.Controls.Add(this.rbRojo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNombreJugador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Partida";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.RadioButton rbRojo;
        public System.Windows.Forms.RadioButton rbAzul;
        public System.Windows.Forms.RadioButton rbAmarillo;
        public System.Windows.Forms.RadioButton rbVerde;
        public System.Windows.Forms.NumericUpDown nudCantJugadores;
    }
}