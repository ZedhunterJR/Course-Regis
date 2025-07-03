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
    public partial class ManaCourse : Form
    {
        public int mode = 0;
        public Course currentCourse;
        public ManaCourse()
        {
            InitializeComponent();
            lecturerCb.DataSource = DBOAccess.Instance.GetAllLecturerName();
            dataGrid.DataSource = DBOAccess.Instance.ManaCourseTable("");
            termTxt.Text = "" + DBOAccess.Instance.CurrentTerm();
            updateTermB.Click += (ev, arg) =>
            {
                if (int.TryParse(termTxt.Text, out int term))
                {
                    string injectionQuery = $"update appdata set current_term = {term} where 0 = 0";
                    DBOAccess.Instance.InjectDB(injectionQuery);
                    MessageBox.Show("Update success.");
                    Main.Instance.UpdateUser();
                } else
                {
                    MessageBox.Show("Invalid term number, must be an integer.");
                }
            };
            searchTxt.TextChanged += (ev, arg) =>
            {
                dataGrid.DataSource = DBOAccess.Instance.ManaCourseTable(searchTxt.Text);
            };
            dataGrid.SelectionChanged += (ev, arg) =>
            {
                mode = 2;
                if (dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dataGrid.SelectedRows[0];
                    statusLbl.Text = "Current Course ID: " + dr.Cells[0].Value.ToString();
                    currentCourse = DBOAccess.Instance.GetCourse(dr.Cells[0].Value.ToString());
                    if (currentCourse != null)
                    {
                        nameTxt.Text = currentCourse.name;
                        desTxt.Text = currentCourse.des;
                        creditTxt.Text = "" + currentCourse.credit;
                        lecturerCb.Text = DBOAccess.Instance.LecturerName(currentCourse.lecturer_id);

                        depCb.Text = DBOAccess.Instance.DepartmentName(currentCourse.department_id).Trim();
                    }
                }
            };
            saveB.Click += (ev, arg) =>
            {
                int.TryParse(creditTxt.Text, out int credit);
                if (credit > 0)
                {
                    if (mode == 2)
                    {
                        string injectionQuery = "update table_course set " +
                            $"name = '{nameTxt.Text}', des = '{desTxt.Text}', credit = {credit}, " +
                            $"lecturer_id = '{DBOAccess.Instance.GetUId(lecturerCb.Text)}', department_id = '{DBOAccess.Instance.GetDId(depCb.Text)}'" +
                            $"where id = '{currentCourse.id}'";
                        DBOAccess.Instance.InjectDB(injectionQuery);
                        MessageBox.Show("Update success.");
                    }
                    if (mode == 1)
                    {
                        DBOAccess.Instance.NewCourse(nameTxt.Text, desTxt.Text, credit, DBOAccess.Instance.GetUId(lecturerCb.Text), DBOAccess.Instance.GetDId(depCb.Text));
                        MessageBox.Show("Add success.");
                    }
                }
                ModeZero();
            };
            newUserB.Click += (ev, arg) =>
            {
                ModeZero();
                mode = 1;
                statusLbl.Text = "New Course:";
            };
            delUserB.Click += (ev, arg) =>
            {
                if (mode == 2)
                {
                    DBOAccess.Instance.DeleteCourse(currentCourse.id);
                    MessageBox.Show("Delete success.");
                    ModeZero();
                }
            };
        }

        private void ModeZero()
        {
            statusLbl.Text = "Standby...";
            nameTxt.Text = "";
            desTxt.Text = "";
            creditTxt.Text = "";
            depCb.Text = "General";
            mode = 0;
        }
    }
}
