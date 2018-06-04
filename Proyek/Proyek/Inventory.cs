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
        }
        DataSet dsBarang = new DataSet();
        OracleDataAdapter daBarang = new OracleDataAdapter();

        public void setgridBarang()
        {
            String q1 = "select * from barang";
            daBarang = new OracleDataAdapter(q1, f.conn);
            daBarang.Fill(dsBarang);
            gridBarang.DataSource = dsBarang.Tables[0];
        }
    }
}
