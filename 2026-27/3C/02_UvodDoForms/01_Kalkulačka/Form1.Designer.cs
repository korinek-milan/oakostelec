namespace _01_Kalkulačka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_soucet = new Button();
            vysledek = new Label();
            txt_prvniCislo = new TextBox();
            txt_druheCislo = new TextBox();
            SuspendLayout();
            // 
            // btn_soucet
            // 
            btn_soucet.Location = new Point(208, 212);
            btn_soucet.Name = "btn_soucet";
            btn_soucet.Size = new Size(75, 23);
            btn_soucet.TabIndex = 0;
            btn_soucet.Text = "+";
            btn_soucet.UseVisualStyleBackColor = true;
            btn_soucet.Click += btn_soucet_Click;
            // 
            // vysledek
            // 
            vysledek.AutoSize = true;
            vysledek.Location = new Point(451, 216);
            vysledek.Name = "vysledek";
            vysledek.Size = new Size(38, 15);
            vysledek.TabIndex = 1;
            vysledek.Text = "label1";
            // 
            // txt_prvniCislo
            // 
            txt_prvniCislo.Location = new Point(74, 212);
            txt_prvniCislo.Name = "txt_prvniCislo";
            txt_prvniCislo.Size = new Size(100, 23);
            txt_prvniCislo.TabIndex = 2;
            // 
            // txt_druheCislo
            // 
            txt_druheCislo.Location = new Point(306, 212);
            txt_druheCislo.Name = "txt_druheCislo";
            txt_druheCislo.Size = new Size(100, 23);
            txt_druheCislo.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_druheCislo);
            Controls.Add(txt_prvniCislo);
            Controls.Add(vysledek);
            Controls.Add(btn_soucet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_soucet;
        private Label vysledek;
        private TextBox txt_prvniCislo;
        private TextBox txt_druheCislo;
    }
}
