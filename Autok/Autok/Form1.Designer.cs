namespace Autok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tipus = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FelveszBTN = new System.Windows.Forms.Button();
            this.ListazBTN = new System.Windows.Forms.Button();
            this.Marka = new System.Windows.Forms.ComboBox();
            this.Evszam = new System.Windows.Forms.NumericUpDown();
            this.Uzemanyag = new System.Windows.Forms.ComboBox();
            this.Rendszam = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Evszam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Márka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Típus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Évszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Üzemanyag:";
            // 
            // Tipus
            // 
            this.Tipus.Location = new System.Drawing.Point(101, 88);
            this.Tipus.Name = "Tipus";
            this.Tipus.Size = new System.Drawing.Size(121, 20);
            this.Tipus.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(539, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 329);
            this.listBox1.TabIndex = 6;
            // 
            // FelveszBTN
            // 
            this.FelveszBTN.Location = new System.Drawing.Point(437, 20);
            this.FelveszBTN.Name = "FelveszBTN";
            this.FelveszBTN.Size = new System.Drawing.Size(96, 42);
            this.FelveszBTN.TabIndex = 7;
            this.FelveszBTN.Text = "Felvesz";
            this.FelveszBTN.UseVisualStyleBackColor = true;
            this.FelveszBTN.Click += new System.EventHandler(this.FelveszBTN_Click);
            // 
            // ListazBTN
            // 
            this.ListazBTN.Location = new System.Drawing.Point(437, 68);
            this.ListazBTN.Name = "ListazBTN";
            this.ListazBTN.Size = new System.Drawing.Size(96, 42);
            this.ListazBTN.TabIndex = 8;
            this.ListazBTN.Text = "Listáz";
            this.ListazBTN.UseVisualStyleBackColor = true;
            this.ListazBTN.Click += new System.EventHandler(this.ListazBTN_Click);
            // 
            // Marka
            // 
            this.Marka.FormattingEnabled = true;
            this.Marka.Items.AddRange(new object[] {
            "Audi",
            "Skoda",
            "Citroen",
            "Lamborgini",
            "Mercedes-Benz",
            "Madza",
            "Opel",
            "Tesla",
            "Akura",
            "Toyota",
            "Nissan",
            "Suzuki",
            "BMW",
            "Alfa Romeo",
            "Ferrári"});
            this.Marka.Location = new System.Drawing.Point(101, 46);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(121, 21);
            this.Marka.TabIndex = 9;
            // 
            // Evszam
            // 
            this.Evszam.Location = new System.Drawing.Point(102, 127);
            this.Evszam.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.Evszam.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.Evszam.Name = "Evszam";
            this.Evszam.Size = new System.Drawing.Size(120, 20);
            this.Evszam.TabIndex = 11;
            this.Evszam.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // Uzemanyag
            // 
            this.Uzemanyag.FormattingEnabled = true;
            this.Uzemanyag.Items.AddRange(new object[] {
            "Benzin",
            "Elektromos Áram",
            "Mind2"});
            this.Uzemanyag.Location = new System.Drawing.Point(102, 163);
            this.Uzemanyag.Name = "Uzemanyag";
            this.Uzemanyag.Size = new System.Drawing.Size(121, 21);
            this.Uzemanyag.TabIndex = 12;
            // 
            // Rendszam
            // 
            this.Rendszam.Location = new System.Drawing.Point(102, 13);
            this.Rendszam.Mask = "AAA-000";
            this.Rendszam.Name = "Rendszam";
            this.Rendszam.Size = new System.Drawing.Size(120, 20);
            this.Rendszam.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Autok.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 365);
            this.Controls.Add(this.Rendszam);
            this.Controls.Add(this.Uzemanyag);
            this.Controls.Add(this.Evszam);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.ListazBTN);
            this.Controls.Add(this.FelveszBTN);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Tipus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Evszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tipus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button FelveszBTN;
        private System.Windows.Forms.Button ListazBTN;
        private System.Windows.Forms.ComboBox Marka;
        private System.Windows.Forms.NumericUpDown Evszam;
        private System.Windows.Forms.ComboBox Uzemanyag;
        private System.Windows.Forms.MaskedTextBox Rendszam;
    }
}

