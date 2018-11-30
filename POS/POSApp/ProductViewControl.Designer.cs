﻿namespace POSApp
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
            this.ProductDataGradeView = new System.Windows.Forms.DataGridView();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RecommendedButtton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGradeView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDataGradeView
            // 
            this.ProductDataGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGradeView.Location = new System.Drawing.Point(0, 0);
            this.ProductDataGradeView.Name = "ProductDataGradeView";
            this.ProductDataGradeView.RowTemplate.Height = 37;
            this.ProductDataGradeView.Size = new System.Drawing.Size(1293, 620);
            this.ProductDataGradeView.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(243, 725);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(276, 77);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RecommendedButtton
            // 
            this.RecommendedButtton.Location = new System.Drawing.Point(817, 725);
            this.RecommendedButtton.Name = "RecommendedButtton";
            this.RecommendedButtton.Size = new System.Drawing.Size(218, 77);
            this.RecommendedButtton.TabIndex = 2;
            this.RecommendedButtton.Text = "Recommended";
            this.RecommendedButtton.UseVisualStyleBackColor = true;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(861, 654);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(409, 37);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.Text = "Select Category";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(471, 654);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(353, 37);
            this.BrandComboBox.TabIndex = 5;
            this.BrandComboBox.Text = "Select Brand";
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(24, 654);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(425, 35);
            this.SearchTextbox.TabIndex = 6;
            // 
            // ProductViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.BrandComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.RecommendedButtton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ProductDataGradeView);
            this.Name = "ProductViewControl";
            this.Size = new System.Drawing.Size(1293, 825);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGradeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGradeView;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button RecommendedButtton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.TextBox SearchTextbox;
    }
}