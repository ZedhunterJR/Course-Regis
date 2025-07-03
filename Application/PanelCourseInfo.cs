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
    public partial class PanelCourseInfo : UserControl
    {
        Course courseObj;
        int sCredit;
        public PanelCourseInfo(Course course)
        {
            InitializeComponent();
            courseObj = course;
            nameLbl.Text = courseObj.name;
            idLbl.Text = "ID: " + courseObj.id;
            desLbl.Text = "Description: " + courseObj.des;
            dNameLbl.Text = DBOAccess.Instance.DepartmentName(courseObj.department_id);
            iconPb.Image = DBOAccess.Instance.DepartmentIcon(courseObj.department_id);
            dNameLbl.BackColor = courseObj.department_id.DColor(0);

            if (checkEli())
            {
                eliLbl.Text = "You are eligible to enroll this course.";
                enrollCourseB.Click += (ev, arg) =>
                {
                    DBOAccess.Instance.EnrollCourse(Main.Instance.mainUser.id, courseObj.id);
                    MessageBox.Show("Registration success!");
                    Main.Instance.showLastBrowsePanel(Main.Instance.browseWord);
                };
            }
            else if (courseObj.term_num < DBOAccess.Instance.CurrentTerm())
            {
                eliLbl.Text = "This course is archived.";
                enrollCourseB.Visible = false;
            }
            else if (courseObj.term_num > DBOAccess.Instance.CurrentTerm())
            {
                eliLbl.Text = "This course is pending, not accepting registration.";
                enrollCourseB.Visible = false;
            }
            else if (DBOAccess.Instance.IsEnrolled(Main.Instance.mainUser.id, courseObj.id))
            {
                eliLbl.Text = "You are already enrolled!";
                enrollCourseB.Text = "Withdraw";
                enrollCourseB.Click += (ev, arg) =>
                {
                    DBOAccess.Instance.WithDrawCourse(Main.Instance.mainUser.id, courseObj.id);
                    MessageBox.Show("Withdraw success!");
                    Main.Instance.showLastBrowsePanel(Main.Instance.browseWord);
                };
            }
            else
            {
                eliLbl.Text = "You are not eligible to enroll this course.";
                enrollCourseB.Visible = false;
            }

            if (Main.Instance.mainUser.role != "student")
            {
                enrollCourseB.Visible = false;
                if (courseObj.term_num < DBOAccess.Instance.CurrentTerm())
                    eliLbl.Text = "This course is archived.";
                else
                    eliLbl.Text = "";
            }
            backB.Click += (ev, arg) => Main.Instance.showLastBrowsePanel(Main.Instance.browseWord);

            string creditText = "Term: " + course.term_num + "|| Course credit: " + course.credit;
            if (Main.Instance.mainUser.role == "student")
                creditText += $"   Current: {sCredit}(+{course.credit})/9";
            creditLbl.Text = creditText;

            if (courseObj.lecturer_id != "")
            {
                User lec = DBOAccess.Instance.GetUser(courseObj.lecturer_id);
                var userObj = new UserObj(lec);
                userObj.uNameLbl.Click += (ev, arg) =>
                {
                    Main.Instance.showUserInfo(lec, true);
                };
                userObj.Location = new Point(720, 232);
                this.Controls.Add(userObj);
            } else
            {
                lecLbl.Text = "Lecturer unassigned";
            }
        }

        private void PanelCourseInfo_Load(object sender, EventArgs e)
        {

        }
        private bool checkEli()
        {
            int currentCredit = 0;
            DataTable scDt = DBOAccess.Instance.FetchDB("table_student_course");
            DataTable refAllCourse = DBOAccess.Instance.FetchDB("table_course");
            foreach (var item in scDt.Select())
            {
                if (item["student_id"].ToString() == Main.Instance.mainUser.id)
                {
                    Course temp = new Course(refAllCourse.UncheckedFindId(item["course_id"].ToString()));
                    currentCredit += temp.credit;
                }
            }
            sCredit = currentCredit;
            //Console.WriteLine(courseObj.id + ", " + Main.Instance.mainUser.department_id);
            return courseObj.credit <= 9 - currentCredit && courseObj.term_num == DBOAccess.Instance.CurrentTerm()
                && (courseObj.department_id == Main.Instance.mainUser.department_id || courseObj.department_id == Main.Instance.generalCourseId)
                && !DBOAccess.Instance.IsEnrolled(Main.Instance.mainUser.id, courseObj.id);
        }

    }
}
