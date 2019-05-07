using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Tracking_Project
{
    public partial class Login : Form
    {
        public static string logged_user = "";
        public static string studentID = "";
        public static bool supervisor = false;
        public static bool mentor = false;

        
       

        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(check_student() == false && check_mentor() == false && check_supervisor() == false)
            {
                MessageBox.Show("Please check your email and password!");
            }
            else if(check_student() == true)
            {
                Student_Home_Page home = new Student_Home_Page();
                this.Hide();
                home.Show();

            }
            else if(check_mentor() == true || check_supervisor() == true)
            {
                Supervisor_Mentor ment_sup = new Supervisor_Mentor();
                this.Hide();
                ment_sup.Show();
            }
        }
        bool check_student()
        {
            Student stud = new Student();
            stud.student_email = email_textBox.Text;
            stud.student_password = password_textBox.Text;
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                var query = from s in ent.Students select s;
                List<Student> students = query.ToList();
                for (int i = 0; i < students.Count(); i++)
                {
                    if (email_textBox.Text == students[i].student_email.ToString() && password_textBox.Text == students[i].student_password.ToString())
                    {
                        logged_user = email_textBox.Text;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return false;



        }
        bool check_mentor()
        {
            Mentor ment = new Mentor();
            
            ment.mentor_email = email_textBox.Text;
            ment.mentor_password = password_textBox.Text;
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                var query = from s in ent.Mentors select s;
                List<Mentor> mentors = query.ToList();
                for (int i = 0; i < mentors.Count(); i++)
                {
                    if (email_textBox.Text == mentors[i].mentor_email.ToString() && password_textBox.Text == mentors[i].mentor_password.ToString())
                    {
                        logged_user = email_textBox.Text;
                        mentor = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return false;
        }
        bool check_supervisor()
        {
            Supervisor sup = new Supervisor();
            sup.supervisor_email = email_textBox.Text;
            sup.supervisor_password = password_textBox.Text;
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                var query = from s in ent.Supervisors select s;
                List<Supervisor> supervisors = query.ToList();
                for (int i = 0; i < supervisors.Count(); i++)
                {
                    if (email_textBox.Text == supervisors[i].supervisor_email.ToString() && password_textBox.Text == supervisors[i].supervisor_password.ToString())
                    {
                        logged_user = email_textBox.Text;
                        supervisor = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return false;
        }
    }
}
