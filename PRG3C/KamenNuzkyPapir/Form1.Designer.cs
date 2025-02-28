namespace KamenNuzkyPapir
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
            this.VictoryLabel = new System.Windows.Forms.Label();
            this.WinLooseRatioLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpockBtn = new System.Windows.Forms.Button();
            this.TapirBtn = new System.Windows.Forms.Button();
            this.ScissorsBtn = new System.Windows.Forms.Button();
            this.PaperBtn = new System.Windows.Forms.Button();
            this.stoneBtn = new System.Windows.Forms.Button();
            this.EnemyChoice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // VictoryLabel
            // 
            this.VictoryLabel.AutoSize = true;
            this.VictoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VictoryLabel.ForeColor = System.Drawing.Color.Lime;
            this.VictoryLabel.Location = new System.Drawing.Point(338, 11);
            this.VictoryLabel.Name = "VictoryLabel";
            this.VictoryLabel.Size = new System.Drawing.Size(168, 63);
            this.VictoryLabel.TabIndex = 4;
            this.VictoryLabel.Text = "Výhra";
            // 
            // WinLooseRatioLbl
            // 
            this.WinLooseRatioLbl.AutoSize = true;
            this.WinLooseRatioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WinLooseRatioLbl.Location = new System.Drawing.Point(35, 34);
            this.WinLooseRatioLbl.Name = "WinLooseRatioLbl";
            this.WinLooseRatioLbl.Size = new System.Drawing.Size(265, 31);
            this.WinLooseRatioLbl.TabIndex = 5;
            this.WinLooseRatioLbl.Text = "poměr výher - proher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(545, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Protihráč";
            // 
            // SpockBtn
            // 
            this.SpockBtn.BackgroundImage = global::KamenNuzkyPapir.Properties.Resources.spock;
            this.SpockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpockBtn.Location = new System.Drawing.Point(41, 200);
            this.SpockBtn.Name = "SpockBtn";
            this.SpockBtn.Size = new System.Drawing.Size(100, 100);
            this.SpockBtn.TabIndex = 8;
            this.SpockBtn.UseVisualStyleBackColor = true;
            this.SpockBtn.Click += new System.EventHandler(this.SpockBtn_Click);
            // 
            // TapirBtn
            // 
            this.TapirBtn.BackgroundImage = global::KamenNuzkyPapir.Properties.Resources.tapir;
            this.TapirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TapirBtn.Location = new System.Drawing.Point(94, 323);
            this.TapirBtn.Name = "TapirBtn";
            this.TapirBtn.Size = new System.Drawing.Size(100, 100);
            this.TapirBtn.TabIndex = 7;
            this.TapirBtn.UseVisualStyleBackColor = true;
            this.TapirBtn.Click += new System.EventHandler(this.TapirBtn_Click);
            // 
            // ScissorsBtn
            // 
            this.ScissorsBtn.BackgroundImage = global::KamenNuzkyPapir.Properties.Resources.scissors;
            this.ScissorsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScissorsBtn.Location = new System.Drawing.Point(279, 323);
            this.ScissorsBtn.Name = "ScissorsBtn";
            this.ScissorsBtn.Size = new System.Drawing.Size(100, 100);
            this.ScissorsBtn.TabIndex = 3;
            this.ScissorsBtn.UseVisualStyleBackColor = true;
            this.ScissorsBtn.Click += new System.EventHandler(this.ScissorsBtn_Click);
            // 
            // PaperBtn
            // 
            this.PaperBtn.BackgroundImage = global::KamenNuzkyPapir.Properties.Resources.paper;
            this.PaperBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaperBtn.Location = new System.Drawing.Point(320, 200);
            this.PaperBtn.Name = "PaperBtn";
            this.PaperBtn.Size = new System.Drawing.Size(100, 100);
            this.PaperBtn.TabIndex = 2;
            this.PaperBtn.UseVisualStyleBackColor = true;
            this.PaperBtn.Click += new System.EventHandler(this.PaperBtn_Click);
            // 
            // stoneBtn
            // 
            this.stoneBtn.BackgroundImage = global::KamenNuzkyPapir.Properties.Resources.stone;
            this.stoneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stoneBtn.Location = new System.Drawing.Point(183, 94);
            this.stoneBtn.Name = "stoneBtn";
            this.stoneBtn.Size = new System.Drawing.Size(100, 100);
            this.stoneBtn.TabIndex = 1;
            this.stoneBtn.UseVisualStyleBackColor = true;
            this.stoneBtn.Click += new System.EventHandler(this.RockBtn_Click);
            // 
            // EnemyChoice
            // 
            this.EnemyChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnemyChoice.Image = global::KamenNuzkyPapir.Properties.Resources.HappyLlama;
            this.EnemyChoice.InitialImage = global::KamenNuzkyPapir.Properties.Resources.HappyLlama;
            this.EnemyChoice.Location = new System.Drawing.Point(466, 94);
            this.EnemyChoice.Name = "EnemyChoice";
            this.EnemyChoice.Size = new System.Drawing.Size(284, 280);
            this.EnemyChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnemyChoice.TabIndex = 0;
            this.EnemyChoice.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpockBtn);
            this.Controls.Add(this.TapirBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WinLooseRatioLbl);
            this.Controls.Add(this.VictoryLabel);
            this.Controls.Add(this.ScissorsBtn);
            this.Controls.Add(this.PaperBtn);
            this.Controls.Add(this.stoneBtn);
            this.Controls.Add(this.EnemyChoice);
            this.Name = "Form1";
            this.Text = "Kámen - Nůžky - Papír";
            ((System.ComponentModel.ISupportInitialize)(this.EnemyChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EnemyChoice;
        private System.Windows.Forms.Button stoneBtn;
        private System.Windows.Forms.Button PaperBtn;
        private System.Windows.Forms.Button ScissorsBtn;
        private System.Windows.Forms.Label VictoryLabel;
        private System.Windows.Forms.Label WinLooseRatioLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TapirBtn;
        private System.Windows.Forms.Button SpockBtn;
    }
}

