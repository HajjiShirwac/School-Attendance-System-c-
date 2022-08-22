using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System
{
    public partial class Mainform : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public Mainform()
        {
            InitializeComponent();
            //loggedIn = 0;

           
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
           
        }

        private void Mainform_Activated(object sender, EventArgs e)
        {
          
            }
        }
    }
}
