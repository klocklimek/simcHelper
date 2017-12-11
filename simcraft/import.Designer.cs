namespace simcraft
{
    partial class import
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
            this.ImportTextBox = new System.Windows.Forms.RichTextBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportTextBox
            // 
            this.ImportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportTextBox.Location = new System.Drawing.Point(12, 12);
            this.ImportTextBox.Multiline = true;
            this.ImportTextBox.Name = "ImportTextBox";
            this.ImportTextBox.Size = new System.Drawing.Size(260, 205);
            this.ImportTextBox.TabIndex = 0;
            // 
            // importBtn
            // 
            this.importBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importBtn.Location = new System.Drawing.Point(12, 226);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(260, 23);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "Importuj";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.ImportTextBox);
            this.Name = "import";
            this.Text = "import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ImportTextBox;
        private System.Windows.Forms.Button importBtn;
    }
}