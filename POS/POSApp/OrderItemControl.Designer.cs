namespace POSApp
{
    partial class OrderItemControl
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
            this.ItemBarcodeLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemBarcodeLabel
            // 
            this.ItemBarcodeLabel.AutoSize = true;
            this.ItemBarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBarcodeLabel.Location = new System.Drawing.Point(18, 19);
            this.ItemBarcodeLabel.Name = "ItemBarcodeLabel";
            this.ItemBarcodeLabel.Size = new System.Drawing.Size(40, 42);
            this.ItemBarcodeLabel.TabIndex = 0;
            this.ItemBarcodeLabel.Text = "1";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(93, 19);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(321, 42);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "Macbook Pro 15\'\'";
            // 
            // ItemPriceLabel
            // 
            this.ItemPriceLabel.AutoSize = true;
            this.ItemPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPriceLabel.Location = new System.Drawing.Point(514, 19);
            this.ItemPriceLabel.Name = "ItemPriceLabel";
            this.ItemPriceLabel.Size = new System.Drawing.Size(205, 42);
            this.ItemPriceLabel.TabIndex = 2;
            this.ItemPriceLabel.Text = "3333,0000";
            // 
            // OrderItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemPriceLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemBarcodeLabel);
            this.Name = "OrderItemControl";
            this.Size = new System.Drawing.Size(746, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemBarcodeLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemPriceLabel;
    }
}
