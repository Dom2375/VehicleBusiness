namespace CarBusinessSkeleton
{
    partial class Locations
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
            this.locationsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vehiclesInStock = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.mostExpensive = new System.Windows.Forms.Label();
            this.mostExpensiveType = new System.Windows.Forms.Label();
            this.selectLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationsList
            // 
            this.locationsList.FormattingEnabled = true;
            this.locationsList.Location = new System.Drawing.Point(44, 50);
            this.locationsList.Name = "locationsList";
            this.locationsList.Size = new System.Drawing.Size(702, 251);
            this.locationsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicles in stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Most expensive vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Most expensive vehicle type";
            // 
            // vehiclesInStock
            // 
            this.vehiclesInStock.AutoSize = true;
            this.vehiclesInStock.Location = new System.Drawing.Point(234, 331);
            this.vehiclesInStock.Name = "vehiclesInStock";
            this.vehiclesInStock.Size = new System.Drawing.Size(35, 13);
            this.vehiclesInStock.TabIndex = 5;
            this.vehiclesInStock.Text = "label5";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Location = new System.Drawing.Point(234, 360);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(35, 13);
            this.totalValue.TabIndex = 6;
            this.totalValue.Text = "label5";
            // 
            // mostExpensive
            // 
            this.mostExpensive.AutoSize = true;
            this.mostExpensive.Location = new System.Drawing.Point(234, 389);
            this.mostExpensive.Name = "mostExpensive";
            this.mostExpensive.Size = new System.Drawing.Size(35, 13);
            this.mostExpensive.TabIndex = 7;
            this.mostExpensive.Text = "label5";
            // 
            // mostExpensiveType
            // 
            this.mostExpensiveType.AutoSize = true;
            this.mostExpensiveType.Location = new System.Drawing.Point(233, 417);
            this.mostExpensiveType.Name = "mostExpensiveType";
            this.mostExpensiveType.Size = new System.Drawing.Size(35, 13);
            this.mostExpensiveType.TabIndex = 8;
            this.mostExpensiveType.Text = "label5";
            // 
            // selectLocation
            // 
            this.selectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.selectLocation.Location = new System.Drawing.Point(586, 344);
            this.selectLocation.Name = "selectLocation";
            this.selectLocation.Size = new System.Drawing.Size(147, 60);
            this.selectLocation.TabIndex = 9;
            this.selectLocation.Text = "Select";
            this.selectLocation.UseVisualStyleBackColor = true;
            this.selectLocation.Click += new System.EventHandler(this.selectLocation_Click);
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectLocation);
            this.Controls.Add(this.mostExpensiveType);
            this.Controls.Add(this.mostExpensive);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.vehiclesInStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationsList);
            this.Name = "Locations";
            this.Text = "Locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox locationsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vehiclesInStock;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label mostExpensive;
        private System.Windows.Forms.Label mostExpensiveType;
        private System.Windows.Forms.Button selectLocation;
    }
}