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
    public partial class UserObj : UserControl
    {
        public User user;
        public UserObj(User user)
        {
            InitializeComponent();
            this.user = user;
            uNameLbl.Text = user.name;
            idLbl.Text = "ID: " + user.id;
            pfp.Image = user.pfp;
            roleLbl.Text = user.role.UserRole();
            deIcon.Image = DBOAccess.Instance.DepartmentIcon(user.department_id);
            this.BackColor = user.role.UColor();
        }
    }
}
