namespace ToDoList
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
            this.txtBox_AddItem = new System.Windows.Forms.TextBox();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.combo_ListOfItems = new System.Windows.Forms.ComboBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBox_AddItem
            // 
            this.txtBox_AddItem.Location = new System.Drawing.Point(304, 120);
            this.txtBox_AddItem.Name = "txtBox_AddItem";
            this.txtBox_AddItem.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AddItem.TabIndex = 0;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(446, 120);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(75, 23);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "Přidat položku";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // combo_ListOfItems
            // 
            this.combo_ListOfItems.FormattingEnabled = true;
            this.combo_ListOfItems.Location = new System.Drawing.Point(75, 120);
            this.combo_ListOfItems.Name = "combo_ListOfItems";
            this.combo_ListOfItems.Size = new System.Drawing.Size(121, 21);
            this.combo_ListOfItems.TabIndex = 2;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(109, 158);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "odebrat";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(75, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 251);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(527, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 226);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(345, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.combo_ListOfItems);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.txtBox_AddItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_AddItem;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.ComboBox combo_ListOfItems;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

