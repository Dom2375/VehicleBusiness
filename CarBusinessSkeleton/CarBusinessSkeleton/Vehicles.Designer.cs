namespace CarBusinessSkeleton
{
    partial class Vehicles
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
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.Location = new System.Drawing.Point(35, 76);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(730, 251);
            this.vehiclesListBox.TabIndex = 0;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.add.Location = new System.Drawing.Point(38, 369);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(142, 52);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.remove.Location = new System.Drawing.Point(315, 369);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(142, 52);
            this.remove.TabIndex = 2;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.modify.Location = new System.Drawing.Point(608, 369);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(142, 52);
            this.modify.TabIndex = 3;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.vehiclesListBox);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button modify;
    }
}