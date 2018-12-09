namespace POSApp
{
    partial class DailyReportForm
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
            this.labelCurrentDateTitle = new System.Windows.Forms.Label();
            this.labelTotalOrdersTitle = new System.Windows.Forms.Label();
            this.labelTotalItemsTitle = new System.Windows.Forms.Label();
            this.labelTotalIncomeTitle = new System.Windows.Forms.Label();
            this.labelTotalByCardTitle = new System.Windows.Forms.Label();
            this.labelTotalByCashTitle = new System.Windows.Forms.Label();
            this.labelTotalRedeemsTitle = new System.Windows.Forms.Label();
            this.labelActualTillMoneyTitle = new System.Windows.Forms.Label();
            this.labelVarianceTitle = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.labelTotalItems = new System.Windows.Forms.Label();
            this.labelTotalByCard = new System.Windows.Forms.Label();
            this.labelTotalByCash = new System.Windows.Forms.Label();
            this.labelTotalRedeems = new System.Windows.Forms.Label();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelTotalActualTillIncome = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.panelDelimiter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelStartingCashTitle = new System.Windows.Forms.Label();
            this.labelStartingCash = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDayEndReportDocs = new System.Drawing.Printing.PrintDocument();
            this.printDialogDayEndReport = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // labelCurrentDateTitle
            // 
            this.labelCurrentDateTitle.AutoSize = true;
            this.labelCurrentDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDateTitle.Location = new System.Drawing.Point(348, 87);
            this.labelCurrentDateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentDateTitle.Name = "labelCurrentDateTitle";
            this.labelCurrentDateTitle.Size = new System.Drawing.Size(126, 54);
            this.labelCurrentDateTitle.TabIndex = 0;
            this.labelCurrentDateTitle.Text = "Date";
            // 
            // labelTotalOrdersTitle
            // 
            this.labelTotalOrdersTitle.AutoSize = true;
            this.labelTotalOrdersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrdersTitle.Location = new System.Drawing.Point(348, 203);
            this.labelTotalOrdersTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalOrdersTitle.Name = "labelTotalOrdersTitle";
            this.labelTotalOrdersTitle.Size = new System.Drawing.Size(296, 54);
            this.labelTotalOrdersTitle.TabIndex = 0;
            this.labelTotalOrdersTitle.Text = "Total Orders";
            // 
            // labelTotalItemsTitle
            // 
            this.labelTotalItemsTitle.AutoSize = true;
            this.labelTotalItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItemsTitle.Location = new System.Drawing.Point(348, 317);
            this.labelTotalItemsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalItemsTitle.Name = "labelTotalItemsTitle";
            this.labelTotalItemsTitle.Size = new System.Drawing.Size(265, 54);
            this.labelTotalItemsTitle.TabIndex = 0;
            this.labelTotalItemsTitle.Text = "Total Items";
            // 
            // labelTotalIncomeTitle
            // 
            this.labelTotalIncomeTitle.AutoSize = true;
            this.labelTotalIncomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncomeTitle.Location = new System.Drawing.Point(348, 742);
            this.labelTotalIncomeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalIncomeTitle.Name = "labelTotalIncomeTitle";
            this.labelTotalIncomeTitle.Size = new System.Drawing.Size(305, 54);
            this.labelTotalIncomeTitle.TabIndex = 0;
            this.labelTotalIncomeTitle.Text = "Total Income";
            // 
            // labelTotalByCardTitle
            // 
            this.labelTotalByCardTitle.AutoSize = true;
            this.labelTotalByCardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCardTitle.Location = new System.Drawing.Point(348, 422);
            this.labelTotalByCardTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalByCardTitle.Name = "labelTotalByCardTitle";
            this.labelTotalByCardTitle.Size = new System.Drawing.Size(494, 54);
            this.labelTotalByCardTitle.TabIndex = 0;
            this.labelTotalByCardTitle.Text = "Total Income By Card";
            // 
            // labelTotalByCashTitle
            // 
            this.labelTotalByCashTitle.AutoSize = true;
            this.labelTotalByCashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCashTitle.Location = new System.Drawing.Point(348, 531);
            this.labelTotalByCashTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalByCashTitle.Name = "labelTotalByCashTitle";
            this.labelTotalByCashTitle.Size = new System.Drawing.Size(502, 54);
            this.labelTotalByCashTitle.TabIndex = 0;
            this.labelTotalByCashTitle.Text = "Total Income By Cash";
            // 
            // labelTotalRedeemsTitle
            // 
            this.labelTotalRedeemsTitle.AutoSize = true;
            this.labelTotalRedeemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRedeemsTitle.Location = new System.Drawing.Point(347, 640);
            this.labelTotalRedeemsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalRedeemsTitle.Name = "labelTotalRedeemsTitle";
            this.labelTotalRedeemsTitle.Size = new System.Drawing.Size(450, 54);
            this.labelTotalRedeemsTitle.TabIndex = 0;
            this.labelTotalRedeemsTitle.Text = "Total Redeems Fee";
            // 
            // labelActualTillMoneyTitle
            // 
            this.labelActualTillMoneyTitle.AutoSize = true;
            this.labelActualTillMoneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualTillMoneyTitle.Location = new System.Drawing.Point(347, 946);
            this.labelActualTillMoneyTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActualTillMoneyTitle.Name = "labelActualTillMoneyTitle";
            this.labelActualTillMoneyTitle.Size = new System.Drawing.Size(453, 54);
            this.labelActualTillMoneyTitle.TabIndex = 0;
            this.labelActualTillMoneyTitle.Text = "Cash Draw Balance";
            // 
            // labelVarianceTitle
            // 
            this.labelVarianceTitle.AutoSize = true;
            this.labelVarianceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarianceTitle.Location = new System.Drawing.Point(347, 1052);
            this.labelVarianceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVarianceTitle.Name = "labelVarianceTitle";
            this.labelVarianceTitle.Size = new System.Drawing.Size(216, 54);
            this.labelVarianceTitle.TabIndex = 0;
            this.labelVarianceTitle.Text = "Variance";
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(937, 84);
            this.labelCurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(244, 46);
            this.labelCurrentDate.TabIndex = 1;
            this.labelCurrentDate.Text = "current date";
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrders.Location = new System.Drawing.Point(1013, 207);
            this.labelTotalOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(244, 46);
            this.labelTotalOrders.TabIndex = 1;
            this.labelTotalOrders.Text = "current date";
            // 
            // labelTotalItems
            // 
            this.labelTotalItems.AutoSize = true;
            this.labelTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItems.Location = new System.Drawing.Point(1013, 324);
            this.labelTotalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalItems.Name = "labelTotalItems";
            this.labelTotalItems.Size = new System.Drawing.Size(244, 46);
            this.labelTotalItems.TabIndex = 1;
            this.labelTotalItems.Text = "current date";
            // 
            // labelTotalByCard
            // 
            this.labelTotalByCard.AutoSize = true;
            this.labelTotalByCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCard.Location = new System.Drawing.Point(1020, 428);
            this.labelTotalByCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalByCard.Name = "labelTotalByCard";
            this.labelTotalByCard.Size = new System.Drawing.Size(244, 46);
            this.labelTotalByCard.TabIndex = 1;
            this.labelTotalByCard.Text = "current date";
            // 
            // labelTotalByCash
            // 
            this.labelTotalByCash.AutoSize = true;
            this.labelTotalByCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCash.Location = new System.Drawing.Point(1020, 538);
            this.labelTotalByCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalByCash.Name = "labelTotalByCash";
            this.labelTotalByCash.Size = new System.Drawing.Size(244, 46);
            this.labelTotalByCash.TabIndex = 1;
            this.labelTotalByCash.Text = "current date";
            // 
            // labelTotalRedeems
            // 
            this.labelTotalRedeems.AutoSize = true;
            this.labelTotalRedeems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRedeems.Location = new System.Drawing.Point(1020, 647);
            this.labelTotalRedeems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalRedeems.Name = "labelTotalRedeems";
            this.labelTotalRedeems.Size = new System.Drawing.Size(244, 46);
            this.labelTotalRedeems.TabIndex = 1;
            this.labelTotalRedeems.Text = "current date";
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncome.Location = new System.Drawing.Point(1020, 749);
            this.labelTotalIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(244, 46);
            this.labelTotalIncome.TabIndex = 1;
            this.labelTotalIncome.Text = "current date";
            // 
            // labelTotalActualTillIncome
            // 
            this.labelTotalActualTillIncome.AutoSize = true;
            this.labelTotalActualTillIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalActualTillIncome.Location = new System.Drawing.Point(1020, 946);
            this.labelTotalActualTillIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalActualTillIncome.Name = "labelTotalActualTillIncome";
            this.labelTotalActualTillIncome.Size = new System.Drawing.Size(244, 46);
            this.labelTotalActualTillIncome.TabIndex = 1;
            this.labelTotalActualTillIncome.Text = "current date";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.BackColor = System.Drawing.SystemColors.Control;
            this.labelVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariance.ForeColor = System.Drawing.Color.Brown;
            this.labelVariance.Location = new System.Drawing.Point(1020, 1058);
            this.labelVariance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(285, 54);
            this.labelVariance.TabIndex = 1;
            this.labelVariance.Text = "current date";
            // 
            // panelDelimiter
            // 
            this.panelDelimiter.BackColor = System.Drawing.Color.IndianRed;
            this.panelDelimiter.Location = new System.Drawing.Point(348, 259);
            this.panelDelimiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDelimiter.Name = "panelDelimiter";
            this.panelDelimiter.Size = new System.Drawing.Size(939, 12);
            this.panelDelimiter.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(348, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 12);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(348, 373);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 12);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(348, 477);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 12);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Location = new System.Drawing.Point(356, 588);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 12);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Location = new System.Drawing.Point(357, 697);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 12);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Location = new System.Drawing.Point(357, 799);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(939, 12);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.Location = new System.Drawing.Point(348, 1002);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(939, 12);
            this.panel7.TabIndex = 2;
            // 
            // labelStartingCashTitle
            // 
            this.labelStartingCashTitle.AutoSize = true;
            this.labelStartingCashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingCashTitle.Location = new System.Drawing.Point(348, 851);
            this.labelStartingCashTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartingCashTitle.Name = "labelStartingCashTitle";
            this.labelStartingCashTitle.Size = new System.Drawing.Size(319, 54);
            this.labelStartingCashTitle.TabIndex = 0;
            this.labelStartingCashTitle.Text = "Starting Cash";
            // 
            // labelStartingCash
            // 
            this.labelStartingCash.AutoSize = true;
            this.labelStartingCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingCash.Location = new System.Drawing.Point(1020, 858);
            this.labelStartingCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartingCash.Name = "labelStartingCash";
            this.labelStartingCash.Size = new System.Drawing.Size(244, 46);
            this.labelStartingCash.TabIndex = 1;
            this.labelStartingCash.Text = "current date";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.Location = new System.Drawing.Point(357, 908);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(939, 12);
            this.panel8.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(199, 1215);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(343, 128);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.Location = new System.Drawing.Point(664, 1215);
            this.btnExportData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(321, 128);
            this.btnExportData.TabIndex = 3;
            this.btnExportData.Text = "Save";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(1107, 1208);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(321, 135);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDayEndReportDocs
            // 
            this.printDayEndReportDocs.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDayEndReportDocs_PrintPage);
            // 
            // printDialogDayEndReport
            // 
            this.printDialogDayEndReport.Document = this.printDayEndReportDocs;
            this.printDialogDayEndReport.UseEXDialog = true;
            // 
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1409);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDelimiter);
            this.Controls.Add(this.labelVariance);
            this.Controls.Add(this.labelTotalActualTillIncome);
            this.Controls.Add(this.labelStartingCash);
            this.Controls.Add(this.labelTotalIncome);
            this.Controls.Add(this.labelTotalRedeems);
            this.Controls.Add(this.labelTotalByCash);
            this.Controls.Add(this.labelTotalByCard);
            this.Controls.Add(this.labelTotalItems);
            this.Controls.Add(this.labelTotalOrders);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.labelTotalRedeemsTitle);
            this.Controls.Add(this.labelTotalByCashTitle);
            this.Controls.Add(this.labelTotalByCardTitle);
            this.Controls.Add(this.labelVarianceTitle);
            this.Controls.Add(this.labelActualTillMoneyTitle);
            this.Controls.Add(this.labelStartingCashTitle);
            this.Controls.Add(this.labelTotalIncomeTitle);
            this.Controls.Add(this.labelTotalItemsTitle);
            this.Controls.Add(this.labelTotalOrdersTitle);
            this.Controls.Add(this.labelCurrentDateTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DailyReportForm";
            this.Text = "DailyReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DailyReportForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentDateTitle;
        private System.Windows.Forms.Label labelTotalOrdersTitle;
        private System.Windows.Forms.Label labelTotalItemsTitle;
        private System.Windows.Forms.Label labelTotalIncomeTitle;
        private System.Windows.Forms.Label labelTotalByCardTitle;
        private System.Windows.Forms.Label labelTotalByCashTitle;
        private System.Windows.Forms.Label labelTotalRedeemsTitle;
        private System.Windows.Forms.Label labelActualTillMoneyTitle;
        private System.Windows.Forms.Label labelVarianceTitle;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.Label labelTotalItems;
        private System.Windows.Forms.Label labelTotalByCard;
        private System.Windows.Forms.Label labelTotalByCash;
        private System.Windows.Forms.Label labelTotalRedeems;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelTotalActualTillIncome;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Panel panelDelimiter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelStartingCashTitle;
        private System.Windows.Forms.Label labelStartingCash;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDayEndReportDocs;
        private System.Windows.Forms.PrintDialog printDialogDayEndReport;
    }
}