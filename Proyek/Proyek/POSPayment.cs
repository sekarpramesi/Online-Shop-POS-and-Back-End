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
        
        POS p = null;
        public Login f;
        public void init(Login f1, POS p1)
        {
            this.f = f1;
            this.p = p1;
            setcbbMember();
            tbCash.Text = "0";
            lblChange.Text = "0";
            setgridSummary();
            lblGrandTotal.Text = p.lblTotalPrice.Text;
            lblPoints.Text = (Convert.ToInt32(lblGrandTotal.Text) / 10000).ToString();
            grandtotal = Convert.ToInt32(lblGrandTotal.Text);
        }

        int cash = 0;
        int change = 0;
        int grandtotal = 0;
        OracleDataAdapter daMember = new OracleDataAdapter();
        DataSet dsMember = new DataSet();
        
        private void setgridSummary()
        {
            for (int i = 0; i < p.gridDTrans.Rows.Count-1; i++)
            {
                DataGridViewRow row = (DataGridViewRow)p.gridDTrans.Rows[i].Clone();
                row.Cells[0].Value = p.gridDTrans.Rows[i].Cells[0].Value;
                row.Cells[1].Value = p.gridDTrans.Rows[i].Cells[1].Value;
                row.Cells[2].Value = p.gridDTrans.Rows[i].Cells[2].Value;
                row.Cells[5].Value = p.gridDTrans.Rows[i].Cells[5].Value;
                row.Cells[6].Value = p.gridDTrans.Rows[i].Cells[6].Value;
                gridtest.Rows.Add(row);
            }
            gridtest.Columns[3].Visible = false;
            gridtest.Columns[4].Visible = false;
        }
        private void setcbbMember()
        {
            String q1 = "select * from niya.member";
            daMember = new OracleDataAdapter(q1, f.conn);
            daMember.Fill(dsMember);
            for (int i = 0; i < dsMember.Tables[0].Rows.Count; i++)
            {
                cbbMember.Items.Add(dsMember.Tables[0].Rows[i][0].ToString());
            }
        }

        private void POSPayment_Load(object sender, EventArgs e)
        {
            lblNoTrans.Text = p.lblTransactionNo.Text;
            lblDateTime.Text = DateTime.Now.Date.DayOfWeek + ", " + DateTime.Now.Date.Day + "/" +
                               DateTime.Now.Date.Month + "/" + DateTime.Now.Date.Year;
        }

        private void cbbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            String q1 = "select point from niya.point_history where id_member ='" + cbbMember.Text + "'";
            OracleCommand cmd = new OracleCommand(q1, f.conn);
            lblCurrentPoints.Text = cmd.ExecuteScalar().ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            cash = Convert.ToInt32(tbCash.Text);
            change = cash - grandtotal;
            lblChange.Text = change.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCash.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "0";
            }
            else
            {
                tbCash.Text = "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "1";
            }
            else
            {
                tbCash.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "2";
            }
            else
            {
                tbCash.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "3";
            }
            else
            {
                tbCash.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "4";
            }
            else
            {
                tbCash.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "5";
            }
            else
            {
                tbCash.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "6";
            }
            else
            {
                tbCash.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "7";
            }
            else
            {
                tbCash.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "8";
            }
            else
            {
                tbCash.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbCash.Text != "0")
            {
                tbCash.Text += "9";
            }
            else
            {
                tbCash.Text = "9";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            tbCash.Text += ".";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayout_Click(object sender, EventArgs e)
        {
            String q1 = "INSERT INTO niya.HJUAL VALUES ('" + lblNoTrans.Text + "','P0001',TO_DATE('" + p.thn +
                        "-" + p.bln + "-" + p.tgl + " 10:30:44','YYYY-MM-DD HH24:MI:SS')," + grandtotal + ")";
            OracleCommand cmdpo = new OracleCommand(q1, f.conn);
            cmdpo.ExecuteNonQuery();
            for (int i = 0; i < gridtest.Rows.Count; i++)
            {
                String idb = gridtest.Rows[i].Cells[0].Value.ToString();
                String idh = lblNoTrans.Text;
                String jm = gridtest.Rows[i].Cells[2].Value.ToString();
                String st = gridtest.Rows[i].Cells[6].Value.ToString();
                String q2 = "insert into niya.djual values('" + idb + "','" + idh + "','" + jm + "','" + st + "')";
                cmdpo = new OracleCommand(q2, f.conn);
                cmdpo.ExecuteNonQuery();
            }
            String idm = cbbMember.Text;
            int totalp = Convert.ToInt32(lblCurrentPoints.Text) + Convert.ToInt32(lblPoints.Text);
            String q3 = "update niya.point_history set point=" + totalp + " where id_member = '" + idm + "'";
            cmdpo = new OracleCommand(q3, f.conn);
            cmdpo.ExecuteNonQuery();
            MessageBox.Show("Transaction Succeed");
            this.Close();
        }
    }
}
