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
            this.PrintLastOrderBtn = new System.Windows.Forms.Button();
            this.DayEndButton = new System.Windows.Forms.Button();
            this.DayReportButton = new System.Windows.Forms.Button();
            this.FinalizeOrderButton = new System.Windows.Forms.Button();
            this.SignOff_Button = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.PrintReceiptDialog = new System.Windows.Forms.PrintDialog();
            this.PrintReceiptDocument = new System.Drawing.Printing.PrintDocument();
            this.printDayDetailReport = new System.Drawing.Printing.PrintDocument();
            this.OrderControl = new POSApp.OrderControl();
            this.productViewControl1 = new POSApp.ProductViewControl();
            this.DetailRepoetDialog = new System.Windows.Forms.PrintDialog();
            this.OrderControl_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderControl_Panel
            // 
            this.OrderControl_Panel.BackColor = System.Drawing.SystemColors.Control;
            this.OrderControl_Panel.Controls.Add(this.PrintLastOrderBtn);
            this.OrderControl_Panel.Controls.Add(this.DayEndButton);
            this.OrderControl_Panel.Controls.Add(this.DayReportButton);
            this.OrderControl_Panel.Controls.Add(this.FinalizeOrderButton);
            this.OrderControl_Panel.Controls.Add(this.SignOff_Button);
            this.OrderControl_Panel.Controls.Add(this.ReturnButton);
            this.OrderControl_Panel.Location = new System.Drawing.Point(849, 980);
            this.OrderControl_Panel.Margin = new System.Windows.Forms.Padding(6);
            this.OrderControl_Panel.Name = "OrderControl_Panel";
            this.OrderControl_Panel.Size = new System.Drawing.Size(1126, 163);
            this.OrderControl_Panel.TabIndex = 2;
            // 
            // PrintLastOrderBtn
            // 
            this.PrintLastOrderBtn.Location = new System.Drawing.Point(340, 14);
            this.PrintLastOrderBtn.Margin = new System.Windows.Forms.Padding(6);
            this.PrintLastOrderBtn.Name = "PrintLastOrderBtn";
            this.PrintLastOrderBtn.Size = new System.Drawing.Size(145, 135);
            this.PrintLastOrderBtn.TabIndex = 47;
            this.PrintLastOrderBtn.Text = "Print Last Order";
            this.PrintLastOrderBtn.UseVisualStyleBackColor = true;
            this.PrintLastOrderBtn.Click += new System.EventHandler(this.PrintLastOrderBtn_Click);
            // 
            // DayEndButton
            // 
            this.DayEndButton.Location = new System.Drawing.Point(814, 14);
            this.DayEndButton.Margin = new System.Windows.Forms.Padding(6);
            this.DayEndButton.Name = "DayEndButton";
            this.DayEndButton.Size = new System.Drawing.Size(150, 135);
            this.DayEndButton.TabIndex = 46;
            this.DayEndButton.Text = "DayEnd";
            this.DayEndButton.UseVisualStyleBackColor = true;
            this.DayEndButton.Click += new System.EventHandler(this.DayEndButton_Click_1);
            // 
            // DayReportButton
            // 
            this.DayReportButton.Location = new System.Drawing.Point(970, 14);
            this.DayReportButton.Margin = new System.Windows.Forms.Padding(6);
            this.DayReportButton.Name = "DayReportButton";
            this.DayReportButton.Size = new System.Drawing.Size(150, 135);
            this.DayReportButton.TabIndex = 45;
            this.DayReportButton.Text = "DayReport";
            this.DayReportButton.UseVisualStyleBackColor = true;
            this.DayReportButton.Click += new System.EventHandler(this.DayReportButton_Click);
            // 
            // FinalizeOrderButton
            // 
            this.FinalizeOrderButton.Location = new System.Drawing.Point(6, 14);
            this.FinalizeOrderButton.Margin = new System.Windows.Forms.Padding(6);
            this.FinalizeOrderButton.Name = "FinalizeOrderButton";
            this.FinalizeOrderButton.Size = new System.Drawing.Size(313, 135);
            this.FinalizeOrderButton.TabIndex = 44;
            this.FinalizeOrderButton.Text = "Finalize Order";
            this.FinalizeOrderButton.UseVisualStyleBackColor = true;
            this.FinalizeOrderButton.Click += new System.EventHandler(this.FinalizeOrderButton_Click);
            // 
            // SignOff_Button
            // 
            this.SignOff_Button.Location = new System.Drawing.Point(653, 14);
            this.SignOff_Button.Margin = new System.Windows.Forms.Padding(6);
            this.SignOff_Button.Name = "SignOff_Button";
            this.SignOff_Button.Size = new System.Drawing.Size(150, 135);
            this.SignOff_Button.TabIndex = 43;
            this.SignOff_Button.Text = "Sign Off";
            this.SignOff_Button.UseVisualStyleBackColor = true;
            this.SignOff_Button.Click += new System.EventHandler(this.SignOff_Button_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(496, 14);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(6);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(145, 135);
            this.ReturnButton.TabIndex = 42;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // PrintReceiptDialog
            // 
            this.PrintReceiptDialog.Document = this.PrintReceiptDocument;
            this.PrintReceiptDialog.UseEXDialog = true;
            // 
            // PrintReceiptDocument
            // 
            this.PrintReceiptDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintReceiptDocument_PrintPage);
            // 
            // printDayDetailReport
            // 
            this.printDayDetailReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDayDetailReport_PrintPage);
            // 
            // OrderControl
            // 
            this.OrderControl.BackColor = System.Drawing.SystemColors.Control;
            this.OrderControl.EmployeeId = 0;
            this.OrderControl.Location = new System.Drawing.Point(12, 17);
            this.OrderControl.Margin = new System.Windows.Forms.Padding(2);
            this.OrderControl.Name = "OrderControl";
            this.OrderControl.Size = new System.Drawing.Size(806, 1125);
            this.OrderControl.TabIndex = 7;
            // 
            // productViewControl1
            // 
            this.productViewControl1.BackColor = System.Drawing.SystemColors.Control;
            this.productViewControl1.Location = new System.Drawing.Point(849, 15);
            this.productViewControl1.Margin = new System.Windows.Forms.Padding(2);
            this.productViewControl1.Name = "productViewControl1";
            this.productViewControl1.Size = new System.Drawing.Size(1125, 937);
            this.productViewControl1.TabIndex = 6;
            // 
            // DetailRepoetDialog
            // 
            this.DetailRepoetDialog.Document = this.printDayDetailReport;
            this.DetailRepoetDialog.UseEXDialog = true;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1995, 1164);
            this.Controls.Add(this.OrderControl);
            this.Controls.Add(this.productViewControl1);
            this.Controls.Add(this.OrderControl_Panel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "POSForm";
            this.Text = "POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POSForm_FormClosing);
            this.Load += new System.EventHandler(this.PosForm_Load);
            this.OrderControl_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel OrderControl_Panel;
        private ProductViewControl productViewControl1;
        private OrderControl OrderControl;
        private System.Windows.Forms.Button DayEndButton;
        private System.Windows.Forms.Button DayReportButton;
        private System.Windows.Forms.Button FinalizeOrderButton;
        private System.Windows.Forms.Button SignOff_Button;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button PrintLastOrderBtn;
        private System.Windows.Forms.PrintDialog PrintReceiptDialog;
        private System.Drawing.Printing.PrintDocument PrintReceiptDocument;
        private System.Drawing.Printing.PrintDocument printDayDetailReport;
        private System.Windows.Forms.PrintDialog DetailRepoetDialog;
    }
}