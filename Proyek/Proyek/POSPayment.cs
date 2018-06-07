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

namespace Proyek
{
    public partial class POSPayment : MetroForm
    {
        
        public POSPayment()
        {
            InitializeComponent();
            
        }
        public Login f;
        POS p = null;
        public void init(Login f1, POS p1)
        {
            f = f1;
            this.p = p1;
            setcbbMember();
            tbCash.Text = "";
        }
        int cash = 0;
        int change = 0;
        int grandtotal = 0;
        OracleDataAdapter daMember = new OracleDataAdapter();
        DataSet dsMember = new DataSet();

        private void setcbbMember()
        {
            String q1 = "select * from member";
            daMember = new OracleDataAdapter(q1, f.conn);
            daMember.Fill(dsMember);
            for (int i = 0; i < dsMember.Tables[0].Rows.Count; i++)
            {
                cbbMember.Items.Add(dsMember.Tables[0].Rows[i][0].ToString());
            }
        }

        private void POSPayment_Load(object sender, EventArgs e)
        {
            MessageBox.Show("On Proggress");
        }

        private void cbbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCash.Text = "0";
        }
    }
}
