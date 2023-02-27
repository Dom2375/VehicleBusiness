namespace CarBusinessSkeleton
{
    partial class Vehicle
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
            this.Make = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Location = new System.Drawing.Point(31, 43);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(34, 13);
            this.Make.TabIndex = 0;
            this.Make.Text = "Make";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(31, 96);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(31, 154);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(34, 170);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(110, 21);
            this.typeComboBox.TabIndex = 3;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(35, 114);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(108, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // makeTextBox2
            // 
            this.makeTextBox2.Location = new System.Drawing.Point(34, 59);
            this.makeTextBox2.Name = "makeTextBox2";
            this.makeTextBox2.Size = new System.Drawing.Size(108, 20);
            this.makeTextBox2.TabIndex = 5;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.makeTextBox2);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Make);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Make;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox2;
    }
}