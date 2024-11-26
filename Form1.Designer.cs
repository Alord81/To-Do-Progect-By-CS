namespace To_Do_List_Project_1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveCompletedTasks = new System.Windows.Forms.Button();
            this.btnUncompletedAllTasks = new System.Windows.Forms.Button();
            this.btnCompletedAllTasks = new System.Windows.Forms.Button();
            this.btnRemoveThisTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedListBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(785, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(412, 735);
            this.checkedListBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnRemoveCompletedTasks);
            this.panel1.Controls.Add(this.btnUncompletedAllTasks);
            this.panel1.Controls.Add(this.btnCompletedAllTasks);
            this.panel1.Controls.Add(this.btnRemoveThisTask);
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 735);
            this.panel1.TabIndex = 2;
            // 
            // btnRemoveCompletedTasks
            // 
            this.btnRemoveCompletedTasks.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveCompletedTasks.FlatAppearance.BorderSize = 0;
            this.btnRemoveCompletedTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCompletedTasks.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCompletedTasks.Location = new System.Drawing.Point(23, 289);
            this.btnRemoveCompletedTasks.Margin = new System.Windows.Forms.Padding(28);
            this.btnRemoveCompletedTasks.Name = "btnRemoveCompletedTasks";
            this.btnRemoveCompletedTasks.Size = new System.Drawing.Size(180, 50);
            this.btnRemoveCompletedTasks.TabIndex = 8;
            this.btnRemoveCompletedTasks.Text = "Remove Completed Tasks";
            this.btnRemoveCompletedTasks.UseVisualStyleBackColor = false;
            this.btnRemoveCompletedTasks.Click += new System.EventHandler(this.btnRemoveCompletedTasks_Click);
            // 
            // btnUncompletedAllTasks
            // 
            this.btnUncompletedAllTasks.BackColor = System.Drawing.Color.Tomato;
            this.btnUncompletedAllTasks.FlatAppearance.BorderSize = 0;
            this.btnUncompletedAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUncompletedAllTasks.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnUncompletedAllTasks.Location = new System.Drawing.Point(231, 211);
            this.btnUncompletedAllTasks.Margin = new System.Windows.Forms.Padding(28);
            this.btnUncompletedAllTasks.Name = "btnUncompletedAllTasks";
            this.btnUncompletedAllTasks.Size = new System.Drawing.Size(180, 50);
            this.btnUncompletedAllTasks.TabIndex = 7;
            this.btnUncompletedAllTasks.Text = "Uncompleted All Tasks";
            this.btnUncompletedAllTasks.UseVisualStyleBackColor = false;
            this.btnUncompletedAllTasks.Click += new System.EventHandler(this.btnUncompletedAllTasks_Click);
            // 
            // btnCompletedAllTasks
            // 
            this.btnCompletedAllTasks.BackColor = System.Drawing.Color.Tomato;
            this.btnCompletedAllTasks.FlatAppearance.BorderSize = 0;
            this.btnCompletedAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletedAllTasks.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnCompletedAllTasks.Location = new System.Drawing.Point(23, 211);
            this.btnCompletedAllTasks.Margin = new System.Windows.Forms.Padding(28);
            this.btnCompletedAllTasks.Name = "btnCompletedAllTasks";
            this.btnCompletedAllTasks.Size = new System.Drawing.Size(180, 50);
            this.btnCompletedAllTasks.TabIndex = 6;
            this.btnCompletedAllTasks.Text = "Completed All Tasks";
            this.btnCompletedAllTasks.UseVisualStyleBackColor = false;
            this.btnCompletedAllTasks.Click += new System.EventHandler(this.btnCompletedAllTasks_Click);
            // 
            // btnRemoveThisTask
            // 
            this.btnRemoveThisTask.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveThisTask.FlatAppearance.BorderSize = 0;
            this.btnRemoveThisTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveThisTask.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnRemoveThisTask.Location = new System.Drawing.Point(231, 133);
            this.btnRemoveThisTask.Margin = new System.Windows.Forms.Padding(28);
            this.btnRemoveThisTask.Name = "btnRemoveThisTask";
            this.btnRemoveThisTask.Size = new System.Drawing.Size(180, 50);
            this.btnRemoveThisTask.TabIndex = 5;
            this.btnRemoveThisTask.Text = "Remove This Task";
            this.btnRemoveThisTask.UseVisualStyleBackColor = false;
            this.btnRemoveThisTask.Click += new System.EventHandler(this.btnRemoveThisTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Tomato;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(23, 133);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(28);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(180, 50);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task :";
            // 
            // tbTask
            // 
            this.tbTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTask.Location = new System.Drawing.Point(23, 73);
            this.tbTask.Margin = new System.Windows.Forms.Padding(10);
            this.tbTask.MaxLength = 45;
            this.tbTask.Multiline = true;
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(388, 30);
            this.tbTask.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.Button btnRemoveThisTask;
        private System.Windows.Forms.Button btnCompletedAllTasks;
        private System.Windows.Forms.Button btnUncompletedAllTasks;
        private System.Windows.Forms.Button btnRemoveCompletedTasks;
    }
}

