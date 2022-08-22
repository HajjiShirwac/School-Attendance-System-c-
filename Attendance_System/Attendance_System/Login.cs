using System;
using System.Data;
using System.Windows.Forms;

namespace Attendance_System
{
    public partial class Login : Form
    {
        public bool loginFlag { get; set; }
        public Login()
        {
            InitializeComponent();
            loginFlag = false;
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DataTable1TableAdapter UserAda = new DataSet1TableAdapters.DataTable1TableAdapter();
            DataTable dt = UserAda.GetDataByUserAndPass(metroTextBox1.Text, metroTextBox1.Text);
            //metrotextbox1 is the naming of Metrotextbox password
            if (dt.Rows.Count > 0)
            {
                //valid
                MessageBox.Show("logged in");
                loginFlag = true;
            }
            else
            {
                //invalid
                MessageBox.Show("denied");
                loginFlag = false;
            }
            Close();
        }
    }
}
