namespace biblioteka
{
    partial class frmTworzStrukture
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
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btn_add_tab_czyt = new System.Windows.Forms.Button();
            this.btn_add_tab_ksi = new System.Windows.Forms.Button();
            this.btn_add_tab_wypo = new System.Windows.Forms.Button();
            this.btn_usun_tab_wypo = new System.Windows.Forms.Button();
            this.btn_usun_tab_ksi = new System.Windows.Forms.Button();
            this.btn_usun_tab_czyt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnZamknij.Cursor = System.Windows.Forms.Cursors.No;
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnZamknij.ForeColor = System.Drawing.Color.Red;
            this.btnZamknij.Location = new System.Drawing.Point(644, 397);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(144, 41);
            this.btnZamknij.TabIndex = 6;
            this.btnZamknij.Text = "ZAMKNIJ";
            this.btnZamknij.UseVisualStyleBackColor = false;
            // 
            // btn_add_tab_czyt
            // 
            this.btn_add_tab_czyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_add_tab_czyt.Location = new System.Drawing.Point(71, 126);
            this.btn_add_tab_czyt.Name = "btn_add_tab_czyt";
            this.btn_add_tab_czyt.Size = new System.Drawing.Size(182, 54);
            this.btn_add_tab_czyt.TabIndex = 7;
            this.btn_add_tab_czyt.Text = "tblCzytelnicy";
            this.btn_add_tab_czyt.UseVisualStyleBackColor = true;
            this.btn_add_tab_czyt.Click += new System.EventHandler(this.btn_add_tab_czyt_Click);
            // 
            // btn_add_tab_ksi
            // 
            this.btn_add_tab_ksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_add_tab_ksi.Location = new System.Drawing.Point(71, 186);
            this.btn_add_tab_ksi.Name = "btn_add_tab_ksi";
            this.btn_add_tab_ksi.Size = new System.Drawing.Size(182, 54);
            this.btn_add_tab_ksi.TabIndex = 8;
            this.btn_add_tab_ksi.Text = "tblKsiazki";
            this.btn_add_tab_ksi.UseVisualStyleBackColor = true;
            // 
            // btn_add_tab_wypo
            // 
            this.btn_add_tab_wypo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_add_tab_wypo.Location = new System.Drawing.Point(71, 246);
            this.btn_add_tab_wypo.Name = "btn_add_tab_wypo";
            this.btn_add_tab_wypo.Size = new System.Drawing.Size(182, 54);
            this.btn_add_tab_wypo.TabIndex = 9;
            this.btn_add_tab_wypo.Text = "tblWypozycz";
            this.btn_add_tab_wypo.UseVisualStyleBackColor = true;
            // 
            // btn_usun_tab_wypo
            // 
            this.btn_usun_tab_wypo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_usun_tab_wypo.Location = new System.Drawing.Point(504, 246);
            this.btn_usun_tab_wypo.Name = "btn_usun_tab_wypo";
            this.btn_usun_tab_wypo.Size = new System.Drawing.Size(182, 54);
            this.btn_usun_tab_wypo.TabIndex = 12;
            this.btn_usun_tab_wypo.Text = "tblWypozycz";
            this.btn_usun_tab_wypo.UseVisualStyleBackColor = true;
            // 
            // btn_usun_tab_ksi
            // 
            this.btn_usun_tab_ksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_usun_tab_ksi.Location = new System.Drawing.Point(504, 186);
            this.btn_usun_tab_ksi.Name = "btn_usun_tab_ksi";
            this.btn_usun_tab_ksi.Size = new System.Drawing.Size(182, 54);
            this.btn_usun_tab_ksi.TabIndex = 11;
            this.btn_usun_tab_ksi.Text = "tblKsiazki";
            this.btn_usun_tab_ksi.UseVisualStyleBackColor = true;
            // 
            // btn_usun_tab_czyt
            // 
            this.btn_usun_tab_czyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_usun_tab_czyt.Location = new System.Drawing.Point(504, 126);
            this.btn_usun_tab_czyt.Name = "btn_usun_tab_czyt";
            this.btn_usun_tab_czyt.Size = new System.Drawing.Size(182, 54);
            this.btn_usun_tab_czyt.TabIndex = 10;
            this.btn_usun_tab_czyt.Text = "tblCzytelnicy";
            this.btn_usun_tab_czyt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tworzenie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(491, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuwanie";
            // 
            // frmTworzStrukture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_usun_tab_wypo);
            this.Controls.Add(this.btn_usun_tab_ksi);
            this.Controls.Add(this.btn_usun_tab_czyt);
            this.Controls.Add(this.btn_add_tab_wypo);
            this.Controls.Add(this.btn_add_tab_ksi);
            this.Controls.Add(this.btn_add_tab_czyt);
            this.Controls.Add(this.btnZamknij);
            this.Name = "frmTworzStrukture";
            this.Text = "Bibliotczan v3";
            this.Load += new System.EventHandler(this.frmTworzStrukture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btn_add_tab_czyt;
        private System.Windows.Forms.Button btn_add_tab_ksi;
        private System.Windows.Forms.Button btn_add_tab_wypo;
        private System.Windows.Forms.Button btn_usun_tab_wypo;
        private System.Windows.Forms.Button btn_usun_tab_ksi;
        private System.Windows.Forms.Button btn_usun_tab_czyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}