namespace CarBusinessSkeleton
{
    partial class Start
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
            this.Business = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Business
            // 
            this.Business.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Business.Location = new System.Drawing.Point(16, 44);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(176, 112);
            this.Business.TabIndex = 0;
            this.Business.Text = "Business";
            this.Business.UseVisualStyleBackColor = true;
            this.Business.Click += new System.EventHandler(this.Business_Click);
            // 
            // customersButton
            // 
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.customersButton.Location = new System.Drawing.Point(216, 44);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(176, 112);
            this.customersButton.TabIndex = 1;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 178);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.Business);
            this.Name = "Start";
            this.Text = "Vehicle Sales Business";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Business;
        private System.Windows.Forms.Button customersButton;
    }
}

