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
    public partial class CourseObj : UserControl
    {
        public Course course;
        public CourseObj(Course course)
        {
            InitializeComponent();
            this.course = course;
            this.BackColor = course.department_id.DColor(course.term_num.CompareCourseTerm());
            this.nameLbl.Text = course.name;
            this.dNameLbl.Text = DBOAccess.Instance.DepartmentName(course.department_id);
            this.dpfp.Image = DBOAccess.Instance.DepartmentIcon(course.department_id);
            this.termLbl.Text = "Term: " + course.term_num;
            this.idLbl.Text = "ID: " + course.id;
            this.creditLbl.Text = "Credit: " + course.credit;
        }
    }
}
