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
using System.IO;
using System.Globalization;

namespace Proyek
{
    public partial class POS : MetroForm
    {
        public POS()
        {
            InitializeComponent();
        }
        public Login f;

        public void init(Login f1)
        {
            f = f1;
            setGridProducts();
            setAutoComplete();
            setTansno();
            lblTotalItems.Text = "0";
            lblTotalPrice.Text = "0";
        }

        DataSet dsProduct = new DataSet();
        OracleDataAdapter daProduct = new OracleDataAdapter();
        AutoCompleteStringCollection atCari = null;
        OracleCommand cmd = null;
        public void setLabels()
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        public void setGridProducts()
        {
            String q1 = "select id_barang, nama_barang from barang";
            daProduct = new OracleDataAdapter(q1, f.conn);
            dsProduct = new DataSet();
            daProduct.Fill(dsProduct);
            gridProductList.DataSource = dsProduct.Tables[0];
        }
        public string tgl = "";
        public string bln = "";
        public string thn = "";
        public void setTansno()
        {
            DateTime dt = DateTime.Now.Date;
            tgl = dt.Date.Day.ToString();
            bln = dt.Date.Month.ToString();
            thn = dt.Date.Year.ToString();
            if (Convert.ToInt32(tgl) < 10)
            {
                tgl = "0" + tgl;
            }
            if (Convert.ToInt32(bln) < 10)
            {
                bln = "0" + bln;
            }
            String t = "HJ" + bln + tgl + thn;
            String q1 = "select count(id_hjual) from hjual where id_hjual like '" + t + "%'";
            cmd = new OracleCommand(q1, f.conn);
            int ctr = Convert.ToInt32(cmd.ExecuteScalar())+1;
            t+=ctr.ToString("D3");
            lblTransactionNo.Text = t;
        }
        public void setGridDTrans()
        {

        }
        public void setAutoComplete()
        {
            String q1 = "select nama_member from member";
            OracleDataAdapter daTemp = new OracleDataAdapter(q1, f.conn);
            DataSet dsTemp = new DataSet();
            daTemp.Fill(dsTemp);
            atCari = new AutoCompleteStringCollection();
            for (int i = 0; i < dsTemp.Tables[0].Rows.Count; i++)
            {
                atCari.Add(dsTemp.Tables[0].Rows[i][0].ToString());
            }
            txtCariMember.AutoCompleteCustomSource = atCari;
            txtCariMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCariMember.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void POS_Load(object sender, EventArgs e)
        {
            MessageBox.Show("label atas belum terisi");
            pbFotoMember.Image = null;
            //this.reportViewer1.RefreshReport();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            POSPayment fPa = new POSPayment();
            fPa.init(f,this);
            fPa.ShowDialog();
        }

        private void gridProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = (DataGridViewRow)gridDTrans.Rows[0].Clone();
            row.Cells[0].Value = lblId.Text;
            row.Cells[1].Value = lblName.Text;
            row.Cells[2].Value = 1;
            row.Cells[5].Value = lblPrice.Text;
            row.Cells[6].Value = Convert.ToInt32(lblPrice.Text)*Convert.ToInt32(row.Cells[2].Value);
            gridDTrans.Rows.Add(row);
            lblTotalPrice.Text = sumPriceDTrans().ToString();
            lblTotalItems.Text = sumQDTrans().ToString();
        }

        private void gridDTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {
                    int qty = Convert.ToInt32(gridDTrans.Rows[e.RowIndex].Cells[2].Value);
                    qty++;
                    gridDTrans.Rows[e.RowIndex].Cells[2].Value = qty;
                    gridDTrans.Rows[e.RowIndex].Cells[6].Value = qty * Convert.ToInt32(gridDTrans.Rows[e.RowIndex].Cells[5].Value);
                    lblTotalPrice.Text = sumPriceDTrans().ToString();
                    lblTotalItems.Text = sumQDTrans().ToString();
                }
                else if (e.ColumnIndex == 4)
                {
                    int qty = Convert.ToInt32(gridDTrans.Rows[e.RowIndex].Cells[2].Value);
                    if (qty - 1 == 0)
                    {
                        gridDTrans.Rows.RemoveAt(e.RowIndex);
                        lblTotalPrice.Text = sumPriceDTrans().ToString();
                        lblTotalItems.Text = sumQDTrans().ToString();
                    }
                    else
                    {
                        qty--;
                        gridDTrans.Rows[e.RowIndex].Cells[2].Value = qty;
                        gridDTrans.Rows[e.RowIndex].Cells[6].Value = qty * Convert.ToInt32(gridDTrans.Rows[e.RowIndex].Cells[5].Value);
                        lblTotalPrice.Text = sumPriceDTrans().ToString();
                        lblTotalItems.Text = sumQDTrans().ToString();
                    }
                }
            }
            
        }
        private int sumQDTrans()
        {
            int sum = 0;
            for (int i = 0; i < gridDTrans.Rows.Count; i++)
            {
                sum += Convert.ToInt32(gridDTrans.Rows[i].Cells[2].Value);
            }
            return sum;
        }
        private int sumPriceDTrans()
        {
            int sum = 0;
            for (int i = 0; i < gridDTrans.Rows.Count; i++)
            {
                sum += Convert.ToInt32(gridDTrans.Rows[i].Cells[6].Value);
            }
            return sum;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            gridDTrans.Rows.Clear();
            lblTotalItems.Text = "0";
            lblTotalPrice.Text = "0";
        }

        private void btnSearchmember_Click(object sender, EventArgs e)
        {
            String nama_member = txtCariMember.Text;
            String q1 = "select * from member where nama_member = '" + nama_member + "'";
            OracleDataAdapter daTemp = new OracleDataAdapter(q1, f.conn);
            DataSet dsTemp = new DataSet();
            daTemp.Fill(dsTemp);
            txtIdMember.Text = dsTemp.Tables[0].Rows[0][0].ToString();
            txtNama.Text = dsTemp.Tables[0].Rows[0][1].ToString();
            MessageBox.Show("datetime belum");
            //DateTime dateTime = DateTime.ParseExact(dsTemp.Tables[0].Rows[0][2].ToString(), "yyyy-MM-dd HH24:mm:ss", CultureInfo.InvariantCulture);
            //dtpTanggalLahir.Value = dateTime;
            if (Convert.ToInt32(dsTemp.Tables[0].Rows[0][3]) == 0)
            {
                cbPerempuan.Checked = true;
            }
            else if (Convert.ToInt32(dsTemp.Tables[0].Rows[0][3]) == 1)
            {
                cbLakiLaki.Checked = true;
            }
            txtEmail.Text = dsTemp.Tables[0].Rows[0][4].ToString();
            txtAlamat.Text = dsTemp.Tables[0].Rows[0][5].ToString();
            String foto = dsTemp.Tables[0].Rows[0][6].ToString();
            try
            {
                pbFotoMember.Load(Application.StartupPath + "\\Gambar\\Member" + foto +".jpg");
            }
            catch (Exception)
            {
                
            }
            try
            {
                pbFotoMember.Load(Application.StartupPath + "\\Gambar\\Member" + foto + ".png");
            }
            catch (Exception)
            {
            }
            cmd = new OracleCommand();
            cmd.Connection = f.conn;
            String q2 = "select sum(point) from point_history where id_member='" + txtIdMember.Text + "'";
            cmd.CommandText = q2;
            txtJumlahPoint.Text = cmd.ExecuteScalar().ToString();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchitem_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text==""){
                setGridProducts();
            }else{
                if (cbId.Checked)
                {
                    String id = txtSearch.Text;
                    String q1 = "select id_barang, nama_barang from barang where id_barang like '" + id + "%'";
                    daProduct = new OracleDataAdapter(q1, f.conn);
                    dsProduct = new DataSet();
                    daProduct.Fill(dsProduct);
                    gridProductList.DataSource = dsProduct.Tables[0];
                }
                else if (cbName.Checked)
                {
                    String nama = txtSearch.Text;
                    String q1 = "select id_barang, nama_barang from barang where nama_barang like '" + nama + "%'";
                    daProduct = new OracleDataAdapter(q1, f.conn);
                    dsProduct = new DataSet();
                    daProduct.Fill(dsProduct);
                    gridProductList.DataSource = dsProduct.Tables[0];
                }
                else if (cbBrand.Checked)
                {
                    String brand = txtSearch.Text;
                    String q1 = "select b.id_barang, b.nama_barang from barang b, merk m where m.nama_merk like '" + 
                                brand + "%' and m.id_merk = b.id_merk";
                    daProduct = new OracleDataAdapter(q1, f.conn);
                    dsProduct = new DataSet();
                    daProduct.Fill(dsProduct);
                    gridProductList.DataSource = dsProduct.Tables[0];
                }
                else if (cbCategory.Checked)
                {
                    String category = txtSearch.Text;
                    String q1 = "select b.id_barang, b.nama_barang from barang b, kategori k where k.nama_kategori like '" + 
                                category + "%' and k.id_kategori = b.id_kategori";
                    daProduct = new OracleDataAdapter(q1, f.conn);
                    dsProduct = new DataSet();
                    daProduct.Fill(dsProduct);
                    gridProductList.DataSource = dsProduct.Tables[0];
                }
            }
            this.Validate();
        }
        Image File;

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                
                pbFotoMember.Image = File;
                pbFotoMember.Image.Tag = f.FileName;
            }
        }

        private void btnMemberBaru_Click(object sender, EventArgs e)
        {
            String id = txtIdMember.Text;
            String nama = txtNama.Text;
            String alamat = txtAlamat.Text;
            String email = txtEmail.Text;
            String point = txtJumlahPoint.Text;
            int gender = 0;
            if (cbLakiLaki.Checked)
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }
            String tanggal = dtpTanggalLahir.Value.Day.ToString();
            String bulan = dtpTanggalLahir.Value.Month.ToString();
            String tahun = dtpTanggalLahir.Value.Year.ToString();
            String q1 = "";
            if (pbFotoMember.Image == null)
            {
                q1 = "INSERT INTO MEMBER VALUES ('" + id + "','" + nama + "',TO_DATE('" + tahun + "-" + bulan + "-" + tanggal +
                            "','YYYY-MM-DD')," + gender + ",'" + email + "','" + alamat + "','NULL','ABC001')";
            }
            else
            {
                String file = pbFotoMember.Image.Tag.ToString();
                file = Path.GetFileName(file);
                q1 = "INSERT INTO MEMBER VALUES ('" + id + "','" + nama + "',TO_DATE('" + tahun + "-" + bulan + "-" + tanggal +
                            "','YYYY-MM-DD')," + gender + ",'" + email + "','" + alamat + "','" + file + "','ABC001')";
            } 
            OracleCommand c1 = new OracleCommand(q1, f.conn);
            c1.ExecuteNonQuery(); 
            MessageBox.Show("added");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            String id = txtIdMember.Text;
            String nama = txtNama.Text;
            String alamat = txtAlamat.Text;
            String email = txtEmail.Text;
            String point = txtJumlahPoint.Text;
            int gender = 0;
            if (cbLakiLaki.Checked)
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }
            String tanggal = dtpTanggalLahir.Value.Day.ToString();
            String bulan = dtpTanggalLahir.Value.Month.ToString();
            String tahun = dtpTanggalLahir.Value.Year.ToString();
            String q1 = "";
            if (pbFotoMember.Image == null)
            {
                q1 = "update member set nama_member='" + nama +
                            "', alamat_member='" + alamat +
                            "', email_member='" + email +
                            "', jk_member='" + gender +
                            "', foto_member=NULL where id_member='" + id + "'";
            }
            else
            {
                String file = pbFotoMember.Image.Tag.ToString();
                file = Path.GetFileName(file);
                q1 = "update member set nama_member='" + nama +
                            "', alamat_member='" + alamat +
                            "', email_member='" + email +
                            "', jk_member='" + gender +
                            "', foto_member='" + file +
                            "' where id_member='" + id + "'";
            }
            OracleCommand c1 = new OracleCommand(q1, f.conn);
            c1.ExecuteNonQuery();
            MessageBox.Show("updated");
        }

        private void gridProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            String id_barang = gridProductList.Rows[index].Cells[0].Value.ToString();
            String q1 = "select * from barang where id_barang = '" + id_barang + "'";
            OracleDataAdapter daTemp = new OracleDataAdapter(q1, f.conn);
            DataSet dsTemp = new DataSet();
            daTemp.Fill(dsTemp);

            String nama_barang = dsTemp.Tables[0].Rows[0][3].ToString();
            String harga_jual = dsTemp.Tables[0].Rows[0][5].ToString();
            String stock = dsTemp.Tables[0].Rows[0][6].ToString();

            OracleCommand cmd = new OracleCommand();
            String brand = "select nama_merk from merk where id_merk = '" + dsTemp.Tables[0].Rows[0][2].ToString() + "'";
            cmd = new OracleCommand(brand, f.conn);
            brand = cmd.ExecuteScalar().ToString();
            String category = "select nama_kategori from kategori where id_kategori = '" + dsTemp.Tables[0].Rows[0][1].ToString() + "'";
            cmd = new OracleCommand(category, f.conn);
            category = cmd.ExecuteScalar().ToString();
            lblId.Text = id_barang;
            lblName.Text = nama_barang;
            lblBrand.Text = brand;
            lblPrice.Text = harga_jual;
            lblCategory.Text = category;
            lblStock.Text = stock;
            String nama_gambar = dsTemp.Tables[0].Rows[0][8].ToString();
            try
            {
                pictureBox1.Load(Application.StartupPath + "\\Gambar\\" + category + "\\" + nama_gambar);
            }
            catch (Exception)
            {
            }
        }

    }
}
