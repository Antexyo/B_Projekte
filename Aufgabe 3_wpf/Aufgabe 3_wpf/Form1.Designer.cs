namespace Aufgabe_3_wpf
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
            this.btPruefziffer = new System.Windows.Forms.Button();
            this.tbxSeriennummer = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSeriennummer = new System.Windows.Forms.Label();
            this.lblPruefziffer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPruefziffer
            // 
            this.btPruefziffer.Location = new System.Drawing.Point(429, 250);
            this.btPruefziffer.Name = "btPruefziffer";
            this.btPruefziffer.Size = new System.Drawing.Size(183, 20);
            this.btPruefziffer.TabIndex = 0;
            this.btPruefziffer.Text = "Prüfziffer berechnen";
            this.btPruefziffer.UseVisualStyleBackColor = true;
            this.btPruefziffer.Click += new System.EventHandler(this.btPruefziffer_Click);
            // 
            // tbxSeriennummer
            // 
            this.tbxSeriennummer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxSeriennummer.Location = new System.Drawing.Point(208, 250);
            this.tbxSeriennummer.MaxLength = 2000;
            this.tbxSeriennummer.Name = "tbxSeriennummer";
            this.tbxSeriennummer.Size = new System.Drawing.Size(183, 20);
            this.tbxSeriennummer.TabIndex = 1;
            // 
            // lblSeriennummer
            // 
            this.lblSeriennummer.AutoSize = true;
            this.lblSeriennummer.Location = new System.Drawing.Point(205, 215);
            this.lblSeriennummer.Name = "lblSeriennummer";
            this.lblSeriennummer.Size = new System.Drawing.Size(74, 13);
            this.lblSeriennummer.TabIndex = 2;
            this.lblSeriennummer.Text = "Seriennummer";
            // 
            // lblPruefziffer
            // 
            this.lblPruefziffer.AutoSize = true;
            this.lblPruefziffer.Location = new System.Drawing.Point(208, 304);
            this.lblPruefziffer.Name = "lblPruefziffer";
            this.lblPruefziffer.Size = new System.Drawing.Size(0, 13);
            this.lblPruefziffer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 503);
            this.Controls.Add(this.lblPruefziffer);
            this.Controls.Add(this.lblSeriennummer);
            this.Controls.Add(this.tbxSeriennummer);
            this.Controls.Add(this.btPruefziffer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPruefziffer;
        private System.Windows.Forms.TextBox tbxSeriennummer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblSeriennummer;
        private System.Windows.Forms.Label lblPruefziffer;
    }
}

