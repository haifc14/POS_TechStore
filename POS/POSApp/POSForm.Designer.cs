namespace POSApp
{
    partial class POSForm
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
            this.SubmitBarcodeBtn = new System.Windows.Forms.Button();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.ProductView_Panel = new System.Windows.Forms.Panel();
            this.OrderControl_Panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DayReport_Button = new System.Windows.Forms.Button();
            this.DayEnd_Button = new System.Windows.Forms.Button();
            this.SignOff_Button = new System.Windows.Forms.Button();
            this.AbortTrans_Button = new System.Windows.Forms.Button();
            this.ItemVoid_Button = new System.Windows.Forms.Button();
            this.Receipt_Button = new System.Windows.Forms.Button();
            this.ScanLoyalty_Button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Discount_Button = new System.Windows.Forms.Button();
            this.RedeemPoint_Button = new System.Windows.Forms.Button();
            this.PayCard_Button = new System.Windows.Forms.Button();
            this.PayCash_Button = new System.Windows.Forms.Button();
            this.ProductControl_Panel = new System.Windows.Forms.Panel();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterSubmitBtn = new System.Windows.Forms.Button();
            this.Recommended_Button = new System.Windows.Forms.Button();
            this.OrderView_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.InputBarcodePanel = new System.Windows.Forms.Panel();
            this.OrderControl_Panel.SuspendLayout();
            this.ProductControl_Panel.SuspendLayout();
            this.InputBarcodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitBarcodeBtn
            // 
            this.SubmitBarcodeBtn.Location = new System.Drawing.Point(601, 77);
            this.SubmitBarcodeBtn.Name = "SubmitBarcodeBtn";
            this.SubmitBarcodeBtn.Size = new System.Drawing.Size(170, 58);
            this.SubmitBarcodeBtn.TabIndex = 14;
            this.SubmitBarcodeBtn.Text = "Submit";
            this.SubmitBarcodeBtn.UseVisualStyleBackColor = true;
            this.SubmitBarcodeBtn.Click += new System.EventHandler(this.SubmitBarcodeBtn_Click);
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(112, 80);
            this.BarcodeTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(478, 35);
            this.BarcodeTextBox.TabIndex = 13;
            // 
            // ProductView_Panel
            // 
            this.ProductView_Panel.Location = new System.Drawing.Point(978, 17);
            this.ProductView_Panel.Margin = new System.Windows.Forms.Padding(7);
            this.ProductView_Panel.Name = "ProductView_Panel";
            this.ProductView_Panel.Size = new System.Drawing.Size(1085, 508);
            this.ProductView_Panel.TabIndex = 1;
            // 
            // OrderControl_Panel
            // 
            this.OrderControl_Panel.Controls.Add(this.textBox1);
            this.OrderControl_Panel.Controls.Add(this.DayReport_Button);
            this.OrderControl_Panel.Controls.Add(this.DayEnd_Button);
            this.OrderControl_Panel.Controls.Add(this.SignOff_Button);
            this.OrderControl_Panel.Controls.Add(this.AbortTrans_Button);
            this.OrderControl_Panel.Controls.Add(this.ItemVoid_Button);
            this.OrderControl_Panel.Controls.Add(this.Receipt_Button);
            this.OrderControl_Panel.Controls.Add(this.ScanLoyalty_Button);
            this.OrderControl_Panel.Controls.Add(this.Return_Button);
            this.OrderControl_Panel.Controls.Add(this.Discount_Button);
            this.OrderControl_Panel.Controls.Add(this.RedeemPoint_Button);
            this.OrderControl_Panel.Controls.Add(this.PayCard_Button);
            this.OrderControl_Panel.Controls.Add(this.PayCash_Button);
            this.OrderControl_Panel.Location = new System.Drawing.Point(978, 532);
            this.OrderControl_Panel.Margin = new System.Windows.Forms.Padding(7);
            this.OrderControl_Panel.Name = "OrderControl_Panel";
            this.OrderControl_Panel.Size = new System.Drawing.Size(574, 771);
            this.OrderControl_Panel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 35);
            this.textBox1.TabIndex = 12;
            // 
            // DayReport_Button
            // 
            this.DayReport_Button.Location = new System.Drawing.Point(385, 604);
            this.DayReport_Button.Margin = new System.Windows.Forms.Padding(7);
            this.DayReport_Button.Name = "DayReport_Button";
            this.DayReport_Button.Size = new System.Drawing.Size(175, 157);
            this.DayReport_Button.TabIndex = 11;
            this.DayReport_Button.Text = "Day Report";
            this.DayReport_Button.UseVisualStyleBackColor = true;
            // 
            // DayEnd_Button
            // 
            this.DayEnd_Button.Location = new System.Drawing.Point(196, 604);
            this.DayEnd_Button.Margin = new System.Windows.Forms.Padding(7);
            this.DayEnd_Button.Name = "DayEnd_Button";
            this.DayEnd_Button.Size = new System.Drawing.Size(175, 157);
            this.DayEnd_Button.TabIndex = 10;
            this.DayEnd_Button.Text = "Day End";
            this.DayEnd_Button.UseVisualStyleBackColor = true;
            // 
            // SignOff_Button
            // 
            this.SignOff_Button.Location = new System.Drawing.Point(7, 604);
            this.SignOff_Button.Margin = new System.Windows.Forms.Padding(7);
            this.SignOff_Button.Name = "SignOff_Button";
            this.SignOff_Button.Size = new System.Drawing.Size(175, 157);
            this.SignOff_Button.TabIndex = 9;
            this.SignOff_Button.Text = "Sign Off";
            this.SignOff_Button.UseVisualStyleBackColor = true;
            // 
            // AbortTrans_Button
            // 
            this.AbortTrans_Button.Location = new System.Drawing.Point(385, 435);
            this.AbortTrans_Button.Margin = new System.Windows.Forms.Padding(7);
            this.AbortTrans_Button.Name = "AbortTrans_Button";
            this.AbortTrans_Button.Size = new System.Drawing.Size(175, 157);
            this.AbortTrans_Button.TabIndex = 8;
            this.AbortTrans_Button.Text = "Abort Trans";
            this.AbortTrans_Button.UseVisualStyleBackColor = true;
            // 
            // ItemVoid_Button
            // 
            this.ItemVoid_Button.Location = new System.Drawing.Point(196, 435);
            this.ItemVoid_Button.Margin = new System.Windows.Forms.Padding(7);
            this.ItemVoid_Button.Name = "ItemVoid_Button";
            this.ItemVoid_Button.Size = new System.Drawing.Size(175, 157);
            this.ItemVoid_Button.TabIndex = 7;
            this.ItemVoid_Button.Text = "Item Void";
            this.ItemVoid_Button.UseVisualStyleBackColor = true;
            // 
            // Receipt_Button
            // 
            this.Receipt_Button.Location = new System.Drawing.Point(7, 435);
            this.Receipt_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Receipt_Button.Name = "Receipt_Button";
            this.Receipt_Button.Size = new System.Drawing.Size(175, 157);
            this.Receipt_Button.TabIndex = 6;
            this.Receipt_Button.Text = "Receipt";
            this.Receipt_Button.UseVisualStyleBackColor = true;
            // 
            // ScanLoyalty_Button
            // 
            this.ScanLoyalty_Button.Location = new System.Drawing.Point(385, 266);
            this.ScanLoyalty_Button.Margin = new System.Windows.Forms.Padding(7);
            this.ScanLoyalty_Button.Name = "ScanLoyalty_Button";
            this.ScanLoyalty_Button.Size = new System.Drawing.Size(175, 157);
            this.ScanLoyalty_Button.TabIndex = 5;
            this.ScanLoyalty_Button.Text = "Scan Loyalty ";
            this.ScanLoyalty_Button.UseVisualStyleBackColor = true;
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(196, 266);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(175, 157);
            this.Return_Button.TabIndex = 4;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            // 
            // Discount_Button
            // 
            this.Discount_Button.Location = new System.Drawing.Point(7, 266);
            this.Discount_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Discount_Button.Name = "Discount_Button";
            this.Discount_Button.Size = new System.Drawing.Size(175, 157);
            this.Discount_Button.TabIndex = 3;
            this.Discount_Button.Text = "Discount";
            this.Discount_Button.UseVisualStyleBackColor = true;
            // 
            // RedeemPoint_Button
            // 
            this.RedeemPoint_Button.Location = new System.Drawing.Point(385, 96);
            this.RedeemPoint_Button.Margin = new System.Windows.Forms.Padding(7);
            this.RedeemPoint_Button.Name = "RedeemPoint_Button";
            this.RedeemPoint_Button.Size = new System.Drawing.Size(175, 157);
            this.RedeemPoint_Button.TabIndex = 2;
            this.RedeemPoint_Button.Text = "Redeem Point";
            this.RedeemPoint_Button.UseVisualStyleBackColor = true;
            // 
            // PayCard_Button
            // 
            this.PayCard_Button.Location = new System.Drawing.Point(196, 96);
            this.PayCard_Button.Margin = new System.Windows.Forms.Padding(7);
            this.PayCard_Button.Name = "PayCard_Button";
            this.PayCard_Button.Size = new System.Drawing.Size(175, 157);
            this.PayCard_Button.TabIndex = 1;
            this.PayCard_Button.Text = "Pay Card";
            this.PayCard_Button.UseVisualStyleBackColor = true;
            // 
            // PayCash_Button
            // 
            this.PayCash_Button.Location = new System.Drawing.Point(7, 96);
            this.PayCash_Button.Margin = new System.Windows.Forms.Padding(7);
            this.PayCash_Button.Name = "PayCash_Button";
            this.PayCash_Button.Size = new System.Drawing.Size(175, 157);
            this.PayCash_Button.TabIndex = 0;
            this.PayCash_Button.Text = "Pay Cash";
            this.PayCash_Button.UseVisualStyleBackColor = true;
            // 
            // ProductControl_Panel
            // 
            this.ProductControl_Panel.Controls.Add(this.CategoryComboBox);
            this.ProductControl_Panel.Controls.Add(this.BrandComboBox);
            this.ProductControl_Panel.Controls.Add(this.SearchTextBox);
            this.ProductControl_Panel.Controls.Add(this.FilterSubmitBtn);
            this.ProductControl_Panel.Controls.Add(this.Recommended_Button);
            this.ProductControl_Panel.Location = new System.Drawing.Point(1566, 532);
            this.ProductControl_Panel.Margin = new System.Windows.Forms.Padding(7);
            this.ProductControl_Panel.Name = "ProductControl_Panel";
            this.ProductControl_Panel.Size = new System.Drawing.Size(497, 771);
            this.ProductControl_Panel.TabIndex = 3;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(28, 493);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(426, 37);
            this.CategoryComboBox.TabIndex = 16;
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(28, 324);
            this.BrandComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(426, 37);
            this.BrandComboBox.TabIndex = 15;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(28, 154);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(426, 35);
            this.SearchTextBox.TabIndex = 14;
            // 
            // FilterSubmitBtn
            // 
            this.FilterSubmitBtn.Location = new System.Drawing.Point(28, 576);
            this.FilterSubmitBtn.Margin = new System.Windows.Forms.Padding(7);
            this.FilterSubmitBtn.Name = "FilterSubmitBtn";
            this.FilterSubmitBtn.Size = new System.Drawing.Size(432, 75);
            this.FilterSubmitBtn.TabIndex = 1;
            this.FilterSubmitBtn.Text = "Submit";
            this.FilterSubmitBtn.UseVisualStyleBackColor = true;
            this.FilterSubmitBtn.Click += new System.EventHandler(this.FilterSubmitBtn_Click);
            // 
            // Recommended_Button
            // 
            this.Recommended_Button.Location = new System.Drawing.Point(99, 685);
            this.Recommended_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Recommended_Button.Name = "Recommended_Button";
            this.Recommended_Button.Size = new System.Drawing.Size(282, 70);
            this.Recommended_Button.TabIndex = 0;
            this.Recommended_Button.Text = "Recommended";
            this.Recommended_Button.UseVisualStyleBackColor = true;
            // 
            // OrderView_Panel
            // 
            this.OrderView_Panel.Location = new System.Drawing.Point(14, 17);
            this.OrderView_Panel.Margin = new System.Windows.Forms.Padding(58);
            this.OrderView_Panel.Name = "OrderView_Panel";
            this.OrderView_Panel.Size = new System.Drawing.Size(929, 1085);
            this.OrderView_Panel.TabIndex = 4;
            // 
            // InputBarcodePanel
            // 
            this.InputBarcodePanel.Controls.Add(this.BarcodeTextBox);
            this.InputBarcodePanel.Controls.Add(this.SubmitBarcodeBtn);
            this.InputBarcodePanel.Location = new System.Drawing.Point(14, 1137);
            this.InputBarcodePanel.Name = "InputBarcodePanel";
            this.InputBarcodePanel.Size = new System.Drawing.Size(929, 179);
            this.InputBarcodePanel.TabIndex = 5;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2089, 1336);
            this.Controls.Add(this.InputBarcodePanel);
            this.Controls.Add(this.OrderView_Panel);
            this.Controls.Add(this.ProductControl_Panel);
            this.Controls.Add(this.OrderControl_Panel);
            this.Controls.Add(this.ProductView_Panel);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "POSForm";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.PosForm_Load);
            this.OrderControl_Panel.ResumeLayout(false);
            this.OrderControl_Panel.PerformLayout();
            this.ProductControl_Panel.ResumeLayout(false);
            this.ProductControl_Panel.PerformLayout();
            this.InputBarcodePanel.ResumeLayout(false);
            this.InputBarcodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ProductView_Panel;
        private System.Windows.Forms.Panel OrderControl_Panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DayReport_Button;
        private System.Windows.Forms.Button DayEnd_Button;
        private System.Windows.Forms.Button SignOff_Button;
        private System.Windows.Forms.Button AbortTrans_Button;
        private System.Windows.Forms.Button ItemVoid_Button;
        private System.Windows.Forms.Button Receipt_Button;
        private System.Windows.Forms.Button ScanLoyalty_Button;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button Discount_Button;
        private System.Windows.Forms.Button RedeemPoint_Button;
        private System.Windows.Forms.Button PayCard_Button;
        private System.Windows.Forms.Button PayCash_Button;
        private System.Windows.Forms.Panel ProductControl_Panel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.Button FilterSubmitBtn;
        private System.Windows.Forms.Button Recommended_Button;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.Button SubmitBarcodeBtn;
        private System.Windows.Forms.FlowLayoutPanel OrderView_Panel;
        private System.Windows.Forms.Panel InputBarcodePanel;
    }
}

