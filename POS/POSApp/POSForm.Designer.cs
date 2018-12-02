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
            this.FinalizeOrderButton = new System.Windows.Forms.Button();
            this.SignOff_Button = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.DayReportButton = new System.Windows.Forms.Button();
            this.DayEndButton = new System.Windows.Forms.Button();
            this.OrderControl = new POSApp.OrderControl();
            this.productViewControl1 = new POSApp.ProductViewControl();
            this.OrderControl_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderControl_Panel
            // 
            this.OrderControl_Panel.Controls.Add(this.DayEndButton);
            this.OrderControl_Panel.Controls.Add(this.DayReportButton);
            this.OrderControl_Panel.Controls.Add(this.FinalizeOrderButton);
            this.OrderControl_Panel.Controls.Add(this.SignOff_Button);
            this.OrderControl_Panel.Controls.Add(this.ReturnButton);
            this.OrderControl_Panel.Location = new System.Drawing.Point(566, 495);
            this.OrderControl_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.OrderControl_Panel.Name = "OrderControl_Panel";
            this.OrderControl_Panel.Size = new System.Drawing.Size(751, 236);
            this.OrderControl_Panel.TabIndex = 2;
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
            // SignOff_Button
            // 
            this.SignOff_Button.Location = new System.Drawing.Point(521, 134);
            this.SignOff_Button.Margin = new System.Windows.Forms.Padding(4);
            this.SignOff_Button.Name = "SignOff_Button";
            this.SignOff_Button.Size = new System.Drawing.Size(100, 86);
            this.SignOff_Button.TabIndex = 35;
            this.SignOff_Button.Text = "Sign Off";
            this.SignOff_Button.UseVisualStyleBackColor = true;
            this.SignOff_Button.Click += new System.EventHandler(this.SignOff_Button_Click_1);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(521, 40);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(100, 86);
            this.ReturnButton.TabIndex = 30;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // DayReportButton
            // 
            this.DayReportButton.Location = new System.Drawing.Point(629, 136);
            this.DayReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.DayReportButton.Name = "DayReportButton";
            this.DayReportButton.Size = new System.Drawing.Size(100, 86);
            this.DayReportButton.TabIndex = 40;
            this.DayReportButton.Text = "DayReport";
            this.DayReportButton.UseVisualStyleBackColor = true;
            this.DayReportButton.Click += new System.EventHandler(this.DayReportButton_Click);
            // 
            // DayEndButton
            // 
            this.DayEndButton.Location = new System.Drawing.Point(629, 40);
            this.DayEndButton.Margin = new System.Windows.Forms.Padding(4);
            this.DayEndButton.Name = "DayEndButton";
            this.DayEndButton.Size = new System.Drawing.Size(100, 86);
            this.DayEndButton.TabIndex = 41;
            this.DayEndButton.Text = "DayEnd";
            this.DayEndButton.UseVisualStyleBackColor = true;
            this.DayEndButton.Click += new System.EventHandler(this.DayEndButton_Click);
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
        private System.Windows.Forms.Button SignOff_Button;
        private System.Windows.Forms.Button ReturnButton;
        private ProductViewControl productViewControl1;
        private OrderControl OrderControl;
        private System.Windows.Forms.Button FinalizeOrderButton;
        private System.Windows.Forms.Button DayEndButton;
        private System.Windows.Forms.Button DayReportButton;
    }
}