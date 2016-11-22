namespace Assignment_1
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
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.EditEmployeeBtn = new System.Windows.Forms.Button();
            this.DeleteEmployeBtn = new System.Windows.Forms.Button();
            this.EmployeePropertiesLbl = new System.Windows.Forms.Label();
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.ProjectPropertiesLbl = new System.Windows.Forms.Label();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.EditProjectBtn = new System.Windows.Forms.Button();
            this.DeleteProjectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PositionsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.positionDeleteButton = new System.Windows.Forms.Button();
            this.positionEditButton = new System.Windows.Forms.Button();
            this.positionAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.Location = new System.Drawing.Point(12, 44);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(290, 199);
            this.EmployeesListBox.TabIndex = 0;
            this.EmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeesListBox_SelectedIndexChanged);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Location = new System.Drawing.Point(29, 301);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.AddEmployeeBtn.TabIndex = 1;
            this.AddEmployeeBtn.Text = "Add";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.Location = new System.Drawing.Point(110, 301);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.EditEmployeeBtn.TabIndex = 2;
            this.EditEmployeeBtn.Text = "Edit";
            this.EditEmployeeBtn.UseVisualStyleBackColor = true;
            this.EditEmployeeBtn.Click += new System.EventHandler(this.EditEmployeeBtn_Click);
            // 
            // DeleteEmployeBtn
            // 
            this.DeleteEmployeBtn.Location = new System.Drawing.Point(191, 301);
            this.DeleteEmployeBtn.Name = "DeleteEmployeBtn";
            this.DeleteEmployeBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteEmployeBtn.TabIndex = 3;
            this.DeleteEmployeBtn.Text = "Delete";
            this.DeleteEmployeBtn.UseVisualStyleBackColor = true;
            this.DeleteEmployeBtn.Click += new System.EventHandler(this.DeleteEmployeBtn_Click);
            // 
            // EmployeePropertiesLbl
            // 
            this.EmployeePropertiesLbl.AutoSize = true;
            this.EmployeePropertiesLbl.Location = new System.Drawing.Point(95, 266);
            this.EmployeePropertiesLbl.Name = "EmployeePropertiesLbl";
            this.EmployeePropertiesLbl.Size = new System.Drawing.Size(103, 13);
            this.EmployeePropertiesLbl.TabIndex = 4;
            this.EmployeePropertiesLbl.Text = "Employee Properties";
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.Location = new System.Drawing.Point(345, 44);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.Size = new System.Drawing.Size(290, 199);
            this.ProjectsListBox.TabIndex = 5;
            // 
            // ProjectPropertiesLbl
            // 
            this.ProjectPropertiesLbl.AutoSize = true;
            this.ProjectPropertiesLbl.Location = new System.Drawing.Point(439, 266);
            this.ProjectPropertiesLbl.Name = "ProjectPropertiesLbl";
            this.ProjectPropertiesLbl.Size = new System.Drawing.Size(90, 13);
            this.ProjectPropertiesLbl.TabIndex = 6;
            this.ProjectPropertiesLbl.Text = "Project Properties";
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Location = new System.Drawing.Point(373, 301);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProjectBtn.TabIndex = 7;
            this.AddProjectBtn.Text = "Add";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // EditProjectBtn
            // 
            this.EditProjectBtn.Location = new System.Drawing.Point(454, 301);
            this.EditProjectBtn.Name = "EditProjectBtn";
            this.EditProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.EditProjectBtn.TabIndex = 8;
            this.EditProjectBtn.Text = "Edit";
            this.EditProjectBtn.UseVisualStyleBackColor = true;
            this.EditProjectBtn.Click += new System.EventHandler(this.EditProjectBtn_Click);
            // 
            // DeleteProjectBtn
            // 
            this.DeleteProjectBtn.Location = new System.Drawing.Point(535, 301);
            this.DeleteProjectBtn.Name = "DeleteProjectBtn";
            this.DeleteProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteProjectBtn.TabIndex = 9;
            this.DeleteProjectBtn.Text = "Remove";
            this.DeleteProjectBtn.UseVisualStyleBackColor = true;
            this.DeleteProjectBtn.Click += new System.EventHandler(this.DeleteProjectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "BSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Project ID";
            // 
            // PositionsListBox
            // 
            this.PositionsListBox.FormattingEnabled = true;
            this.PositionsListBox.Location = new System.Drawing.Point(676, 44);
            this.PositionsListBox.Name = "PositionsListBox";
            this.PositionsListBox.Size = new System.Drawing.Size(290, 199);
            this.PositionsListBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Position";
            // 
            // positionDeleteButton
            // 
            this.positionDeleteButton.Location = new System.Drawing.Point(862, 301);
            this.positionDeleteButton.Name = "positionDeleteButton";
            this.positionDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.positionDeleteButton.TabIndex = 21;
            this.positionDeleteButton.Text = "Remove";
            this.positionDeleteButton.UseVisualStyleBackColor = true;
            this.positionDeleteButton.Click += new System.EventHandler(this.positionDeleteButton_Click);
            // 
            // positionEditButton
            // 
            this.positionEditButton.Location = new System.Drawing.Point(781, 301);
            this.positionEditButton.Name = "positionEditButton";
            this.positionEditButton.Size = new System.Drawing.Size(75, 23);
            this.positionEditButton.TabIndex = 20;
            this.positionEditButton.Text = "Edit";
            this.positionEditButton.UseVisualStyleBackColor = true;
            this.positionEditButton.Click += new System.EventHandler(this.positionEditButton_Click);
            // 
            // positionAddButton
            // 
            this.positionAddButton.Location = new System.Drawing.Point(700, 301);
            this.positionAddButton.Name = "positionAddButton";
            this.positionAddButton.Size = new System.Drawing.Size(75, 23);
            this.positionAddButton.TabIndex = 19;
            this.positionAddButton.Text = "Add";
            this.positionAddButton.UseVisualStyleBackColor = true;
            this.positionAddButton.Click += new System.EventHandler(this.positionAddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 338);
            this.Controls.Add(this.positionDeleteButton);
            this.Controls.Add(this.positionEditButton);
            this.Controls.Add(this.positionAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionsListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteProjectBtn);
            this.Controls.Add(this.EditProjectBtn);
            this.Controls.Add(this.AddProjectBtn);
            this.Controls.Add(this.ProjectPropertiesLbl);
            this.Controls.Add(this.ProjectsListBox);
            this.Controls.Add(this.EmployeePropertiesLbl);
            this.Controls.Add(this.DeleteEmployeBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.EmployeesListBox);
            this.Name = "Form1";
            this.Text = "Assignment 1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button EditEmployeeBtn;
        private System.Windows.Forms.Button DeleteEmployeBtn;
        private System.Windows.Forms.Label EmployeePropertiesLbl;
        private System.Windows.Forms.ListBox ProjectsListBox;
        private System.Windows.Forms.Label ProjectPropertiesLbl;
        private System.Windows.Forms.Button AddProjectBtn;
        private System.Windows.Forms.Button EditProjectBtn;
        private System.Windows.Forms.Button DeleteProjectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox PositionsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button positionDeleteButton;
        private System.Windows.Forms.Button positionEditButton;
        private System.Windows.Forms.Button positionAddButton;
    }
}

