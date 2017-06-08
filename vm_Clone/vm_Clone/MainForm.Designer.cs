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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.colorPanel = new System.Windows.Forms.Panel();
			this.sidePanel = new System.Windows.Forms.Panel();
			this.link_button = new System.Windows.Forms.Button();
			this.floatMenu = new System.Windows.Forms.Panel();
			this.settings_button = new System.Windows.Forms.Button();
			this.stream_button = new System.Windows.Forms.Button();
			this.contacts_button = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.subLinkPanel = new System.Windows.Forms.Panel();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.linkSortUp = new System.Windows.Forms.Button();
			this.link_Panel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.searchBar_Panel = new System.Windows.Forms.Panel();
			this.shareButton = new System.Windows.Forms.Button();
			this.search_Button = new System.Windows.Forms.Button();
			this.searchTextPanel = new System.Windows.Forms.Panel();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.sidePanel.SuspendLayout();
			this.floatMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.subLinkPanel.SuspendLayout();
			this.link_Panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.searchBar_Panel.SuspendLayout();
			this.searchTextPanel.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// colorPanel
			// 
			this.colorPanel.BackColor = System.Drawing.Color.Gold;
			this.colorPanel.Location = new System.Drawing.Point(0, 0);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(1010, 15);
			this.colorPanel.TabIndex = 1;
			// 
			// sidePanel
			// 
			this.sidePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.sidePanel.Controls.Add(this.link_button);
			this.sidePanel.Controls.Add(this.floatMenu);
			this.sidePanel.Controls.Add(this.pictureBox1);
			this.sidePanel.Controls.Add(this.subLinkPanel);
			this.sidePanel.Controls.Add(this.linkSortUp);
			this.sidePanel.Location = new System.Drawing.Point(0, 15);
			this.sidePanel.Name = "sidePanel";
			this.sidePanel.Size = new System.Drawing.Size(112, 650);
			this.sidePanel.TabIndex = 2;
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
			this.stream_button.Click += new System.EventHandler(this.stream_button_Click);
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
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(63, 61);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// subLinkPanel
			// 
			this.subLinkPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.subLinkPanel.Controls.Add(this.checkBox5);
			this.subLinkPanel.Controls.Add(this.checkBox4);
			this.subLinkPanel.Controls.Add(this.checkBox3);
			this.subLinkPanel.Controls.Add(this.checkBox2);
			this.subLinkPanel.Controls.Add(this.checkBox1);
			this.subLinkPanel.Location = new System.Drawing.Point(0, 152);
			this.subLinkPanel.Name = "subLinkPanel";
			this.subLinkPanel.Size = new System.Drawing.Size(112, 101);
			this.subLinkPanel.TabIndex = 4;
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
			// link_Panel
			// 
			this.link_Panel.Controls.Add(this.panel1);
			this.link_Panel.Controls.Add(this.searchBar_Panel);
			this.link_Panel.Location = new System.Drawing.Point(114, 15);
			this.link_Panel.Name = "link_Panel";
			this.link_Panel.Size = new System.Drawing.Size(893, 644);
			this.link_Panel.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(4, 78);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(885, 569);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(13, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(861, 56);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.textBox1.Location = new System.Drawing.Point(13, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Recent Used";
			// 
			// searchBar_Panel
			// 
			this.searchBar_Panel.Controls.Add(this.shareButton);
			this.searchBar_Panel.Controls.Add(this.search_Button);
			this.searchBar_Panel.Controls.Add(this.searchTextPanel);
			this.searchBar_Panel.Location = new System.Drawing.Point(4, 20);
			this.searchBar_Panel.Name = "searchBar_Panel";
			this.searchBar_Panel.Size = new System.Drawing.Size(885, 52);
			this.searchBar_Panel.TabIndex = 0;
			// 
			// shareButton
			// 
			this.shareButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.shareButton.FlatAppearance.BorderSize = 0;
			this.shareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.shareButton.Image = ((System.Drawing.Image)(resources.GetObject("shareButton.Image")));
			this.shareButton.Location = new System.Drawing.Point(834, 7);
			this.shareButton.Name = "shareButton";
			this.shareButton.Size = new System.Drawing.Size(40, 33);
			this.shareButton.TabIndex = 2;
			this.shareButton.UseVisualStyleBackColor = true;
			// 
			// search_Button
			// 
			this.search_Button.BackColor = System.Drawing.Color.Silver;
			this.search_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.search_Button.FlatAppearance.BorderSize = 0;
			this.search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.search_Button.Image = ((System.Drawing.Image)(resources.GetObject("search_Button.Image")));
			this.search_Button.Location = new System.Drawing.Point(605, 7);
			this.search_Button.Name = "search_Button";
			this.search_Button.Size = new System.Drawing.Size(49, 33);
			this.search_Button.TabIndex = 0;
			this.search_Button.UseVisualStyleBackColor = false;
			// 
			// searchTextPanel
			// 
			this.searchTextPanel.BackColor = System.Drawing.Color.Transparent;
			this.searchTextPanel.Controls.Add(this.searchTextBox);
			this.searchTextPanel.Location = new System.Drawing.Point(222, 7);
			this.searchTextPanel.Name = "searchTextPanel";
			this.searchTextPanel.Size = new System.Drawing.Size(385, 33);
			this.searchTextPanel.TabIndex = 0;
			this.searchTextPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchTextPanel_Paint);
			// 
			// searchTextBox
			// 
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.searchTextBox.Location = new System.Drawing.Point(3, 3);
			this.searchTextBox.Multiline = true;
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(374, 27);
			this.searchTextBox.TabIndex = 1;
			this.searchTextBox.Text = "Search...";
			this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(134, 70);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			// 
			// configureToolStripMenuItem
			// 
			this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			this.configureToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.configureToolStripMenuItem.Text = "Configure";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "VmosoBKW";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1008, 661);
			this.Controls.Add(this.link_Panel);
			this.Controls.Add(this.sidePanel);
			this.Controls.Add(this.colorPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vmoso Big Knowledge Widget";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Move += new System.EventHandler(this.MainForm_Move);
			this.sidePanel.ResumeLayout(false);
			this.floatMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.subLinkPanel.ResumeLayout(false);
			this.subLinkPanel.PerformLayout();
			this.link_Panel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.searchBar_Panel.ResumeLayout(false);
			this.searchTextPanel.ResumeLayout(false);
			this.searchTextPanel.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
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
		private System.Windows.Forms.Panel link_Panel;
		private System.Windows.Forms.Panel searchBar_Panel;
		private System.Windows.Forms.Panel searchTextPanel;
		private System.Windows.Forms.Button search_Button;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button shareButton;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon NotifyIcon;
	}
}