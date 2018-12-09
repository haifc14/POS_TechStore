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
            this.PaymentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeLabel.Location = new System.Drawing.Point(32, 5);
            this.PaymentTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PaymentTypeLabel.Name = "PaymentTypeLabel";
            this.PaymentTypeLabel.Size = new System.Drawing.Size(41, 15);
            this.PaymentTypeLabel.TabIndex = 0;
            this.PaymentTypeLabel.Text = "label1";
            // 
            // PaymentTypeTextbox
            // 
            this.PaymentTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeTextbox.Location = new System.Drawing.Point(170, 3);
            this.PaymentTypeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentTypeTextbox.Name = "PaymentTypeTextbox";
            this.PaymentTypeTextbox.Size = new System.Drawing.Size(167, 21);
            this.PaymentTypeTextbox.TabIndex = 1;
            // 
            // CurrencyLable
            // 
            this.CurrencyLable.AutoSize = true;
            this.CurrencyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLable.Location = new System.Drawing.Point(153, 5);
            this.CurrencyLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrencyLable.Name = "CurrencyLable";
            this.CurrencyLable.Size = new System.Drawing.Size(14, 15);
            this.CurrencyLable.TabIndex = 2;
            this.CurrencyLable.Text = "$";
            // 
            // OrderPaymentOptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrencyLable);
            this.Controls.Add(this.PaymentTypeTextbox);
            this.Controls.Add(this.PaymentTypeLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderPaymentOptionControl";
            this.Size = new System.Drawing.Size(356, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentTypeLabel;
        private System.Windows.Forms.TextBox PaymentTypeTextbox;
        private System.Windows.Forms.Label CurrencyLable;
    }
}
