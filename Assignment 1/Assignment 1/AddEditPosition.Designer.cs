namespace Assignment_1
{
    partial class AddEditPosition
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_hourfee = new System.Windows.Forms.TextBox();
            this.savePositionButton = new System.Windows.Forms.Button();
            this.cancelPositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hour fee";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(15, 25);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(324, 20);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(15, 64);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(324, 20);
            this.textBox_description.TabIndex = 6;
            // 
            // textBox_hourfee
            // 
            this.textBox_hourfee.Location = new System.Drawing.Point(15, 103);
            this.textBox_hourfee.Name = "textBox_hourfee";
            this.textBox_hourfee.Size = new System.Drawing.Size(324, 20);
            this.textBox_hourfee.TabIndex = 7;
            // 
            // savePositionButton
            // 
            this.savePositionButton.Location = new System.Drawing.Point(15, 182);
            this.savePositionButton.Name = "savePositionButton";
            this.savePositionButton.Size = new System.Drawing.Size(75, 23);
            this.savePositionButton.TabIndex = 8;
            this.savePositionButton.Text = "Save";
            this.savePositionButton.UseVisualStyleBackColor = true;
            this.savePositionButton.Click += new System.EventHandler(this.savePositionButton_Click);
            // 
            // cancelPositionButton
            // 
            this.cancelPositionButton.Location = new System.Drawing.Point(264, 182);
            this.cancelPositionButton.Name = "cancelPositionButton";
            this.cancelPositionButton.Size = new System.Drawing.Size(75, 23);
            this.cancelPositionButton.TabIndex = 9;
            this.cancelPositionButton.Text = "Cancel";
            this.cancelPositionButton.UseVisualStyleBackColor = true;
            this.cancelPositionButton.Click += new System.EventHandler(this.cancelPositionButton_Click);
            // 
            // AddEditPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 217);
            this.Controls.Add(this.cancelPositionButton);
            this.Controls.Add(this.savePositionButton);
            this.Controls.Add(this.textBox_hourfee);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditPosition";
            this.Text = "AddEditPosition";
            this.Activated += new System.EventHandler(this.AddEditPosition_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_hourfee;
        private System.Windows.Forms.Button savePositionButton;
        private System.Windows.Forms.Button cancelPositionButton;
    }
}