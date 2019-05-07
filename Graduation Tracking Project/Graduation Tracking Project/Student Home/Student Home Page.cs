using Graduation_Tracking_Project.Student_Home;
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
    public partial class Student_Home_Page : Form
    {
        public Student_Home_Page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Identify_Task_Status GUI = new Identify_Task_Status();
            GUI.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Assigned_Supervisors GUI = new View_Assigned_Supervisors();
            GUI.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email_Supervisor GUI = new Email_Supervisor();
            GUI.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings GUI = new Settings();
            GUI.Show();
            this.Hide();
        }
    }
}
