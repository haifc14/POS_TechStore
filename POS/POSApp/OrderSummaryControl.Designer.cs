namespace POSApp
{
    partial class OrderSummaryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubTotalTitleLabel = new System.Windows.Forms.Label();
            this.TaxTitleLabel = new System.Windows.Forms.Label();
            this.DiscountTitleLabel = new System.Windows.Forms.Label();
            this.TotalTitleLabel = new System.Windows.Forms.Label();
            this.SubTotalValueLabel = new System.Windows.Forms.Label();
            this.TaxValueLabel = new System.Windows.Forms.Label();
            this.DiscountValueLabel = new System.Windows.Forms.Label();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubTotalTitleLabel
            // 
            this.SubTotalTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubTotalTitleLabel.AutoSize = true;
            this.SubTotalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTitleLabel.Location = new System.Drawing.Point(49, 48);
            this.SubTotalTitleLabel.Name = "SubTotalTitleLabel";
            this.SubTotalTitleLabel.Size = new System.Drawing.Size(187, 42);
            this.SubTotalTitleLabel.TabIndex = 0;
            this.SubTotalTitleLabel.Text = "Sub Total";
            // 
            // TaxTitleLabel
            // 
            this.TaxTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxTitleLabel.AutoSize = true;
            this.TaxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTitleLabel.Location = new System.Drawing.Point(49, 128);
            this.TaxTitleLabel.Name = "TaxTitleLabel";
            this.TaxTitleLabel.Size = new System.Drawing.Size(84, 42);
            this.TaxTitleLabel.TabIndex = 1;
            this.TaxTitleLabel.Text = "Tax";
            // 
            // DiscountTitleLabel
            // 
            this.DiscountTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountTitleLabel.AutoSize = true;
            this.DiscountTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTitleLabel.Location = new System.Drawing.Point(49, 220);
            this.DiscountTitleLabel.Name = "DiscountTitleLabel";
            this.DiscountTitleLabel.Size = new System.Drawing.Size(172, 42);
            this.DiscountTitleLabel.TabIndex = 2;
            this.DiscountTitleLabel.Text = "Discount";
            // 
            // TotalTitleLabel
            // 
            this.TotalTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTitleLabel.AutoSize = true;
            this.TotalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTitleLabel.Location = new System.Drawing.Point(49, 322);
            this.TotalTitleLabel.Name = "TotalTitleLabel";
            this.TotalTitleLabel.Size = new System.Drawing.Size(106, 42);
            this.TotalTitleLabel.TabIndex = 3;
            this.TotalTitleLabel.Text = "Total";
            // 
            // SubTotalValueLabel
            // 
            this.SubTotalValueLabel.AutoSize = true;
            this.SubTotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalValueLabel.Location = new System.Drawing.Point(321, 44);
            this.SubTotalValueLabel.Name = "SubTotalValueLabel";
            this.SubTotalValueLabel.Size = new System.Drawing.Size(40, 42);
            this.SubTotalValueLabel.TabIndex = 4;
            this.SubTotalValueLabel.Text = "0";
            // 
            // TaxValueLabel
            // 
            this.TaxValueLabel.AutoSize = true;
            this.TaxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxValueLabel.Location = new System.Drawing.Point(321, 124);
            this.TaxValueLabel.Name = "TaxValueLabel";
            this.TaxValueLabel.Size = new System.Drawing.Size(40, 42);
            this.TaxValueLabel.TabIndex = 5;
            this.TaxValueLabel.Text = "0";
            // 
            // DiscountValueLabel
            // 
            this.DiscountValueLabel.AutoSize = true;
            this.DiscountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountValueLabel.Location = new System.Drawing.Point(321, 216);
            this.DiscountValueLabel.Name = "DiscountValueLabel";
            this.DiscountValueLabel.Size = new System.Drawing.Size(40, 42);
            this.DiscountValueLabel.TabIndex = 6;
            this.DiscountValueLabel.Text = "0";
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalValueLabel.Location = new System.Drawing.Point(321, 318);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(40, 42);
            this.TotalValueLabel.TabIndex = 7;
            this.TotalValueLabel.Text = "0";
            // 
            // OrderSummaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalValueLabel);
            this.Controls.Add(this.DiscountValueLabel);
            this.Controls.Add(this.TaxValueLabel);
            this.Controls.Add(this.SubTotalValueLabel);
            this.Controls.Add(this.TotalTitleLabel);
            this.Controls.Add(this.DiscountTitleLabel);
            this.Controls.Add(this.TaxTitleLabel);
            this.Controls.Add(this.SubTotalTitleLabel);
            this.Name = "OrderSummaryControl";
            this.Size = new System.Drawing.Size(546, 410);
            this.Load += new System.EventHandler(this.OrderSummaryControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubTotalTitleLabel;
        private System.Windows.Forms.Label TaxTitleLabel;
        private System.Windows.Forms.Label DiscountTitleLabel;
        private System.Windows.Forms.Label TotalTitleLabel;
        private System.Windows.Forms.Label SubTotalValueLabel;
        private System.Windows.Forms.Label TaxValueLabel;
        private System.Windows.Forms.Label DiscountValueLabel;
        private System.Windows.Forms.Label TotalValueLabel;
    }
}
