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
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }
        public Login f;

        public void init(Login f1)
        {
            f = f1;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            Master fM = new Master();
            fM.init(f);
            fM.ShowDialog();
        }

        

        private void btnPointOfSales_Click(object sender, EventArgs e)
        {
            POS fP = new POS();
            fP.init(f);
            fP.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory fI = new Inventory();
            fI.init(f);
            fI.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
