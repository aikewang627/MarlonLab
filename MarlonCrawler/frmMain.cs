using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarlonCrawler
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnJianLib_Click(object sender, EventArgs e)
        {
            JianLib.frmJianLib frm = new JianLib.frmJianLib();
            frm.ShowDialog();
        }

        private void btnLiepinHeadhunter_Click(object sender, EventArgs e)
        {
            Liepin.frmHeadhunter frm = new Liepin.frmHeadhunter();
            frm.ShowDialog();
        }

        private void btnLiepinJobhunter_Click(object sender, EventArgs e)
        {
            Liepin.frmJobhunter frm = new Liepin.frmJobhunter();
            frm.ShowDialog();
        }

        private void btnLiepinHr_Click(object sender, EventArgs e)
        {
            Liepin.frmHr frm = new Liepin.frmHr();
            frm.ShowDialog();
        }
    }
}
