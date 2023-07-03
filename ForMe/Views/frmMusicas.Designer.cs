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
            SuspendLayout();
            // 
            // btnTryHttp
            // 
            btnTryHttp.Location = new Point(36, 12);
            btnTryHttp.Name = "btnTryHttp";
            btnTryHttp.Size = new Size(106, 23);
            btnTryHttp.TabIndex = 0;
            btnTryHttp.Text = "Api / HttpMode";
            btnTryHttp.UseVisualStyleBackColor = true;
            btnTryHttp.Click += btnTryHttp_Click;
            // 
            // rtbResponse
            // 
            rtbResponse.Location = new Point(36, 69);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.Size = new Size(410, 267);
            rtbResponse.TabIndex = 1;
            rtbResponse.Text = "";
            // 
            // btnTryHttp2
            // 
            btnTryHttp2.Location = new Point(36, 40);
            btnTryHttp2.Name = "btnTryHttp2";
            btnTryHttp2.Size = new Size(106, 23);
            btnTryHttp2.TabIndex = 2;
            btnTryHttp2.Text = "Api / String";
            btnTryHttp2.UseVisualStyleBackColor = true;
            btnTryHttp2.Click += btnTryHttp2_Click;
            // 
            // frmMusicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTryHttp2);
            Controls.Add(rtbResponse);
            Controls.Add(btnTryHttp);
            Name = "frmMusicas";
            Text = "frmMusicas";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTryHttp;
        private RichTextBox rtbResponse;
        private Button btnTryHttp2;
    }
}