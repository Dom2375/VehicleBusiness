namespace CarBusinessSkeleton
{
    partial class Customers
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
            this.customerListBox1 = new System.Windows.Forms.ListBox();
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.searchVehicleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerListBox1
            // 
            this.customerListBox1.FormattingEnabled = true;
            this.customerListBox1.Location = new System.Drawing.Point(25, 84);
            this.customerListBox1.Name = "customerListBox1";
            this.customerListBox1.Size = new System.Drawing.Size(217, 251);
            this.customerListBox1.TabIndex = 0;
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.Location = new System.Drawing.Point(319, 85);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(219, 251);
            this.vehiclesListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicles Wanted";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addButton.Location = new System.Drawing.Point(319, 351);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 55);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Vehicle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.removeButton.Location = new System.Drawing.Point(439, 351);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(99, 55);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove Vehicle";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // searchVehicleButton
            // 
            this.searchVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.searchVehicleButton.Location = new System.Drawing.Point(319, 412);
            this.searchVehicleButton.Name = "searchVehicleButton";
            this.searchVehicleButton.Size = new System.Drawing.Size(219, 32);
            this.searchVehicleButton.TabIndex = 6;
            this.searchVehicleButton.Text = "Search for vehicles";
            this.searchVehicleButton.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.searchVehicleButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehiclesListBox);
            this.Controls.Add(this.customerListBox1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerListBox1;
        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button searchVehicleButton;
    }
}