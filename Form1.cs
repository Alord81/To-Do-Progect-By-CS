using System;
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
        It took me 1 hour and 15 minutes.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool IsEmpty()
        {
            if (tbTask.Text == "")
            {
                MessageBox.Show("The task did not add/Remove becuse it \"Empty\"!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        bool IsExist(string Task)
        {
            for (byte i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString() == Task.ToString())
                    return true;
            }

            return false;
        }

        byte CountRepeatedTask(string Task)
        {
            byte count = 0;
            for (byte i = 0;i < checkedListBox1.Items.Count;i++)
            {
                if ((checkedListBox1.Items[i].ToString() == (count == 0 ? Task : $"{Task} - {count}")))
                    count++;
            }

            return count;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (IsEmpty()) return;


            string Task = $"{tbTask.Text}";
            
            if (IsExist(Task))
            {
                Task = $"{tbTask.Text} - {CountRepeatedTask(tbTask.Text)}";
            }

            checkedListBox1.Items.Add(Task);
            MessageBox.Show("The Task Add Successfully!","Add Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
            tbTask.Text = "";
        }

        private void btnRemoveThisTask_Click(object sender, EventArgs e)
        {
            if (IsEmpty()) return;

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

        private void btnCompletedAllTasks_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnUncompletedAllTasks_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        void RemoveTaskByName(string Task)
        {
            for (byte i = 0;i < checkedListBox1.Items.Count;i++)
            {
                if (checkedListBox1.Items[i].ToString() == Task)
                { 
                    checkedListBox1.Items.RemoveAt(i);
                    return;
                }
                
            }
        }
        private void btnRemoveCompletedTasks_Click(object sender, EventArgs e)
        {
            bool IsRemovedon = false;
            
            for (byte i = 0;i <checkedListBox1.Items.Count;i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    RemoveTaskByName(checkedListBox1.Items[i].ToString());
                    i--;
                }
            }

            if (IsRemovedon)
            {
                MessageBox.Show("The Task(s) Remove Successfully!", "Remove Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRemoveAllTasks_Click(object sender, EventArgs e)
        {
            while(checkedListBox1.Items.Count != 0)
                checkedListBox1.Items.RemoveAt(0);
        }

    }
}
