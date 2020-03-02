namespace Marcius2
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
            this.FelveszBTN = new System.Windows.Forms.Button();
            this.BeszurBTN = new System.Windows.Forms.Button();
            this.TorolBTN = new System.Windows.Forms.Button();
            this.TorolMindBTN = new System.Windows.Forms.Button();
            this.AtmasolBTN = new System.Windows.Forms.Button();
            this.AtmozgatBTN = new System.Windows.Forms.Button();
            this.KeresBTN = new System.Windows.Forms.Button();
            this.TopMozi = new System.Windows.Forms.ListBox();
            this.LatottMoziLV = new System.Windows.Forms.ListBox();
            this.szovegTxt = new System.Windows.Forms.TextBox();
            this.elemszamNUD = new System.Windows.Forms.NumericUpDown();
            this.evTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.elemszamNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // FelveszBTN
            // 
            this.FelveszBTN.Location = new System.Drawing.Point(324, 73);
            this.FelveszBTN.Name = "FelveszBTN";
            this.FelveszBTN.Size = new System.Drawing.Size(75, 23);
            this.FelveszBTN.TabIndex = 0;
            this.FelveszBTN.Text = "Felvesz";
            this.FelveszBTN.UseVisualStyleBackColor = true;
            this.FelveszBTN.Click += new System.EventHandler(this.FelveszBTN_Click);
            // 
            // BeszurBTN
            // 
            this.BeszurBTN.Location = new System.Drawing.Point(324, 117);
            this.BeszurBTN.Name = "BeszurBTN";
            this.BeszurBTN.Size = new System.Drawing.Size(75, 23);
            this.BeszurBTN.TabIndex = 1;
            this.BeszurBTN.Text = "Beszúr";
            this.BeszurBTN.UseVisualStyleBackColor = true;
            this.BeszurBTN.Click += new System.EventHandler(this.BeszurBTN_Click);
            // 
            // TorolBTN
            // 
            this.TorolBTN.Location = new System.Drawing.Point(324, 162);
            this.TorolBTN.Name = "TorolBTN";
            this.TorolBTN.Size = new System.Drawing.Size(75, 23);
            this.TorolBTN.TabIndex = 2;
            this.TorolBTN.Text = "Töröl";
            this.TorolBTN.UseVisualStyleBackColor = true;
            this.TorolBTN.Click += new System.EventHandler(this.TorolBTN_Click);
            // 
            // TorolMindBTN
            // 
            this.TorolMindBTN.Location = new System.Drawing.Point(324, 202);
            this.TorolMindBTN.Name = "TorolMindBTN";
            this.TorolMindBTN.Size = new System.Drawing.Size(75, 23);
            this.TorolMindBTN.TabIndex = 3;
            this.TorolMindBTN.Text = "Töröl Mind";
            this.TorolMindBTN.UseVisualStyleBackColor = true;
            this.TorolMindBTN.Click += new System.EventHandler(this.TorolMindBTN_Click);
            // 
            // AtmasolBTN
            // 
            this.AtmasolBTN.Location = new System.Drawing.Point(324, 242);
            this.AtmasolBTN.Name = "AtmasolBTN";
            this.AtmasolBTN.Size = new System.Drawing.Size(75, 23);
            this.AtmasolBTN.TabIndex = 4;
            this.AtmasolBTN.Text = "Átmásol";
            this.AtmasolBTN.UseVisualStyleBackColor = true;
            this.AtmasolBTN.Click += new System.EventHandler(this.AtmasolBTN_Click);
            // 
            // AtmozgatBTN
            // 
            this.AtmozgatBTN.Location = new System.Drawing.Point(324, 286);
            this.AtmozgatBTN.Name = "AtmozgatBTN";
            this.AtmozgatBTN.Size = new System.Drawing.Size(75, 23);
            this.AtmozgatBTN.TabIndex = 5;
            this.AtmozgatBTN.Text = "Átmozgat";
            this.AtmozgatBTN.UseVisualStyleBackColor = true;
            this.AtmozgatBTN.Click += new System.EventHandler(this.AtmozgatBTN_Click);
            // 
            // KeresBTN
            // 
            this.KeresBTN.Location = new System.Drawing.Point(324, 327);
            this.KeresBTN.Name = "KeresBTN";
            this.KeresBTN.Size = new System.Drawing.Size(75, 23);
            this.KeresBTN.TabIndex = 6;
            this.KeresBTN.Text = "Keres";
            this.KeresBTN.UseVisualStyleBackColor = true;
            this.KeresBTN.Click += new System.EventHandler(this.KeresBTN_Click);
            // 
            // TopMozi
            // 
            this.TopMozi.FormattingEnabled = true;
            this.TopMozi.Location = new System.Drawing.Point(120, 73);
            this.TopMozi.Name = "TopMozi";
            this.TopMozi.Size = new System.Drawing.Size(198, 277);
            this.TopMozi.TabIndex = 7;
            this.TopMozi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LatottMoziLV
            // 
            this.LatottMoziLV.FormattingEnabled = true;
            this.LatottMoziLV.Location = new System.Drawing.Point(405, 73);
            this.LatottMoziLV.Name = "LatottMoziLV";
            this.LatottMoziLV.Size = new System.Drawing.Size(195, 277);
            this.LatottMoziLV.TabIndex = 8;
            this.LatottMoziLV.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // szovegTxt
            // 
            this.szovegTxt.Location = new System.Drawing.Point(107, 23);
            this.szovegTxt.Name = "szovegTxt";
            this.szovegTxt.Size = new System.Drawing.Size(198, 20);
            this.szovegTxt.TabIndex = 9;
            // 
            // elemszamNUD
            // 
            this.elemszamNUD.Location = new System.Drawing.Point(456, 22);
            this.elemszamNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.elemszamNUD.Name = "elemszamNUD";
            this.elemszamNUD.Size = new System.Drawing.Size(120, 20);
            this.elemszamNUD.TabIndex = 11;
            this.elemszamNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // evTxt
            // 
            this.evTxt.Location = new System.Drawing.Point(313, 22);
            this.evTxt.Name = "evTxt";
            this.evTxt.Size = new System.Drawing.Size(100, 20);
            this.evTxt.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Marcius2.Properties.Resources.ujfilm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(756, 367);
            this.Controls.Add(this.evTxt);
            this.Controls.Add(this.elemszamNUD);
            this.Controls.Add(this.szovegTxt);
            this.Controls.Add(this.LatottMoziLV);
            this.Controls.Add(this.TopMozi);
            this.Controls.Add(this.KeresBTN);
            this.Controls.Add(this.AtmozgatBTN);
            this.Controls.Add(this.AtmasolBTN);
            this.Controls.Add(this.TorolMindBTN);
            this.Controls.Add(this.TorolBTN);
            this.Controls.Add(this.BeszurBTN);
            this.Controls.Add(this.FelveszBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elemszamNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FelveszBTN;
        private System.Windows.Forms.Button BeszurBTN;
        private System.Windows.Forms.Button TorolBTN;
        private System.Windows.Forms.Button TorolMindBTN;
        private System.Windows.Forms.Button AtmasolBTN;
        private System.Windows.Forms.Button AtmozgatBTN;
        private System.Windows.Forms.Button KeresBTN;
        private System.Windows.Forms.ListBox TopMozi;
        private System.Windows.Forms.ListBox LatottMoziLV;
        private System.Windows.Forms.TextBox szovegTxt;
        private System.Windows.Forms.NumericUpDown elemszamNUD;
        private System.Windows.Forms.TextBox evTxt;
    }
}

