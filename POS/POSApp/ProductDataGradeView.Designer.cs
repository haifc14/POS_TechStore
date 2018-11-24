namespace POSApp
{
    partial class ProductViewControl
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
            this.ProductsViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ProductsViewPanel
            // 
            this.ProductsViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsViewPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductsViewPanel.Name = "ProductsViewPanel";
            this.ProductsViewPanel.Size = new System.Drawing.Size(1013, 746);
            this.ProductsViewPanel.TabIndex = 0;
            // 
            // ProductDataGradeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductsViewPanel);
            this.Name = "ProductDataGradeView";
            this.Size = new System.Drawing.Size(1013, 746);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductsViewPanel;
    }
}
