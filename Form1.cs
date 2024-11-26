﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Project_1
{
    /*
        To-Do List Project .
        It took me 30 minutes.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool ItIsEmpty()
        {
            if (tbTask.Text == "")
            {
                MessageBox.Show("The Task Not Add/Remove Becuse It \"Empty\"!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (ItIsEmpty()) return;

            string Task = $"{tbTask.Text}";
            checkedListBox1.Items.Add(Task);
            MessageBox.Show("The Task Add Successfully!","Add Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnRemoveThisTask_Click(object sender, EventArgs e)
        {
            if (ItIsEmpty()) return;

            string TheTask = (string)tbTask.Text;

            for (byte i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == TheTask)
                {
                    checkedListBox1.Items.RemoveAt(i);
                    MessageBox.Show("The Task Remove Successfully!", "Remove Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            tbTask.Focus();
        }

    }
}