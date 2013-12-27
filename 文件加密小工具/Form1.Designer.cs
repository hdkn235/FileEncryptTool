namespace 文件加密小工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecipher = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbltotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectCount = new System.Windows.Forms.Label();
            this.btnDelSelectItem = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(347, 41);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(90, 29);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "添加文件夹";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(347, 98);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(90, 29);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "添加文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(125, 335);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(90, 29);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecipher
            // 
            this.btnDecipher.Location = new System.Drawing.Point(230, 335);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(90, 29);
            this.btnDecipher.TabIndex = 4;
            this.btnDecipher.Text = "解密";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.CheckOnClick = true;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.HorizontalScrollbar = true;
            this.lbFiles.Location = new System.Drawing.Point(51, 30);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(284, 260);
            this.lbFiles.Sorted = true;
            this.lbFiles.TabIndex = 5;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(347, 150);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(90, 29);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Tag = "1";
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(347, 204);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(90, 29);
            this.btnClearList.TabIndex = 7;
            this.btnClearList.Text = "清空列表";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(49, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 12);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "总计：";
            // 
            // lbltotalCount
            // 
            this.lbltotalCount.AutoSize = true;
            this.lbltotalCount.Location = new System.Drawing.Point(96, 302);
            this.lbltotalCount.Name = "lbltotalCount";
            this.lbltotalCount.Size = new System.Drawing.Size(29, 12);
            this.lbltotalCount.TabIndex = 9;
            this.lbltotalCount.Text = "0 个";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "已选择：";
            // 
            // lblSelectCount
            // 
            this.lblSelectCount.AutoSize = true;
            this.lblSelectCount.Location = new System.Drawing.Point(185, 302);
            this.lblSelectCount.Name = "lblSelectCount";
            this.lblSelectCount.Size = new System.Drawing.Size(29, 12);
            this.lblSelectCount.TabIndex = 11;
            this.lblSelectCount.Text = "0 个";
            // 
            // btnDelSelectItem
            // 
            this.btnDelSelectItem.Location = new System.Drawing.Point(347, 253);
            this.btnDelSelectItem.Name = "btnDelSelectItem";
            this.btnDelSelectItem.Size = new System.Drawing.Size(90, 29);
            this.btnDelSelectItem.TabIndex = 12;
            this.btnDelSelectItem.Text = "删除选中文件";
            this.btnDelSelectItem.UseVisualStyleBackColor = true;
            this.btnDelSelectItem.Click += new System.EventHandler(this.btnDelSelectItem_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(449, 387);
            this.Controls.Add(this.btnDelSelectItem);
            this.Controls.Add(this.lblSelectCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotalCount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.btnDecipher);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件加密小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecipher;
        private System.Windows.Forms.CheckedListBox lbFiles;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbltotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectCount;
        private System.Windows.Forms.Button btnDelSelectItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

