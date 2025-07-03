using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DBOAccess
    {
        private static DBOAccess instance;
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CourseRegis;Integrated Security=True";

        private DBOAccess() { }

        public static DBOAccess Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBOAccess();
                return instance;
            }
        }

        public DataTable FetchDB(string table)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            string selectquery = "select * from " + table;
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            adpt.Fill(dt);
            return dt;
        }
        public DataTable SearchForCourses(string sw)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            string selectquery = "select table_course.*, table_department.name from table_course, table_department " +
                                "where table_course.department_id = table_department.id and " +
                                $"(table_course.name like '%{sw}%' or table_department.name like '%{sw}%')";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            adpt.Fill(dt);
            return dt;
        }
        public DataTable SearchForUser(string sw)
        {
                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection(connectionString);
            string selectquery = "select table_user.*, table_department.name from table_user, table_department " +
                                "where table_user.department_id = table_department.id and " +
                                $"(table_user.name like '%{sw}%' or table_department.name like '%{sw}%')";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            adpt.Fill(dt);
            return dt;
        }
        public void InjectDB(string syntax)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(syntax, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public User GetUser(string id)
        {
            DataTable data = FetchDB("table_user");
            DataRow[] row = data.Select("id = " + "'" + id + "'");
            if (row.Length > 0)
            {
                return new User(row[0]);
            }
            return null;
        }

        public int CurrentCourseEntry(string id)
        {
            DataTable data = FetchDB("table_student_course");
            DataRow[] row = data.Select("course_id = " + "'" + id + "'");
            return row.Length;
        }

        public Course GetCourse(string id)
        {
            DataTable data = FetchDB("table_course");
            DataRow[] row = data.Select("id = " + "'" + id + "'");
            if (row.Length > 0)
            {
                return new Course(row[0]);
            }
            return null;
        }
        public void EnrollCourse(string sid, string cid)
        {
            string InjectionQuery = $"insert into table_student_course values ('{sid}', '{cid}')";
            InjectDB(InjectionQuery);
        }
        public bool IsEnrolled(string sid, string cid)
        {
            DataTable scDt = DBOAccess.Instance.FetchDB("table_student_course");
            string query = $"student_id = '{sid}' and course_id = '{cid}'";
            DataRow[] row = scDt.Select(query);
            return row.Length > 0;
        }
        public void WithDrawCourse(string sid, string cid)
        {
            string InjectionQuery = $"delete from table_student_course where student_id = '{sid}' and course_id = '{cid}'";
            InjectDB(InjectionQuery);
        }

        public string DepartmentName(string did)
        {
            DataTable dDt = DBOAccess.Instance.FetchDB("table_department");
            DataRow[] row = dDt.Select("id = " + "'" + did + "'");
            if (row.Length > 0)
            {
                return (row[0]["name"].ToString());
            }
            return "";
        }
        public System.Drawing.Bitmap DepartmentIcon(string did)
        {
            DataTable dt = DBOAccess.Instance.FetchDB("table_department");
            DataRow[] row = dt.Select("id = " + "'" + did + "'");
            if (row.Length > 0)
            {
                byte[] b = (byte[])(row[0]["cover_p"]);
                return b.ImageConverter();
            }
            return null;
        }

        public int CurrentTerm()
        {
            DataTable dt = DBOAccess.Instance.FetchDB("appdata");
            DataRow[] row = dt.Select();
            if (row.Length > 0)
            {
                return (int)row[0]["current_term"];
            }
            return 0;
        }

        public void UpdatePfp(byte[] img, string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand("update table_user set pfp = @pic where id = @id", con);
            com.Parameters.AddWithValue("@id", id);
            com.Parameters.AddWithValue("@Pic", img);
            
            con.Open();
            Console.WriteLine(com.ExecuteNonQuery());
            con.Close();
            //string injectionQuery = $"update table_user set pfp = (convert(varbinary, '{img}')) where id = '{id}'";
            //InjectDB(injectionQuery);
        }
        public DataTable ManaUserTale(string sw)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            string selectquery = "select table_user.id, table_user.name, table_user.user_role, table_department.name as department_name from table_user, table_department " +
                                "where table_user.department_id = table_department.id and table_user.user_role != 'admin' and " +
                                $"table_user.name like '%{sw}%'";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            adpt.Fill(dt);
            return dt;
        }

        public DataTable ManaCourseTable(string sw)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            string selectquery = "select table_course.id, table_course.name,  table_course.term_num, table_course.credit, table_department.name as department_name, table_user.name as lecturer from table_course, table_department, table_user " +
                                "where table_course.department_id = table_department.id and table_course.lecturer_id = table_user.id and " +
                                $"(table_course.name like '%{sw}%' or table_department.name like '%{sw}%' or table_user.name like '%{sw}%')";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            adpt.Fill(dt);
            return dt;
        }

        public string GetDId(string name)
        {
            DataTable dDt = DBOAccess.Instance.FetchDB("table_department");
            DataRow[] row = dDt.Select("name like " + "'%" + name + "%'");
            if (row.Length > 0)
            {
                return (row[0]["id"].ToString());
            }
            return "";
        }

        public void NewUser(string name, string dob, string pob, string mail, string password, string role, string depId)
        {
            string genId = generateId();
            while (CheckIdExist(genId, "table_user"))
            {
                genId = generateId();
            }
            string injectionQuery = "insert into table_user values (" +
                $"'{genId}', '{name}', '{dob}', '{pob}', '{mail}', null, 'Nice to meet you.', '{role}', '{password}', '{depId}')";
            InjectDB(injectionQuery);
            UpdatePfp(Main.Instance.defaultIcon.Image.ImageReverter(), genId);
        }

        public bool CheckIdExist(string id, string table)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            string selectquery = $"select id from {table} where id = '{id}'";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            adpt.Fill(dt);
            return dt.Select().Length > 0;
        }

        public string generateId()
        {
            string re = "";
            Random rnd = new Random();
            re += (char)rnd.Next('a', 'z');
            for (int i = 0; i < 6; i++)
            {
                re += rnd.Next(10);
            }
            return re;
        }

        public void DeleteUser(string id)
        {
            string injectionQuery = $"delete from table_student_course where student_id = '{id}';" +
                            $"delete from table_user where id = '{id}'";
            InjectDB (injectionQuery);
        }
        public void DeleteCourse(string id)
        {
            string injectionQuery = $"delete from table_student_course where course_id = '{id}';" +
                            $"delete from table_course where id = '{id}'";
            InjectDB(injectionQuery);
        }

        public List<string> GetAllLecturerName()
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            string selectquery = "select * from table_user where (user_role = 'lecturer' or user_role = 'faculty')";
            SqlDataAdapter adpt = new SqlDataAdapter(selectquery, con);
            adpt.Fill(dt);
            foreach (var row in dt.Select())
            {
                list.Add(row["name"].ToString().Trim());
            }
            return list;
        }
        public string LecturerName(string did)
        {
            DataTable dDt = DBOAccess.Instance.FetchDB("table_user");
            DataRow[] row = dDt.Select("id = " + "'" + did + "'");
            if (row.Length > 0)
            {
                return (row[0]["name"].ToString().Trim());
            }
            return "";
        }
        public string GetUId(string name)
        {
            DataTable dDt = DBOAccess.Instance.FetchDB("table_user");
            DataRow[] row = dDt.Select("name like " + "'%" + name + "%'");
            if (row.Length > 0)
            {
                return (row[0]["id"].ToString());
            }
            return "";
        }
        public void NewCourse(string name, string des, int credit, string lecId, string depId)
        {
            string genId = generateId();
            while (CheckIdExist(genId, "table_course"))
            {
                genId = generateId();
            }
            string injectionQuery = "insert into table_course values (" +
                $"'{genId}', '{name}', {credit}, '{depId}', 10, '{lecId}', {CurrentTerm()}, '{des}')";
            InjectDB(injectionQuery);
            UpdatePfp(Main.Instance.defaultIcon.Image.ImageReverter(), genId);
        }
    }
}
