using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Tracking_Project.Supervisor_and_Mentor
{
    public partial class Add_Project : Form
    {
        Project proj = new Project();
        public Add_Project()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proj.project_name = name_txtbox.Text;
            proj.project_description = desc_txtbox.Text;
            proj.project_start_date = DateTime.Parse(st_date_txtbox.Text);
            proj.project_end_date = DateTime.Parse(end_date_txtbox.Text);

            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                ent.Projects.Add(proj);
                ent.SaveChanges();
            }
            MessageBox.Show("Project is successfully added");
        }
    }
}
