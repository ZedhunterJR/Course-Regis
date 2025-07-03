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
    public partial class ManaUser : Form
    {
        public int mode = 0;
        public User currentUser;
        public ManaUser()
        {
            InitializeComponent();
            dataGrid.DataSource = DBOAccess.Instance.ManaUserTale("");
            newUserB.Click += (ev, arg) =>
            {
                statusLbl.Text = "New user";
                nameTxt.Text = "";
                dobTxt.Text = "";
                pobTxt.Text = "";
                mailTxt.Text = "";
                pwTxt.Text = "";
                roleCb.Text = "student";
                depCb.Text = "General";
                mode = 1;
            };

            searchTxt.TextChanged += (ev, arg) =>
            {
                dataGrid.DataSource = DBOAccess.Instance.ManaUserTale(searchTxt.Text);
            };

            dataGrid.SelectionChanged += (ev, arg) =>
            {
                mode = 2;
                if (dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGrid.SelectedRows[0];
                    statusLbl.Text = "Current User ID: " + dr.Cells[0].Value.ToString();
                    currentUser = DBOAccess.Instance.GetUser(dr.Cells[0].Value.ToString());
                    if (currentUser != null)
                    {
                        nameTxt.Text = currentUser.name;
                        dobTxt.Text = currentUser.rawDob;
                        pobTxt.Text = currentUser.pob;
                        mailTxt.Text = currentUser.mail;
                        pwTxt.Text = currentUser.pw;
                        roleCb.Text = currentUser.role;
                        depCb.Text = DBOAccess.Instance.DepartmentName(currentUser.department_id).Trim();
                    }
                }
            };

            saveB.Click += (ev, arg) =>
            {
                DateTime dt = dobTxt.Text.ToString().CheckDateFormat();
                string format = "yyyy-MM-dd HH:mm:ss";
                if (dt != null)
                {
                    if (mode == 2)
                    {
                        string injectionQuery = "update table_user set " +
                            $"name = '{nameTxt.Text}', dob = '{dt.ToString(format)}', pob = '{pobTxt.Text}', email = '{mailTxt.Text}', " +
                            $"password = '{pwTxt.Text}', user_role = '{roleCb.Text}', department_id = '{DBOAccess.Instance.GetDId(depCb.Text)}'" +
                            $"where id = '{currentUser.id}'";
                        DBOAccess.Instance.InjectDB(injectionQuery);
                        MessageBox.Show("Update success!");
                    }
                    if (mode == 1)
                    {
                        DBOAccess.Instance.NewUser(nameTxt.Text, dt.ToString(format), pobTxt.Text, mailTxt.Text, pwTxt.Text, roleCb.Text, DBOAccess.Instance.GetDId(depCb.Text));
                        MessageBox.Show("Created success!");
                    }
                }
                else
                {
                    MessageBox.Show("Date format error. Correct format: yyyy-mm-dd");
                }
                ModeZero();
            };
            delUserB.Click += (ev, arg) =>
            {
                if (mode == 2)
                {
                    DBOAccess.Instance.DeleteUser(currentUser.id);
                    ModeZero();
                }
            };
            ModeZero();
        }
        private void ModeZero()
        {
            statusLbl.Text = "Standby...";
            nameTxt.Text = "";
            dobTxt.Text = "";
            pobTxt.Text = "";
            mailTxt.Text = "";
            pwTxt.Text = "";
            roleCb.Text = "student";
            depCb.Text = "General";
            mode = 0;
        }

    }
}
