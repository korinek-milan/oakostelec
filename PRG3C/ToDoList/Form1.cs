using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToDoList
{
    public partial class Form1 : Form
    {
        List<CheckBox> checkedList = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            //string inputText = txtBox_AddItem.Text;

            combo_ListOfItems.Items.Add(txtBox_AddItem.Text);
            refreshCheckboxes();

        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            combo_ListOfItems.Items.Remove(combo_ListOfItems.SelectedItem);
            refreshCheckboxes();
        }

        public void refreshCheckboxes()
        {
            foreach (CheckBox c in checkedList)
            {
                c.Dispose();
            }

            int i = 0;
            int j = 0;
            foreach(var item in combo_ListOfItems.Items)
            {
                CheckBox box = new CheckBox();
                //box.Tag = i.ToString();
                box.Text = item.ToString();
                box.AutoSize = true;
                box.Location = new Point(10 + j * 50, 20 + i * 20);
                
                //panel1.Controls.Add(box);
                //this.Controls.Add(box);
                checkedList.Add(box);
                i++;
                if (i > 9)
                {
                    i = 0;
                    j++;
                }

                flowLayoutPanel1.Controls.Add(box);


            }
        }

    }
}
