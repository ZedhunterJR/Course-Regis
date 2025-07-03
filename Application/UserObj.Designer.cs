namespace Project
{
    partial class UserObj
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
            this.uNameLbl = new System.Windows.Forms.Label();
            this.pfp = new System.Windows.Forms.PictureBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.deIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // uNameLbl
            // 
            this.uNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.uNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.uNameLbl.Location = new System.Drawing.Point(0, 0);
            this.uNameLbl.Name = "uNameLbl";
            this.uNameLbl.Size = new System.Drawing.Size(246, 25);
            this.uNameLbl.TabIndex = 3;
            this.uNameLbl.Text = "label2";
            this.uNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pfp
            // 
            this.pfp.Location = new System.Drawing.Point(3, 33);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(75, 75);
            this.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfp.TabIndex = 4;
            this.pfp.TabStop = false;
            // 
            // idLbl
            // 
            this.idLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idLbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.White;
            this.idLbl.Location = new System.Drawing.Point(82, 33);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(148, 31);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "label2";
            // 
            // roleLbl
            // 
            this.roleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roleLbl.AutoSize = true;
            this.roleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roleLbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.ForeColor = System.Drawing.Color.White;
            this.roleLbl.Location = new System.Drawing.Point(3, 121);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(51, 19);
            this.roleLbl.TabIndex = 6;
            this.roleLbl.Text = "label2";
            // 
            // deIcon
            // 
            this.deIcon.Location = new System.Drawing.Point(170, 58);
            this.deIcon.Name = "deIcon";
            this.deIcon.Size = new System.Drawing.Size(60, 60);
            this.deIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deIcon.TabIndex = 7;
            this.deIcon.TabStop = false;
            // 
            // UserObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.deIcon);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.pfp);
            this.Controls.Add(this.uNameLbl);
            this.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.Name = "UserObj";
            this.Size = new System.Drawing.Size(246, 156);
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label uNameLbl;
        private System.Windows.Forms.PictureBox pfp;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.PictureBox deIcon;
    }
}
