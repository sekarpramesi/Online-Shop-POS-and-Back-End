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
        }

        DataSet dsProduct = new DataSet();
        OracleDataAdapter daProduct = new OracleDataAdapter();

        public void setLabels()
        {
            lblDateTime.Text = DateTime.Now.ToString();
            
        }

        public void setGridProducts()
        {
            String q1 = "select id_barang, nama_barang from barang";
            daProduct = new OracleDataAdapter(q1, f.conn);
            daProduct.Fill(dsProduct);
            gridProductList.DataSource = dsProduct.Tables[0];
        }

        public void setGridDTrans()
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabTransaction_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            POSPayment fPa = new POSPayment();
            fPa.init(f);
            fPa.ShowDialog();
        }

        private void gridProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            String id_barang = gridProductList.Rows[index].Cells[1].Value.ToString();
            String q1 = "select * from barang where id_barang = '"+id_barang+"'";
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
                pictureBox1.Load(Application.StartupPath + "\\Gambar\\" + category + "\\" + nama_barang+".jpg");
            }
            catch (Exception)
            {

                pictureBox1.Load(Application.StartupPath + "\\Gambar\\" + category + "\\" + nama_barang+".png");
            }
            
            
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
        }
    }
}
