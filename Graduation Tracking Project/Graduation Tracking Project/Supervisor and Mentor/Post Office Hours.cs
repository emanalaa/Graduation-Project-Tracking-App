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
    public partial class Post_Office_Hours : Form
    {
        
        public Post_Office_Hours()
        {
            InitializeComponent();
        }

        private void Post_Office_Hours_Load(object sender, EventArgs e)
        {
            Office_Hourse OF = new Office_Hourse();

            if (Login.supervisor == true)
            {
                var query = from sv in OF.Supervisors where sv.supervisor_email == Login.logged_user select sv;
                Supervisor res = query.Single();
                textBox1.Text = res.supervisor_office_hours.ToString();
            }
            else if(Login.mentor == true)
            {
                var query = from mntr in OF.Mentors where mntr.mentor_email == Login.logged_user select mntr;
                Mentor res = query.Single();
                textBox1.Text = res.mentor_office_hours.ToString();
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "")
            {
                MessageBox.Show("you hould ")
            }
        }
    }
}
