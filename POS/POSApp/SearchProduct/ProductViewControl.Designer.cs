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
            this.ProductDataGradeView.BackgroundColor = System.Drawing.Color.White;
            this.ProductDataGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGradeView.Location = new System.Drawing.Point(4, 4);
            this.ProductDataGradeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductDataGradeView.Name = "ProductDataGradeView";
            this.ProductDataGradeView.RowTemplate.Height = 37;
            this.ProductDataGradeView.Size = new System.Drawing.Size(1120, 729);
            this.ProductDataGradeView.TabIndex = 0;
            this.ProductDataGradeView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGradeView_CellContentClick);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DeepPink;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(212, 827);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(236, 65);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Search Product";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RecommendedButtton
            // 
            this.RecommendedButtton.BackColor = System.Drawing.Color.DeepPink;
            this.RecommendedButtton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecommendedButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecommendedButtton.ForeColor = System.Drawing.Color.White;
            this.RecommendedButtton.Location = new System.Drawing.Point(704, 827);
            this.RecommendedButtton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecommendedButtton.Name = "RecommendedButtton";
            this.RecommendedButtton.Size = new System.Drawing.Size(202, 65);
            this.RecommendedButtton.TabIndex = 2;
            this.RecommendedButtton.Text = "Recommended";
            this.RecommendedButtton.UseVisualStyleBackColor = false;
            this.RecommendedButtton.Click += new System.EventHandler(this.RecommendedButtton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(742, 750);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(350, 44);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.Text = "Select Category";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(408, 750);
            this.BrandComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(302, 44);
            this.BrandComboBox.TabIndex = 5;
            this.BrandComboBox.Text = "Select Brand";
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.Location = new System.Drawing.Point(26, 750);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(366, 41);
            this.SearchTextbox.TabIndex = 6;
            // 
            // ProductViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductDataGradeView);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RecommendedButtton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.BrandComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductViewControl";
            this.Size = new System.Drawing.Size(1124, 908);
            this.Load += new System.EventHandler(this.ProductViewControl_Load);
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
