using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Common;



namespace Graduation_Tracking_Project.Supervisor_Mentor_Home
{
    public partial class Email_Students : Form
    {
        Graduation_Project_TrackerEntitiess ent;
        Message mssg = new Message();
        // Student stud = new Student();


        public Email_Students()
        {

            InitializeComponent();
            sender_txtbox.Text = Login.logged_user;
            ent = new Graduation_Project_TrackerEntitiess();
            string email;
            var query = from fc in ent.Students select fc;
            List<Student> student = query.ToList();

            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                var stud = (from students in ent.Students
                            join teams in ent.Teams
                            on students.team_id_fk equals teams.Team_ID
                            where teams.supervisor_email_fk == sender_txtbox.Text
                            select new { email = students.student_email }).ToList();


                foreach (var e in stud)
                {

                    reciever_cmbobox.Items.Add(e.email);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            mssg.sender_email = sender_txtbox.Text;
            mssg.reciever_email = reciever_cmbobox.SelectedItem.ToString();
            mssg.message1 = message_txtbox.Text;
            mssg.date = DateTime.Now;
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                ent.Messages.Add(mssg);
                ent.SaveChanges();
            }
            MessageBox.Show("Message is successfully sent");

        }
    }
}
