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
    public partial class Identify_Task_Status : Form
    {
        Graduation_Project_TrackerEntities2 db = new Graduation_Project_TrackerEntities2();
        public Identify_Task_Status()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (textBox_projectid.Text == "" || textBox_status.Text == "" || textBox_taskid.Text == "")
            {
                MessageBox.Show("Please Fill All Informations");
            }
            else
            {
                Task tsk = new Task();
                tsk = db.Tasks.Find(textBox_taskid.Text);
                if (tsk.task_ID == int.Parse(textBox_taskid.Text))
                {
                    if (tsk.project_id_fk == int.Parse(textBox_projectid.Text) && tsk.student_id_fk == int.Parse(Login.studentID)) 
                    {
                        tsk.task_status = textBox_status.Text;
                        db.SaveChanges();
                        MessageBox.Show("Status Updated");
                    }
                    else
                    {
                        MessageBox.Show("Please Check ProjectID And Task ID");
                    }
                }
                else
                {
                    MessageBox.Show("Please Check Task ID");
                }
            }
        }
    }
}
