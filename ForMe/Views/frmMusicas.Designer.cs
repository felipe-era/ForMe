namespace ForMe.Views
{
    partial class frmMusicas
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
            btnTryHttp = new Button();
            rtbResponse = new RichTextBox();
            btnTryHttp2 = new Button();
            btnMusicTudo = new Button();
            btnMusicaGeneros = new Button();
            btnOrdemNome = new Button();
            button1 = new Button();
            txtTexto = new TextBox();
            SuspendLayout();
            // 
            // btnTryHttp
            // 
            btnTryHttp.Location = new Point(27, 11);
            btnTryHttp.Name = "btnTryHttp";
            btnTryHttp.Size = new Size(106, 23);
            btnTryHttp.TabIndex = 0;
            btnTryHttp.Text = "Api / HttpMode";
            btnTryHttp.UseVisualStyleBackColor = true;
            btnTryHttp.Click += btnTryHttp_Click;
            // 
            // rtbResponse
            // 
            rtbResponse.BackColor = SystemColors.WindowText;
            rtbResponse.ForeColor = SystemColors.Menu;
            rtbResponse.Location = new Point(27, 69);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.Size = new Size(538, 312);
            rtbResponse.TabIndex = 1;
            rtbResponse.Text = "";
            // 
            // btnTryHttp2
            // 
            btnTryHttp2.Location = new Point(27, 40);
            btnTryHttp2.Name = "btnTryHttp2";
            btnTryHttp2.Size = new Size(106, 23);
            btnTryHttp2.TabIndex = 2;
            btnTryHttp2.Text = "Api / String";
            btnTryHttp2.UseVisualStyleBackColor = true;
            btnTryHttp2.Click += btnTryHttp2_Click;
            // 
            // btnMusicTudo
            // 
            btnMusicTudo.Location = new Point(206, 12);
            btnMusicTudo.Name = "btnMusicTudo";
            btnMusicTudo.Size = new Size(106, 23);
            btnMusicTudo.TabIndex = 3;
            btnMusicTudo.Text = "Api / Tudo";
            btnMusicTudo.UseVisualStyleBackColor = true;
            btnMusicTudo.Click += btnMusicGeneros_ClickAsync;
            // 
            // btnMusicaGeneros
            // 
            btnMusicaGeneros.Location = new Point(206, 41);
            btnMusicaGeneros.Name = "btnMusicaGeneros";
            btnMusicaGeneros.Size = new Size(106, 23);
            btnMusicaGeneros.TabIndex = 4;
            btnMusicaGeneros.Text = "Api / Generos";
            btnMusicaGeneros.UseVisualStyleBackColor = true;
            btnMusicaGeneros.Click += btnMusicaGeneros_ClickAsync;
            // 
            // btnOrdemNome
            // 
            btnOrdemNome.Location = new Point(347, 12);
            btnOrdemNome.Name = "btnOrdemNome";
            btnOrdemNome.Size = new Size(106, 23);
            btnOrdemNome.TabIndex = 5;
            btnOrdemNome.Text = "Api / Ord. Nome";
            btnOrdemNome.UseVisualStyleBackColor = true;
            btnOrdemNome.Click += btnOrdemNome_Click;
            // 
            // button1
            // 
            button1.Location = new Point(347, 40);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 6;
            button1.Text = "Api / Filtro Musicas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(465, 40);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(100, 23);
            txtTexto.TabIndex = 7;
            // 
            // frmMusicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(592, 404);
            Controls.Add(txtTexto);
            Controls.Add(button1);
            Controls.Add(btnOrdemNome);
            Controls.Add(btnMusicaGeneros);
            Controls.Add(btnMusicTudo);
            Controls.Add(btnTryHttp2);
            Controls.Add(rtbResponse);
            Controls.Add(btnTryHttp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMusicas";
            Text = "frmMusicas";
            Load += frmMusicas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTryHttp;
        private RichTextBox rtbResponse;
        private Button btnTryHttp2;
        private Button btnMusicTudo;
        private Button btnMusicaGeneros;
        private Button btnOrdemNome;
        private Button button1;
        private TextBox txtTexto;
    }
}