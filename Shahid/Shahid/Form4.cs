using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shahid
{
    public partial class Form4 : Form
    {
        CrystalReport1 cr;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr;


        }
    }
}
