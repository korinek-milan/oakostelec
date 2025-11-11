namespace PrevodJednotek
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxVstup = new System.Windows.Forms.ComboBox();
            this.txtVstup = new System.Windows.Forms.TextBox();
            this.labelKM = new System.Windows.Forms.Label();
            this.btn_vypocet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxVstup
            // 
            this.comboBoxVstup.FormattingEnabled = true;
            this.comboBoxVstup.Location = new System.Drawing.Point(171, 121);
            this.comboBoxVstup.Name = "comboBoxVstup";
            this.comboBoxVstup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVstup.TabIndex = 0;
            // 
            // txtVstup
            // 
            this.txtVstup.Location = new System.Drawing.Point(171, 84);
            this.txtVstup.Name = "txtVstup";
            this.txtVstup.Size = new System.Drawing.Size(100, 20);
            this.txtVstup.TabIndex = 1;
            // 
            // labelKM
            // 
            this.labelKM.AutoSize = true;
            this.labelKM.Location = new System.Drawing.Point(171, 186);
            this.labelKM.Name = "labelKM";
            this.labelKM.Size = new System.Drawing.Size(21, 13);
            this.labelKM.TabIndex = 2;
            this.labelKM.Text = "km";
            // 
            // btn_vypocet
            // 
            this.btn_vypocet.Location = new System.Drawing.Point(243, 181);
            this.btn_vypocet.Name = "btn_vypocet";
            this.btn_vypocet.Size = new System.Drawing.Size(75, 23);
            this.btn_vypocet.TabIndex = 3;
            this.btn_vypocet.Text = "button1";
            this.btn_vypocet.UseVisualStyleBackColor = true;
            this.btn_vypocet.Click += new System.EventHandler(this.btn_vypocet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_vypocet);
            this.Controls.Add(this.labelKM);
            this.Controls.Add(this.txtVstup);
            this.Controls.Add(this.comboBoxVstup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVstup;
        private System.Windows.Forms.TextBox txtVstup;
        private System.Windows.Forms.Label labelKM;
        private System.Windows.Forms.Button btn_vypocet;
    }
}

