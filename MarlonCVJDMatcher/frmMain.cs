using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarlonLab.CommonLib;
using MarlonLab.CommonLib.Common;
using MarlonLab.CommonLib.RedisHelper;//

namespace MarlonCVJDMatcher
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




        #region
        private void 简历精要提取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForm.frmResumeOutline frmRmOtli = new WinForm.frmResumeOutline();
            frmRmOtli.MdiParent = this;
            frmRmOtli.Show();
        }

        private void 职位精要提取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForm.frmPositionOutLine frmPosOtli = new WinForm.frmPositionOutLine();
            frmPosOtli.MdiParent = this;
            frmPosOtli.Show();
        }

        private void 匹配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForm.frmCVJDMatch frmMch = new WinForm.frmCVJDMatch();
            frmMch.MdiParent = this;
            frmMch.Show();
        }




        #endregion

        private void 集运算ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WinForm.frmHashSetOperater frm = new WinForm.frmHashSetOperater();
            frm.MdiParent = this;
            frm.Show();
        }
        private void 分词ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForm.frmSegment frm = new WinForm.frmSegment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 层叠排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);// //使用MdiLayout枚举实现窗体的层叠排列              
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);//
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);//
        }

        private void 缩小成图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);//
        }


    }
}
