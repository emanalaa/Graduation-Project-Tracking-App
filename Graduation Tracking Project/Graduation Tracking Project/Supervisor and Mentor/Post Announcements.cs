using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Tracking_Project.Supervisor_Mentor_Home
{
    public partial class Post_Announcements : Form
    {
        Graduation_Project_TrackerEntities db = new Graduation_Project_TrackerEntities();
        public Post_Announcements()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Supervisor_Mentor Home = new Supervisor_Mentor();
            Home.Show();
            this.Hide();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if(PostTextBox.Text == "")
            {
                MessageBox.Show("Post can't be empty!");
            }
            else
            {
                Announcement post = new Announcement();
                post.Date = System.DateTime.Now;
                post.Announcement1 = PostTextBox.Text;
                if(Login.mentor)
                    post.MentorEmail = Login.logged_user;
                else if (Login.supervisor)
                    post.SupervisorEmail = Login.logged_user;
                else
                {
                    MessageBox.Show("ERROR OCCURRED, user not specified.");
                    return;
                }
                db.Announcements.Add(post);
                db.SaveChanges();
                MessageBox.Show("ANNOUNCEMENT POSTED!");
            }
        }
    }
}
