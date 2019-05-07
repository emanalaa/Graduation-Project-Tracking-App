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
    public partial class Login : Form
    {
        public static string logged_user = "";
        public static string studentID = "";
        public static bool supervisor = false;
        public static bool mentor = false;

        public Login()
        {
            InitializeComponent();
        }
    }
}
