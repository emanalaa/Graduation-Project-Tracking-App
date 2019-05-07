using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Tracking_Project.Student_Home
{
    public partial class View_Assigned_Supervisors : Form
    {
        Graduation_Project_TrackerEntities db = new Graduation_Project_TrackerEntities();
        public View_Assigned_Supervisors()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Student_Home_Page home = new Student_Home_Page();
            home.Show();
            this.Hide();
        }

        private void View_Assigned_Supervisors_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student = db.Students.Find(Login.studentID);

            int teamID = student.team_id_fk??0;
            Team team = new Team();
            team = db.Teams.Find(teamID);

            Mentor mentor = new Mentor();
            Supervisor sp = new Supervisor();

            mentor = db.Mentors.Find(team.mentor_email_fk);
            sp = db.Supervisors.Find(team.supervisor_email_fk);

            MentorEmailTextBox.Text = mentor.mentor_email;
            MentorNametextBox.Text = mentor.mentor_name;
            MentorOfficeHoursTextBox.Text = mentor.office_hours;

            supervisorEmailTxtbox.Text = sp.supervisor_email;
            SupervisorNametxtbox.Text = sp.supervisor_name;
            SupervisorOfficeHourstxtbox.Text = sp.office_hours;
        }
    }
}
