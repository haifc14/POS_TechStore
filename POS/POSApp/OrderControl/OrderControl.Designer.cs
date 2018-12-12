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
            this.EmployeeIDTitleLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerPointsLabel = new System.Windows.Forms.Label();
            this.OrderType_Panel = new System.Windows.Forms.Panel();
            this.OrderType_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InputBarcodePanel.SuspendLayout();
            this.OrderType_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderSummaryFlowPanel
            // 
            this.OrderSummaryFlowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderSummaryFlowPanel.BackColor = System.Drawing.Color.White;
            this.OrderSummaryFlowPanel.Location = new System.Drawing.Point(3, 2);
            this.OrderSummaryFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OrderSummaryFlowPanel.Name = "OrderSummaryFlowPanel";
            this.OrderSummaryFlowPanel.Size = new System.Drawing.Size(391, 133);
            this.OrderSummaryFlowPanel.TabIndex = 13;
            // 
            // InputBarcodePanel
            // 
            this.InputBarcodePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputBarcodePanel.Controls.Add(this.BarcodeTextBox);
            this.InputBarcodePanel.Controls.Add(this.SubmitBarcodeBtn);
            this.InputBarcodePanel.Location = new System.Drawing.Point(4, 507);
            this.InputBarcodePanel.Margin = new System.Windows.Forms.Padding(2);
            this.InputBarcodePanel.Name = "InputBarcodePanel";
            this.InputBarcodePanel.Size = new System.Drawing.Size(398, 81);
            this.InputBarcodePanel.TabIndex = 12;
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTextBox.Location = new System.Drawing.Point(44, 31);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(207, 26);
            this.BarcodeTextBox.TabIndex = 13;
            // 
            // SubmitBarcodeBtn
            // 
            this.SubmitBarcodeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitBarcodeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SubmitBarcodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitBarcodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBarcodeBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBarcodeBtn.Location = new System.Drawing.Point(274, 26);
            this.SubmitBarcodeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitBarcodeBtn.Name = "SubmitBarcodeBtn";
            this.SubmitBarcodeBtn.Size = new System.Drawing.Size(94, 38);
            this.SubmitBarcodeBtn.TabIndex = 14;
            this.SubmitBarcodeBtn.Text = "Scan";
            this.SubmitBarcodeBtn.UseVisualStyleBackColor = false;
            this.SubmitBarcodeBtn.Click += new System.EventHandler(this.SubmitBarcodeBtn_Click);
            // 
            // OrderView_Panel
            // 
            this.OrderView_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderView_Panel.AutoScroll = true;
            this.OrderView_Panel.BackColor = System.Drawing.Color.White;
            this.OrderView_Panel.Location = new System.Drawing.Point(3, 2);
            this.OrderView_Panel.Margin = new System.Windows.Forms.Padding(25, 26, 25, 26);
            this.OrderView_Panel.Name = "OrderView_Panel";
            this.OrderView_Panel.Size = new System.Drawing.Size(391, 283);
            this.OrderView_Panel.TabIndex = 11;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.ForeColor = System.Drawing.Color.Black;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(113, 8);
            this.EmployeeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(54, 24);
            this.EmployeeIDLabel.TabIndex = 14;
            this.EmployeeIDLabel.Text = "1001";
            this.EmployeeIDLabel.Click += new System.EventHandler(this.EmployeeIDLabel_Click);
            // 
            // EmployeeIDTitleLabel
            // 
            this.EmployeeIDTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeIDTitleLabel.AutoSize = true;
            this.EmployeeIDTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.EmployeeIDTitleLabel.Location = new System.Drawing.Point(5, 11);
            this.EmployeeIDTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeIDTitleLabel.Name = "EmployeeIDTitleLabel";
            this.EmployeeIDTitleLabel.Size = new System.Drawing.Size(111, 20);
            this.EmployeeIDTitleLabel.TabIndex = 16;
            this.EmployeeIDTitleLabel.Text = "EmployeeID:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerNameLabel.Location = new System.Drawing.Point(238, 11);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(0, 20);
            this.CustomerNameLabel.TabIndex = 17;
            // 
            // CustomerPointsLabel
            // 
            this.CustomerPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerPointsLabel.AutoSize = true;
            this.CustomerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPointsLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerPointsLabel.Location = new System.Drawing.Point(331, 11);
            this.CustomerPointsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerPointsLabel.Name = "CustomerPointsLabel";
            this.CustomerPointsLabel.Size = new System.Drawing.Size(0, 24);
            this.CustomerPointsLabel.TabIndex = 18;
            this.CustomerPointsLabel.Tag = "";
            // 
            // OrderType_Panel
            // 
            this.OrderType_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderType_Panel.BackColor = System.Drawing.Color.White;
            this.OrderType_Panel.Controls.Add(this.OrderType_Label);
            this.OrderType_Panel.Location = new System.Drawing.Point(4, 37);
            this.OrderType_Panel.Margin = new System.Windows.Forms.Padding(1);
            this.OrderType_Panel.Name = "OrderType_Panel";
            this.OrderType_Panel.Size = new System.Drawing.Size(398, 25);
            this.OrderType_Panel.TabIndex = 19;
            // 
            // OrderType_Label
            // 
            this.OrderType_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderType_Label.AutoSize = true;
            this.OrderType_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderType_Label.Location = new System.Drawing.Point(4, 4);
            this.OrderType_Label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.OrderType_Label.Name = "OrderType_Label";
            this.OrderType_Label.Size = new System.Drawing.Size(0, 20);
            this.OrderType_Label.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.OrderSummaryFlowPanel);
            this.panel1.Location = new System.Drawing.Point(5, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 138);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.OrderView_Panel);
            this.panel2.Location = new System.Drawing.Point(5, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 288);
            this.panel2.TabIndex = 0;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderType_Panel);
            this.Controls.Add(this.CustomerPointsLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.EmployeeIDTitleLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.InputBarcodePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(407, 591);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            this.InputBarcodePanel.ResumeLayout(false);
            this.InputBarcodePanel.PerformLayout();
            this.OrderType_Panel.ResumeLayout(false);
            this.OrderType_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
