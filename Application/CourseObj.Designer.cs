namespace Project
{
    partial class CourseObj
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.dNameLbl = new System.Windows.Forms.Label();
            this.dpfp = new System.Windows.Forms.PictureBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.termLbl = new System.Windows.Forms.Label();
            this.creditLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dpfp)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameLbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(84, 64);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(148, 44);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "label2";
            // 
            // dNameLbl
            // 
            this.dNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dNameLbl.Location = new System.Drawing.Point(0, 0);
            this.dNameLbl.Name = "dNameLbl";
            this.dNameLbl.Size = new System.Drawing.Size(246, 25);
            this.dNameLbl.TabIndex = 2;
            this.dNameLbl.Text = "label2";
            this.dNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpfp
            // 
            this.dpfp.Location = new System.Drawing.Point(3, 33);
            this.dpfp.Name = "dpfp";
            this.dpfp.Size = new System.Drawing.Size(75, 75);
            this.dpfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dpfp.TabIndex = 3;
            this.dpfp.TabStop = false;
            // 
            // idLbl
            // 
            this.idLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idLbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.White;
            this.idLbl.Location = new System.Drawing.Point(84, 33);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(148, 31);
            this.idLbl.TabIndex = 4;
            this.idLbl.Text = "label2";
            // 
            // termLbl
            // 
            this.termLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.termLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.termLbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLbl.ForeColor = System.Drawing.Color.White;
            this.termLbl.Location = new System.Drawing.Point(3, 111);
            this.termLbl.Name = "termLbl";
            this.termLbl.Size = new System.Drawing.Size(75, 31);
            this.termLbl.TabIndex = 5;
            this.termLbl.Text = "label2";
            // 
            // creditLbl
            // 
            this.creditLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.creditLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.creditLbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLbl.ForeColor = System.Drawing.Color.White;
            this.creditLbl.Location = new System.Drawing.Point(84, 111);
            this.creditLbl.Name = "creditLbl";
            this.creditLbl.Size = new System.Drawing.Size(75, 31);
            this.creditLbl.TabIndex = 6;
            this.creditLbl.Text = "label2";
            // 
            // CourseObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.creditLbl);
            this.Controls.Add(this.termLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.dpfp);
            this.Controls.Add(this.dNameLbl);
            this.Controls.Add(this.nameLbl);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.Name = "CourseObj";
            this.Size = new System.Drawing.Size(246, 156);
            ((System.ComponentModel.ISupportInitialize)(this.dpfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.PictureBox dpfp;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label termLbl;
        public System.Windows.Forms.Label dNameLbl;
        private System.Windows.Forms.Label creditLbl;
    }
}
