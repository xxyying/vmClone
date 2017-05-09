namespace vm_Clone {
	partial class LoginForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.colorPanel = new System.Windows.Forms.Panel();
			this.logoPicture = new System.Windows.Forms.PictureBox();
			this.txtLine1 = new System.Windows.Forms.TextBox();
			this.txtLine2 = new System.Windows.Forms.TextBox();
			this.userName = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.passWord = new System.Windows.Forms.TextBox();
			this.forgetPasswordLabel = new System.Windows.Forms.LinkLabel();
			this.rememberMe_checkBox = new System.Windows.Forms.CheckBox();
			this.labelVersion = new System.Windows.Forms.Label();
			this.signUpLink = new System.Windows.Forms.LinkLabel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// colorPanel
			// 
			this.colorPanel.BackColor = System.Drawing.Color.Gold;
			this.colorPanel.Location = new System.Drawing.Point(-2, 0);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(525, 11);
			this.colorPanel.TabIndex = 0;
			// 
			// logoPicture
			// 
			this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
			this.logoPicture.Location = new System.Drawing.Point(28, 48);
			this.logoPicture.Name = "logoPicture";
			this.logoPicture.Size = new System.Drawing.Size(200, 64);
			this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPicture.TabIndex = 1;
			this.logoPicture.TabStop = false;
			// 
			// txtLine1
			// 
			this.txtLine1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLine1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLine1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtLine1.Location = new System.Drawing.Point(28, 128);
			this.txtLine1.Name = "txtLine1";
			this.txtLine1.Size = new System.Drawing.Size(170, 18);
			this.txtLine1.TabIndex = 2;
			this.txtLine1.Text = "Vmoso is where Knowledge";
			// 
			// txtLine2
			// 
			this.txtLine2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLine2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.txtLine2.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtLine2.Location = new System.Drawing.Point(28, 148);
			this.txtLine2.Name = "txtLine2";
			this.txtLine2.Size = new System.Drawing.Size(216, 18);
			this.txtLine2.TabIndex = 3;
			this.txtLine2.Text = "Management meets collaboration";
			// 
			// userName
			// 
			this.userName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.userName.Location = new System.Drawing.Point(280, 48);
			this.userName.Multiline = true;
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(212, 31);
			this.userName.TabIndex = 4;
			this.userName.Text = "Username";
			this.userName.Enter += new System.EventHandler(this.userName_Enter);
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.Color.DodgerBlue;
			this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LoginButton.Location = new System.Drawing.Point(280, 157);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(212, 35);
			this.LoginButton.TabIndex = 6;
			this.LoginButton.Text = "Log In";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// passWord
			// 
			this.passWord.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passWord.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.passWord.Location = new System.Drawing.Point(280, 96);
			this.passWord.Multiline = true;
			this.passWord.Name = "passWord";
			this.passWord.Size = new System.Drawing.Size(212, 31);
			this.passWord.TabIndex = 7;
			this.passWord.Text = "Password";
			this.passWord.Enter += new System.EventHandler(this.passWord_Enter);
			// 
			// forgetPasswordLabel
			// 
			this.forgetPasswordLabel.AutoSize = true;
			this.forgetPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forgetPasswordLabel.LinkColor = System.Drawing.Color.DodgerBlue;
			this.forgetPasswordLabel.Location = new System.Drawing.Point(394, 133);
			this.forgetPasswordLabel.Name = "forgetPasswordLabel";
			this.forgetPasswordLabel.Size = new System.Drawing.Size(98, 13);
			this.forgetPasswordLabel.TabIndex = 8;
			this.forgetPasswordLabel.TabStop = true;
			this.forgetPasswordLabel.Text = "Forget Password?";
			this.forgetPasswordLabel.Click += new System.EventHandler(this.forgetLabel_LinkClicked);
			// 
			// rememberMe_checkBox
			// 
			this.rememberMe_checkBox.AutoSize = true;
			this.rememberMe_checkBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rememberMe_checkBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.rememberMe_checkBox.Location = new System.Drawing.Point(280, 132);
			this.rememberMe_checkBox.Name = "rememberMe_checkBox";
			this.rememberMe_checkBox.Size = new System.Drawing.Size(99, 17);
			this.rememberMe_checkBox.TabIndex = 9;
			this.rememberMe_checkBox.Text = "Remember Me";
			this.rememberMe_checkBox.UseVisualStyleBackColor = true;
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.labelVersion.Location = new System.Drawing.Point(220, 236);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(45, 15);
			this.labelVersion.TabIndex = 10;
			this.labelVersion.Text = "Version";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// signUpLink
			// 
			this.signUpLink.AutoSize = true;
			this.signUpLink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signUpLink.LinkColor = System.Drawing.Color.DodgerBlue;
			this.signUpLink.Location = new System.Drawing.Point(82, 169);
			this.signUpLink.Name = "signUpLink";
			this.signUpLink.Size = new System.Drawing.Size(78, 13);
			this.signUpLink.TabIndex = 11;
			this.signUpLink.TabStop = true;
			this.signUpLink.Text = "Sign Up Now!";
			this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(519, 261);
			this.Controls.Add(this.signUpLink);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.rememberMe_checkBox);
			this.Controls.Add(this.forgetPasswordLabel);
			this.Controls.Add(this.passWord);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.userName);
			this.Controls.Add(this.txtLine2);
			this.Controls.Add(this.txtLine1);
			this.Controls.Add(this.logoPicture);
			this.Controls.Add(this.colorPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(535, 300);
			this.MinimumSize = new System.Drawing.Size(535, 300);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vmoso Big Knowledge Widget Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel colorPanel;
		private System.Windows.Forms.PictureBox logoPicture;
		private System.Windows.Forms.TextBox txtLine1;
		private System.Windows.Forms.TextBox txtLine2;
		private System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox passWord;
		private System.Windows.Forms.LinkLabel forgetPasswordLabel;
		private System.Windows.Forms.CheckBox rememberMe_checkBox;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.LinkLabel signUpLink;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

