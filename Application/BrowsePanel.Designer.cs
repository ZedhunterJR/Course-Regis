namespace Project
{
    partial class BrowsePanel
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
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // filterCB
            // 
            this.filterCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.filterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCB.ForeColor = System.Drawing.Color.White;
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Location = new System.Drawing.Point(774, 65);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(186, 34);
            this.filterCB.TabIndex = 1;
            this.filterCB.SelectedIndexChanged += new System.EventHandler(this.filterCB_SelectedIndexChanged);
            // 
            // layout
            // 
            this.layout.AutoScroll = true;
            this.layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layout.Location = new System.Drawing.Point(31, 93);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.layout.Size = new System.Drawing.Size(929, 575);
            this.layout.TabIndex = 2;
            // 
            // BrowsePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.layout);
            this.Controls.Add(this.filterCB);
            this.Location = new System.Drawing.Point(120, 148);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BrowsePanel";
            this.Size = new System.Drawing.Size(998, 658);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.TableLayoutPanel layout;
    }
}
