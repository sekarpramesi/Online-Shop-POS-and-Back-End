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
    public partial class Inventory : MetroForm
    {
        public Inventory()
        {
            InitializeComponent();
        }
        public Login f;

        public void init(Login f1)
        {
            f = f1;
            setgridBarang();
            setgridHbeli();
        }
        DataSet dsBarang = new DataSet();
        OracleDataAdapter daBarang = new OracleDataAdapter();
        DataSet dsHbeli = new DataSet();
        OracleDataAdapter daHbeli = new OracleDataAdapter();
        DataSet dsDbeli = new DataSet();
        OracleDataAdapter daDbeli = new OracleDataAdapter();
        OracleCommandBuilder cmdBuilder = new OracleCommandBuilder();

        public void setgridBarang()
        {
            String q1 = "select * from barang";
            daBarang = new OracleDataAdapter(q1, f.conn);
            daBarang.Fill(dsBarang);
            gridBarang.DataSource = dsBarang.Tables[0];
        }
        public void setgridHbeli()
        {
            String q1 = "select * from hbeli";
            daHbeli = new OracleDataAdapter(q1, f.conn);
            daHbeli.Fill(dsHbeli);
            gridHbeli.DataSource = dsHbeli.Tables[0];
        }
        private void btnSimpanOrders_Click(object sender, EventArgs e)
        {
            this.Validate();
            cmdBuilder = new OracleCommandBuilder(daHbeli);
            daHbeli.Update(dsHbeli);
            cmdBuilder = new OracleCommandBuilder(daDbeli);
            daDbeli.Update(dsDbeli);
        }

        private void gridHbeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            String id_hbeli = gridHbeli.Rows[index].Cells[0].Value.ToString();
            String q1 = "select * from dbeli where id_hbeli = '"+id_hbeli+"'";
            daDbeli = new OracleDataAdapter(q1, f.conn);
            dsDbeli = new DataSet();
            daDbeli.Fill(dsDbeli);
            gridDbeli.DataSource = dsDbeli.Tables[0];
        }

        private void btnSimpanBarang_Click(object sender, EventArgs e)
        {
            this.Validate();
            cmdBuilder = new OracleCommandBuilder(daBarang);
            daBarang.Update(dsBarang);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
