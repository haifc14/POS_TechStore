namespace POSApp
{
    partial class FinalizeOrderForm
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
            this.OrderSummaryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PaymentControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.OrderDiscountControl = new POSApp.OrderPaymentOptionControl();
            this.CashPaymentControl = new POSApp.OrderPaymentOptionControl();
            this.CardPaymentControl = new POSApp.OrderPaymentOptionControl();
            this.RedeemPointControl = new POSApp.OrderPaymentOptionControl();
            this.PaymentControlsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderSummaryPanel
            // 
            this.OrderSummaryPanel.AutoScroll = true;
            this.OrderSummaryPanel.Location = new System.Drawing.Point(27, 12);
            this.OrderSummaryPanel.Name = "OrderSummaryPanel";
            this.OrderSummaryPanel.Size = new System.Drawing.Size(484, 416);
            this.OrderSummaryPanel.TabIndex = 4;
            // 
            // PaymentControlsPanel
            // 
            this.PaymentControlsPanel.Controls.Add(this.OrderDiscountControl);
            this.PaymentControlsPanel.Controls.Add(this.CashPaymentControl);
            this.PaymentControlsPanel.Controls.Add(this.CardPaymentControl);
            this.PaymentControlsPanel.Controls.Add(this.RedeemPointControl);
            this.PaymentControlsPanel.Controls.Add(this.panel1);
            this.PaymentControlsPanel.Controls.Add(this.panel2);
            this.PaymentControlsPanel.Location = new System.Drawing.Point(27, 434);
            this.PaymentControlsPanel.Name = "PaymentControlsPanel";
            this.PaymentControlsPanel.Size = new System.Drawing.Size(484, 242);
            this.PaymentControlsPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CompleteOrderButton);
            this.panel1.Location = new System.Drawing.Point(3, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 40);
            this.panel1.TabIndex = 4;
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.BackColor = System.Drawing.Color.Green;
            this.CompleteOrderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompleteOrderButton.Location = new System.Drawing.Point(105, 0);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(265, 40);
            this.CompleteOrderButton.TabIndex = 5;
            this.CompleteOrderButton.Text = "Complete Order";
            this.CompleteOrderButton.UseVisualStyleBackColor = false;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CancelOrderButton);
            this.panel2.Location = new System.Drawing.Point(3, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 40);
            this.panel2.TabIndex = 7;
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.BackColor = System.Drawing.Color.Red;
            this.CancelOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelOrderButton.Location = new System.Drawing.Point(105, 0);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(265, 40);
            this.CancelOrderButton.TabIndex = 5;
            this.CancelOrderButton.Text = "Abort Transaction";
            this.CancelOrderButton.UseVisualStyleBackColor = false;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // OrderDiscountControl
            // 
            this.OrderDiscountControl.CurrencySign = "$";
            this.OrderDiscountControl.LabelName = "Discount";
            this.OrderDiscountControl.Location = new System.Drawing.Point(3, 3);
            this.OrderDiscountControl.Name = "OrderDiscountControl";
            this.OrderDiscountControl.Size = new System.Drawing.Size(475, 30);
            this.OrderDiscountControl.TabIndex = 3;
            this.OrderDiscountControl.UserInput = "";
            // 
            // CashPaymentControl
            // 
            this.CashPaymentControl.CurrencySign = "$";
            this.CashPaymentControl.LabelName = "Cash";
            this.CashPaymentControl.Location = new System.Drawing.Point(3, 39);
            this.CashPaymentControl.Name = "CashPaymentControl";
            this.CashPaymentControl.Size = new System.Drawing.Size(475, 30);
            this.CashPaymentControl.TabIndex = 0;
            this.CashPaymentControl.UserInput = "";
            // 
            // CardPaymentControl
            // 
            this.CardPaymentControl.CurrencySign = "$";
            this.CardPaymentControl.LabelName = "Card";
            this.CardPaymentControl.Location = new System.Drawing.Point(3, 75);
            this.CardPaymentControl.Name = "CardPaymentControl";
            this.CardPaymentControl.Size = new System.Drawing.Size(475, 30);
            this.CardPaymentControl.TabIndex = 1;
            this.CardPaymentControl.UserInput = "";
            // 
            // RedeemPointControl
            // 
            this.RedeemPointControl.CurrencySign = "";
            this.RedeemPointControl.LabelName = "Redeem Points";
            this.RedeemPointControl.Location = new System.Drawing.Point(3, 111);
            this.RedeemPointControl.Name = "RedeemPointControl";
            this.RedeemPointControl.Size = new System.Drawing.Size(475, 30);
            this.RedeemPointControl.TabIndex = 2;
            this.RedeemPointControl.UserInput = "";
            // 
            // FinalizeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 688);
            this.Controls.Add(this.OrderSummaryPanel);
            this.Controls.Add(this.PaymentControlsPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalizeOrderForm";
            this.Text = "FinalizeOrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinalizeOrderForm_FormClosed);
            this.Load += new System.EventHandler(this.FinalizeOrderForm_Load);
            this.PaymentControlsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel OrderSummaryPanel;
        private System.Windows.Forms.FlowLayoutPanel PaymentControlsPanel;
        private OrderPaymentOptionControl CashPaymentControl;
        private OrderPaymentOptionControl CardPaymentControl;
        private OrderPaymentOptionControl RedeemPointControl;
        private OrderPaymentOptionControl OrderDiscountControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CompleteOrderButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelOrderButton;
    }
}