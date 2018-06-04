using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Oracle.DataAccess.Client;
using MetroFramework;

namespace Proyek
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public OracleConnection conn = new OracleConnection();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = "user id=" + txtUsername.Text + ";password=" + txtPassword.Text + ";data source=localhost;";

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                    MetroMessageBox.Show(this, "You have successfully Logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu fM = new Menu();
                    fM.init(this);
                    fM.ShowDialog();
                }
                else
                {
                    conn.Open();
                    MetroMessageBox.Show(this, "You have successfully Logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu fM = new Menu();
                    fM.init(this);
                    fM.ShowDialog();
                }
            }
            catch (System.Exception excep)
            {
                MetroMessageBox.Show(this, excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
