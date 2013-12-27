using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 文件加密小工具
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            skinEngine1.SkinFile = "Calmness.ssk";
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
            string floderPath = fbd.SelectedPath;
            GetFilesName(Directory.GetFiles(floderPath));
            TotalCount();
        }

        private void GetFilesName(string[] filesPath)
        {
            string fileName = "";
            foreach (string filePath in filesPath)
            {
                fileName = Path.GetFileName(filePath);
                if (!dic.ContainsKey(fileName))
                {
                    lbFiles.Items.Add(fileName);
                    dic.Add(fileName, filePath);
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
            GetFilesName(ofd.FileNames);
            TotalCount();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            btnEncrypt.Text = "加密中";
            btnEncrypt.Enabled = false;
            if (lbFiles.Items.Count <= 0)
            {
                MessageBox.Show(this, "请选择要加密的文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            List<string> selectPaths = new List<string>();
            foreach (var item in lbFiles.CheckedItems)
            {
                selectPaths.Add(item.ToString());
            }

            foreach (string path in selectPaths)
            {
                Encrypt(dic[path]);
            }
            MessageBox.Show(this, "加密完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            btnEncrypt.Text = "解密中";
            btnEncrypt.Enabled = true;
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="path"></param>
        public void Encrypt(string srcPath)
        {
            string decPath = srcPath + "temp";
            using (FileStream srcFs = File.OpenRead(srcPath))
            {
                using (FileStream decFs = File.OpenWrite(decPath))
                {
                    CopyStream(srcFs, decFs, 1024 * 1024, 1);
                }
            }
            File.Delete(srcPath);
            File.Move(decPath, srcPath);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="srcPath"></param>
        public void Decipher(string srcPath)
        {
            string decPath = srcPath + "temp";
            using (FileStream srcFs = File.OpenRead(srcPath))
            {
                using (FileStream decFs = File.OpenWrite(decPath))
                {
                    CopyStream(srcFs, decFs, 1024 * 1024, -1);
                }
            }
            File.Delete(srcPath);
            File.Move(decPath, srcPath);
        }
        /// <summary>
        /// 加解密算法
        /// </summary>
        /// <param name="srcFs"></param>
        /// <param name="decFs"></param>
        /// <param name="bufferSize"></param>
        /// <param name="t"></param>
        public void CopyStream(FileStream srcFs, FileStream decFs, int bufferSize, int t)
        {
            byte[] buffer = new byte[bufferSize];
            int n;
            while ((n = srcFs.Read(buffer, 0, bufferSize)) > 0)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] += (byte)t;
                }
                decFs.Write(buffer, 0, n);
                decFs.Position = srcFs.Position;
            }
        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
            btnDecipher.Text = "解密中";
            btnDecipher.Enabled = false;
            if (lbFiles.Items.Count <= 0)
            {
                MessageBox.Show(this, "请选择要解密的文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            List<string> selectPaths = new List<string>();
            foreach (var item in lbFiles.CheckedItems)
            {
                selectPaths.Add(item.ToString());
            }

            foreach (string path in selectPaths)
            {
                Decipher(dic[path]);
            }
            MessageBox.Show(this, "解密完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            btnDecipher.Text = "解密";
            btnDecipher.Enabled = true;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (lbFiles.Items.Count <= 0) return;
            bool flag = btnSelectAll.Tag.ToString() == "1" ? true : false;
            for (int i = 0; i < lbFiles.Items.Count; i++)
            {
                lbFiles.SetItemChecked(i, flag);
            }
            btnSelectAll.Tag = btnSelectAll.Tag.ToString() == "1" ? "0" : "1";
            SelectCount();
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            dic.Clear();
            btnSelectAll.Tag = "1";
            TotalCount();
            SelectCount();
        }

        public void TotalCount()
        {
            lbltotalCount.Text = lbFiles.Items.Count.ToString() + " 个";
        }

        public void SelectCount()
        {
            lblSelectCount.Text = lbFiles.CheckedItems.Count + " 个";
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCount();
        }

        private void btnDelSelectItem_Click(object sender, EventArgs e)
        {
            if (lbFiles.CheckedItems.Count <= 0) return;
            string[] s = new string[lbFiles.CheckedItems.Count];
            int i = 0;
            foreach (var item in lbFiles.CheckedItems)
            {
                s[i] = item.ToString();
                i++;
            }
            for (int j = 0; j < s.Length; j++)
            {
                lbFiles.Items.Remove(s[j]);
                dic.Remove(s[j]);
            }

        }
    }
}
