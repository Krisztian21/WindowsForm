namespace Vezerlok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KekSzin = new System.Windows.Forms.RadioButton();
            this.PirosSzin = new System.Windows.Forms.RadioButton();
            this.ZoldSzin = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Szinek = new System.Windows.Forms.GroupBox();
            this.Nemek = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Csajok = new System.Windows.Forms.RadioButton();
            this.Pasik = new System.Windows.Forms.RadioButton();
            this.Lábak = new System.Windows.Forms.GroupBox();
            this.JobbLab = new System.Windows.Forms.CheckBox();
            this.BalLab = new System.Windows.Forms.CheckBox();
            this.FaLab = new System.Windows.Forms.CheckBox();
            this.Szinek.SuspendLayout();
            this.Nemek.SuspendLayout();
            this.Lábak.SuspendLayout();
            this.SuspendLayout();
            // 
            // KekSzin
            // 
            this.KekSzin.AutoSize = true;
            this.KekSzin.Location = new System.Drawing.Point(0, 19);
            this.KekSzin.Name = "KekSzin";
            this.KekSzin.Size = new System.Drawing.Size(44, 17);
            this.KekSzin.TabIndex = 0;
            this.KekSzin.TabStop = true;
            this.KekSzin.Text = "Kék";
            this.KekSzin.UseVisualStyleBackColor = true;
            // 
            // PirosSzin
            // 
            this.PirosSzin.AutoSize = true;
            this.PirosSzin.Location = new System.Drawing.Point(0, 42);
            this.PirosSzin.Name = "PirosSzin";
            this.PirosSzin.Size = new System.Drawing.Size(48, 17);
            this.PirosSzin.TabIndex = 1;
            this.PirosSzin.TabStop = true;
            this.PirosSzin.Text = "Piros";
            this.PirosSzin.UseVisualStyleBackColor = true;
            // 
            // ZoldSzin
            // 
            this.ZoldSzin.AutoSize = true;
            this.ZoldSzin.Location = new System.Drawing.Point(0, 65);
            this.ZoldSzin.Name = "ZoldSzin";
            this.ZoldSzin.Size = new System.Drawing.Size(46, 17);
            this.ZoldSzin.TabIndex = 2;
            this.ZoldSzin.TabStop = true;
            this.ZoldSzin.Text = "Zöld";
            this.ZoldSzin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Szinek
            // 
            this.Szinek.Controls.Add(this.KekSzin);
            this.Szinek.Controls.Add(this.PirosSzin);
            this.Szinek.Controls.Add(this.ZoldSzin);
            this.Szinek.Location = new System.Drawing.Point(12, 12);
            this.Szinek.Name = "Szinek";
            this.Szinek.Size = new System.Drawing.Size(79, 100);
            this.Szinek.TabIndex = 4;
            this.Szinek.TabStop = false;
            this.Szinek.Text = "Szinek";
            // 
            // Nemek
            // 
            this.Nemek.Controls.Add(this.Pasik);
            this.Nemek.Controls.Add(this.Csajok);
            this.Nemek.Location = new System.Drawing.Point(108, 12);
            this.Nemek.Name = "Nemek";
            this.Nemek.Size = new System.Drawing.Size(82, 100);
            this.Nemek.TabIndex = 5;
            this.Nemek.TabStop = false;
            this.Nemek.Text = "Nemek";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Csajok
            // 
            this.Csajok.AutoSize = true;
            this.Csajok.Location = new System.Drawing.Point(0, 19);
            this.Csajok.Name = "Csajok";
            this.Csajok.Size = new System.Drawing.Size(57, 17);
            this.Csajok.TabIndex = 0;
            this.Csajok.TabStop = true;
            this.Csajok.Text = "Csajok";
            this.Csajok.UseVisualStyleBackColor = true;
            // 
            // Pasik
            // 
            this.Pasik.AutoSize = true;
            this.Pasik.Location = new System.Drawing.Point(0, 52);
            this.Pasik.Name = "Pasik";
            this.Pasik.Size = new System.Drawing.Size(51, 17);
            this.Pasik.TabIndex = 1;
            this.Pasik.TabStop = true;
            this.Pasik.Text = "Pasik";
            this.Pasik.UseVisualStyleBackColor = true;
            // 
            // Lábak
            // 
            this.Lábak.Controls.Add(this.FaLab);
            this.Lábak.Controls.Add(this.BalLab);
            this.Lábak.Controls.Add(this.JobbLab);
            this.Lábak.Location = new System.Drawing.Point(12, 138);
            this.Lábak.Name = "Lábak";
            this.Lábak.Size = new System.Drawing.Size(92, 107);
            this.Lábak.TabIndex = 7;
            this.Lábak.TabStop = false;
            this.Lábak.Text = "Lábak";
            // 
            // JobbLab
            // 
            this.JobbLab.AutoSize = true;
            this.JobbLab.Location = new System.Drawing.Point(7, 20);
            this.JobbLab.Name = "JobbLab";
            this.JobbLab.Size = new System.Drawing.Size(77, 17);
            this.JobbLab.TabIndex = 0;
            this.JobbLab.Text = "Jobb lábas";
            this.JobbLab.UseVisualStyleBackColor = true;
            // 
            // BalLab
            // 
            this.BalLab.AutoSize = true;
            this.BalLab.Location = new System.Drawing.Point(7, 43);
            this.BalLab.Name = "BalLab";
            this.BalLab.Size = new System.Drawing.Size(69, 17);
            this.BalLab.TabIndex = 1;
            this.BalLab.Text = "Bal lábas";
            this.BalLab.UseVisualStyleBackColor = true;
            // 
            // FaLab
            // 
            this.FaLab.AutoSize = true;
            this.FaLab.Location = new System.Drawing.Point(7, 67);
            this.FaLab.Name = "FaLab";
            this.FaLab.Size = new System.Drawing.Size(61, 17);
            this.FaLab.TabIndex = 2;
            this.FaLab.Text = "Fa lábú";
            this.FaLab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vezerlok.Properties.Resources._81l0dRslShL__AC_SX522_;
            this.ClientSize = new System.Drawing.Size(756, 365);
            this.Controls.Add(this.Lábak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nemek);
            this.Controls.Add(this.Szinek);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Szinek.ResumeLayout(false);
            this.Szinek.PerformLayout();
            this.Nemek.ResumeLayout(false);
            this.Nemek.PerformLayout();
            this.Lábak.ResumeLayout(false);
            this.Lábak.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton KekSzin;
        private System.Windows.Forms.RadioButton PirosSzin;
        private System.Windows.Forms.RadioButton ZoldSzin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Szinek;
        private System.Windows.Forms.GroupBox Nemek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Pasik;
        private System.Windows.Forms.RadioButton Csajok;
        private System.Windows.Forms.GroupBox Lábak;
        private System.Windows.Forms.CheckBox FaLab;
        private System.Windows.Forms.CheckBox BalLab;
        private System.Windows.Forms.CheckBox JobbLab;
    }
}

