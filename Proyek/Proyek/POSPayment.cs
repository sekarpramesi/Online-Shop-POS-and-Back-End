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

        public void init(Login f1)
        {
            f = f1;
        }
        private void POSPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
