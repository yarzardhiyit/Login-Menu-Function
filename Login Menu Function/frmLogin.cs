using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Menu_Function
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            frmMain objMain = new frmMain();

            string pwd;
            pwd = txtPwd.Text.ToString();

            int res;
            res = string.Compare(pwd, "alpine");

            if(res == 0)
            {
                //MessageBox.Show("Success!");
                objMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
