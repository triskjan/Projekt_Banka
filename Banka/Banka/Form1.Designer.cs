namespace Banka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bVkladyVybery = new System.Windows.Forms.Button();
            this.bUpravKlienta = new System.Windows.Forms.Button();
            this.bOdstranKlienta = new System.Windows.Forms.Button();
            this.bPridatKlienta = new System.Windows.Forms.Button();
            this.lbKlienti = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bVkladyVybery);
            this.groupBox1.Controls.Add(this.bUpravKlienta);
            this.groupBox1.Controls.Add(this.bOdstranKlienta);
            this.groupBox1.Controls.Add(this.bPridatKlienta);
            this.groupBox1.Controls.Add(this.lbKlienti);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klienti";
            // 
            // bVkladyVybery
            // 
            this.bVkladyVybery.Location = new System.Drawing.Point(6, 159);
            this.bVkladyVybery.Name = "bVkladyVybery";
            this.bVkladyVybery.Size = new System.Drawing.Size(120, 23);
            this.bVkladyVybery.TabIndex = 2;
            this.bVkladyVybery.Text = "Vklady/výběry";
            this.bVkladyVybery.UseVisualStyleBackColor = true;
            this.bVkladyVybery.Click += new System.EventHandler(this.bVkladyVybery_Click);
            // 
            // bUpravKlienta
            // 
            this.bUpravKlienta.Location = new System.Drawing.Point(6, 119);
            this.bUpravKlienta.Name = "bUpravKlienta";
            this.bUpravKlienta.Size = new System.Drawing.Size(120, 23);
            this.bUpravKlienta.TabIndex = 1;
            this.bUpravKlienta.Text = "&Upravit klienta";
            this.bUpravKlienta.UseVisualStyleBackColor = true;
            this.bUpravKlienta.Click += new System.EventHandler(this.bUpravKlienta_Click);
            // 
            // bOdstranKlienta
            // 
            this.bOdstranKlienta.Location = new System.Drawing.Point(6, 80);
            this.bOdstranKlienta.Name = "bOdstranKlienta";
            this.bOdstranKlienta.Size = new System.Drawing.Size(120, 23);
            this.bOdstranKlienta.TabIndex = 1;
            this.bOdstranKlienta.Text = "&Odstranit klienta";
            this.bOdstranKlienta.UseVisualStyleBackColor = true;
            this.bOdstranKlienta.Click += new System.EventHandler(this.bOdstranKlienta_Click);
            // 
            // bPridatKlienta
            // 
            this.bPridatKlienta.Location = new System.Drawing.Point(6, 41);
            this.bPridatKlienta.Name = "bPridatKlienta";
            this.bPridatKlienta.Size = new System.Drawing.Size(120, 23);
            this.bPridatKlienta.TabIndex = 1;
            this.bPridatKlienta.Text = "&Přidat klienta";
            this.bPridatKlienta.UseVisualStyleBackColor = true;
            this.bPridatKlienta.Click += new System.EventHandler(this.bPridejKlienta_Click);
            // 
            // lbKlienti
            // 
            this.lbKlienti.FormattingEnabled = true;
            this.lbKlienti.Location = new System.Drawing.Point(132, 19);
            this.lbKlienti.Name = "lbKlienti";
            this.lbKlienti.Size = new System.Drawing.Size(142, 342);
            this.lbKlienti.TabIndex = 0;
            this.lbKlienti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbKlienti_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 387);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Banka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bUpravKlienta;
        private System.Windows.Forms.Button bOdstranKlienta;
        private System.Windows.Forms.Button bPridatKlienta;
        private System.Windows.Forms.ListBox lbKlienti;
        private System.Windows.Forms.Button bVkladyVybery;
    }
}

