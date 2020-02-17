namespace Elso
{
    partial class Urlap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urlap));
            this.Szoveg = new System.Windows.Forms.Label();
            this.Gomb = new System.Windows.Forms.Button();
            this.Bemeno = new System.Windows.Forms.TextBox();
            this.Kimeno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Szoveg
            // 
            resources.ApplyResources(this.Szoveg, "Szoveg");
            this.Szoveg.BackColor = System.Drawing.SystemColors.Control;
            this.Szoveg.ForeColor = System.Drawing.Color.Red;
            this.Szoveg.Name = "Szoveg";
            this.Szoveg.TextChanged += new System.EventHandler(this.Szoveg1);
            // 
            // Gomb
            // 
            resources.ApplyResources(this.Gomb, "Gomb");
            this.Gomb.Name = "Gomb";
            this.Gomb.UseVisualStyleBackColor = true;
            this.Gomb.TextChanged += new System.EventHandler(this.ModositoGomb);
            this.Gomb.Click += new System.EventHandler(this.ModositoGomb);
            // 
            // Bemeno
            // 
            resources.ApplyResources(this.Bemeno, "Bemeno");
            this.Bemeno.Name = "Bemeno";
            this.Bemeno.TextChanged += new System.EventHandler(this.BemenoSzoveg);
            // 
            // Kimeno
            // 
            resources.ApplyResources(this.Kimeno, "Kimeno");
            this.Kimeno.Name = "Kimeno";
            this.Kimeno.TextChanged += new System.EventHandler(this.KimenoSzoveg);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.TextChanged += new System.EventHandler(this.Modositogomb1);
            this.button1.Click += new System.EventHandler(this.Modositogomb1);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // Urlap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::Elso.Properties.Resources.ed98wx7mnds21;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kimeno);
            this.Controls.Add(this.Bemeno);
            this.Controls.Add(this.Gomb);
            this.Controls.Add(this.Szoveg);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Urlap";
            this.Load += new System.EventHandler(this.Urlap_Load);
            this.TextChanged += new System.EventHandler(this.Urlap_TextChanged);
            this.VisibleChanged += new System.EventHandler(this.Urlap_VisibleChanged);
            this.Click += new System.EventHandler(this.ModositoGomb);
            this.MouseLeave += new System.EventHandler(this.Urlap_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Urlap_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Szoveg;
        private System.Windows.Forms.Button Gomb;
        private System.Windows.Forms.TextBox Bemeno;
        private System.Windows.Forms.TextBox Kimeno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

