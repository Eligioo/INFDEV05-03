namespace Assignment_1
{
    partial class AddEditDegree
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
            this.textBox_course = new System.Windows.Forms.TextBox();
            this.textBox_school = new System.Windows.Forms.TextBox();
            this.textBox_level = new System.Windows.Forms.TextBox();
            this.saveDegreeButton = new System.Windows.Forms.Button();
            this.cancelDegreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "School";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level";
            // 
            // textBox_course
            // 
            this.textBox_course.Location = new System.Drawing.Point(3, 35);
            this.textBox_course.Name = "textBox_course";
            this.textBox_course.Size = new System.Drawing.Size(273, 20);
            this.textBox_course.TabIndex = 3;
            // 
            // textBox_school
            // 
            this.textBox_school.Location = new System.Drawing.Point(3, 74);
            this.textBox_school.Name = "textBox_school";
            this.textBox_school.Size = new System.Drawing.Size(273, 20);
            this.textBox_school.TabIndex = 4;
            // 
            // textBox_level
            // 
            this.textBox_level.Location = new System.Drawing.Point(3, 113);
            this.textBox_level.Name = "textBox_level";
            this.textBox_level.Size = new System.Drawing.Size(273, 20);
            this.textBox_level.TabIndex = 5;
            // 
            // saveDegreeButton
            // 
            this.saveDegreeButton.Location = new System.Drawing.Point(3, 184);
            this.saveDegreeButton.Name = "saveDegreeButton";
            this.saveDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.saveDegreeButton.TabIndex = 6;
            this.saveDegreeButton.Text = "Save";
            this.saveDegreeButton.UseVisualStyleBackColor = true;
            this.saveDegreeButton.Click += new System.EventHandler(this.saveDegreeButton_Click);
            // 
            // cancelDegreeButton
            // 
            this.cancelDegreeButton.Location = new System.Drawing.Point(201, 184);
            this.cancelDegreeButton.Name = "cancelDegreeButton";
            this.cancelDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.cancelDegreeButton.TabIndex = 7;
            this.cancelDegreeButton.Text = "Cancel";
            this.cancelDegreeButton.UseVisualStyleBackColor = true;
            this.cancelDegreeButton.Click += new System.EventHandler(this.cancelDegreeButton_Click);
            // 
            // AddEditDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 219);
            this.Controls.Add(this.cancelDegreeButton);
            this.Controls.Add(this.saveDegreeButton);
            this.Controls.Add(this.textBox_level);
            this.Controls.Add(this.textBox_school);
            this.Controls.Add(this.textBox_course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditDegree";
            this.Text = "AddEditDegree";
            this.Activated += new System.EventHandler(this.AddEditDegree_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_course;
        private System.Windows.Forms.TextBox textBox_school;
        private System.Windows.Forms.TextBox textBox_level;
        private System.Windows.Forms.Button saveDegreeButton;
        private System.Windows.Forms.Button cancelDegreeButton;
    }
}