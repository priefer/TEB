namespace biblioteka
{
    partial class frmDodajKsiazke
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
            // frmDodajKsiazke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZamknij);
            this.Name = "frmDodajKsiazke";
            this.Text = "Bibliotczan v3";
            this.Load += new System.EventHandler(this.frmDodajKsiazke_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZamknij;
    }
}