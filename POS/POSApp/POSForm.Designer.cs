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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
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
            this.SubmitBarcodeBtn.Location = new System.Drawing.Point(515, 66);
            this.SubmitBarcodeBtn.Name = "SubmitBarcodeBtn";
            this.SubmitBarcodeBtn.Size = new System.Drawing.Size(146, 50);
            this.SubmitBarcodeBtn.TabIndex = 14;
            this.SubmitBarcodeBtn.Text = "Submit";
            this.SubmitBarcodeBtn.UseVisualStyleBackColor = true;
            this.SubmitBarcodeBtn.Click += new System.EventHandler(this.SubmitBarcodeBtn_Click);
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(96, 69);
            this.BarcodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(410, 31);
            this.BarcodeTextBox.TabIndex = 13;
            // 
            // ProductView_Panel
            // 
            this.ProductView_Panel.Location = new System.Drawing.Point(838, 15);
            this.ProductView_Panel.Margin = new System.Windows.Forms.Padding(6);
            this.ProductView_Panel.Name = "ProductView_Panel";
            this.ProductView_Panel.Size = new System.Drawing.Size(930, 438);
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
            this.OrderControl_Panel.Location = new System.Drawing.Point(838, 459);
            this.OrderControl_Panel.Margin = new System.Windows.Forms.Padding(6);
            this.OrderControl_Panel.Name = "OrderControl_Panel";
            this.OrderControl_Panel.Size = new System.Drawing.Size(492, 665);
            this.OrderControl_Panel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 31);
            this.textBox1.TabIndex = 12;
            // 
            // DayReport_Button
            // 
            this.DayReport_Button.Location = new System.Drawing.Point(330, 521);
            this.DayReport_Button.Margin = new System.Windows.Forms.Padding(6);
            this.DayReport_Button.Name = "DayReport_Button";
            this.DayReport_Button.Size = new System.Drawing.Size(150, 135);
            this.DayReport_Button.TabIndex = 11;
            this.DayReport_Button.Text = "Day Report";
            this.DayReport_Button.UseVisualStyleBackColor = true;
            // 
            // DayEnd_Button
            // 
            this.DayEnd_Button.Location = new System.Drawing.Point(168, 521);
            this.DayEnd_Button.Margin = new System.Windows.Forms.Padding(6);
            this.DayEnd_Button.Name = "DayEnd_Button";
            this.DayEnd_Button.Size = new System.Drawing.Size(150, 135);
            this.DayEnd_Button.TabIndex = 10;
            this.DayEnd_Button.Text = "Day End";
            this.DayEnd_Button.UseVisualStyleBackColor = true;
            // 
            // SignOff_Button
            // 
            this.SignOff_Button.Location = new System.Drawing.Point(6, 521);
            this.SignOff_Button.Margin = new System.Windows.Forms.Padding(6);
            this.SignOff_Button.Name = "SignOff_Button";
            this.SignOff_Button.Size = new System.Drawing.Size(150, 135);
            this.SignOff_Button.TabIndex = 9;
            this.SignOff_Button.Text = "Sign Off";
            this.SignOff_Button.UseVisualStyleBackColor = true;
            this.SignOff_Button.Click += new System.EventHandler(this.SignOff_Button_Click);
            // 
            // AbortTrans_Button
            // 
            this.AbortTrans_Button.Location = new System.Drawing.Point(330, 375);
            this.AbortTrans_Button.Margin = new System.Windows.Forms.Padding(6);
            this.AbortTrans_Button.Name = "AbortTrans_Button";
            this.AbortTrans_Button.Size = new System.Drawing.Size(150, 135);
            this.AbortTrans_Button.TabIndex = 8;
            this.AbortTrans_Button.Text = "Abort Trans";
            this.AbortTrans_Button.UseVisualStyleBackColor = true;
            // 
            // ItemVoid_Button
            // 
            this.ItemVoid_Button.Location = new System.Drawing.Point(168, 375);
            this.ItemVoid_Button.Margin = new System.Windows.Forms.Padding(6);
            this.ItemVoid_Button.Name = "ItemVoid_Button";
            this.ItemVoid_Button.Size = new System.Drawing.Size(150, 135);
            this.ItemVoid_Button.TabIndex = 7;
            this.ItemVoid_Button.Text = "Item Void";
            this.ItemVoid_Button.UseVisualStyleBackColor = true;
            // 
            // Receipt_Button
            // 
            this.Receipt_Button.Location = new System.Drawing.Point(6, 375);
            this.Receipt_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Receipt_Button.Name = "Receipt_Button";
            this.Receipt_Button.Size = new System.Drawing.Size(150, 135);
            this.Receipt_Button.TabIndex = 6;
            this.Receipt_Button.Text = "Receipt";
            this.Receipt_Button.UseVisualStyleBackColor = true;
            // 
            // ScanLoyalty_Button
            // 
            this.ScanLoyalty_Button.Location = new System.Drawing.Point(330, 229);
            this.ScanLoyalty_Button.Margin = new System.Windows.Forms.Padding(6);
            this.ScanLoyalty_Button.Name = "ScanLoyalty_Button";
            this.ScanLoyalty_Button.Size = new System.Drawing.Size(150, 135);
            this.ScanLoyalty_Button.TabIndex = 5;
            this.ScanLoyalty_Button.Text = "Scan Loyalty ";
            this.ScanLoyalty_Button.UseVisualStyleBackColor = true;
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(168, 229);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(150, 135);
            this.Return_Button.TabIndex = 4;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            // 
            // Discount_Button
            // 
            this.Discount_Button.Location = new System.Drawing.Point(6, 229);
            this.Discount_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Discount_Button.Name = "Discount_Button";
            this.Discount_Button.Size = new System.Drawing.Size(150, 135);
            this.Discount_Button.TabIndex = 3;
            this.Discount_Button.Text = "Discount";
            this.Discount_Button.UseVisualStyleBackColor = true;
            // 
            // RedeemPoint_Button
            // 
            this.RedeemPoint_Button.Location = new System.Drawing.Point(330, 83);
            this.RedeemPoint_Button.Margin = new System.Windows.Forms.Padding(6);
            this.RedeemPoint_Button.Name = "RedeemPoint_Button";
            this.RedeemPoint_Button.Size = new System.Drawing.Size(150, 135);
            this.RedeemPoint_Button.TabIndex = 2;
            this.RedeemPoint_Button.Text = "Redeem Point";
            this.RedeemPoint_Button.UseVisualStyleBackColor = true;
            // 
            // PayCard_Button
            // 
            this.PayCard_Button.Location = new System.Drawing.Point(168, 83);
            this.PayCard_Button.Margin = new System.Windows.Forms.Padding(6);
            this.PayCard_Button.Name = "PayCard_Button";
            this.PayCard_Button.Size = new System.Drawing.Size(150, 135);
            this.PayCard_Button.TabIndex = 1;
            this.PayCard_Button.Text = "Pay Card";
            this.PayCard_Button.UseVisualStyleBackColor = true;
            // 
            // PayCash_Button
            // 
            this.PayCash_Button.Location = new System.Drawing.Point(6, 83);
            this.PayCash_Button.Margin = new System.Windows.Forms.Padding(6);
            this.PayCash_Button.Name = "PayCash_Button";
            this.PayCash_Button.Size = new System.Drawing.Size(150, 135);
            this.PayCash_Button.TabIndex = 0;
            this.PayCash_Button.Text = "Pay Cash";
            this.PayCash_Button.UseVisualStyleBackColor = true;
            // 
            // ProductControl_Panel
            // 
            this.ProductControl_Panel.Controls.Add(this.comboBox2);
            this.ProductControl_Panel.Controls.Add(this.comboBox1);
            this.ProductControl_Panel.Controls.Add(this.textBox3);
            this.ProductControl_Panel.Controls.Add(this.Submit_Button);
            this.ProductControl_Panel.Controls.Add(this.Recommended_Button);
            this.ProductControl_Panel.Location = new System.Drawing.Point(1342, 459);
            this.ProductControl_Panel.Margin = new System.Windows.Forms.Padding(6);
            this.ProductControl_Panel.Name = "ProductControl_Panel";
            this.ProductControl_Panel.Size = new System.Drawing.Size(426, 665);
            this.ProductControl_Panel.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 425);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(366, 33);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 279);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(366, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 133);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(366, 31);
            this.textBox3.TabIndex = 14;
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(24, 590);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(370, 65);
            this.Submit_Button.TabIndex = 1;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            // 
            // Recommended_Button
            // 
            this.Recommended_Button.Location = new System.Drawing.Point(92, 510);
            this.Recommended_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Recommended_Button.Name = "Recommended_Button";
            this.Recommended_Button.Size = new System.Drawing.Size(242, 60);
            this.Recommended_Button.TabIndex = 0;
            this.Recommended_Button.Text = "Recommended";
            this.Recommended_Button.UseVisualStyleBackColor = true;
            // 
            // OrderView_Panel
            // 
            this.OrderView_Panel.Location = new System.Drawing.Point(12, 15);
            this.OrderView_Panel.Margin = new System.Windows.Forms.Padding(50);
            this.OrderView_Panel.Name = "OrderView_Panel";
            this.OrderView_Panel.Size = new System.Drawing.Size(796, 935);
            this.OrderView_Panel.TabIndex = 4;
            // 
            // InputBarcodePanel
            // 
            this.InputBarcodePanel.Controls.Add(this.BarcodeTextBox);
            this.InputBarcodePanel.Controls.Add(this.SubmitBarcodeBtn);
            this.InputBarcodePanel.Location = new System.Drawing.Point(12, 980);
            this.InputBarcodePanel.Name = "InputBarcodePanel";
            this.InputBarcodePanel.Size = new System.Drawing.Size(796, 154);
            this.InputBarcodePanel.TabIndex = 5;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1152);
            this.Controls.Add(this.InputBarcodePanel);
            this.Controls.Add(this.OrderView_Panel);
            this.Controls.Add(this.ProductControl_Panel);
            this.Controls.Add(this.OrderControl_Panel);
            this.Controls.Add(this.ProductView_Panel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "POSForm";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Button Recommended_Button;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SubmitBarcodeBtn;
        private System.Windows.Forms.FlowLayoutPanel OrderView_Panel;
        private System.Windows.Forms.Panel InputBarcodePanel;
    }
}

