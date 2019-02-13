namespace RedisPublisher
{
    partial class Publicacao
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
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.LblHistorico = new System.Windows.Forms.Label();
            this.LblMensagem = new System.Windows.Forms.Label();
            this.TxtHistorico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.Location = new System.Drawing.Point(12, 273);
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(265, 20);
            this.TxtMensagem.TabIndex = 0;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(287, 270);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 1;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // LblHistorico
            // 
            this.LblHistorico.AutoSize = true;
            this.LblHistorico.Location = new System.Drawing.Point(12, 25);
            this.LblHistorico.Name = "LblHistorico";
            this.LblHistorico.Size = new System.Drawing.Size(48, 13);
            this.LblHistorico.TabIndex = 3;
            this.LblHistorico.Text = "Histórico";
            // 
            // LblMensagem
            // 
            this.LblMensagem.AutoSize = true;
            this.LblMensagem.Location = new System.Drawing.Point(12, 257);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(59, 13);
            this.LblMensagem.TabIndex = 4;
            this.LblMensagem.Text = "Mensagem";
            // 
            // TxtHistorico
            // 
            this.TxtHistorico.Enabled = false;
            this.TxtHistorico.Location = new System.Drawing.Point(15, 41);
            this.TxtHistorico.Multiline = true;
            this.TxtHistorico.Name = "TxtHistorico";
            this.TxtHistorico.Size = new System.Drawing.Size(347, 199);
            this.TxtHistorico.TabIndex = 5;
            // 
            // Publicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 305);
            this.Controls.Add(this.TxtHistorico);
            this.Controls.Add(this.LblMensagem);
            this.Controls.Add(this.LblHistorico);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtMensagem);
            this.Name = "Publicacao";
            this.Text = "Publicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label LblHistorico;
        private System.Windows.Forms.Label LblMensagem;
        private System.Windows.Forms.TextBox TxtHistorico;
    }
}

