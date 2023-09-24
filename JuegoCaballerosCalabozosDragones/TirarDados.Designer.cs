namespace JuegoCaballerosCalabozosDragones
{
    partial class TirarDados
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
            this.btnTirarDados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTirarDados
            // 
            this.btnTirarDados.BackColor = System.Drawing.Color.Transparent;
            this.btnTirarDados.BackgroundImage = global::JuegoCaballerosCalabozosDragones.Properties.Resources.dados;
            this.btnTirarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTirarDados.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTirarDados.Location = new System.Drawing.Point(11, 11);
            this.btnTirarDados.Margin = new System.Windows.Forms.Padding(2);
            this.btnTirarDados.Name = "btnTirarDados";
            this.btnTirarDados.Size = new System.Drawing.Size(259, 99);
            this.btnTirarDados.TabIndex = 0;
            this.btnTirarDados.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(11, 130);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(258, 53);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // TirarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 195);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTirarDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 600);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TirarDados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TirarDados";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnTirarDados;
        public System.Windows.Forms.Button btnSalir;
    }
}