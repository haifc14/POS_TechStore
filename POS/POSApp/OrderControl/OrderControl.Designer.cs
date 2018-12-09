﻿namespace POSApp
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
            this.EmployeeIDTitleLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerPointsLabel = new System.Windows.Forms.Label();
            this.OrderType_Panel = new System.Windows.Forms.Panel();
            this.OrderType_Label = new System.Windows.Forms.Label();
            this.InputBarcodePanel.SuspendLayout();
            this.OrderType_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderSummaryFlowPanel
            // 
            this.OrderSummaryFlowPanel.Location = new System.Drawing.Point(6, 876);
            this.OrderSummaryFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderSummaryFlowPanel.Name = "OrderSummaryFlowPanel";
            this.OrderSummaryFlowPanel.Size = new System.Drawing.Size(1064, 320);
            this.OrderSummaryFlowPanel.TabIndex = 13;
            // 
            // InputBarcodePanel
            // 
            this.InputBarcodePanel.Controls.Add(this.BarcodeTextBox);
            this.InputBarcodePanel.Controls.Add(this.SubmitBarcodeBtn);
            this.InputBarcodePanel.Location = new System.Drawing.Point(6, 1201);
            this.InputBarcodePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputBarcodePanel.Name = "InputBarcodePanel";
            this.InputBarcodePanel.Size = new System.Drawing.Size(1062, 192);
            this.InputBarcodePanel.TabIndex = 12;
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Location = new System.Drawing.Point(128, 85);
            this.BarcodeTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(546, 38);
            this.BarcodeTextBox.TabIndex = 13;
            // 
            // SubmitBarcodeBtn
            // 
            this.SubmitBarcodeBtn.Location = new System.Drawing.Point(736, 76);
            this.SubmitBarcodeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitBarcodeBtn.Name = "SubmitBarcodeBtn";
            this.SubmitBarcodeBtn.Size = new System.Drawing.Size(194, 62);
            this.SubmitBarcodeBtn.TabIndex = 14;
            this.SubmitBarcodeBtn.Text = "Submit";
            this.SubmitBarcodeBtn.UseVisualStyleBackColor = true;
            this.SubmitBarcodeBtn.Click += new System.EventHandler(this.SubmitBarcodeBtn_Click);
            // 
            // OrderView_Panel
            // 
            this.OrderView_Panel.AutoScroll = true;
            this.OrderView_Panel.Location = new System.Drawing.Point(6, 147);
            this.OrderView_Panel.Margin = new System.Windows.Forms.Padding(66, 62, 66, 62);
            this.OrderView_Panel.Name = "OrderView_Panel";
            this.OrderView_Panel.Size = new System.Drawing.Size(1062, 723);
            this.OrderView_Panel.TabIndex = 11;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(296, 13);
            this.EmployeeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(131, 54);
            this.EmployeeIDLabel.TabIndex = 14;
            this.EmployeeIDLabel.Text = "1001";
            // 
            // EmployeeIDTitleLabel
            // 
            this.EmployeeIDTitleLabel.AutoSize = true;
            this.EmployeeIDTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTitleLabel.Location = new System.Drawing.Point(8, 19);
            this.EmployeeIDTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeIDTitleLabel.Name = "EmployeeIDTitleLabel";
            this.EmployeeIDTitleLabel.Size = new System.Drawing.Size(259, 46);
            this.EmployeeIDTitleLabel.TabIndex = 16;
            this.EmployeeIDTitleLabel.Text = "EmployeeID:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(628, 19);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(0, 46);
            this.CustomerNameLabel.TabIndex = 17;
            // 
            // CustomerPointsLabel
            // 
            this.CustomerPointsLabel.AutoSize = true;
            this.CustomerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPointsLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.CustomerPointsLabel.Location = new System.Drawing.Point(878, 19);
            this.CustomerPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerPointsLabel.Name = "CustomerPointsLabel";
            this.CustomerPointsLabel.Size = new System.Drawing.Size(0, 54);
            this.CustomerPointsLabel.TabIndex = 18;
            this.CustomerPointsLabel.Tag = "";
            // 
            // OrderType_Panel
            // 
            this.OrderType_Panel.Controls.Add(this.OrderType_Label);
            this.OrderType_Panel.Location = new System.Drawing.Point(6, 81);
            this.OrderType_Panel.Name = "OrderType_Panel";
            this.OrderType_Panel.Size = new System.Drawing.Size(1062, 60);
            this.OrderType_Panel.TabIndex = 19;
            // 
            // OrderType_Label
            // 
            this.OrderType_Label.AutoSize = true;
            this.OrderType_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderType_Label.Location = new System.Drawing.Point(10, 10);
            this.OrderType_Label.Name = "OrderType_Label";
            this.OrderType_Label.Size = new System.Drawing.Size(0, 46);
            this.OrderType_Label.TabIndex = 0;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderType_Panel);
            this.Controls.Add(this.CustomerPointsLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.EmployeeIDTitleLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.OrderSummaryFlowPanel);
            this.Controls.Add(this.InputBarcodePanel);
            this.Controls.Add(this.OrderView_Panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(1074, 1395);
            this.InputBarcodePanel.ResumeLayout(false);
            this.InputBarcodePanel.PerformLayout();
            this.OrderType_Panel.ResumeLayout(false);
            this.OrderType_Panel.PerformLayout();
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
        private System.Windows.Forms.Label EmployeeIDTitleLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustomerPointsLabel;
        private System.Windows.Forms.Panel OrderType_Panel;
        private System.Windows.Forms.Label OrderType_Label;
    }
}