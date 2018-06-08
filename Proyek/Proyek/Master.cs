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
            setgridHjual();
        }
        DataSet dsMember = new DataSet();
        OracleDataAdapter daMember = new OracleDataAdapter();
        DataSet dsSupplier = new DataSet();
        OracleDataAdapter daSupplier = new OracleDataAdapter();
        DataSet dsPegawai = new DataSet();
        OracleDataAdapter daPegawai = new OracleDataAdapter();
        DataSet dsPoint = new DataSet();
        OracleDataAdapter daPoint = new OracleDataAdapter();
        DataSet dsAbsensi = new DataSet();
        OracleDataAdapter daAbsensi = new OracleDataAdapter();
        OracleCommandBuilder cmdBuilder = new OracleCommandBuilder();
        DataSet dsBarang = new DataSet();
        OracleDataAdapter daBarang = new OracleDataAdapter();
        DataSet dsHjual = new DataSet();
        OracleDataAdapter daHjual = new OracleDataAdapter();
        DataSet dsDjual = new DataSet();
        OracleDataAdapter daDjual = new OracleDataAdapter();
        
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
        }

        public void initSupplier()
        {
            String q1 = "select * from supplier";
            daSupplier = new OracleDataAdapter(q1, f.conn);
            daSupplier.Fill(dsSupplier);
            gridSupplier.DataSource = dsSupplier.Tables[0];
        }

        public void setgridHjual()
        {
            String q1 = "select * from hjual";
            daHjual = new OracleDataAdapter(q1, f.conn);
            daHjual.Fill(dsHjual);
            gridHjual.DataSource = dsHjual.Tables[0];
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
            cmdBuilder = new OracleCommandBuilder(daAbsensi);
            daAbsensi.Update(dsAbsensi);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Validate();
            cmdBuilder = new OracleCommandBuilder(daMember);
            daMember.Update(dsMember);
        }

        private void btnSimpanMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            String id_member = btnSimpanMember.Rows[index].Cells[0].Value.ToString();
            String q2 = "select h.id_hjual,h.tanggal_hjual,p.point from point_history p,hjual h where h.id_hjual = p.id_hjual and p.id_member = '"+id_member+"'";
            daPoint = new OracleDataAdapter(q2, f.conn);
            dsPoint = new DataSet();
            daPoint.Fill(dsPoint);
            gridPointHistory.DataSource = dsPoint.Tables[0];
        }

        private void gridPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            String id_pegawai = gridPegawai.Rows[index].Cells[0].Value.ToString();
            String q1 = "select * from absensi where id_pegawai = '" + id_pegawai + "'";
            daAbsensi = new OracleDataAdapter(q1, f.conn);
            dsAbsensi = new DataSet();
            daAbsensi.Fill(dsAbsensi);
            gridAbsensi.DataSource = dsAbsensi.Tables[0];
        }

        private void gridHjual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            String id_hjual = gridHjual.Rows[index].Cells[0].Value.ToString();
            String q1 = "select * from djual where id_hjual = '" + id_hjual +"'";
            daDjual = new OracleDataAdapter(q1, f.conn);
            dsDjual = new DataSet();
            daDjual.Fill(dsDjual);
            gridDjual.DataSource = dsDjual.Tables[0];
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Validate();
            cmdBuilder = new OracleCommandBuilder(daHjual);
            daHjual.Update(dsHjual);
            cmdBuilder = new OracleCommandBuilder(daDjual);
            daDjual.Update(dsDjual);
        }
        
    }
}
