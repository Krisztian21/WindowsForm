namespace Vezerlok2
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
            this.BetuStilus = new System.Windows.Forms.GroupBox();
            this.AlaHuzott = new System.Windows.Forms.CheckBox();
            this.Dolt = new System.Windows.Forms.CheckBox();
            this.FelKover = new System.Windows.Forms.CheckBox();
            this.BetuMeret = new System.Windows.Forms.GroupBox();
            this.TizenNyolcas = new System.Windows.Forms.RadioButton();
            this.TizenHatos = new System.Windows.Forms.RadioButton();
            this.TizenNegyes = new System.Windows.Forms.RadioButton();
            this.TizenKettes = new System.Windows.Forms.RadioButton();
            this.TizenEgyes = new System.Windows.Forms.RadioButton();
            this.Tizes = new System.Windows.Forms.RadioButton();
            this.BetuSzin = new System.Windows.Forms.GroupBox();
            this.Fekete = new System.Windows.Forms.RadioButton();
            this.Zold = new System.Windows.Forms.RadioButton();
            this.Kek = new System.Windows.Forms.RadioButton();
            this.Piros = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AtHuzott = new System.Windows.Forms.CheckBox();
            this.R = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BetuStilus.SuspendLayout();
            this.BetuMeret.SuspendLayout();
            this.BetuSzin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BetuStilus
            // 
            this.BetuStilus.Controls.Add(this.AtHuzott);
            this.BetuStilus.Controls.Add(this.AlaHuzott);
            this.BetuStilus.Controls.Add(this.Dolt);
            this.BetuStilus.Controls.Add(this.FelKover);
            this.BetuStilus.Location = new System.Drawing.Point(44, 239);
            this.BetuStilus.Name = "BetuStilus";
            this.BetuStilus.Size = new System.Drawing.Size(200, 114);
            this.BetuStilus.TabIndex = 0;
            this.BetuStilus.TabStop = false;
            this.BetuStilus.Text = "Betű Stílus";
            // 
            // AlaHuzott
            // 
            this.AlaHuzott.AutoSize = true;
            this.AlaHuzott.Location = new System.Drawing.Point(6, 65);
            this.AlaHuzott.Name = "AlaHuzott";
            this.AlaHuzott.Size = new System.Drawing.Size(70, 17);
            this.AlaHuzott.TabIndex = 2;
            this.AlaHuzott.Text = "Aláhúzott";
            this.AlaHuzott.UseVisualStyleBackColor = true;
            this.AlaHuzott.CheckedChanged += new System.EventHandler(this.AlaHuzott_CheckedChanged);
            // 
            // Dolt
            // 
            this.Dolt.AutoSize = true;
            this.Dolt.Location = new System.Drawing.Point(6, 42);
            this.Dolt.Name = "Dolt";
            this.Dolt.Size = new System.Drawing.Size(45, 17);
            this.Dolt.TabIndex = 1;
            this.Dolt.Text = "Dőlt";
            this.Dolt.UseVisualStyleBackColor = true;
            this.Dolt.CheckedChanged += new System.EventHandler(this.Dolt_CheckedChanged);
            // 
            // FelKover
            // 
            this.FelKover.AutoSize = true;
            this.FelKover.Location = new System.Drawing.Point(7, 19);
            this.FelKover.Name = "FelKover";
            this.FelKover.Size = new System.Drawing.Size(71, 17);
            this.FelKover.TabIndex = 0;
            this.FelKover.Text = "Fél Kövér";
            this.FelKover.UseVisualStyleBackColor = true;
            this.FelKover.CheckedChanged += new System.EventHandler(this.FelKover_CheckedChanged);
            // 
            // BetuMeret
            // 
            this.BetuMeret.Controls.Add(this.TizenNyolcas);
            this.BetuMeret.Controls.Add(this.TizenHatos);
            this.BetuMeret.Controls.Add(this.TizenNegyes);
            this.BetuMeret.Controls.Add(this.TizenKettes);
            this.BetuMeret.Controls.Add(this.TizenEgyes);
            this.BetuMeret.Controls.Add(this.Tizes);
            this.BetuMeret.Location = new System.Drawing.Point(264, 239);
            this.BetuMeret.Name = "BetuMeret";
            this.BetuMeret.Size = new System.Drawing.Size(200, 114);
            this.BetuMeret.TabIndex = 1;
            this.BetuMeret.TabStop = false;
            this.BetuMeret.Text = "Betű Méret";
            // 
            // TizenNyolcas
            // 
            this.TizenNyolcas.AutoSize = true;
            this.TizenNyolcas.Location = new System.Drawing.Point(81, 65);
            this.TizenNyolcas.Name = "TizenNyolcas";
            this.TizenNyolcas.Size = new System.Drawing.Size(51, 17);
            this.TizenNyolcas.TabIndex = 5;
            this.TizenNyolcas.TabStop = true;
            this.TizenNyolcas.Text = "18-as";
            this.TizenNyolcas.UseVisualStyleBackColor = true;
            this.TizenNyolcas.CheckedChanged += new System.EventHandler(this.TizenNyolcas_CheckedChanged);
            // 
            // TizenHatos
            // 
            this.TizenHatos.AutoSize = true;
            this.TizenHatos.Location = new System.Drawing.Point(81, 42);
            this.TizenHatos.Name = "TizenHatos";
            this.TizenHatos.Size = new System.Drawing.Size(51, 17);
            this.TizenHatos.TabIndex = 4;
            this.TizenHatos.TabStop = true;
            this.TizenHatos.Text = "16-os";
            this.TizenHatos.UseVisualStyleBackColor = true;
            this.TizenHatos.CheckedChanged += new System.EventHandler(this.TizenHatos_CheckedChanged);
            // 
            // TizenNegyes
            // 
            this.TizenNegyes.AutoSize = true;
            this.TizenNegyes.Location = new System.Drawing.Point(81, 19);
            this.TizenNegyes.Name = "TizenNegyes";
            this.TizenNegyes.Size = new System.Drawing.Size(51, 17);
            this.TizenNegyes.TabIndex = 3;
            this.TizenNegyes.TabStop = true;
            this.TizenNegyes.Text = "14-es";
            this.TizenNegyes.UseVisualStyleBackColor = true;
            this.TizenNegyes.CheckedChanged += new System.EventHandler(this.TizenNegyes_CheckedChanged);
            // 
            // TizenKettes
            // 
            this.TizenKettes.AutoSize = true;
            this.TizenKettes.Location = new System.Drawing.Point(6, 64);
            this.TizenKettes.Name = "TizenKettes";
            this.TizenKettes.Size = new System.Drawing.Size(51, 17);
            this.TizenKettes.TabIndex = 2;
            this.TizenKettes.TabStop = true;
            this.TizenKettes.Text = "12-es";
            this.TizenKettes.UseVisualStyleBackColor = true;
            this.TizenKettes.CheckedChanged += new System.EventHandler(this.TizenKettes_CheckedChanged);
            // 
            // TizenEgyes
            // 
            this.TizenEgyes.AutoSize = true;
            this.TizenEgyes.Location = new System.Drawing.Point(6, 41);
            this.TizenEgyes.Name = "TizenEgyes";
            this.TizenEgyes.Size = new System.Drawing.Size(51, 17);
            this.TizenEgyes.TabIndex = 1;
            this.TizenEgyes.TabStop = true;
            this.TizenEgyes.Text = "11-es";
            this.TizenEgyes.UseVisualStyleBackColor = true;
            this.TizenEgyes.CheckedChanged += new System.EventHandler(this.TizenEgyes_CheckedChanged);
            // 
            // Tizes
            // 
            this.Tizes.AutoSize = true;
            this.Tizes.Location = new System.Drawing.Point(6, 19);
            this.Tizes.Name = "Tizes";
            this.Tizes.Size = new System.Drawing.Size(51, 17);
            this.Tizes.TabIndex = 0;
            this.Tizes.TabStop = true;
            this.Tizes.Text = "10-es";
            this.Tizes.UseVisualStyleBackColor = true;
            this.Tizes.CheckedChanged += new System.EventHandler(this.Tizes_CheckedChanged);
            // 
            // BetuSzin
            // 
            this.BetuSzin.Controls.Add(this.Fekete);
            this.BetuSzin.Controls.Add(this.Zold);
            this.BetuSzin.Controls.Add(this.Kek);
            this.BetuSzin.Controls.Add(this.Piros);
            this.BetuSzin.Location = new System.Drawing.Point(489, 239);
            this.BetuSzin.Name = "BetuSzin";
            this.BetuSzin.Size = new System.Drawing.Size(200, 114);
            this.BetuSzin.TabIndex = 2;
            this.BetuSzin.TabStop = false;
            this.BetuSzin.Text = "Betű Színek";
            // 
            // Fekete
            // 
            this.Fekete.AutoSize = true;
            this.Fekete.Location = new System.Drawing.Point(4, 87);
            this.Fekete.Name = "Fekete";
            this.Fekete.Size = new System.Drawing.Size(58, 17);
            this.Fekete.TabIndex = 3;
            this.Fekete.TabStop = true;
            this.Fekete.Text = "Fekete";
            this.Fekete.UseVisualStyleBackColor = true;
            this.Fekete.CheckedChanged += new System.EventHandler(this.Fekete_CheckedChanged);
            // 
            // Zold
            // 
            this.Zold.AutoSize = true;
            this.Zold.Location = new System.Drawing.Point(4, 64);
            this.Zold.Name = "Zold";
            this.Zold.Size = new System.Drawing.Size(46, 17);
            this.Zold.TabIndex = 2;
            this.Zold.TabStop = true;
            this.Zold.Text = "Zöld";
            this.Zold.UseVisualStyleBackColor = true;
            this.Zold.CheckedChanged += new System.EventHandler(this.Zold_CheckedChanged);
            // 
            // Kek
            // 
            this.Kek.AutoSize = true;
            this.Kek.Location = new System.Drawing.Point(4, 42);
            this.Kek.Name = "Kek";
            this.Kek.Size = new System.Drawing.Size(44, 17);
            this.Kek.TabIndex = 1;
            this.Kek.TabStop = true;
            this.Kek.Text = "Kék";
            this.Kek.UseVisualStyleBackColor = true;
            this.Kek.CheckedChanged += new System.EventHandler(this.Kek_CheckedChanged);
            // 
            // Piros
            // 
            this.Piros.AutoSize = true;
            this.Piros.Location = new System.Drawing.Point(4, 19);
            this.Piros.Name = "Piros";
            this.Piros.Size = new System.Drawing.Size(48, 17);
            this.Piros.TabIndex = 0;
            this.Piros.TabStop = true;
            this.Piros.Text = "Piros";
            this.Piros.UseVisualStyleBackColor = true;
            this.Piros.CheckedChanged += new System.EventHandler(this.Piros_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Star Wars The Clone Wars";
            // 
            // AtHuzott
            // 
            this.AtHuzott.AutoSize = true;
            this.AtHuzott.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AtHuzott.Location = new System.Drawing.Point(6, 88);
            this.AtHuzott.Name = "AtHuzott";
            this.AtHuzott.Size = new System.Drawing.Size(65, 17);
            this.AtHuzott.TabIndex = 3;
            this.AtHuzott.Text = "Áthúzott";
            this.AtHuzott.UseVisualStyleBackColor = true;
            this.AtHuzott.CheckedChanged += new System.EventHandler(this.AtHuzott_CheckedChanged);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(12, 13);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(18, 13);
            this.R.TabIndex = 4;
            this.R.Text = "R:";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(12, 40);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(18, 13);
            this.G.TabIndex = 5;
            this.G.Text = "G:";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(13, 67);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(17, 13);
            this.B.TabIndex = 6;
            this.B.Text = "B:";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(38, 13);
            this.hScrollBar1.Maximum = 264;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(237, 20);
            this.hScrollBar1.TabIndex = 7;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(38, 40);
            this.hScrollBar2.Maximum = 264;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(237, 20);
            this.hScrollBar2.TabIndex = 8;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(38, 67);
            this.hScrollBar3.Maximum = 264;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(237, 20);
            this.hScrollBar3.TabIndex = 9;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(515, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(515, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(515, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 100);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(621, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 91);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vezerlok2.Properties.Resources.b14da232558b3584b9ba618eb29fdcbe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(756, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetuSzin);
            this.Controls.Add(this.BetuMeret);
            this.Controls.Add(this.BetuStilus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BetuStilus.ResumeLayout(false);
            this.BetuStilus.PerformLayout();
            this.BetuMeret.ResumeLayout(false);
            this.BetuMeret.PerformLayout();
            this.BetuSzin.ResumeLayout(false);
            this.BetuSzin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BetuStilus;
        private System.Windows.Forms.CheckBox AtHuzott;
        private System.Windows.Forms.CheckBox AlaHuzott;
        private System.Windows.Forms.CheckBox Dolt;
        private System.Windows.Forms.CheckBox FelKover;
        private System.Windows.Forms.GroupBox BetuMeret;
        private System.Windows.Forms.RadioButton TizenNyolcas;
        private System.Windows.Forms.RadioButton TizenHatos;
        private System.Windows.Forms.RadioButton TizenNegyes;
        private System.Windows.Forms.RadioButton TizenKettes;
        private System.Windows.Forms.RadioButton TizenEgyes;
        private System.Windows.Forms.RadioButton Tizes;
        private System.Windows.Forms.GroupBox BetuSzin;
        private System.Windows.Forms.RadioButton Fekete;
        private System.Windows.Forms.RadioButton Zold;
        private System.Windows.Forms.RadioButton Kek;
        private System.Windows.Forms.RadioButton Piros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

