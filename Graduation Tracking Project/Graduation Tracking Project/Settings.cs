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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = Login.logged_user;
            Student stud = new Student();
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                if (email == EmailtextBox1.Text)
                {
                    stud = ent.Students.Where(x => x.student_email == email).FirstOrDefault();
                    stud.student_password = PasswordtextBox2.Text;
                    ent.Entry(stud).State = System.Data.Entity.EntityState.Modified;
                    ent.SaveChanges();
                    MessageBox.Show("Your Password is updated!");

                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = Login.logged_user;
            Student stud = new Student();
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
              
                stud = ent.Students.Where(x => x.student_email == email).FirstOrDefault();
                ent.Students.Remove(stud);
                ent.SaveChanges();
               
                MessageBox.Show("Deleted Successfully!");
                Sign_Up s = new Sign_Up();
                this.Hide();
                s.Show();
            }
        }
    }
}