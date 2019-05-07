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
    public partial class View_Announcements : Form
    {
        public View_Announcements()
        {
            InitializeComponent();
        }

        private void View_Announcements_Load(object sender, EventArgs e)
        {
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                var query = from posts in ent.Announcements select posts;
                List < Announcement > announcement= query.ToList();
                    dataGridView1.DataSource = announcement;
                //dataGridView1.DataSource = ent.Announcements; or this
                
            }
        }
    }
}
