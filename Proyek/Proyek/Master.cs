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
        DataSet dsMember = new DataSet();
        OracleDataAdapter daMember = new OracleDataAdapter();
        DataSet dsSupplier = new DataSet();
        OracleDataAdapter daSupplier = new OracleDataAdapter();
        DataSet dsPegawai = new DataSet();
        OracleDataAdapter daPegawai = new OracleDataAdapter();
        DataSet dsPoint = new DataSet();
        OracleDataAdapter daPoint = new OracleDataAdapter();
        OracleCommandBuilder cmdBuilder = new OracleCommandBuilder();

        public void initPegawai()
        {
            String q1 = "select * from pegawai";
            daPegawai = new OracleDataAdapter(q1, f.conn);
            daPegawai.Fill(dsPegawai);
            gridPegawai.DataSource = dsPegawai.Tables[0];
        }

        public void initMember()
        {
            String q1 = "select * from member";
            daMember = new OracleDataAdapter(q1, f.conn);
            daMember.Fill(dsMember);
            btnSimpanMember.DataSource = dsMember.Tables[0];
            String q2 = "select p.id_member,m.nama_member,p.point from point_history p,member m where p.id_member = m.id_member";
            daPoint = new OracleDataAdapter(q2, f.conn);
            daPoint.Fill(dsPoint);
            gridPointHistory.DataSource = dsPoint.Tables[0];
        }

        public void initSupplier()
        {
            String q1 = "select * from supplier";
            daSupplier = new OracleDataAdapter(q1, f.conn);
            daSupplier.Fill(dsSupplier);
            gridSupplier.DataSource = dsSupplier.Tables[0];
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpanSupplier_Click(object sender, EventArgs e)
        {
            this.Validate();
            cmdBuilder = new OracleCommandBuilder(daSupplier);
            daSupplier.Update(dsSupplier);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.Validate();
            cmdBuilder = new OracleCommandBuilder(daPegawai);
            daPegawai.Update(dsPegawai);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Validate();
            cmdBuilder = new OracleCommandBuilder(daMember);
            daMember.Update(dsMember);
        }
        
    }
}
