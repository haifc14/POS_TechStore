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
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemPriceLabel = new System.Windows.Forms.Label();
            this.RemoveItemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(24, 24);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(279, 37);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "Macbook Pro 15\'\'";
            // 
            // ItemPriceLabel
            // 
            this.ItemPriceLabel.AutoSize = true;
            this.ItemPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPriceLabel.Location = new System.Drawing.Point(436, 25);
            this.ItemPriceLabel.Name = "ItemPriceLabel";
            this.ItemPriceLabel.Size = new System.Drawing.Size(179, 37);
            this.ItemPriceLabel.TabIndex = 2;
            this.ItemPriceLabel.Text = "3333,0000";
            // 
            // RemoveItemBtn
            // 
            this.RemoveItemBtn.BackColor = System.Drawing.Color.DarkRed;
            this.RemoveItemBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveItemBtn.Location = new System.Drawing.Point(647, 19);
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.RemoveItemBtn.Size = new System.Drawing.Size(74, 42);
            this.RemoveItemBtn.TabIndex = 3;
            this.RemoveItemBtn.Text = "X";
            this.RemoveItemBtn.UseVisualStyleBackColor = false;
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // OrderItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveItemBtn);
            this.Controls.Add(this.ItemPriceLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Name = "OrderItemControl";
            this.Size = new System.Drawing.Size(746, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemPriceLabel;
        private System.Windows.Forms.Button RemoveItemBtn;
    }
}
