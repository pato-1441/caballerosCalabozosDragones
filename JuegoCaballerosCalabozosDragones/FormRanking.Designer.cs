namespace JuegoCaballerosCalabozosDragones
{
    partial class FormRanking
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
            this.lbRanking = new System.Windows.Forms.ListBox();
            this.lRankingJugadores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRanking
            // 
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.Location = new System.Drawing.Point(12, 43);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(225, 290);
            this.lbRanking.TabIndex = 0;
            // 
            // lRankingJugadores
            // 
            this.lRankingJugadores.AutoSize = true;
            this.lRankingJugadores.Location = new System.Drawing.Point(12, 18);
            this.lRankingJugadores.Name = "lRankingJugadores";
            this.lRankingJugadores.Size = new System.Drawing.Size(111, 13);
            this.lRankingJugadores.TabIndex = 1;
            this.lRankingJugadores.Text = "Ranking de jugadores";
            // 
            // FormRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 348);
            this.Controls.Add(this.lRankingJugadores);
            this.Controls.Add(this.lbRanking);
            this.Name = "FormRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lRankingJugadores;
        public System.Windows.Forms.ListBox lbRanking;
    }
}