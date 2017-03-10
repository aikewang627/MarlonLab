using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MarlonLab.CommonLib;
using MarlonLab.CommonLib.Common;

namespace MarlonLucene
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();


        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            tbFolderPath.Text = @"C:\Users\Administrator\Desktop\临时文件\新建文件夹 (2)";
            tbKeyWord.Text = "C# Java";
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "id";
            col1.Name = "id";
            col1.Width = 50;
            dgvResult.Columns.Add(col1);
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Path";
            col2.Name = "Path";
            col2.Width = 500;
            dgvResult.Columns.Add(col2);

        }
        //select Path
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            dlgFolderSelect.ShowDialog();
            tbFolderPath.Text = dlgFolderSelect.SelectedPath;
        }
        //建立索引
        private void btnAddIndex_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbFolderPath.Text))
            { WinFormControlHelper.AddLog(rtbLog, "目录不存在"); return; }


            string[] lsFileFullName = Directory.GetFiles(tbFolderPath.Text);

            Index.CreateIndex(Index.INDEX_DIR);
            Index.MaxMergeFactor = 301;
            Index.MinMergeDocs = 301;

            for (int i = 0; i < lsFileFullName.Length; i++)
            {

                string strTitle = lsFileFullName[i].Substring(lsFileFullName[i].LastIndexOf(@"\"));
                string strContent = FileHelper.ReadFromFile(lsFileFullName[i]);

                Index.IndexString("", lsFileFullName[i], strTitle, DateTime.Now, strContent);
                if (i % 300 == 0)
                {
                    Index.CloseWithoutOptimize();
                    Index.CreateIndex(Index.INDEX_DIR);
                    Index.MaxMergeFactor = 301;
                    Index.MinMergeDocs = 301;
                }
            }
            Index.Close();

        }
        //搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbKeyWord.Text=="")
            { WinFormControlHelper.AddLog(rtbLog, "请输入关键字"); return; }

            string indexDir = Index.INDEX_DIR;
            int recCount = 0;
            List<IndexItem> lsResult= Index.Search(indexDir, tbKeyWord.Text, 1000, 1, out recCount);
            dgvResult.Rows.Clear();
            for (int i = 0; i < lsResult.Count; i++)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                dgvr.CreateCells(dgvResult);
                dgvr.Cells[0].Value =i.ToString();
                dgvr.Cells[1].Value = lsResult[i].Url;
                dgvResult.Rows.Add(dgvr);
            }


        }


        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          rtbResult.Text = FileHelper.ReadFromFile(dgvResult.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
