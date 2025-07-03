using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        public string id, name, dob, pob, des, mail, role, pw, department_id;
        public string rawDob;
        public Image pfp;
        public User(DataRow userData)
        {
            id = userData["id"].ToString(); 
            name = userData["name"].ToString().Trim();
            if (userData["dob"] != DBNull.Value)
            {
                DateTime dt = (DateTime)userData["dob"];
                if (dt.Year != 1000)
                    dob = dt.ToString("MMMM dd, yyyy", new CultureInfo("en-US"));
                else dob = dt.ToString("MMMM dd, yyyy", new CultureInfo("en-US"));

                rawDob = dt.ToString("yyyy-MM-dd");
            } else
            {
                dob = "Unknown";
                rawDob = "";
            }
            pob = userData["pob"].ToString().Trim();
            des = userData["des"].ToString().Trim();
            mail = userData["email"].ToString().Trim();
            role = userData["user_role"].ToString();
            role = role.Trim();
            pw = userData["password"].ToString();
            pw = pw.Trim();
            if (userData["pfp"] != DBNull.Value)
            {
                byte[] arg = (byte[])userData["pfp"];
                pfp = arg.ImageConverter();
            }
            department_id = userData["department_id"].ToString();
        }
    }
}
