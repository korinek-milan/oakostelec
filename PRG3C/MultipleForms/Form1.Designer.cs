﻿namespace MultipleForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn1f1 = new System.Windows.Forms.Button();
            this.txt1f1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toto je první formulář";
            // 
            // btn1f1
            // 
            this.btn1f1.Location = new System.Drawing.Point(233, 200);
            this.btn1f1.Name = "btn1f1";
            this.btn1f1.Size = new System.Drawing.Size(75, 23);
            this.btn1f1.TabIndex = 1;
            this.btn1f1.Text = "button1";
            this.btn1f1.UseVisualStyleBackColor = true;
            this.btn1f1.Click += new System.EventHandler(this.btn1f1_Click);
            // 
            // txt1f1
            // 
            this.txt1f1.Location = new System.Drawing.Point(448, 202);
            this.txt1f1.Name = "txt1f1";
            this.txt1f1.Size = new System.Drawing.Size(100, 20);
            this.txt1f1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt1f1);
            this.Controls.Add(this.btn1f1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1f1;
        private System.Windows.Forms.TextBox txt1f1;
    }
}

