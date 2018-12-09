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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelDelimiter = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentDateTitle
            // 
            this.labelCurrentDateTitle.AutoSize = true;
            this.labelCurrentDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDateTitle.Location = new System.Drawing.Point(29, 24);
            this.labelCurrentDateTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentDateTitle.Name = "labelCurrentDateTitle";
            this.labelCurrentDateTitle.Size = new System.Drawing.Size(52, 24);
            this.labelCurrentDateTitle.TabIndex = 0;
            this.labelCurrentDateTitle.Text = "Date";
            // 
            // labelTotalOrdersTitle
            // 
            this.labelTotalOrdersTitle.AutoSize = true;
            this.labelTotalOrdersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrdersTitle.Location = new System.Drawing.Point(29, 73);
            this.labelTotalOrdersTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalOrdersTitle.Name = "labelTotalOrdersTitle";
            this.labelTotalOrdersTitle.Size = new System.Drawing.Size(126, 24);
            this.labelTotalOrdersTitle.TabIndex = 0;
            this.labelTotalOrdersTitle.Text = "Total Orders";
            // 
            // labelTotalItemsTitle
            // 
            this.labelTotalItemsTitle.AutoSize = true;
            this.labelTotalItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItemsTitle.Location = new System.Drawing.Point(29, 121);
            this.labelTotalItemsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalItemsTitle.Name = "labelTotalItemsTitle";
            this.labelTotalItemsTitle.Size = new System.Drawing.Size(111, 24);
            this.labelTotalItemsTitle.TabIndex = 0;
            this.labelTotalItemsTitle.Text = "Total Items";
            // 
            // labelTotalIncomeTitle
            // 
            this.labelTotalIncomeTitle.AutoSize = true;
            this.labelTotalIncomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncomeTitle.Location = new System.Drawing.Point(29, 299);
            this.labelTotalIncomeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalIncomeTitle.Name = "labelTotalIncomeTitle";
            this.labelTotalIncomeTitle.Size = new System.Drawing.Size(131, 24);
            this.labelTotalIncomeTitle.TabIndex = 0;
            this.labelTotalIncomeTitle.Text = "Total Income";
            // 
            // labelTotalByCardTitle
            // 
            this.labelTotalByCardTitle.AutoSize = true;
            this.labelTotalByCardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCardTitle.Location = new System.Drawing.Point(29, 165);
            this.labelTotalByCardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalByCardTitle.Name = "labelTotalByCardTitle";
            this.labelTotalByCardTitle.Size = new System.Drawing.Size(210, 24);
            this.labelTotalByCardTitle.TabIndex = 0;
            this.labelTotalByCardTitle.Text = "Total Income By Card";
            // 
            // labelTotalByCashTitle
            // 
            this.labelTotalByCashTitle.AutoSize = true;
            this.labelTotalByCashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCashTitle.Location = new System.Drawing.Point(29, 211);
            this.labelTotalByCashTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalByCashTitle.Name = "labelTotalByCashTitle";
            this.labelTotalByCashTitle.Size = new System.Drawing.Size(213, 24);
            this.labelTotalByCashTitle.TabIndex = 0;
            this.labelTotalByCashTitle.Text = "Total Income By Cash";
            // 
            // labelTotalRedeemsTitle
            // 
            this.labelTotalRedeemsTitle.AutoSize = true;
            this.labelTotalRedeemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRedeemsTitle.Location = new System.Drawing.Point(29, 256);
            this.labelTotalRedeemsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalRedeemsTitle.Name = "labelTotalRedeemsTitle";
            this.labelTotalRedeemsTitle.Size = new System.Drawing.Size(194, 24);
            this.labelTotalRedeemsTitle.TabIndex = 0;
            this.labelTotalRedeemsTitle.Text = "Total Redeems Fee";
            // 
            // labelActualTillMoneyTitle
            // 
            this.labelActualTillMoneyTitle.AutoSize = true;
            this.labelActualTillMoneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualTillMoneyTitle.Location = new System.Drawing.Point(29, 385);
            this.labelActualTillMoneyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActualTillMoneyTitle.Name = "labelActualTillMoneyTitle";
            this.labelActualTillMoneyTitle.Size = new System.Drawing.Size(191, 24);
            this.labelActualTillMoneyTitle.TabIndex = 0;
            this.labelActualTillMoneyTitle.Text = "Cash Draw Balance";
            // 
            // labelVarianceTitle
            // 
            this.labelVarianceTitle.AutoSize = true;
            this.labelVarianceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarianceTitle.Location = new System.Drawing.Point(29, 429);
            this.labelVarianceTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVarianceTitle.Name = "labelVarianceTitle";
            this.labelVarianceTitle.Size = new System.Drawing.Size(93, 24);
            this.labelVarianceTitle.TabIndex = 0;
            this.labelVarianceTitle.Text = "Variance";
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(250, 23);
            this.labelCurrentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(107, 20);
            this.labelCurrentDate.TabIndex = 1;
            this.labelCurrentDate.Text = "current date";
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.AutoSize = true;
            this.labelTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOrders.Location = new System.Drawing.Point(279, 75);
            this.labelTotalOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(107, 20);
            this.labelTotalOrders.TabIndex = 1;
            this.labelTotalOrders.Text = "current date";
            // 
            // labelTotalItems
            // 
            this.labelTotalItems.AutoSize = true;
            this.labelTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItems.Location = new System.Drawing.Point(279, 124);
            this.labelTotalItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalItems.Name = "labelTotalItems";
            this.labelTotalItems.Size = new System.Drawing.Size(107, 20);
            this.labelTotalItems.TabIndex = 1;
            this.labelTotalItems.Text = "current date";
            // 
            // labelTotalByCard
            // 
            this.labelTotalByCard.AutoSize = true;
            this.labelTotalByCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCard.Location = new System.Drawing.Point(281, 167);
            this.labelTotalByCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalByCard.Name = "labelTotalByCard";
            this.labelTotalByCard.Size = new System.Drawing.Size(107, 20);
            this.labelTotalByCard.TabIndex = 1;
            this.labelTotalByCard.Text = "current date";
            // 
            // labelTotalByCash
            // 
            this.labelTotalByCash.AutoSize = true;
            this.labelTotalByCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalByCash.Location = new System.Drawing.Point(281, 214);
            this.labelTotalByCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalByCash.Name = "labelTotalByCash";
            this.labelTotalByCash.Size = new System.Drawing.Size(107, 20);
            this.labelTotalByCash.TabIndex = 1;
            this.labelTotalByCash.Text = "current date";
            // 
            // labelTotalRedeems
            // 
            this.labelTotalRedeems.AutoSize = true;
            this.labelTotalRedeems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRedeems.Location = new System.Drawing.Point(281, 259);
            this.labelTotalRedeems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalRedeems.Name = "labelTotalRedeems";
            this.labelTotalRedeems.Size = new System.Drawing.Size(107, 20);
            this.labelTotalRedeems.TabIndex = 1;
            this.labelTotalRedeems.Text = "current date";
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncome.Location = new System.Drawing.Point(281, 302);
            this.labelTotalIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(107, 20);
            this.labelTotalIncome.TabIndex = 1;
            this.labelTotalIncome.Text = "current date";
            // 
            // labelTotalActualTillIncome
            // 
            this.labelTotalActualTillIncome.AutoSize = true;
            this.labelTotalActualTillIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalActualTillIncome.Location = new System.Drawing.Point(281, 385);
            this.labelTotalActualTillIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalActualTillIncome.Name = "labelTotalActualTillIncome";
            this.labelTotalActualTillIncome.Size = new System.Drawing.Size(107, 20);
            this.labelTotalActualTillIncome.TabIndex = 1;
            this.labelTotalActualTillIncome.Text = "current date";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.BackColor = System.Drawing.SystemColors.Control;
            this.labelVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariance.ForeColor = System.Drawing.Color.Brown;
            this.labelVariance.Location = new System.Drawing.Point(262, 432);
            this.labelVariance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(122, 24);
            this.labelVariance.TabIndex = 1;
            this.labelVariance.Text = "current date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(29, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 3);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(29, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 3);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(29, 188);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 3);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(33, 239);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 3);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(33, 280);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 3);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(33, 323);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(352, 3);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(29, 408);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(352, 3);
            this.panel7.TabIndex = 2;
            // 
            // labelStartingCashTitle
            // 
            this.labelStartingCashTitle.AutoSize = true;
            this.labelStartingCashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingCashTitle.Location = new System.Drawing.Point(29, 345);
            this.labelStartingCashTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartingCashTitle.Name = "labelStartingCashTitle";
            this.labelStartingCashTitle.Size = new System.Drawing.Size(133, 24);
            this.labelStartingCashTitle.TabIndex = 0;
            this.labelStartingCashTitle.Text = "Starting Cash";
            // 
            // labelStartingCash
            // 
            this.labelStartingCash.AutoSize = true;
            this.labelStartingCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingCash.Location = new System.Drawing.Point(281, 348);
            this.labelStartingCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartingCash.Name = "labelStartingCash";
            this.labelStartingCash.Size = new System.Drawing.Size(107, 20);
            this.labelStartingCash.TabIndex = 1;
            this.labelStartingCash.Text = "current date";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(33, 369);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(352, 3);
            this.panel8.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(330, 511);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 54);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExportData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.ForeColor = System.Drawing.Color.White;
            this.btnExportData.Location = new System.Drawing.Point(31, 511);
            this.btnExportData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(120, 54);
            this.btnExportData.TabIndex = 3;
            this.btnExportData.Text = "Save";
            this.btnExportData.UseVisualStyleBackColor = false;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(184, 510);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 57);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Green;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(22, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(445, 475);
            this.panel9.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Controls.Add(this.labelCurrentDateTitle);
            this.panel10.Controls.Add(this.labelTotalRedeems);
            this.panel10.Controls.Add(this.labelTotalOrdersTitle);
            this.panel10.Controls.Add(this.labelTotalIncome);
            this.panel10.Controls.Add(this.labelTotalItemsTitle);
            this.panel10.Controls.Add(this.labelTotalByCash);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.labelStartingCash);
            this.panel10.Controls.Add(this.labelTotalIncomeTitle);
            this.panel10.Controls.Add(this.labelTotalByCard);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.labelTotalActualTillIncome);
            this.panel10.Controls.Add(this.labelStartingCashTitle);
            this.panel10.Controls.Add(this.labelTotalItems);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.labelVariance);
            this.panel10.Controls.Add(this.labelActualTillMoneyTitle);
            this.panel10.Controls.Add(this.labelTotalOrders);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panelDelimiter);
            this.panel10.Controls.Add(this.labelVarianceTitle);
            this.panel10.Controls.Add(this.labelCurrentDate);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.labelTotalRedeemsTitle);
            this.panel10.Controls.Add(this.labelTotalByCardTitle);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.labelTotalByCashTitle);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(439, 469);
            this.panel10.TabIndex = 3;
            // 
            // panelDelimiter
            // 
            this.panelDelimiter.BackColor = System.Drawing.Color.Green;
            this.panelDelimiter.Location = new System.Drawing.Point(29, 97);
            this.panelDelimiter.Margin = new System.Windows.Forms.Padding(2);
            this.panelDelimiter.Name = "panelDelimiter";
            this.panelDelimiter.Size = new System.Drawing.Size(352, 3);
            this.panelDelimiter.TabIndex = 2;
            // 
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 574);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DailyReportForm";
            this.Text = "DailyReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DailyReportForm_FormClosing);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelDelimiter;
    }
}