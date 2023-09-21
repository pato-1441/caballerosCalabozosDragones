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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbAmarillo = new System.Windows.Forms.RadioButton();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(15, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(15, 28);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(165, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color:";
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(15, 72);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(47, 17);
            this.rbRojo.TabIndex = 4;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Location = new System.Drawing.Point(15, 95);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(45, 17);
            this.rbAzul.TabIndex = 5;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            // 
            // rbAmarillo
            // 
            this.rbAmarillo.AutoSize = true;
            this.rbAmarillo.Location = new System.Drawing.Point(95, 72);
            this.rbAmarillo.Name = "rbAmarillo";
            this.rbAmarillo.Size = new System.Drawing.Size(61, 17);
            this.rbAmarillo.TabIndex = 6;
            this.rbAmarillo.TabStop = true;
            this.rbAmarillo.Text = "Amarillo";
            this.rbAmarillo.UseVisualStyleBackColor = true;
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Location = new System.Drawing.Point(95, 95);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(53, 17);
            this.rbVerde.TabIndex = 7;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            // 
            // FormNombreJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 178);
            this.Controls.Add(this.rbVerde);
            this.Controls.Add(this.rbAmarillo);
            this.Controls.Add(this.rbAzul);
            this.Controls.Add(this.rbRojo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormNombreJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNombreJugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rbRojo;
        public System.Windows.Forms.RadioButton rbAzul;
        public System.Windows.Forms.RadioButton rbAmarillo;
        public System.Windows.Forms.RadioButton rbVerde;
    }
}