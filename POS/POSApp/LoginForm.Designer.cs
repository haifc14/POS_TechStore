namespace POSApp
{
    partial class LoginForm
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
            this.SignInBtn = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.pictureBoxLoginPhoto = new System.Windows.Forms.PictureBox();
            this.panelLineDeco = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.SignInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(875, 406);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(215, 89);
            this.SignInBtn.TabIndex = 0;
            this.SignInBtn.Text = "Log In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(407, 161);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(196, 44);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(398, 292);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(207, 44);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Passwaord";
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(615, 149);
            this.UserNameTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.UserNameTextbox.Multiline = true;
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(475, 56);
            this.UserNameTextbox.TabIndex = 3;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(615, 280);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(475, 56);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Text = "\r\n";
            // 
            // pictureBoxLoginPhoto
            // 
            this.pictureBoxLoginPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoginPhoto.ErrorImage = null;
            this.pictureBoxLoginPhoto.Image = global::POSApp.Properties.Resources.loginPhoto;
            this.pictureBoxLoginPhoto.Location = new System.Drawing.Point(33, 123);
            this.pictureBoxLoginPhoto.Name = "pictureBoxLoginPhoto";
            this.pictureBoxLoginPhoto.Size = new System.Drawing.Size(354, 336);
            this.pictureBoxLoginPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginPhoto.TabIndex = 5;
            this.pictureBoxLoginPhoto.TabStop = false;
            // 
            // panelLineDeco
            // 
            this.panelLineDeco.BackColor = System.Drawing.Color.YellowGreen;
            this.panelLineDeco.Location = new System.Drawing.Point(33, 40);
            this.panelLineDeco.Name = "panelLineDeco";
            this.panelLineDeco.Size = new System.Drawing.Size(1057, 16);
            this.panelLineDeco.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 560);
            this.Controls.Add(this.panelLineDeco);
            this.Controls.Add(this.pictureBoxLoginPhoto);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SignInBtn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.Text = "POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.PictureBox pictureBoxLoginPhoto;
        private System.Windows.Forms.Panel panelLineDeco;
    }
}