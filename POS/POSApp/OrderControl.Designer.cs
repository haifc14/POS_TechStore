namespace POSApp
{
    partial class OrderControl
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
            this.OrderSummaryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InputBarcodePanel = new System.Windows.Forms.Panel();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.SubmitBarcodeBtn = new System.Windows.Forms.Button();
            this.OrderView_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.ClearOrderBtn = new System.Windows.Forms.Button();
            this.EmployeeIDTitleLabel = new System.Windows.Forms.Label();
            this.InputBarcodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderSummaryFlowPanel
            // 
            this.OrderSummaryFlowPanel.Location = new System.Drawing.Point(4, 576);
            this.OrderSummaryFlowPanel.Name = "OrderSummaryFlowPanel";
            this.OrderSummaryFlowPanel.Size = new System.Drawing.Size(796, 378);
            this.OrderSummaryFlowPanel.TabIndex = 13;
            // 
            // InputBarcodePanel
            // 
            this.InputBarcodePanel.Controls.Add(this.BarcodeTextBox);
            this.InputBarcodePanel.Controls.Add(this.SubmitBarcodeBtn);
            this.InputBarcodePanel.Location = new System.Drawing.Point(4, 968);
            this.InputBarcodePanel.Name = "InputBarcodePanel";
            this.InputBarcodePanel.Size = new System.Drawing.Size(796, 154);
            this.InputBarcodePanel.TabIndex = 12;
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(96, 69);
            this.BarcodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(410, 31);
            this.BarcodeTextBox.TabIndex = 13;
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
            // OrderView_Panel
            // 
            this.OrderView_Panel.AutoScroll = true;
            this.OrderView_Panel.Location = new System.Drawing.Point(4, 119);
            this.OrderView_Panel.Margin = new System.Windows.Forms.Padding(50);
            this.OrderView_Panel.Name = "OrderView_Panel";
            this.OrderView_Panel.Size = new System.Drawing.Size(796, 439);
            this.OrderView_Panel.TabIndex = 11;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(237, 10);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(106, 42);
            this.EmployeeIDLabel.TabIndex = 14;
            this.EmployeeIDLabel.Text = "1001";
            // 
            // ClearOrderBtn
            // 
            this.ClearOrderBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ClearOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearOrderBtn.Location = new System.Drawing.Point(633, 15);
            this.ClearOrderBtn.Name = "ClearOrderBtn";
            this.ClearOrderBtn.Size = new System.Drawing.Size(127, 51);
            this.ClearOrderBtn.TabIndex = 15;
            this.ClearOrderBtn.Text = "Clear";
            this.ClearOrderBtn.UseVisualStyleBackColor = false;
            // 
            // EmployeeIDTitleLabel
            // 
            this.EmployeeIDTitleLabel.AutoSize = true;
            this.EmployeeIDTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTitleLabel.Location = new System.Drawing.Point(13, 15);
            this.EmployeeIDTitleLabel.Name = "EmployeeIDTitleLabel";
            this.EmployeeIDTitleLabel.Size = new System.Drawing.Size(208, 37);
            this.EmployeeIDTitleLabel.TabIndex = 16;
            this.EmployeeIDTitleLabel.Text = "EmployeeID:";
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeIDTitleLabel);
            this.Controls.Add(this.ClearOrderBtn);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.OrderSummaryFlowPanel);
            this.Controls.Add(this.InputBarcodePanel);
            this.Controls.Add(this.OrderView_Panel);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(805, 1125);
            this.InputBarcodePanel.ResumeLayout(false);
            this.InputBarcodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrderSummaryFlowPanel;
        private System.Windows.Forms.Panel InputBarcodePanel;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.Button SubmitBarcodeBtn;
        private System.Windows.Forms.FlowLayoutPanel OrderView_Panel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Button ClearOrderBtn;
        private System.Windows.Forms.Label EmployeeIDTitleLabel;
    }
}
