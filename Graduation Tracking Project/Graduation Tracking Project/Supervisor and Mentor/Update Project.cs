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
    public partial class Update_Project : Form
    {
        Graduation_Project_TrackerEntities db = new Graduation_Project_TrackerEntities();
        public Update_Project()
        {
            InitializeComponent();
        }

        private void Update_Project_Load(object sender, EventArgs e)
        {
            List<int> projectIDs = db.Teams.Where(sp => sp.supervisor_email_fk == Login.logged_user).Select(sp=>sp.project_id_fk??-1).ToList();
            for(int i=0; i<projectIDs.Count; i++)
            {
                if(projectIDs[i] != -1)
                {
                    Project project = new Project();
                    project = db.Projects.Find(projectIDs[i]);
                    if(project != null)
                    {
                        IDcomboBox.Items.Add(project.project_id);
                    }
                }
            }
        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project project = new Project();
            int projectID = Int32.Parse(IDcomboBox.SelectedItem.ToString());
            project = db.Projects.Find(projectID);
            if (project != null)
            {
                projectNametxtBox.Text = project.project_name;
                startdateTimePicker.Text = project.project_start_date.ToString();
                EndDateTimePicker.Text = project.project_end_date.ToString();
                DescriptionTextbox.Text = project.project_description;
            }
            else
            {
                MessageBox.Show("Sorry no data avaliable!");
            }
        }

        private void updateProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = new Project();
                int projectID = Int32.Parse(IDcomboBox.SelectedItem.ToString());
                project = db.Projects.Find(projectID);
                project.project_name = projectNametxtBox.Text;
                project.project_start_date = startdateTimePicker.Value;
                project.project_end_date = EndDateTimePicker.Value;
                project.project_description = DescriptionTextbox.Text;
                db.SaveChanges();
                MessageBox.Show("Done.");
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
