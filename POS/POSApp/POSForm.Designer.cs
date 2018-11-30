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
            this.OrderControl_Panel = new System.Windows.Forms.Panel();
            this.DayReport_Button = new System.Windows.Forms.Button();
            this.DayEnd_Button = new System.Windows.Forms.Button();
            this.SignOff_Button = new System.Windows.Forms.Button();
            this.AbortTrans_Button = new System.Windows.Forms.Button();
            this.ItemVoid_Button = new System.Windows.Forms.Button();
            this.Receipt_Button = new System.Windows.Forms.Button();
            this.ScanLoyaltyButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.OrderControl = new POSApp.OrderControl();
            this.productViewControl1 = new POSApp.ProductViewControl();
            this.FinalizeOrderButton = new System.Windows.Forms.Button();
            this.OrderControl_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderControl_Panel
            // 
            this.OrderControl_Panel.Controls.Add(this.FinalizeOrderButton);
            this.OrderControl_Panel.Controls.Add(this.DayReport_Button);
            this.OrderControl_Panel.Controls.Add(this.DayEnd_Button);
            this.OrderControl_Panel.Controls.Add(this.SignOff_Button);
            this.OrderControl_Panel.Controls.Add(this.AbortTrans_Button);
            this.OrderControl_Panel.Controls.Add(this.ItemVoid_Button);
            this.OrderControl_Panel.Controls.Add(this.Receipt_Button);
            this.OrderControl_Panel.Controls.Add(this.ScanLoyaltyButton);
            this.OrderControl_Panel.Controls.Add(this.ReturnButton);
            this.OrderControl_Panel.Location = new System.Drawing.Point(566, 495);
            this.OrderControl_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.OrderControl_Panel.Name = "OrderControl_Panel";
            this.OrderControl_Panel.Size = new System.Drawing.Size(751, 236);
            this.OrderControl_Panel.TabIndex = 2;
            // 
            // DayReport_Button
            // 
            this.DayReport_Button.Location = new System.Drawing.Point(643, 134);
            this.DayReport_Button.Margin = new System.Windows.Forms.Padding(4);
            this.DayReport_Button.Name = "DayReport_Button";
            this.DayReport_Button.Size = new System.Drawing.Size(100, 86);
            this.DayReport_Button.TabIndex = 37;
            this.DayReport_Button.Text = "Day Report";
            this.DayReport_Button.UseVisualStyleBackColor = true;
            // 
            // DayEnd_Button
            // 
            this.DayEnd_Button.Location = new System.Drawing.Point(643, 42);
            this.DayEnd_Button.Margin = new System.Windows.Forms.Padding(4);
            this.DayEnd_Button.Name = "DayEnd_Button";
            this.DayEnd_Button.Size = new System.Drawing.Size(100, 86);
            this.DayEnd_Button.TabIndex = 36;
            this.DayEnd_Button.Text = "Day End";
            this.DayEnd_Button.UseVisualStyleBackColor = true;
            // 
            // SignOff_Button
            // 
            this.SignOff_Button.Location = new System.Drawing.Point(521, 134);
            this.SignOff_Button.Margin = new System.Windows.Forms.Padding(4);
            this.SignOff_Button.Name = "SignOff_Button";
            this.SignOff_Button.Size = new System.Drawing.Size(100, 86);
            this.SignOff_Button.TabIndex = 35;
            this.SignOff_Button.Text = "Sign Off";
            this.SignOff_Button.UseVisualStyleBackColor = true;
            // 
            // AbortTrans_Button
            // 
            this.AbortTrans_Button.Location = new System.Drawing.Point(521, 40);
            this.AbortTrans_Button.Margin = new System.Windows.Forms.Padding(4);
            this.AbortTrans_Button.Name = "AbortTrans_Button";
            this.AbortTrans_Button.Size = new System.Drawing.Size(100, 86);
            this.AbortTrans_Button.TabIndex = 34;
            this.AbortTrans_Button.Text = "Abort Trans";
            this.AbortTrans_Button.UseVisualStyleBackColor = true;
            // 
            // ItemVoid_Button
            // 
            this.ItemVoid_Button.Location = new System.Drawing.Point(398, 42);
            this.ItemVoid_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ItemVoid_Button.Name = "ItemVoid_Button";
            this.ItemVoid_Button.Size = new System.Drawing.Size(100, 86);
            this.ItemVoid_Button.TabIndex = 33;
            this.ItemVoid_Button.Text = "Item Void";
            this.ItemVoid_Button.UseVisualStyleBackColor = true;
            // 
            // Receipt_Button
            // 
            this.Receipt_Button.Location = new System.Drawing.Point(398, 136);
            this.Receipt_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Receipt_Button.Name = "Receipt_Button";
            this.Receipt_Button.Size = new System.Drawing.Size(100, 86);
            this.Receipt_Button.TabIndex = 32;
            this.Receipt_Button.Text = "Receipt";
            this.Receipt_Button.UseVisualStyleBackColor = true;
            // 
            // ScanLoyaltyButton
            // 
            this.ScanLoyaltyButton.Location = new System.Drawing.Point(290, 42);
            this.ScanLoyaltyButton.Margin = new System.Windows.Forms.Padding(4);
            this.ScanLoyaltyButton.Name = "ScanLoyaltyButton";
            this.ScanLoyaltyButton.Size = new System.Drawing.Size(100, 86);
            this.ScanLoyaltyButton.TabIndex = 31;
            this.ScanLoyaltyButton.Text = "Scan Loyalty ";
            this.ScanLoyaltyButton.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(290, 136);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(100, 86);
            this.ReturnButton.TabIndex = 30;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // OrderControl
            // 
            this.OrderControl.EmployeeId = 0;
            this.OrderControl.Location = new System.Drawing.Point(8, 11);
            this.OrderControl.Margin = new System.Windows.Forms.Padding(1);
            this.OrderControl.Name = "OrderControl";
            this.OrderControl.Size = new System.Drawing.Size(537, 720);
            this.OrderControl.TabIndex = 7;
            // 
            // productViewControl1
            // 
            this.productViewControl1.Location = new System.Drawing.Point(566, 10);
            this.productViewControl1.Margin = new System.Windows.Forms.Padding(1);
            this.productViewControl1.Name = "productViewControl1";
            this.productViewControl1.Size = new System.Drawing.Size(751, 465);
            this.productViewControl1.TabIndex = 6;
            // 
            // FinalizeOrderButton
            // 
            this.FinalizeOrderButton.Location = new System.Drawing.Point(29, 42);
            this.FinalizeOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.FinalizeOrderButton.Name = "FinalizeOrderButton";
            this.FinalizeOrderButton.Size = new System.Drawing.Size(234, 86);
            this.FinalizeOrderButton.TabIndex = 38;
            this.FinalizeOrderButton.Text = "Finalize Order";
            this.FinalizeOrderButton.UseVisualStyleBackColor = true;
            this.FinalizeOrderButton.Click += new System.EventHandler(this.FinalizeOrderButton_Click);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 745);
            this.Controls.Add(this.OrderControl);
            this.Controls.Add(this.productViewControl1);
            this.Controls.Add(this.OrderControl_Panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "POSForm";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.PosForm_Load);
            this.OrderControl_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel OrderControl_Panel;
        private System.Windows.Forms.Button DayReport_Button;
        private System.Windows.Forms.Button DayEnd_Button;
        private System.Windows.Forms.Button SignOff_Button;
        private System.Windows.Forms.Button AbortTrans_Button;
        private System.Windows.Forms.Button ItemVoid_Button;
        private System.Windows.Forms.Button Receipt_Button;
        private System.Windows.Forms.Button ScanLoyaltyButton;
        private System.Windows.Forms.Button ReturnButton;
        private ProductViewControl productViewControl1;
        private OrderControl OrderControl;
        private System.Windows.Forms.Button FinalizeOrderButton;
    }
}