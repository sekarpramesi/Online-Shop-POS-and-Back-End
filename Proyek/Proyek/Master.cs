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
using MetroFramework.Components;
using MetroFramework.Controls;

namespace Proyek
{
    public partial class Master : MetroForm
    {
        public Master()
        {
            InitializeComponent();
        }
        public Login f;

        public void init(Login f1)
        {
            f = f1;
            initMember();
            initPegawai();
            initSupplier();
        }



        public void initPegawai()
        {
            String q1 = "select * from pegawai";
            DataSet ds1 = new DataSet();
            OracleDataAdapter da1 = new OracleDataAdapter(q1, f.conn);
            da1.Fill(ds1);
            gridPegawai.DataSource = ds1.Tables[0];
        }

        public void initMember()
        {
            String q1 = "select * from member";
            DataSet ds1 = new DataSet();
            OracleDataAdapter da1 = new OracleDataAdapter(q1, f.conn);
            da1.Fill(ds1);
            btnSimpanMember.DataSource = ds1.Tables[0];
        }

        public void initSupplier()
        {
            String q1 = "select * from supplier";
            DataSet ds1 = new DataSet();
            OracleDataAdapter da1 = new OracleDataAdapter(q1, f.conn);
            da1.Fill(ds1);
            gridSupplier.DataSource = ds1.Tables[0];
        }
        
    }
}
