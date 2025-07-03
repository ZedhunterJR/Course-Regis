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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            idTxt.TextChanged += (ev, arg) =>
            {
                errorLbl.Visible = false;
            };
            pwTxt.TextChanged += (ev, arg) =>
            {
                errorLbl.Visible = false;
            };
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            User temp = DBOAccess.Instance.GetUser(idTxt.Text);
            if (temp == null) 
            {
                errorLbl.Text = "User ID does not exist.";
                errorLbl.Visible = true;
                return;
            }
            if (temp.pw == pwTxt.Text)
            {
                this.Hide();
                var mainForm = new Main(temp);
                mainForm.Show();
                mainForm.FormClosed += (arg, ea) => this.Close();
            } else
            {
                errorLbl.Text = "Wrong password!";
                errorLbl.Visible = true;
            }
        }
    }
}
