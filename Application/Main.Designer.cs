namespace Project
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.termLbl = new System.Windows.Forms.Label();
            this.defaultIcon = new System.Windows.Forms.PictureBox();
            this.userConfiB = new System.Windows.Forms.PictureBox();
            this.pfpPb = new System.Windows.Forms.PictureBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.search_b = new System.Windows.Forms.PictureBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.browseCourseB = new System.Windows.Forms.Button();
            this.homeB = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userConfigBox = new System.Windows.Forms.FlowLayoutPanel();
            this.profileB = new System.Windows.Forms.Button();
            this.settingB = new System.Windows.Forms.Button();
            this.manaCourseB = new System.Windows.Forms.Button();
            this.manaUserB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userConfiB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.userConfigBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.termLbl);
            this.panel1.Controls.Add(this.defaultIcon);
            this.panel1.Controls.Add(this.userConfiB);
            this.panel1.Controls.Add(this.pfpPb);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.search_b);
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this.browseCourseB);
            this.panel1.Controls.Add(this.homeB);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 75);
            this.panel1.TabIndex = 0;
            // 
            // termLbl
            // 
            this.termLbl.BackColor = System.Drawing.Color.Transparent;
            this.termLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.termLbl.Location = new System.Drawing.Point(677, 24);
            this.termLbl.Name = "termLbl";
            this.termLbl.Size = new System.Drawing.Size(102, 31);
            this.termLbl.TabIndex = 8;
            this.termLbl.Text = "Term: 1";
            this.termLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defaultIcon
            // 
            this.defaultIcon.BackColor = System.Drawing.Color.Transparent;
            this.defaultIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.defaultIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("defaultIcon.ErrorImage")));
            this.defaultIcon.Image = ((System.Drawing.Image)(resources.GetObject("defaultIcon.Image")));
            this.defaultIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("defaultIcon.InitialImage")));
            this.defaultIcon.Location = new System.Drawing.Point(698, 0);
            this.defaultIcon.Margin = new System.Windows.Forms.Padding(0);
            this.defaultIcon.Name = "defaultIcon";
            this.defaultIcon.Size = new System.Drawing.Size(75, 75);
            this.defaultIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultIcon.TabIndex = 7;
            this.defaultIcon.TabStop = false;
            this.defaultIcon.Visible = false;
            // 
            // userConfiB
            // 
            this.userConfiB.BackColor = System.Drawing.Color.Transparent;
            this.userConfiB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userConfiB.ErrorImage = ((System.Drawing.Image)(resources.GetObject("userConfiB.ErrorImage")));
            this.userConfiB.Image = ((System.Drawing.Image)(resources.GetObject("userConfiB.Image")));
            this.userConfiB.InitialImage = ((System.Drawing.Image)(resources.GetObject("userConfiB.InitialImage")));
            this.userConfiB.Location = new System.Drawing.Point(1208, 12);
            this.userConfiB.Name = "userConfiB";
            this.userConfiB.Size = new System.Drawing.Size(50, 50);
            this.userConfiB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userConfiB.TabIndex = 6;
            this.userConfiB.TabStop = false;
            this.userConfiB.Click += new System.EventHandler(this.userConfiB_Click);
            // 
            // pfpPb
            // 
            this.pfpPb.BackColor = System.Drawing.Color.Transparent;
            this.pfpPb.Cursor = System.Windows.Forms.Cursors.Default;
            this.pfpPb.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pfpPb.ErrorImage")));
            this.pfpPb.Image = ((System.Drawing.Image)(resources.GetObject("pfpPb.Image")));
            this.pfpPb.InitialImage = ((System.Drawing.Image)(resources.GetObject("pfpPb.InitialImage")));
            this.pfpPb.Location = new System.Drawing.Point(1120, 0);
            this.pfpPb.Margin = new System.Windows.Forms.Padding(0);
            this.pfpPb.Name = "pfpPb";
            this.pfpPb.Size = new System.Drawing.Size(75, 75);
            this.pfpPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfpPb.TabIndex = 5;
            this.pfpPb.TabStop = false;
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NameLbl.Location = new System.Drawing.Point(806, 24);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(300, 31);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Kiana Kaslana";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // search_b
            // 
            this.search_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_b.ErrorImage = ((System.Drawing.Image)(resources.GetObject("search_b.ErrorImage")));
            this.search_b.Image = ((System.Drawing.Image)(resources.GetObject("search_b.Image")));
            this.search_b.InitialImage = ((System.Drawing.Image)(resources.GetObject("search_b.InitialImage")));
            this.search_b.Location = new System.Drawing.Point(605, 24);
            this.search_b.Name = "search_b";
            this.search_b.Size = new System.Drawing.Size(30, 30);
            this.search_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search_b.TabIndex = 3;
            this.search_b.TabStop = false;
            this.search_b.Click += new System.EventHandler(this.search_b_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.Black;
            this.searchTxt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.ForeColor = System.Drawing.Color.White;
            this.searchTxt.Location = new System.Drawing.Point(297, 19);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(345, 39);
            this.searchTxt.TabIndex = 2;
            // 
            // browseCourseB
            // 
            this.browseCourseB.BackColor = System.Drawing.Color.Transparent;
            this.browseCourseB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.browseCourseB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseCourseB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.browseCourseB.FlatAppearance.BorderSize = 0;
            this.browseCourseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseCourseB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseCourseB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.browseCourseB.Location = new System.Drawing.Point(160, 14);
            this.browseCourseB.Name = "browseCourseB";
            this.browseCourseB.Size = new System.Drawing.Size(110, 38);
            this.browseCourseB.TabIndex = 1;
            this.browseCourseB.Text = "Browse";
            this.browseCourseB.UseVisualStyleBackColor = false;
            this.browseCourseB.Click += new System.EventHandler(this.browseCourseB_Click);
            // 
            // homeB
            // 
            this.homeB.BackColor = System.Drawing.Color.Transparent;
            this.homeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.homeB.FlatAppearance.BorderSize = 0;
            this.homeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.homeB.Location = new System.Drawing.Point(57, 14);
            this.homeB.Name = "homeB";
            this.homeB.Size = new System.Drawing.Size(97, 38);
            this.homeB.TabIndex = 0;
            this.homeB.Text = "Home";
            this.homeB.UseVisualStyleBackColor = false;
            // 
            // userConfigBox
            // 
            this.userConfigBox.AutoSize = true;
            this.userConfigBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userConfigBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userConfigBox.Controls.Add(this.profileB);
            this.userConfigBox.Controls.Add(this.settingB);
            this.userConfigBox.Controls.Add(this.manaCourseB);
            this.userConfigBox.Controls.Add(this.manaUserB);
            this.userConfigBox.Controls.Add(this.exitB);
            this.userConfigBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userConfigBox.Location = new System.Drawing.Point(1030, 83);
            this.userConfigBox.Name = "userConfigBox";
            this.userConfigBox.Size = new System.Drawing.Size(242, 222);
            this.userConfigBox.TabIndex = 1;
            this.userConfigBox.Visible = false;
            // 
            // profileB
            // 
            this.profileB.BackColor = System.Drawing.Color.Transparent;
            this.profileB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profileB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profileB.FlatAppearance.BorderSize = 0;
            this.profileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.profileB.Location = new System.Drawing.Point(3, 3);
            this.profileB.Name = "profileB";
            this.profileB.Size = new System.Drawing.Size(234, 38);
            this.profileB.TabIndex = 7;
            this.profileB.Text = "Profile";
            this.profileB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.profileB.UseVisualStyleBackColor = false;
            // 
            // settingB
            // 
            this.settingB.BackColor = System.Drawing.Color.Transparent;
            this.settingB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingB.FlatAppearance.BorderSize = 0;
            this.settingB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.settingB.Location = new System.Drawing.Point(3, 47);
            this.settingB.Name = "settingB";
            this.settingB.Size = new System.Drawing.Size(234, 38);
            this.settingB.TabIndex = 8;
            this.settingB.Text = "Setting";
            this.settingB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.settingB.UseVisualStyleBackColor = false;
            // 
            // manaCourseB
            // 
            this.manaCourseB.BackColor = System.Drawing.Color.Transparent;
            this.manaCourseB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manaCourseB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manaCourseB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.manaCourseB.FlatAppearance.BorderSize = 0;
            this.manaCourseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manaCourseB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaCourseB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.manaCourseB.Location = new System.Drawing.Point(3, 91);
            this.manaCourseB.Name = "manaCourseB";
            this.manaCourseB.Size = new System.Drawing.Size(234, 38);
            this.manaCourseB.TabIndex = 9;
            this.manaCourseB.Text = "Manage Courses";
            this.manaCourseB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.manaCourseB.UseVisualStyleBackColor = false;
            // 
            // manaUserB
            // 
            this.manaUserB.BackColor = System.Drawing.Color.Transparent;
            this.manaUserB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manaUserB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manaUserB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.manaUserB.FlatAppearance.BorderSize = 0;
            this.manaUserB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manaUserB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaUserB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.manaUserB.Location = new System.Drawing.Point(3, 135);
            this.manaUserB.Name = "manaUserB";
            this.manaUserB.Size = new System.Drawing.Size(234, 38);
            this.manaUserB.TabIndex = 10;
            this.manaUserB.Text = "Manage Users";
            this.manaUserB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.manaUserB.UseVisualStyleBackColor = false;
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Transparent;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitB.FlatAppearance.BorderSize = 0;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.exitB.Location = new System.Drawing.Point(3, 179);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(234, 38);
            this.exitB.TabIndex = 11;
            this.exitB.Text = "Exit";
            this.exitB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitB.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 800);
            this.Controls.Add(this.userConfigBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userConfiB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.userConfigBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeB;
        private System.Windows.Forms.Button browseCourseB;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.PictureBox search_b;
        private System.Windows.Forms.PictureBox pfpPb;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.PictureBox userConfiB;
        private System.Windows.Forms.FlowLayoutPanel userConfigBox;
        private System.Windows.Forms.Button profileB;
        private System.Windows.Forms.Button settingB;
        private System.Windows.Forms.Button manaCourseB;
        private System.Windows.Forms.Button manaUserB;
        private System.Windows.Forms.Button exitB;
        public System.Windows.Forms.PictureBox defaultIcon;
        private System.Windows.Forms.Label termLbl;
    }
}