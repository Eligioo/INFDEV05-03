namespace Assignment_1
{
    partial class AddEditProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.allocatedHoursTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_positions = new System.Windows.Forms.ListBox();
            this.AddPositionButton = new System.Windows.Forms.Button();
            this.editPositionButton = new System.Windows.Forms.Button();
            this.deletePositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Allocated hours";
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(6, 24);
            this.projectTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(120, 20);
            this.projectTextBox.TabIndex = 3;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(6, 75);
            this.budgetTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(120, 20);
            this.budgetTextBox.TabIndex = 4;
            // 
            // allocatedHoursTextBox
            // 
            this.allocatedHoursTextBox.Location = new System.Drawing.Point(6, 127);
            this.allocatedHoursTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allocatedHoursTextBox.Name = "allocatedHoursTextBox";
            this.allocatedHoursTextBox.Size = new System.Drawing.Size(120, 20);
            this.allocatedHoursTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 299);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 195);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Project headquarter";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add headquarter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Positions";
            // 
            // listBox_positions
            // 
            this.listBox_positions.FormattingEnabled = true;
            this.listBox_positions.Location = new System.Drawing.Point(279, 23);
            this.listBox_positions.Name = "listBox_positions";
            this.listBox_positions.Size = new System.Drawing.Size(187, 147);
            this.listBox_positions.TabIndex = 12;
            // 
            // AddPositionButton
            // 
            this.AddPositionButton.Location = new System.Drawing.Point(472, 24);
            this.AddPositionButton.Name = "AddPositionButton";
            this.AddPositionButton.Size = new System.Drawing.Size(75, 23);
            this.AddPositionButton.TabIndex = 13;
            this.AddPositionButton.Text = "Add";
            this.AddPositionButton.UseVisualStyleBackColor = true;
            this.AddPositionButton.Click += new System.EventHandler(this.AddPositionButton_Click);
            // 
            // editPositionButton
            // 
            this.editPositionButton.Location = new System.Drawing.Point(472, 53);
            this.editPositionButton.Name = "editPositionButton";
            this.editPositionButton.Size = new System.Drawing.Size(75, 23);
            this.editPositionButton.TabIndex = 14;
            this.editPositionButton.Text = "Edit";
            this.editPositionButton.UseVisualStyleBackColor = true;
            this.editPositionButton.Click += new System.EventHandler(this.editPositionButton_Click);
            // 
            // deletePositionButton
            // 
            this.deletePositionButton.Location = new System.Drawing.Point(472, 82);
            this.deletePositionButton.Name = "deletePositionButton";
            this.deletePositionButton.Size = new System.Drawing.Size(75, 23);
            this.deletePositionButton.TabIndex = 15;
            this.deletePositionButton.Text = "Delete";
            this.deletePositionButton.UseVisualStyleBackColor = true;
            this.deletePositionButton.Click += new System.EventHandler(this.deletePositionButton_Click);
            // 
            // AddEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 327);
            this.Controls.Add(this.deletePositionButton);
            this.Controls.Add(this.editPositionButton);
            this.Controls.Add(this.AddPositionButton);
            this.Controls.Add(this.listBox_positions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allocatedHoursTextBox);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEditProject";
            this.Text = "Project";
            this.Activated += new System.EventHandler(this.AddEditProject_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox allocatedHoursTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_positions;
        private System.Windows.Forms.Button AddPositionButton;
        private System.Windows.Forms.Button editPositionButton;
        private System.Windows.Forms.Button deletePositionButton;
    }
}