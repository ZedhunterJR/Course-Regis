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
    public partial class PanelUserProfile : UserControl
    {
        public PanelUserProfile(User u, bool back)
        {
            InitializeComponent();

            pfpPb.Image = u.pfp;
            nameLbl.Text = u.name;
            idLbl.Text = "User ID: " + u.id;
            dobLbl.Text = "Date of birth: " + u.dob;
            pobLbl.Text = "Place of birth: " + u.pob;
            mailLbl.Text = "Contact: " + u.mail;
            desLbl.Text = "Self description:\n" + u.des;

            d_icon.Image = DBOAccess.Instance.DepartmentIcon(u.department_id);
            deLbl.Text = DBOAccess.Instance.DepartmentName(u.department_id);
            roleLbl.Text = "User role: " + u.role.UserRole();
            if (back)
                backB.Click += (ev, arg) => Main.Instance.showLastBrowsePanel(Main.Instance.browseWord);
            else backB.Visible = false;
        }
    }

}
