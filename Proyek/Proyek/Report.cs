﻿using System;
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
    public partial class Report : MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }
        public Login f;

        public void init(Login f1)
        {
            f = f1;
        }
    }
}
