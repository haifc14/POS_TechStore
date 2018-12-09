namespace POSApp
{
    partial class GetCashReportInputForm
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
            this.labelStartingCashTitle = new System.Windows.Forms.Label();
            this.labelTotalCashEarnTitle = new System.Windows.Forms.Label();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.textBoxStartingCash = new System.Windows.Forms.TextBox();
            this.textBoxTotalCashInTill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelStartingCashTitle
            // 
            this.labelStartingCashTitle.AutoSize = true;
            this.labelStartingCashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingCashTitle.Location = new System.Drawing.Point(49, 99);
            this.labelStartingCashTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartingCashTitle.Name = "labelStartingCashTitle";
            this.labelStartingCashTitle.Size = new System.Drawing.Size(319, 54);
            this.labelStartingCashTitle.TabIndex = 4;
            this.labelStartingCashTitle.Text = "Starting Cash";
            // 
            // labelTotalCashEarnTitle
            // 
            this.labelTotalCashEarnTitle.AutoSize = true;
            this.labelTotalCashEarnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCashEarnTitle.Location = new System.Drawing.Point(49, 248);
            this.labelTotalCashEarnTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalCashEarnTitle.Name = "labelTotalCashEarnTitle";
            this.labelTotalCashEarnTitle.Size = new System.Drawing.Size(386, 54);
            this.labelTotalCashEarnTitle.TabIndex = 4;
            this.labelTotalCashEarnTitle.Text = "Total Cash in Till";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(305, 429);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(329, 140);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // textBoxStartingCash
            // 
            this.textBoxStartingCash.Location = new System.Drawing.Point(516, 114);
            this.textBoxStartingCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxStartingCash.Multiline = true;
            this.textBoxStartingCash.Name = "textBoxStartingCash";
            this.textBoxStartingCash.Size = new System.Drawing.Size(332, 62);
            this.textBoxStartingCash.TabIndex = 1;
            // 
            // textBoxTotalCashInTill
            // 
            this.textBoxTotalCashInTill.Location = new System.Drawing.Point(516, 237);
            this.textBoxTotalCashInTill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotalCashInTill.Multiline = true;
            this.textBoxTotalCashInTill.Name = "textBoxTotalCashInTill";
            this.textBoxTotalCashInTill.Size = new System.Drawing.Size(332, 62);
            this.textBoxTotalCashInTill.TabIndex = 2;
            // 
            // GetCashReportInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 652);
            this.Controls.Add(this.textBoxTotalCashInTill);
            this.Controls.Add(this.textBoxStartingCash);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.labelTotalCashEarnTitle);
            this.Controls.Add(this.labelStartingCashTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GetCashReportInputForm";
            this.Text = "Cash Report Input Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetCashReportInputForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStartingCashTitle;
        private System.Windows.Forms.Label labelTotalCashEarnTitle;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.TextBox textBoxStartingCash;
        private System.Windows.Forms.TextBox textBoxTotalCashInTill;
    }
}