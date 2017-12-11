namespace simcraft
{
    partial class Form1
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
            this.btn_importujEq = new System.Windows.Forms.Button();
            this.list_doWyboru = new System.Windows.Forms.ListBox();
            this.listaPrzedmiotow = new System.Windows.Forms.CheckedListBox();
            this.btn_generuj = new System.Windows.Forms.Button();
            this.btn_modyfApl = new System.Windows.Forms.Button();
            this.btn_usunItem = new System.Windows.Forms.Button();
            this.btn_wczytaj = new System.Windows.Forms.Button();
            this.btn_Zapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_importujEq
            // 
            this.btn_importujEq.Location = new System.Drawing.Point(12, 233);
            this.btn_importujEq.Name = "btn_importujEq";
            this.btn_importujEq.Size = new System.Drawing.Size(107, 23);
            this.btn_importujEq.TabIndex = 0;
            this.btn_importujEq.Text = "Importuj EQ";
            this.btn_importujEq.UseVisualStyleBackColor = true;
            this.btn_importujEq.Click += new System.EventHandler(this.btn_importujEq_Click);
            // 
            // list_doWyboru
            // 
            this.list_doWyboru.FormattingEnabled = true;
            this.list_doWyboru.Location = new System.Drawing.Point(12, 12);
            this.list_doWyboru.Name = "list_doWyboru";
            this.list_doWyboru.Size = new System.Drawing.Size(107, 186);
            this.list_doWyboru.TabIndex = 1;
            this.list_doWyboru.SelectedIndexChanged += new System.EventHandler(this.list_doWyboru_SelectedIndexChanged);
            // 
            // listaPrzedmiotow
            // 
            this.listaPrzedmiotow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaPrzedmiotow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listaPrzedmiotow.FormattingEnabled = true;
            this.listaPrzedmiotow.Location = new System.Drawing.Point(125, 12);
            this.listaPrzedmiotow.Name = "listaPrzedmiotow";
            this.listaPrzedmiotow.Size = new System.Drawing.Size(378, 364);
            this.listaPrzedmiotow.TabIndex = 2;
            this.listaPrzedmiotow.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listaPrzedmiotow_ItemCheck);
            this.listaPrzedmiotow.SelectedIndexChanged += new System.EventHandler(this.listaPrzedmiotow_SelectedIndexChanged);
            // 
            // btn_generuj
            // 
            this.btn_generuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_generuj.Location = new System.Drawing.Point(12, 353);
            this.btn_generuj.Name = "btn_generuj";
            this.btn_generuj.Size = new System.Drawing.Size(107, 23);
            this.btn_generuj.TabIndex = 3;
            this.btn_generuj.Text = "Generuj";
            this.btn_generuj.UseVisualStyleBackColor = true;
            this.btn_generuj.Click += new System.EventHandler(this.btn_generuj_Click);
            // 
            // btn_modyfApl
            // 
            this.btn_modyfApl.Location = new System.Drawing.Point(13, 204);
            this.btn_modyfApl.Name = "btn_modyfApl";
            this.btn_modyfApl.Size = new System.Drawing.Size(106, 23);
            this.btn_modyfApl.TabIndex = 4;
            this.btn_modyfApl.Text = "Modyfikuj APL";
            this.btn_modyfApl.UseVisualStyleBackColor = true;
            this.btn_modyfApl.Click += new System.EventHandler(this.btn_modyfApl_Click);
            // 
            // btn_usunItem
            // 
            this.btn_usunItem.Location = new System.Drawing.Point(13, 262);
            this.btn_usunItem.Name = "btn_usunItem";
            this.btn_usunItem.Size = new System.Drawing.Size(106, 23);
            this.btn_usunItem.TabIndex = 5;
            this.btn_usunItem.Text = "Usuń";
            this.btn_usunItem.UseVisualStyleBackColor = true;
            this.btn_usunItem.Click += new System.EventHandler(this.btn_usunItem_Click);
            // 
            // btn_wczytaj
            // 
            this.btn_wczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_wczytaj.Location = new System.Drawing.Point(13, 291);
            this.btn_wczytaj.Name = "btn_wczytaj";
            this.btn_wczytaj.Size = new System.Drawing.Size(106, 23);
            this.btn_wczytaj.TabIndex = 6;
            this.btn_wczytaj.Text = "Wczytaj";
            this.btn_wczytaj.UseVisualStyleBackColor = true;
            this.btn_wczytaj.Click += new System.EventHandler(this.btn_wczytaj_Click);
            // 
            // btn_Zapisz
            // 
            this.btn_Zapisz.Enabled = false;
            this.btn_Zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Zapisz.Location = new System.Drawing.Point(13, 320);
            this.btn_Zapisz.Name = "btn_Zapisz";
            this.btn_Zapisz.Size = new System.Drawing.Size(106, 23);
            this.btn_Zapisz.TabIndex = 7;
            this.btn_Zapisz.Text = "Zapisz";
            this.btn_Zapisz.UseVisualStyleBackColor = true;
            this.btn_Zapisz.Click += new System.EventHandler(this.btn_Zapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 377);
            this.Controls.Add(this.btn_Zapisz);
            this.Controls.Add(this.btn_wczytaj);
            this.Controls.Add(this.btn_usunItem);
            this.Controls.Add(this.btn_modyfApl);
            this.Controls.Add(this.btn_generuj);
            this.Controls.Add(this.listaPrzedmiotow);
            this.Controls.Add(this.list_doWyboru);
            this.Controls.Add(this.btn_importujEq);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Autor: klocklimek-SteamwheedleCartel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_importujEq;
        private System.Windows.Forms.ListBox list_doWyboru;
        private System.Windows.Forms.CheckedListBox listaPrzedmiotow;
        private System.Windows.Forms.Button btn_generuj;
        private System.Windows.Forms.Button btn_modyfApl;
        private System.Windows.Forms.Button btn_usunItem;
        private System.Windows.Forms.Button btn_wczytaj;
        private System.Windows.Forms.Button btn_Zapisz;
    }
}

