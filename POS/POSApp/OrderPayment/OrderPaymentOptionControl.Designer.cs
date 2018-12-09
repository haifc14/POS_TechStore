namespace POSApp
{
    partial class OrderPaymentOptionControl
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
            this.PaymentTypeLabel = new System.Windows.Forms.Label();
            this.PaymentTypeTextbox = new System.Windows.Forms.TextBox();
            this.CurrencyLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaymentTypeLabel
            // 
            this.PaymentTypeLabel.AutoSize = true;
            this.PaymentTypeLabel.Location = new System.Drawing.Point(42, 6);
            this.PaymentTypeLabel.Name = "PaymentTypeLabel";
            this.PaymentTypeLabel.Size = new System.Drawing.Size(46, 17);
            this.PaymentTypeLabel.TabIndex = 0;
            this.PaymentTypeLabel.Text = "label1";
            // 
            // PaymentTypeTextbox
            // 
            this.PaymentTypeTextbox.Location = new System.Drawing.Point(226, 4);
            this.PaymentTypeTextbox.Name = "PaymentTypeTextbox";
            this.PaymentTypeTextbox.Size = new System.Drawing.Size(221, 22);
            this.PaymentTypeTextbox.TabIndex = 1;
            // 
            // CurruncyLabel
            // 
            this.CurrencyLable.AutoSize = true;
            this.CurrencyLable.Location = new System.Drawing.Point(204, 6);
            this.CurrencyLable.Name = "CurruncyLabel";
            this.CurrencyLable.Size = new System.Drawing.Size(16, 17);
            this.CurrencyLable.TabIndex = 2;
            this.CurrencyLable.Text = "$";
            // 
            // OrderPaymentOptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrencyLable);
            this.Controls.Add(this.PaymentTypeTextbox);
            this.Controls.Add(this.PaymentTypeLabel);
            this.Name = "OrderPaymentOptionControl";
            this.Size = new System.Drawing.Size(475, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentTypeLabel;
        private System.Windows.Forms.TextBox PaymentTypeTextbox;
        private System.Windows.Forms.Label CurrencyLable;
    }
}
