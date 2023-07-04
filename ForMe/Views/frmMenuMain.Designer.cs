namespace ForMe
{
    partial class frmMenuMain
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
            btnMusicas = new Button();
            SuspendLayout();
            // 
            // btnMusicas
            // 
            btnMusicas.Location = new Point(164, 12);
            btnMusicas.Name = "btnMusicas";
            btnMusicas.Size = new Size(79, 33);
            btnMusicas.TabIndex = 0;
            btnMusicas.Text = "🎵";
            btnMusicas.UseVisualStyleBackColor = true;
            btnMusicas.Click += button1_Click;
            // 
            // frmMenuMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 184);
            Controls.Add(btnMusicas);
            Name = "frmMenuMain";
            Text = "fmrMenuMain";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnMusicas;
    }
}