namespace vm_Clone {
	partial class MainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.colorPanel = new System.Windows.Forms.Panel();
			this.sidePanel = new System.Windows.Forms.Panel();
			this.linkSortUp = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.settings_button = new System.Windows.Forms.Button();
			this.contacts_button = new System.Windows.Forms.Button();
			this.stream_button = new System.Windows.Forms.Button();
			this.link_button = new System.Windows.Forms.Button();
			this.subLinkPanel = new System.Windows.Forms.Panel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.floatMenu = new System.Windows.Forms.Panel();
			this.sidePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.subLinkPanel.SuspendLayout();
			this.floatMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// colorPanel
			// 
			this.colorPanel.BackColor = System.Drawing.Color.Gold;
			this.colorPanel.Location = new System.Drawing.Point(0, 0);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(635, 13);
			this.colorPanel.TabIndex = 1;
			// 
			// sidePanel
			// 
			this.sidePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.sidePanel.Controls.Add(this.floatMenu);
			this.sidePanel.Controls.Add(this.linkSortUp);
			this.sidePanel.Controls.Add(this.pictureBox1);
			this.sidePanel.Controls.Add(this.link_button);
			this.sidePanel.Location = new System.Drawing.Point(0, 12);
			this.sidePanel.Name = "sidePanel";
			this.sidePanel.Size = new System.Drawing.Size(112, 481);
			this.sidePanel.TabIndex = 2;
			// 
			// linkSortUp
			// 
			this.linkSortUp.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.linkSortUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.linkSortUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.linkSortUp.FlatAppearance.BorderSize = 0;
			this.linkSortUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.linkSortUp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkSortUp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.linkSortUp.Image = ((System.Drawing.Image)(resources.GetObject("linkSortUp.Image")));
			this.linkSortUp.Location = new System.Drawing.Point(0, 109);
			this.linkSortUp.Name = "linkSortUp";
			this.linkSortUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.linkSortUp.Size = new System.Drawing.Size(112, 43);
			this.linkSortUp.TabIndex = 4;
			this.linkSortUp.Text = "    Links";
			this.linkSortUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkSortUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.linkSortUp.UseVisualStyleBackColor = false;
			this.linkSortUp.Click += new System.EventHandler(this.linkSortUp_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(63, 61);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// settings_button
			// 
			this.settings_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.settings_button.FlatAppearance.BorderSize = 0;
			this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settings_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settings_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.settings_button.Location = new System.Drawing.Point(0, 86);
			this.settings_button.Name = "settings_button";
			this.settings_button.Size = new System.Drawing.Size(112, 43);
			this.settings_button.TabIndex = 6;
			this.settings_button.Text = "    Settings";
			this.settings_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.settings_button.UseVisualStyleBackColor = true;
			// 
			// contacts_button
			// 
			this.contacts_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.contacts_button.FlatAppearance.BorderSize = 0;
			this.contacts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.contacts_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contacts_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.contacts_button.Location = new System.Drawing.Point(0, 43);
			this.contacts_button.Name = "contacts_button";
			this.contacts_button.Size = new System.Drawing.Size(112, 43);
			this.contacts_button.TabIndex = 5;
			this.contacts_button.Text = "    Contacts";
			this.contacts_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.contacts_button.UseVisualStyleBackColor = true;
			// 
			// stream_button
			// 
			this.stream_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.stream_button.FlatAppearance.BorderSize = 0;
			this.stream_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stream_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stream_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.stream_button.Location = new System.Drawing.Point(0, 0);
			this.stream_button.Name = "stream_button";
			this.stream_button.Size = new System.Drawing.Size(112, 43);
			this.stream_button.TabIndex = 4;
			this.stream_button.Text = "    Stream";
			this.stream_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.stream_button.UseVisualStyleBackColor = true;
			// 
			// link_button
			// 
			this.link_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.link_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.link_button.FlatAppearance.BorderSize = 0;
			this.link_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.link_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.link_button.Image = ((System.Drawing.Image)(resources.GetObject("link_button.Image")));
			this.link_button.Location = new System.Drawing.Point(0, 109);
			this.link_button.Name = "link_button";
			this.link_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.link_button.Size = new System.Drawing.Size(112, 43);
			this.link_button.TabIndex = 3;
			this.link_button.Text = "    Links";
			this.link_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.link_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.link_button.UseVisualStyleBackColor = true;
			this.link_button.Click += new System.EventHandler(this.link_button_Click);
			// 
			// subLinkPanel
			// 
			this.subLinkPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.subLinkPanel.Controls.Add(this.checkBox5);
			this.subLinkPanel.Controls.Add(this.checkBox4);
			this.subLinkPanel.Controls.Add(this.checkBox3);
			this.subLinkPanel.Controls.Add(this.checkBox2);
			this.subLinkPanel.Controls.Add(this.checkBox1);
			this.subLinkPanel.Location = new System.Drawing.Point(118, 130);
			this.subLinkPanel.Name = "subLinkPanel";
			this.subLinkPanel.Size = new System.Drawing.Size(112, 101);
			this.subLinkPanel.TabIndex = 4;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.checkBox1.Location = new System.Drawing.Point(34, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(40, 19);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "All";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.checkBox2.Location = new System.Drawing.Point(34, 22);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(54, 19);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Users";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.checkBox3.Location = new System.Drawing.Point(34, 41);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(64, 19);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Groups";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.checkBox4.Location = new System.Drawing.Point(34, 79);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(74, 19);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Activities";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.checkBox5.Location = new System.Drawing.Point(34, 60);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(62, 19);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Spaces";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// floatMenu
			// 
			this.floatMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.floatMenu.Controls.Add(this.settings_button);
			this.floatMenu.Controls.Add(this.stream_button);
			this.floatMenu.Controls.Add(this.contacts_button);
			this.floatMenu.Location = new System.Drawing.Point(0, 152);
			this.floatMenu.Name = "floatMenu";
			this.floatMenu.Size = new System.Drawing.Size(112, 140);
			this.floatMenu.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(633, 493);
			this.Controls.Add(this.subLinkPanel);
			this.Controls.Add(this.colorPanel);
			this.Controls.Add(this.sidePanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vmoso Big Knowledge Widget";
			this.sidePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.subLinkPanel.ResumeLayout(false);
			this.subLinkPanel.PerformLayout();
			this.floatMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel colorPanel;
		private System.Windows.Forms.Panel sidePanel;
		private System.Windows.Forms.Button link_button;
		private System.Windows.Forms.Button stream_button;
		private System.Windows.Forms.Button settings_button;
		private System.Windows.Forms.Button contacts_button;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button linkSortUp;
		private System.Windows.Forms.Panel subLinkPanel;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Panel floatMenu;
	}
}