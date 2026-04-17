namespace Banka
{
    partial class Form_klient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrijmeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUzivatelskeJmeno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHeslo = new System.Windows.Forms.TextBox();
            this.lbUcty = new System.Windows.Forms.ListBox();
            this.bOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bVybrat = new System.Windows.Forms.Button();
            this.bVlozit = new System.Windows.Forms.Button();
            this.nudCastka = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudZustatek = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bOdstranitUcet = new System.Windows.Forms.Button();
            this.bPridatUcet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCastka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZustatek)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(6, 48);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(100, 20);
            this.tbJmeno.TabIndex = 1;
            this.tbJmeno.Text = "Jan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Příjmení";
            // 
            // tbPrijmeni
            // 
            this.tbPrijmeni.Location = new System.Drawing.Point(6, 97);
            this.tbPrijmeni.Name = "tbPrijmeni";
            this.tbPrijmeni.Size = new System.Drawing.Size(100, 20);
            this.tbPrijmeni.TabIndex = 1;
            this.tbPrijmeni.Text = "Tříska";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Uživatelské jméno";
            // 
            // tbUzivatelskeJmeno
            // 
            this.tbUzivatelskeJmeno.Location = new System.Drawing.Point(6, 146);
            this.tbUzivatelskeJmeno.Name = "tbUzivatelskeJmeno";
            this.tbUzivatelskeJmeno.Size = new System.Drawing.Size(100, 20);
            this.tbUzivatelskeJmeno.TabIndex = 1;
            this.tbUzivatelskeJmeno.Text = "triska";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Heslo";
            // 
            // tbHeslo
            // 
            this.tbHeslo.Location = new System.Drawing.Point(6, 195);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.PasswordChar = '*';
            this.tbHeslo.Size = new System.Drawing.Size(100, 20);
            this.tbHeslo.TabIndex = 1;
            this.tbHeslo.Text = "ssdfd";
            // 
            // lbUcty
            // 
            this.lbUcty.FormattingEnabled = true;
            this.lbUcty.Location = new System.Drawing.Point(6, 19);
            this.lbUcty.Name = "lbUcty";
            this.lbUcty.Size = new System.Drawing.Size(120, 134);
            this.lbUcty.TabIndex = 2;
            this.lbUcty.SelectedIndexChanged += new System.EventHandler(this.lbUcty_SelectedIndexChanged);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(21, 244);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 3;
            this.bOK.Text = "&OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bVybrat);
            this.groupBox1.Controls.Add(this.bVlozit);
            this.groupBox1.Controls.Add(this.nudCastka);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nudZustatek);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(301, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peněžní operace";
            // 
            // bVybrat
            // 
            this.bVybrat.Location = new System.Drawing.Point(9, 147);
            this.bVybrat.Name = "bVybrat";
            this.bVybrat.Size = new System.Drawing.Size(120, 23);
            this.bVybrat.TabIndex = 3;
            this.bVybrat.Text = "Vybrat z účtu";
            this.bVybrat.UseVisualStyleBackColor = true;
            this.bVybrat.Click += new System.EventHandler(this.bVybrat_Click);
            // 
            // bVlozit
            // 
            this.bVlozit.Location = new System.Drawing.Point(9, 119);
            this.bVlozit.Name = "bVlozit";
            this.bVlozit.Size = new System.Drawing.Size(120, 23);
            this.bVlozit.TabIndex = 3;
            this.bVlozit.Text = "Vložit na účet";
            this.bVlozit.UseVisualStyleBackColor = true;
            this.bVlozit.Click += new System.EventHandler(this.bVlozit_Click);
            // 
            // nudCastka
            // 
            this.nudCastka.DecimalPlaces = 2;
            this.nudCastka.Location = new System.Drawing.Point(9, 91);
            this.nudCastka.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCastka.Name = "nudCastka";
            this.nudCastka.Size = new System.Drawing.Size(120, 20);
            this.nudCastka.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Částka";
            // 
            // nudZustatek
            // 
            this.nudZustatek.DecimalPlaces = 2;
            this.nudZustatek.Location = new System.Drawing.Point(9, 42);
            this.nudZustatek.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudZustatek.Name = "nudZustatek";
            this.nudZustatek.Size = new System.Drawing.Size(120, 20);
            this.nudZustatek.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Zůstatek";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bOdstranitUcet);
            this.groupBox2.Controls.Add(this.bPridatUcet);
            this.groupBox2.Controls.Add(this.lbUcty);
            this.groupBox2.Location = new System.Drawing.Point(150, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 218);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Účty klienta";
            // 
            // bOdstranitUcet
            // 
            this.bOdstranitUcet.Location = new System.Drawing.Point(6, 188);
            this.bOdstranitUcet.Name = "bOdstranitUcet";
            this.bOdstranitUcet.Size = new System.Drawing.Size(75, 23);
            this.bOdstranitUcet.TabIndex = 3;
            this.bOdstranitUcet.Text = "Odstra&nit účet";
            this.bOdstranitUcet.UseVisualStyleBackColor = true;
            // 
            // bPridatUcet
            // 
            this.bPridatUcet.Location = new System.Drawing.Point(6, 159);
            this.bPridatUcet.Name = "bPridatUcet";
            this.bPridatUcet.Size = new System.Drawing.Size(75, 23);
            this.bPridatUcet.TabIndex = 3;
            this.bPridatUcet.Text = "&Přidat účet";
            this.bPridatUcet.UseVisualStyleBackColor = true;
            this.bPridatUcet.Click += new System.EventHandler(this.bPridatUcet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbJmeno);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbPrijmeni);
            this.groupBox3.Controls.Add(this.tbHeslo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbUzivatelskeJmeno);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 218);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Klient";
            // 
            // Form_klient
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 279);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bOK);
            this.Name = "Form_klient";
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Form_klient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCastka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZustatek)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrijmeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUzivatelskeJmeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHeslo;
        private System.Windows.Forms.ListBox lbUcty;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bVybrat;
        private System.Windows.Forms.Button bVlozit;
        private System.Windows.Forms.NumericUpDown nudCastka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudZustatek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bOdstranitUcet;
        private System.Windows.Forms.Button bPridatUcet;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}