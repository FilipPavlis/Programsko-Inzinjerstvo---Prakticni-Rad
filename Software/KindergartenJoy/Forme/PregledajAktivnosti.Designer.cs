﻿
namespace KindergartenJoy.Forme
{
    partial class PregledajAktivnosti
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
            this.dgvAktivnosti = new System.Windows.Forms.DataGridView();
            this.btnDodajAktivnost = new System.Windows.Forms.Button();
            this.btnObrisiAktivnost = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPošaljiNaMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivnosti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAktivnosti
            // 
            this.dgvAktivnosti.AllowUserToAddRows = false;
            this.dgvAktivnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivnosti.Location = new System.Drawing.Point(17, 12);
            this.dgvAktivnosti.Name = "dgvAktivnosti";
            this.dgvAktivnosti.Size = new System.Drawing.Size(668, 236);
            this.dgvAktivnosti.TabIndex = 0;
            // 
            // btnDodajAktivnost
            // 
            this.btnDodajAktivnost.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodajAktivnost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajAktivnost.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAktivnost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodajAktivnost.Location = new System.Drawing.Point(387, 254);
            this.btnDodajAktivnost.Name = "btnDodajAktivnost";
            this.btnDodajAktivnost.Size = new System.Drawing.Size(146, 42);
            this.btnDodajAktivnost.TabIndex = 9;
            this.btnDodajAktivnost.Text = "DODAJ AKTIVNOST";
            this.btnDodajAktivnost.UseVisualStyleBackColor = false;
            this.btnDodajAktivnost.Click += new System.EventHandler(this.btnDodajAktivnost_Click);
            // 
            // btnObrisiAktivnost
            // 
            this.btnObrisiAktivnost.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObrisiAktivnost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiAktivnost.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiAktivnost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnObrisiAktivnost.Location = new System.Drawing.Point(539, 253);
            this.btnObrisiAktivnost.Name = "btnObrisiAktivnost";
            this.btnObrisiAktivnost.Size = new System.Drawing.Size(146, 42);
            this.btnObrisiAktivnost.TabIndex = 10;
            this.btnObrisiAktivnost.Text = "OBRIŠI AKTIVNOST";
            this.btnObrisiAktivnost.UseVisualStyleBackColor = false;
            this.btnObrisiAktivnost.Click += new System.EventHandler(this.btnObrisiAktivnost_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExport.Location = new System.Drawing.Point(235, 254);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(146, 42);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "EXPORT U PDF";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPošaljiNaMail
            // 
            this.btnPošaljiNaMail.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPošaljiNaMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPošaljiNaMail.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPošaljiNaMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPošaljiNaMail.Location = new System.Drawing.Point(17, 254);
            this.btnPošaljiNaMail.Name = "btnPošaljiNaMail";
            this.btnPošaljiNaMail.Size = new System.Drawing.Size(212, 43);
            this.btnPošaljiNaMail.TabIndex = 12;
            this.btnPošaljiNaMail.Text = "POŠALJI AKTIVNOSTI NA MAIL";
            this.btnPošaljiNaMail.UseVisualStyleBackColor = false;
            this.btnPošaljiNaMail.Click += new System.EventHandler(this.btnPošaljiNaMail_Click);
            // 
            // PregledajAktivnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(697, 308);
            this.Controls.Add(this.btnPošaljiNaMail);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnObrisiAktivnost);
            this.Controls.Add(this.btnDodajAktivnost);
            this.Controls.Add(this.dgvAktivnosti);
            this.Name = "PregledajAktivnosti";
            this.Text = "Pregledaj aktivnosti";
            this.Load += new System.EventHandler(this.PregledajAktivnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivnosti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAktivnosti;
        private System.Windows.Forms.Button btnDodajAktivnost;
        private System.Windows.Forms.Button btnObrisiAktivnost;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPošaljiNaMail;
    }
}