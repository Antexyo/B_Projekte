namespace Aufgabe_5
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
            this.btBerechnen = new System.Windows.Forms.Button();
            this.btLoeschen = new System.Windows.Forms.Button();
            this.lblh = new System.Windows.Forms.Label();
            this.lblm = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.tbxT1h = new System.Windows.Forms.TextBox();
            this.tbxT1m = new System.Windows.Forms.TextBox();
            this.tbxT1s = new System.Windows.Forms.TextBox();
            this.tbxT2h = new System.Windows.Forms.TextBox();
            this.tbxT2m = new System.Windows.Forms.TextBox();
            this.tbxT2s = new System.Windows.Forms.TextBox();
            this.tbxDiffh = new System.Windows.Forms.TextBox();
            this.tbxDiffm = new System.Windows.Forms.TextBox();
            this.tbxDiffs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btBerechnen
            // 
            this.btBerechnen.Location = new System.Drawing.Point(424, 128);
            this.btBerechnen.Name = "btBerechnen";
            this.btBerechnen.Size = new System.Drawing.Size(102, 23);
            this.btBerechnen.TabIndex = 0;
            this.btBerechnen.Text = "Berechnen";
            this.btBerechnen.UseVisualStyleBackColor = true;
            this.btBerechnen.Click += new System.EventHandler(this.btBerechnen_Click);
            // 
            // btLoeschen
            // 
            this.btLoeschen.Location = new System.Drawing.Point(424, 235);
            this.btLoeschen.Name = "btLoeschen";
            this.btLoeschen.Size = new System.Drawing.Size(102, 23);
            this.btLoeschen.TabIndex = 1;
            this.btLoeschen.Text = "Löschen";
            this.btLoeschen.UseVisualStyleBackColor = true;
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Location = new System.Drawing.Point(202, 112);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(13, 13);
            this.lblh.TabIndex = 2;
            this.lblh.Text = "h";
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Location = new System.Drawing.Point(280, 112);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(15, 13);
            this.lblm.TabIndex = 3;
            this.lblm.Text = "m";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Location = new System.Drawing.Point(352, 112);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(12, 13);
            this.lbls.TabIndex = 4;
            this.lbls.Text = "s";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(100, 135);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(71, 13);
            this.lblT1.TabIndex = 5;
            this.lblT1.Text = "Zeitpunkt T1:";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(100, 181);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(71, 13);
            this.lblT2.TabIndex = 6;
            this.lblT2.Text = "Zeitpunkt T2:";
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(87, 241);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(84, 13);
            this.lblDiff.TabIndex = 7;
            this.lblDiff.Text = "Differenz T2-T1:";
            // 
            // tbxT1h
            // 
            this.tbxT1h.Location = new System.Drawing.Point(177, 128);
            this.tbxT1h.Name = "tbxT1h";
            this.tbxT1h.Size = new System.Drawing.Size(68, 20);
            this.tbxT1h.TabIndex = 8;
            this.tbxT1h.Text = "?";
            this.tbxT1h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxT1m
            // 
            this.tbxT1m.Location = new System.Drawing.Point(254, 128);
            this.tbxT1m.Name = "tbxT1m";
            this.tbxT1m.Size = new System.Drawing.Size(68, 20);
            this.tbxT1m.TabIndex = 9;
            this.tbxT1m.Text = "?";
            this.tbxT1m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxT1s
            // 
            this.tbxT1s.Location = new System.Drawing.Point(328, 128);
            this.tbxT1s.Name = "tbxT1s";
            this.tbxT1s.Size = new System.Drawing.Size(68, 20);
            this.tbxT1s.TabIndex = 10;
            this.tbxT1s.Text = "?.???";
            this.tbxT1s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxT2h
            // 
            this.tbxT2h.Location = new System.Drawing.Point(177, 178);
            this.tbxT2h.Name = "tbxT2h";
            this.tbxT2h.Size = new System.Drawing.Size(68, 20);
            this.tbxT2h.TabIndex = 11;
            this.tbxT2h.Text = "?";
            this.tbxT2h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxT2m
            // 
            this.tbxT2m.Location = new System.Drawing.Point(254, 178);
            this.tbxT2m.Name = "tbxT2m";
            this.tbxT2m.Size = new System.Drawing.Size(68, 20);
            this.tbxT2m.TabIndex = 12;
            this.tbxT2m.Text = "?";
            this.tbxT2m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxT2s
            // 
            this.tbxT2s.Location = new System.Drawing.Point(328, 178);
            this.tbxT2s.Name = "tbxT2s";
            this.tbxT2s.Size = new System.Drawing.Size(68, 20);
            this.tbxT2s.TabIndex = 13;
            this.tbxT2s.Text = "?.???";
            this.tbxT2s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDiffh
            // 
            this.tbxDiffh.Location = new System.Drawing.Point(177, 238);
            this.tbxDiffh.Name = "tbxDiffh";
            this.tbxDiffh.ReadOnly = true;
            this.tbxDiffh.Size = new System.Drawing.Size(68, 20);
            this.tbxDiffh.TabIndex = 14;
            this.tbxDiffh.Text = "0";
            this.tbxDiffh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDiffm
            // 
            this.tbxDiffm.Location = new System.Drawing.Point(254, 238);
            this.tbxDiffm.Name = "tbxDiffm";
            this.tbxDiffm.ReadOnly = true;
            this.tbxDiffm.Size = new System.Drawing.Size(68, 20);
            this.tbxDiffm.TabIndex = 15;
            this.tbxDiffm.Text = "0";
            this.tbxDiffm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDiffs
            // 
            this.tbxDiffs.Location = new System.Drawing.Point(328, 238);
            this.tbxDiffs.Name = "tbxDiffs";
            this.tbxDiffs.ReadOnly = true;
            this.tbxDiffs.Size = new System.Drawing.Size(68, 20);
            this.tbxDiffs.TabIndex = 16;
            this.tbxDiffs.Text = "0.000";
            this.tbxDiffs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 472);
            this.Controls.Add(this.tbxDiffs);
            this.Controls.Add(this.tbxDiffm);
            this.Controls.Add(this.tbxDiffh);
            this.Controls.Add(this.tbxT2s);
            this.Controls.Add(this.tbxT2m);
            this.Controls.Add(this.tbxT2h);
            this.Controls.Add(this.tbxT1s);
            this.Controls.Add(this.tbxT1m);
            this.Controls.Add(this.tbxT1h);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.btLoeschen);
            this.Controls.Add(this.btBerechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBerechnen;
        private System.Windows.Forms.Button btLoeschen;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.TextBox tbxT1h;
        private System.Windows.Forms.TextBox tbxT1m;
        private System.Windows.Forms.TextBox tbxT1s;
        private System.Windows.Forms.TextBox tbxT2h;
        private System.Windows.Forms.TextBox tbxT2m;
        private System.Windows.Forms.TextBox tbxT2s;
        private System.Windows.Forms.TextBox tbxDiffh;
        private System.Windows.Forms.TextBox tbxDiffm;
        private System.Windows.Forms.TextBox tbxDiffs;
    }
}

