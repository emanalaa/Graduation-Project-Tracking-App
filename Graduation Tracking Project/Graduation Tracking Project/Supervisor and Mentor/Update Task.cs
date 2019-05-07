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

namespace Graduation_Tracking_Project.Supervisor_and_Mentor
{
    public partial class Update_Task : Form
    {
        Task tsk = new Task();
        public Update_Task()
        {
            InitializeComponent();
        }

        private void Update_Task_Load(object sender, EventArgs e)
        {
            populate_data_gridview();
        }
        void populate_data_gridview()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                dataGridView1.DataSource = ent.Tasks.ToList();
            }
        }

        void clear()
        {
            id_textBox.Text = desc_textBox.Text = tsk.task_description = st_textBox.Text = end_textBox.Text = "";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                tsk.task_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["task_ID"].Value);
                //tsk.task_description = dataGridView1.CurrentRow.Cells["task_description"].Value.ToString();
                using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
                {
                    tsk = ent.Tasks.Where(x => x.task_ID == tsk.task_ID).FirstOrDefault();
                    id_textBox.Text = tsk.task_ID.ToString();
                    desc_textBox.Text = tsk.task_description;
                    st_textBox.Text = tsk.task_start_date.ToString();
                    end_textBox.Text = tsk.task_end_date.ToString();


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tsk.task_description = desc_textBox.Text;
            tsk.task_start_date = DateTime.Parse(st_textBox.Text);
            tsk.task_end_date = DateTime.Parse(end_textBox.Text);

            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                ent.Entry(tsk).State = EntityState.Modified;
                ent.SaveChanges();
            }
            populate_data_gridview();
            MessageBox.Show("Updated Successfully!");
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Graduation_Project_TrackerEntitiess ent = new Graduation_Project_TrackerEntitiess())
            {
                if(dataGridView1.CurrentRow.Index !=-1)
                {
                    var entry = ent.Entry(tsk);
                    if (entry.State == EntityState.Detached)
                        ent.Tasks.Attach(tsk);

                    ent.Tasks.Remove(tsk);
                    ent.SaveChanges();
                    populate_data_gridview(); //enty fhma? :D
                    MessageBox.Show("Deleted Successfully!");
                    clear();
                }
            }
        }
    }
}
