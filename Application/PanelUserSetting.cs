using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PanelUserSetting : UserControl
    {
        public PanelUserSetting()
        {
            InitializeComponent();
            nameLbl.Text = Main.Instance.mainUser.name;
            pfpPb.Image = Main.Instance.mainUser.pfp;
            desTxt.Text = Main.Instance.mainUser.des;
            //change img
            editPfpB.Click += (ev, arg) =>
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image Files|*.png; *.jpg; *.jpeg";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        // Create a new Bitmap object from the picture file on disk,
                        // and assign that to the PictureBox.Image property
                        Bitmap bm = new Bitmap(dlg.FileName);
                        pfpPb.Image = bm;

                        discardPfpB.Visible = true;
                        savePfpB.Visible = true;
                    }
                }
            };
            desEditB.Click += (ev, arg) =>
            {
                desTxt.ReadOnly = false;
                desDisB.Visible = true;
                desSaveB.Visible = true;
            };
            editPwB.Click += (ev, arg) =>
            {
                oldPwTxt.Text = "";
                newPwTxt.Text = "";
                repeatTxt.Text = "";
                editPwPanel.Visible = true;
            };
        }

        private void savePfpB_Click(object sender, EventArgs e)
        {
            byte[] imgBytes = pfpPb.Image.ImageReverter();
            DBOAccess.Instance.UpdatePfp(imgBytes, Main.Instance.mainUser.id);
            Main.Instance.UpdateUser();
            MessageBox.Show("Update profile icon success.");
            discardPfpB.Visible = false;
            savePfpB.Visible = false;
        }

        private void discardPfpB_Click(object sender, EventArgs e)
        {
            pfpPb.Image = Main.Instance.mainUser.pfp;
            discardPfpB.Visible = false;
            savePfpB.Visible = false;
        }

        private void desDisB_Click(object sender, EventArgs e)
        {
            desTxt.Text = Main.Instance.mainUser.des;
            desDisB.Visible = false;
            desSaveB.Visible = false;
        }

        private void desSaveB_Click(object sender, EventArgs e)
        {
            string injectionQuery = $"update table_user set des = '{desTxt.Text}' where id = '{Main.Instance.mainUser.id}'";
            DBOAccess.Instance.InjectDB(injectionQuery);
            Main.Instance.UpdateUser();
            MessageBox.Show("Update self description success.");
            desDisB.Visible = false;
            desSaveB.Visible = false;
        }

        private void discardPwB_Click(object sender, EventArgs e)
        {
            editPwPanel.Visible = false;
        }

        private void savePwB_Click(object sender, EventArgs e)
        {
            if (oldPwTxt.Text == Main.Instance.mainUser.pw.Trim())
            {
                if (newPwTxt.Text != oldPwTxt.Text)
                {
                    if (oldPwTxt.Text == repeatTxt.Text)
                    {
                        string injectionQuery = $"update table_user set password = '{desTxt.Text}' where id = '{Main.Instance.mainUser.id}'";
                        DBOAccess.Instance.InjectDB(injectionQuery);
                        Main.Instance.UpdateUser();
                        MessageBox.Show("Update password success.");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password repeat.");
                    }
                }
                else
                {
                    MessageBox.Show("New password cannot be the same as old one.");
                }
            }
            else
            {
                MessageBox.Show("Wrong old password.");
            }
            editPwPanel.Visible = false;
        }
    }
}
