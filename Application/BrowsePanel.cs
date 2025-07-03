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
    public partial class BrowsePanel : UserControl
    {
        public DataTable allCourses;
        public DataTable allUsers;
        public BrowsePanel(string type)
        {
            InitializeComponent();
            this.SetDoubleBuffered();
            layout.SetDoubleBuffered();
            //allUsers = DBOAccess.Instance.FetchDB("table_user");
            /*layout.AutoScroll = false;
            layout.HorizontalScroll.Enabled = false;
            layout.AutoScroll = true;
            */ 
            if (type == "browse")
            {
                allCourses = DBOAccess.Instance.FetchDB("table_course");
                allUsers = new DataTable();
                if (Main.Instance.mainUser.role == "student")
                    filterCB.DataSource = new String[] { "This term", "All Courses", "Eligible", "Associated" };
                else
                    filterCB.DataSource = new String[] { "This term", "All Courses", "Associated" };
            } else
            {
                allCourses = DBOAccess.Instance.SearchForCourses(type);
                allUsers = DBOAccess.Instance.SearchForUser(type);
                filterCB.DataSource = new String[] { "No filter", "All Courses", "Student", "Faculty" };
            }
            //filterCB.SelectedIndex = -1;
            filterCB_SelectedIndexChanged(null, null);
        }

        private void filterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable filteredCourse = allCourses.Copy();
            DataTable refAllCourse = allCourses.Copy();
            filteredCourse.Rows.Clear();

            DataTable filteredUser = allUsers.Copy();
            DataTable refAllUser = allUsers.Copy();
            filteredUser.Rows.Clear();

            switch (filterCB.SelectedItem)
            {
                case "This term":
                    {
                        for (int i = 0; i < refAllCourse.Select().Length; i++)
                        {
                            DataRow dr = refAllCourse.Select()[i];
                            if ((int)dr["term_num"] == DBOAccess.Instance.CurrentTerm())
                                filteredCourse.ImportRow(dr);
                        }
                    } break;
                case "Eligible":
                    {
                        int currentCredit = 0;
                        DataTable scDt = DBOAccess.Instance.FetchDB("table_student_course");
                        foreach (var item in scDt.Select())
                        {
                            if (item["student_id"].ToString() == Main.Instance.mainUser.id)
                            {
                                Course temp = new Course(refAllCourse.UncheckedFindId(item["course_id"].ToString()));
                                currentCredit += temp.credit;
                            }
                        }
                        foreach (var item in refAllCourse.Select())
                        {
                            if ((int)item["credit"] <= 9 - currentCredit && (int)item["term_num"] == DBOAccess.Instance.CurrentTerm()
                                && (item["department_id"].ToString() == Main.Instance.mainUser.department_id || item["department_id"].ToString() == Main.Instance.generalCourseId)
                                && !DBOAccess.Instance.IsEnrolled(Main.Instance.mainUser.id, item["id"].ToString()))
                                filteredCourse.ImportRow(item);
                        }
                        
                    } break;
                case "All Courses":
                    {
                        filteredCourse = allCourses.Copy();
                    } break;
                case "Associated":
                    {
                        if (Main.Instance.mainUser.role == "student")
                        {
                            DataTable scDt = DBOAccess.Instance.FetchDB("table_student_course");
                            List<string> allAssoCId = new List<string>();
                            foreach (var item in scDt.Select())
                            {
                                if (item["student_id"].ToString() == Main.Instance.mainUser.id)
                                    allAssoCId.Add(item["course_id"].ToString());
                            }
                            for (int i = 0; i < refAllCourse.Select().Length; i++)
                            {
                                DataRow dr = refAllCourse.Select()[i];
                                if (allAssoCId.Contains(dr["id"]))
                                    filteredCourse.ImportRow(dr);
                            }
                        }
                        else
                        {
                            foreach (var item in refAllCourse.Select())
                            {
                                if (item["lecturer_id"].ToString() == Main.Instance.mainUser.id)
                                    filteredCourse.ImportRow(item);
                            }
                        }
                    }
                    break; ;
                case "No filter":
                    {
                        filteredCourse = allCourses.Copy();
                        filteredUser = allUsers.Copy();
                    }
                    break;
                case "Student":
                    {
                        foreach (var u in refAllUser.Select())
                        {
                            if (u["user_role"].ToString().Trim() == "student")
                                filteredUser.ImportRow(u);
                        }
                    }
                    break;
                case "Faculty":
                    {
                        foreach (var u in refAllUser.Select())
                        {
                            string userRole = u["user_role"].ToString().Trim();
                            if (userRole == "lecturer" || userRole == "faculty")
                                filteredUser.ImportRow(u);
                        }
                    }
                    break;
            }
            //Console.WriteLine(filteredCourse.Select().Length);
            layout.Controls.Clear();
            for (int i = 0; i < filteredCourse.Select().Length; i++)
            {
                var courseItem = new Course(filteredCourse.Select()[i]);
                var courseObj = new CourseObj(courseItem);
                courseObj.dNameLbl.Click += (ev, arg) =>
                {
                    Main.Instance.showCourseInfo(courseItem);
                };
                layout.Controls.Add(courseObj, -1, -1);
            }
            for (int i = 0; i < filteredUser.Select().Length; i++)
            {
                var userItem = new User(filteredUser.Select()[i]);
                var userObj = new UserObj(userItem);
                userObj.uNameLbl.Click += (ev, arg) =>
                {
                    Main.Instance.showUserInfo(userObj.user, true);
                };
                layout.Controls.Add(userObj, -1, -1);
            }

        }

    }
}
