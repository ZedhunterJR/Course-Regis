using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Course
    {
        public string id, name, department_id, lecturer_id, des;
        public int credit, entry_limit, term_num, current_entry;
        public Course(DataRow data)
        {
            id = data["id"].ToString();
            name = data["name"].ToString().Trim();
            department_id = data["department_id"].ToString();
            lecturer_id = data["lecturer_id"].ToString();
            des = data["des"].ToString().Trim();
            credit = (int)data["credit"];
            entry_limit = (int)data["entry_limit"];
            term_num = (int)data["term_num"];
            current_entry = DBOAccess.Instance.CurrentCourseEntry(id);
        }
    }
}
