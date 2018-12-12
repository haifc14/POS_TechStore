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
            this.DetailedReportBtn = new System.Windows.Forms.Button();
            this.DayEndBtn = new System.Windows.Forms.Button();
            this.FinalizeOrderButton = new System.Windows.Forms.Button();
            this.SignOff_Button = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.PrintReceiptDialog = new System.Windows.Forms.PrintDialog();
            this.PrintReceiptDocument = new System.Drawing.Printing.PrintDocument();
            this.printDayDetailReport = new System.Drawing.Printing.PrintDocument();
            this.DetailRepoetDialog = new System.Windows.Forms.PrintDialog();
            this.OrderControl = new POSApp.OrderControl();
            this.ProductViewControl = new POSApp.ProductViewControl();
            this.OrderControl_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderControl_Panel
            // 
            this.OrderControl_Panel.BackColor = System.Drawing.Color.Gray;
            this.OrderControl_Panel.Controls.Add(this.PrintLastOrderBtn);
            this.OrderControl_Panel.Controls.Add(this.DetailedReportBtn);
            this.OrderControl_Panel.Controls.Add(this.DayEndBtn);
            this.OrderControl_Panel.Controls.Add(this.FinalizeOrderButton);
            this.OrderControl_Panel.Controls.Add(this.SignOff_Button);
            this.OrderControl_Panel.Controls.Add(this.ReturnButton);
            this.OrderControl_Panel.Location = new System.Drawing.Point(424, 510);
            this.OrderControl_Panel.Name = "OrderControl_Panel";
            this.OrderControl_Panel.Size = new System.Drawing.Size(563, 85);
            this.OrderControl_Panel.TabIndex = 2;
            // 
            // PrintLastOrderBtn
            // 
            this.PrintLastOrderBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.PrintLastOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintLastOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintLastOrderBtn.ForeColor = System.Drawing.Color.White;
            this.PrintLastOrderBtn.Location = new System.Drawing.Point(170, 7);
            this.PrintLastOrderBtn.Name = "PrintLastOrderBtn";
            this.PrintLastOrderBtn.Size = new System.Drawing.Size(72, 70);
            this.PrintLastOrderBtn.TabIndex = 47;
            this.PrintLastOrderBtn.Text = "Print Last Order";
            this.PrintLastOrderBtn.UseVisualStyleBackColor = false;
            this.PrintLastOrderBtn.Click += new System.EventHandler(this.PrintLastOrderBtn_Click);
            // 
            // DetailedReportBtn
            // 
            this.DetailedReportBtn.BackColor = System.Drawing.Color.Red;
            this.DetailedReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DetailedReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailedReportBtn.ForeColor = System.Drawing.Color.White;
            this.DetailedReportBtn.Location = new System.Drawing.Point(407, 7);
            this.DetailedReportBtn.Name = "DetailedReportBtn";
            this.DetailedReportBtn.Size = new System.Drawing.Size(75, 70);
            this.DetailedReportBtn.TabIndex = 46;
            this.DetailedReportBtn.Text = "Detatiled Report";
            this.DetailedReportBtn.UseVisualStyleBackColor = false;
            this.DetailedReportBtn.Click += new System.EventHandler(this.DayEndButton_Click_1);
            // 
            // DayEndBtn
            // 
            this.DayEndBtn.BackColor = System.Drawing.Color.Red;
            this.DayEndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DayEndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayEndBtn.ForeColor = System.Drawing.Color.White;
            this.DayEndBtn.Location = new System.Drawing.Point(485, 7);
            this.DayEndBtn.Name = "DayEndBtn";
            this.DayEndBtn.Size = new System.Drawing.Size(75, 70);
            this.DayEndBtn.TabIndex = 45;
            this.DayEndBtn.Text = "Day End";
            this.DayEndBtn.UseVisualStyleBackColor = false;
            this.DayEndBtn.Click += new System.EventHandler(this.DayReportButton_Click);
            // 
            // FinalizeOrderButton
            // 
            this.FinalizeOrderButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.FinalizeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinalizeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalizeOrderButton.ForeColor = System.Drawing.Color.White;
            this.FinalizeOrderButton.Location = new System.Drawing.Point(3, 7);
            this.FinalizeOrderButton.Name = "FinalizeOrderButton";
            this.FinalizeOrderButton.Size = new System.Drawing.Size(156, 70);
            this.FinalizeOrderButton.TabIndex = 44;
            this.FinalizeOrderButton.Text = "Finalize Order";
            this.FinalizeOrderButton.UseVisualStyleBackColor = false;
            this.FinalizeOrderButton.Click += new System.EventHandler(this.FinalizeOrderButton_Click);
            // 
            // SignOff_Button
            // 
            this.SignOff_Button.BackColor = System.Drawing.Color.Red;
            this.SignOff_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignOff_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOff_Button.ForeColor = System.Drawing.Color.White;
            this.SignOff_Button.Location = new System.Drawing.Point(327, 7);
            this.SignOff_Button.Name = "SignOff_Button";
            this.SignOff_Button.Size = new System.Drawing.Size(75, 70);
            this.SignOff_Button.TabIndex = 43;
            this.SignOff_Button.Text = "Sign Off";
            this.SignOff_Button.UseVisualStyleBackColor = false;
            this.SignOff_Button.Click += new System.EventHandler(this.SignOff_Button_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Coral;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(248, 7);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(72, 70);
            this.ReturnButton.TabIndex = 42;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
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
            // DetailRepoetDialog
            // 
            this.DetailRepoetDialog.Document = this.printDayDetailReport;
            this.DetailRepoetDialog.UseEXDialog = true;
            // 
            // OrderControl
            // 
            this.OrderControl.BackColor = System.Drawing.Color.White;
            this.OrderControl.EmployeeId = 0;
            this.OrderControl.Location = new System.Drawing.Point(6, 9);
            this.OrderControl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.OrderControl.Name = "OrderControl";
            this.OrderControl.OrderType = "";
            this.OrderControl.Size = new System.Drawing.Size(403, 585);
            this.OrderControl.TabIndex = 7;
            // 
            // ProductViewControl
            // 
            this.ProductViewControl.BackColor = System.Drawing.Color.Gray;
            this.ProductViewControl.Location = new System.Drawing.Point(424, 8);
            this.ProductViewControl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ProductViewControl.Name = "ProductViewControl";
            this.ProductViewControl.Size = new System.Drawing.Size(563, 487);
            this.ProductViewControl.TabIndex = 6;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(994, 602);
            this.Controls.Add(this.OrderControl);
            this.Controls.Add(this.ProductViewControl);
            this.Controls.Add(this.OrderControl_Panel);
            this.Name = "POSForm";
            this.Text = "POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POSForm_FormClosing);
            this.Load += new System.EventHandler(this.PosForm_Load);
            this.OrderControl_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel OrderControl_Panel;
        private ProductViewControl ProductViewControl;
        private OrderControl OrderControl;
        private System.Windows.Forms.Button DetailedReportBtn;
        private System.Windows.Forms.Button DayEndBtn;
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