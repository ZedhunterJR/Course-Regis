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
    public partial class Main : Form
    {
        public static Main Instance { get; private set; }
        public User mainUser = null;
        public UserControl centerPanel;
        //temp
        public string generalCourseId = "000001d";

        public string browseWord;

        public void UpdateUser()
        {
            mainUser = DBOAccess.Instance.GetUser(mainUser.id);
            NameLbl.Text = mainUser.name;
            termLbl.Text = "Term: " + DBOAccess.Instance.CurrentTerm();
            pfpPb.Image = mainUser.pfp;
            if (mainUser.role != "admin")
            {
                manaUserB.Visible = false;
            }
            if (mainUser.role != "faculty" && mainUser.role != "admin")
            {
                manaCourseB.Visible = false;
            }
        }
        public Main(User acc)
        {
            InitializeComponent();
            mainUser = acc;
            termLbl.Text = "Term: " + DBOAccess.Instance.CurrentTerm();
            NameLbl.Text = mainUser.name;
            pfpPb.Image = mainUser.pfp;
            if (mainUser.role != "admin")
            {
                manaUserB.Visible = false;
            }
            if (mainUser.role != "faculty" && mainUser.role != "admin")
            {
                manaCourseB.Visible = false;
            }
            Instance = this;
            this.profileB.Click += (ev, arg) => { 
                showUserInfo(mainUser, false);
                userConfigBox.Visible = !userConfigBox.Visible;
            };
            this.settingB.Click += (ev, arg) =>
            {
                userConfigBox.Visible = !userConfigBox.Visible;
                if (centerPanel != null)
                    centerPanel.Dispose();
                centerPanel = new PanelUserSetting();
                this.Controls.Add(centerPanel);
            };
            this.manaCourseB.Click += (ev, arg) =>
            {
                userConfigBox.Visible = !userConfigBox.Visible;
                ManaCourse manaCourse = new ManaCourse();
                manaCourse.Show();
            };
            this.manaUserB.Click += (ev, arg) =>
            {
                userConfigBox.Visible = !userConfigBox.Visible;
                ManaUser manaUser = new ManaUser();
                manaUser.Show();
            };
            this.exitB.Click += (ev, arg) =>
            {
                userConfigBox.Visible = !userConfigBox.Visible;
            };
            homeB.Click += (ev, arg) =>
            {
                homeB_Click();
            };
            homeB_Click();
        }

        private void search_b_Click(object sender, EventArgs e)
        {
            showLastBrowsePanel(searchTxt.Text);
        }

        private void homeB_Click()
        {
            if (centerPanel != null)
                centerPanel.Dispose();
            centerPanel = new HomePage();
            this.Controls.Add(centerPanel);
        }

        private void browseCourseB_Click(object sender, EventArgs e)
        {
            showLastBrowsePanel("browse");
        }
        public void showLastBrowsePanel(string bw)
        {
            if (centerPanel != null)
                centerPanel.Dispose();
            centerPanel = new BrowsePanel(bw);
            browseWord = bw;
            this.Controls.Add(centerPanel);
        }

        private void userConfiB_Click(object sender, EventArgs e)
        {
            userConfigBox.Visible = !userConfigBox.Visible;
        }

        public void showUserInfo(User user, bool back)
        {
            if (centerPanel != null)
                centerPanel.Dispose();
            centerPanel = new PanelUserProfile(user, back);
            this.Controls.Add(centerPanel);
        }

        public void showCourseInfo(Course course)
        {
            if (centerPanel != null)
                centerPanel.Dispose();
            centerPanel = new PanelCourseInfo(course);
            this.Controls.Add(centerPanel);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}

