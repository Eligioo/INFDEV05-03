namespace Assignment_1
{
    partial class AddEditEmployee
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.bsn = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.residenceListbox = new System.Windows.Forms.ListBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.addResidenceButton = new System.Windows.Forms.Button();
            this.setCurrentResidenceButton = new System.Windows.Forms.Button();
            this.editResidenceButton = new System.Windows.Forms.Button();
            this.deleteResidenceButton = new System.Windows.Forms.Button();
            this.degreeListBox = new System.Windows.Forms.ListBox();
            this.label_Degree = new System.Windows.Forms.Label();
            this.addDegreeButton = new System.Windows.Forms.Button();
            this.editDegreeButton = new System.Windows.Forms.Button();
            this.deleteDegreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(15, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(15, 67);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(198, 20);
            this.surname.TabIndex = 2;
            // 
            // bsn
            // 
            this.bsn.Location = new System.Drawing.Point(15, 93);
            this.bsn.MaxLength = 6;
            this.bsn.Name = "bsn";
            this.bsn.Size = new System.Drawing.Size(198, 20);
            this.bsn.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Residence (selected is current)";
            // 
            // residenceListbox
            // 
            this.residenceListbox.FormattingEnabled = true;
            this.residenceListbox.Location = new System.Drawing.Point(15, 182);
            this.residenceListbox.Name = "residenceListbox";
            this.residenceListbox.Size = new System.Drawing.Size(198, 108);
            this.residenceListbox.TabIndex = 6;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(15, 315);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(138, 315);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // addResidenceButton
            // 
            this.addResidenceButton.Location = new System.Drawing.Point(219, 182);
            this.addResidenceButton.Name = "addResidenceButton";
            this.addResidenceButton.Size = new System.Drawing.Size(75, 23);
            this.addResidenceButton.TabIndex = 9;
            this.addResidenceButton.Text = "Add";
            this.addResidenceButton.UseVisualStyleBackColor = true;
            this.addResidenceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // setCurrentResidenceButton
            // 
            this.setCurrentResidenceButton.Location = new System.Drawing.Point(219, 211);
            this.setCurrentResidenceButton.Name = "setCurrentResidenceButton";
            this.setCurrentResidenceButton.Size = new System.Drawing.Size(75, 23);
            this.setCurrentResidenceButton.TabIndex = 10;
            this.setCurrentResidenceButton.Text = "Set";
            this.setCurrentResidenceButton.UseVisualStyleBackColor = true;
            this.setCurrentResidenceButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // editResidenceButton
            // 
            this.editResidenceButton.Location = new System.Drawing.Point(219, 240);
            this.editResidenceButton.Name = "editResidenceButton";
            this.editResidenceButton.Size = new System.Drawing.Size(75, 23);
            this.editResidenceButton.TabIndex = 11;
            this.editResidenceButton.Text = "Edit";
            this.editResidenceButton.UseVisualStyleBackColor = true;
            this.editResidenceButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteResidenceButton
            // 
            this.deleteResidenceButton.Location = new System.Drawing.Point(219, 269);
            this.deleteResidenceButton.Name = "deleteResidenceButton";
            this.deleteResidenceButton.Size = new System.Drawing.Size(75, 23);
            this.deleteResidenceButton.TabIndex = 12;
            this.deleteResidenceButton.Text = "Delete";
            this.deleteResidenceButton.UseVisualStyleBackColor = true;
            this.deleteResidenceButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // degreeListBox
            // 
            this.degreeListBox.FormattingEnabled = true;
            this.degreeListBox.Location = new System.Drawing.Point(338, 41);
            this.degreeListBox.Name = "degreeListBox";
            this.degreeListBox.Size = new System.Drawing.Size(237, 95);
            this.degreeListBox.TabIndex = 13;
            // 
            // label_Degree
            // 
            this.label_Degree.AutoSize = true;
            this.label_Degree.Location = new System.Drawing.Point(335, 25);
            this.label_Degree.Name = "label_Degree";
            this.label_Degree.Size = new System.Drawing.Size(47, 13);
            this.label_Degree.TabIndex = 14;
            this.label_Degree.Text = "Degrees";
            // 
            // addDegreeButton
            // 
            this.addDegreeButton.Location = new System.Drawing.Point(581, 41);
            this.addDegreeButton.Name = "addDegreeButton";
            this.addDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.addDegreeButton.TabIndex = 15;
            this.addDegreeButton.Text = "Add";
            this.addDegreeButton.UseVisualStyleBackColor = true;
            this.addDegreeButton.Click += new System.EventHandler(this.addDegreeButton_Click);
            // 
            // editDegreeButton
            // 
            this.editDegreeButton.Location = new System.Drawing.Point(581, 70);
            this.editDegreeButton.Name = "editDegreeButton";
            this.editDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.editDegreeButton.TabIndex = 16;
            this.editDegreeButton.Text = "Edit";
            this.editDegreeButton.UseVisualStyleBackColor = true;
            this.editDegreeButton.Click += new System.EventHandler(this.editDegreeButton_Click);
            // 
            // deleteDegreeButton
            // 
            this.deleteDegreeButton.Location = new System.Drawing.Point(581, 99);
            this.deleteDegreeButton.Name = "deleteDegreeButton";
            this.deleteDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDegreeButton.TabIndex = 17;
            this.deleteDegreeButton.Text = "Delete";
            this.deleteDegreeButton.UseVisualStyleBackColor = true;
            this.deleteDegreeButton.Click += new System.EventHandler(this.deleteDegreeButton_Click);
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 372);
            this.Controls.Add(this.deleteDegreeButton);
            this.Controls.Add(this.editDegreeButton);
            this.Controls.Add(this.addDegreeButton);
            this.Controls.Add(this.label_Degree);
            this.Controls.Add(this.degreeListBox);
            this.Controls.Add(this.deleteResidenceButton);
            this.Controls.Add(this.editResidenceButton);
            this.Controls.Add(this.setCurrentResidenceButton);
            this.Controls.Add(this.addResidenceButton);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.residenceListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bsn);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "AddEditEmployee";
            this.Text = "AddEditEmployee";
            this.Activated += new System.EventHandler(this.AddEditEmployee_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox bsn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox residenceListbox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button addResidenceButton;
        private System.Windows.Forms.Button setCurrentResidenceButton;
        private System.Windows.Forms.Button editResidenceButton;
        private System.Windows.Forms.Button deleteResidenceButton;
        private System.Windows.Forms.ListBox degreeListBox;
        private System.Windows.Forms.Label label_Degree;
        private System.Windows.Forms.Button addDegreeButton;
        private System.Windows.Forms.Button editDegreeButton;
        private System.Windows.Forms.Button deleteDegreeButton;
    }
}