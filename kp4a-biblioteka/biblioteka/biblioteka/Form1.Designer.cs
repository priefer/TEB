namespace biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStruktura = new System.Windows.Forms.Button();
            this.btnDodajKsiazke = new System.Windows.Forms.Button();
            this.btnDodajCzytelnika = new System.Windows.Forms.Button();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // btnStruktura
            // 
            this.btnStruktura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStruktura.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnStruktura.FlatAppearance.BorderSize = 0;
            this.btnStruktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStruktura.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStruktura.Location = new System.Drawing.Point(644, 9);
            this.btnStruktura.Name = "btnStruktura";
            this.btnStruktura.Size = new System.Drawing.Size(144, 41);
            this.btnStruktura.TabIndex = 1;
            this.btnStruktura.Text = "Struktura";
            this.btnStruktura.UseVisualStyleBackColor = false;
            this.btnStruktura.Click += new System.EventHandler(this.btnStruktura_Click);
            // 
            // btnDodajKsiazke
            // 
            this.btnDodajKsiazke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajKsiazke.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDodajKsiazke.Location = new System.Drawing.Point(191, 58);
            this.btnDodajKsiazke.Name = "btnDodajKsiazke";
            this.btnDodajKsiazke.Size = new System.Drawing.Size(144, 41);
            this.btnDodajKsiazke.TabIndex = 2;
            this.btnDodajKsiazke.Text = "Dodaj książkę";
            this.btnDodajKsiazke.UseVisualStyleBackColor = true;
            this.btnDodajKsiazke.Click += new System.EventHandler(this.btnDodajKsiazke_Click);
            // 
            // btnDodajCzytelnika
            // 
            this.btnDodajCzytelnika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajCzytelnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDodajCzytelnika.Location = new System.Drawing.Point(20, 58);
            this.btnDodajCzytelnika.Name = "btnDodajCzytelnika";
            this.btnDodajCzytelnika.Size = new System.Drawing.Size(165, 41);
            this.btnDodajCzytelnika.TabIndex = 3;
            this.btnDodajCzytelnika.Text = "Dodaj czytelnika";
            this.btnDodajCzytelnika.UseVisualStyleBackColor = true;
            this.btnDodajCzytelnika.Click += new System.EventHandler(this.btnDodajCzytelnika_Click);
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWypozycz.FlatAppearance.BorderSize = 0;
            this.btnWypozycz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnWypozycz.Location = new System.Drawing.Point(341, 58);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(144, 41);
            this.btnWypozycz.TabIndex = 4;
            this.btnWypozycz.Text = "Wypożycz";
            this.btnWypozycz.UseVisualStyleBackColor = true;
            this.btnWypozycz.Click += new System.EventHandler(this.btnWypozycz_Click);
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
            this.btnZamknij.TabIndex = 5;
            this.btnZamknij.Text = "ZAMKNIJ";
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnWypozycz);
            this.Controls.Add(this.btnDodajCzytelnika);
            this.Controls.Add(this.btnDodajKsiazke);
            this.Controls.Add(this.btnStruktura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bibliotczan v3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStruktura;
        private System.Windows.Forms.Button btnDodajKsiazke;
        private System.Windows.Forms.Button btnDodajCzytelnika;
        private System.Windows.Forms.Button btnWypozycz;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

