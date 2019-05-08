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
    public partial class Upload_Student_Grades : Form
    {
        Grade db = new Grade();
        public Upload_Student_Grades()
        {
            InitializeComponent();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (textBox_grade.Text == " " || textBox_id.Text == "")
            {
                MessageBox.Show("Please Fill All Informations");
            }
            else
            {
                Team temp = new Team();
                temp = db.Teams.Find(textBox_id.Text);
                if(temp.Team_ID == int.Parse(textBox_id.Text))
                {
                    temp.Total_mark = int.Parse(textBox_grade.Text);
                    db.SaveChanges();
                    MessageBox.Show("Grades Updated");
                }
                else
                {
                    MessageBox.Show("No Team Found Please Check The Team ID");
                }
            }
        }
    }
}
