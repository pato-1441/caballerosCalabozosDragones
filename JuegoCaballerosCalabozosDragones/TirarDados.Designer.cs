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
            this.SuspendLayout();
            // 
            // btnTirarDados
            // 
            this.btnTirarDados.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTirarDados.Location = new System.Drawing.Point(-4, -1);
            this.btnTirarDados.Name = "btnTirarDados";
            this.btnTirarDados.Size = new System.Drawing.Size(199, 131);
            this.btnTirarDados.TabIndex = 0;
            this.btnTirarDados.Text = "TIRAR DADOS";
            this.btnTirarDados.UseVisualStyleBackColor = true;
            // 
            // TirarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 125);
            this.Controls.Add(this.btnTirarDados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TirarDados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TirarDados";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnTirarDados;
    }
}