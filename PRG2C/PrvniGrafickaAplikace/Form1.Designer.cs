namespace PrvniGrafickaAplikace
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
            this.btn_akcni = new System.Windows.Forms.Button();
            this.txt_vystup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_akcni
            // 
            this.btn_akcni.Location = new System.Drawing.Point(350, 65);
            this.btn_akcni.Name = "btn_akcni";
            this.btn_akcni.Size = new System.Drawing.Size(208, 269);
            this.btn_akcni.TabIndex = 0;
            this.btn_akcni.Text = "moje tlačítko";
            this.btn_akcni.UseVisualStyleBackColor = true;
            this.btn_akcni.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_vystup
            // 
            this.txt_vystup.Location = new System.Drawing.Point(50, 123);
            this.txt_vystup.Name = "txt_vystup";
            this.txt_vystup.Size = new System.Drawing.Size(242, 20);
            this.txt_vystup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vystup);
            this.Controls.Add(this.btn_akcni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_akcni;
        private System.Windows.Forms.TextBox txt_vystup;
        private System.Windows.Forms.Label label1;
    }
}

