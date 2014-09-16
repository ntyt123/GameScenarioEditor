namespace DialogEditor
{
    partial class 剧本编辑器
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
            this.components = new System.ComponentModel.Container();
            this.TV = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增子节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增同级节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSeleteXML = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnAddSubNode = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.剧情 = new System.Windows.Forms.GroupBox();
            this.Option4 = new System.Windows.Forms.TextBox();
            this.Option3 = new System.Windows.Forms.TextBox();
            this.Option2 = new System.Windows.Forms.TextBox();
            this.Option1 = new System.Windows.Forms.TextBox();
            this.cheakBoxIsOption = new System.Windows.Forms.CheckBox();
            this.txtProfileID = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOption4 = new System.Windows.Forms.ComboBox();
            this.cbOption3 = new System.Windows.Forms.ComboBox();
            this.cbOption2 = new System.Windows.Forms.ComboBox();
            this.cbOption1 = new System.Windows.Forms.ComboBox();
            this.chbOption2 = new System.Windows.Forms.CheckBox();
            this.chbOption4 = new System.Windows.Forms.CheckBox();
            this.chbOption3 = new System.Windows.Forms.CheckBox();
            this.chbOption1 = new System.Windows.Forms.CheckBox();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.剧情.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.ContextMenuStrip = this.contextMenuStrip1;
            this.TV.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TV.LabelEdit = true;
            this.TV.Location = new System.Drawing.Point(0, 36);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(299, 591);
            this.TV.TabIndex = 0;
            this.TV.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TV_AfterLabelEdit);
            this.TV.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.TV_DrawNode);
            this.TV.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TV_BeforeSelect);
            this.TV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_AfterSelect);
            this.TV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TV_NodeMouseClick);
            this.TV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TV_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增子节点ToolStripMenuItem,
            this.新增同级节点ToolStripMenuItem,
            this.删除节点ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // 新增子节点ToolStripMenuItem
            // 
            this.新增子节点ToolStripMenuItem.Name = "新增子节点ToolStripMenuItem";
            this.新增子节点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新增子节点ToolStripMenuItem.Text = "新增子节点";
            this.新增子节点ToolStripMenuItem.Click += new System.EventHandler(this.新增子节点ToolStripMenuItem_Click);
            // 
            // 新增同级节点ToolStripMenuItem
            // 
            this.新增同级节点ToolStripMenuItem.Name = "新增同级节点ToolStripMenuItem";
            this.新增同级节点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新增同级节点ToolStripMenuItem.Text = "新增同级节点";
            this.新增同级节点ToolStripMenuItem.Click += new System.EventHandler(this.新增同级节点ToolStripMenuItem_Click);
            // 
            // 删除节点ToolStripMenuItem
            // 
            this.删除节点ToolStripMenuItem.Name = "删除节点ToolStripMenuItem";
            this.删除节点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除节点ToolStripMenuItem.Text = "删除节点";
            this.删除节点ToolStripMenuItem.Click += new System.EventHandler(this.删除节点ToolStripMenuItem_Click);
            // 
            // btnSeleteXML
            // 
            this.btnSeleteXML.Location = new System.Drawing.Point(429, 12);
            this.btnSeleteXML.Name = "btnSeleteXML";
            this.btnSeleteXML.Size = new System.Drawing.Size(75, 23);
            this.btnSeleteXML.TabIndex = 2;
            this.btnSeleteXML.Text = "选择XML";
            this.btnSeleteXML.UseVisualStyleBackColor = true;
            this.btnSeleteXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteNode);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddNode);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddSubNode);
            this.splitContainer1.Panel1.Controls.Add(this.TV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnNewFile);
            this.splitContainer1.Panel2.Controls.Add(this.btnPreview);
            this.splitContainer1.Panel2.Controls.Add(this.btnQuit);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.剧情);
            this.splitContainer1.Panel2.Controls.Add(this.txtXMLPath);
            this.splitContainer1.Panel2.Controls.Add(this.btnSeleteXML);
            this.splitContainer1.Size = new System.Drawing.Size(897, 627);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Location = new System.Drawing.Point(203, 0);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(96, 37);
            this.btnDeleteNode.TabIndex = 1;
            this.btnDeleteNode.Text = "删除节点";
            this.btnDeleteNode.UseVisualStyleBackColor = true;
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(102, 0);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(96, 37);
            this.btnAddNode.TabIndex = 1;
            this.btnAddNode.Text = "增加同级节点";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnAddSubNode
            // 
            this.btnAddSubNode.Location = new System.Drawing.Point(0, 0);
            this.btnAddSubNode.Name = "btnAddSubNode";
            this.btnAddSubNode.Size = new System.Drawing.Size(96, 37);
            this.btnAddSubNode.TabIndex = 1;
            this.btnAddSubNode.Text = "增加子节点";
            this.btnAddSubNode.UseVisualStyleBackColor = true;
            this.btnAddSubNode.Click += new System.EventHandler(this.btnAddSubNode_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(284, 12);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(111, 23);
            this.btnNewFile.TabIndex = 11;
            this.btnNewFile.Text = "新建空xml文件";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(50, 515);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(465, 515);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // 剧情
            // 
            this.剧情.Controls.Add(this.Option4);
            this.剧情.Controls.Add(this.Option3);
            this.剧情.Controls.Add(this.Option2);
            this.剧情.Controls.Add(this.Option1);
            this.剧情.Controls.Add(this.cheakBoxIsOption);
            this.剧情.Controls.Add(this.txtProfileID);
            this.剧情.Controls.Add(this.txtContent);
            this.剧情.Controls.Add(this.cbPos);
            this.剧情.Controls.Add(this.txtName);
            this.剧情.Controls.Add(this.label12);
            this.剧情.Controls.Add(this.label11);
            this.剧情.Controls.Add(this.label10);
            this.剧情.Controls.Add(this.label9);
            this.剧情.Controls.Add(this.label3);
            this.剧情.Controls.Add(this.label2);
            this.剧情.Controls.Add(this.label4);
            this.剧情.Controls.Add(this.label1);
            this.剧情.Controls.Add(this.groupBox1);
            this.剧情.Location = new System.Drawing.Point(28, 56);
            this.剧情.Name = "剧情";
            this.剧情.Size = new System.Drawing.Size(537, 433);
            this.剧情.TabIndex = 4;
            this.剧情.TabStop = false;
            this.剧情.Text = "剧情";
            // 
            // Option4
            // 
            this.Option4.Enabled = false;
            this.Option4.Location = new System.Drawing.Point(426, 335);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(60, 21);
            this.Option4.TabIndex = 7;
            // 
            // Option3
            // 
            this.Option3.Enabled = false;
            this.Option3.Location = new System.Drawing.Point(292, 335);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(60, 21);
            this.Option3.TabIndex = 7;
            // 
            // Option2
            // 
            this.Option2.Enabled = false;
            this.Option2.Location = new System.Drawing.Point(167, 335);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(60, 21);
            this.Option2.TabIndex = 7;
            // 
            // Option1
            // 
            this.Option1.Enabled = false;
            this.Option1.Location = new System.Drawing.Point(49, 335);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(60, 21);
            this.Option1.TabIndex = 7;
            // 
            // cheakBoxIsOption
            // 
            this.cheakBoxIsOption.AutoSize = true;
            this.cheakBoxIsOption.Location = new System.Drawing.Point(22, 279);
            this.cheakBoxIsOption.Name = "cheakBoxIsOption";
            this.cheakBoxIsOption.Size = new System.Drawing.Size(72, 16);
            this.cheakBoxIsOption.TabIndex = 6;
            this.cheakBoxIsOption.Text = "有否选项";
            this.cheakBoxIsOption.UseVisualStyleBackColor = true;
            this.cheakBoxIsOption.CheckedChanged += new System.EventHandler(this.cheakBoxIsOption_CheckedChanged);
            // 
            // txtProfileID
            // 
            this.txtProfileID.Location = new System.Drawing.Point(302, 28);
            this.txtProfileID.Name = "txtProfileID";
            this.txtProfileID.Size = new System.Drawing.Size(100, 21);
            this.txtProfileID.TabIndex = 4;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(97, 105);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(419, 136);
            this.txtContent.TabIndex = 3;
            // 
            // cbPos
            // 
            this.cbPos.FormattingEnabled = true;
            this.cbPos.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cbPos.Location = new System.Drawing.Point(97, 64);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(121, 20);
            this.cbPos.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "后续步骤";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "后续步骤";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "后续步骤";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "后续步骤";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "对话内容：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "头像方向：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "头像名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "说话人姓名:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOption4);
            this.groupBox1.Controls.Add(this.cbOption3);
            this.groupBox1.Controls.Add(this.cbOption2);
            this.groupBox1.Controls.Add(this.cbOption1);
            this.groupBox1.Controls.Add(this.chbOption2);
            this.groupBox1.Controls.Add(this.chbOption4);
            this.groupBox1.Controls.Add(this.chbOption3);
            this.groupBox1.Controls.Add(this.chbOption1);
            this.groupBox1.Location = new System.Drawing.Point(18, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // cbOption4
            // 
            this.cbOption4.FormattingEnabled = true;
            this.cbOption4.Location = new System.Drawing.Point(408, 135);
            this.cbOption4.Name = "cbOption4";
            this.cbOption4.Size = new System.Drawing.Size(60, 20);
            this.cbOption4.TabIndex = 12;
            // 
            // cbOption3
            // 
            this.cbOption3.FormattingEnabled = true;
            this.cbOption3.Location = new System.Drawing.Point(274, 135);
            this.cbOption3.Name = "cbOption3";
            this.cbOption3.Size = new System.Drawing.Size(60, 20);
            this.cbOption3.TabIndex = 12;
            // 
            // cbOption2
            // 
            this.cbOption2.FormattingEnabled = true;
            this.cbOption2.Location = new System.Drawing.Point(149, 135);
            this.cbOption2.Name = "cbOption2";
            this.cbOption2.Size = new System.Drawing.Size(60, 20);
            this.cbOption2.TabIndex = 12;
            // 
            // cbOption1
            // 
            this.cbOption1.FormattingEnabled = true;
            this.cbOption1.Location = new System.Drawing.Point(31, 135);
            this.cbOption1.Name = "cbOption1";
            this.cbOption1.Size = new System.Drawing.Size(60, 20);
            this.cbOption1.TabIndex = 12;
            // 
            // chbOption2
            // 
            this.chbOption2.AutoSize = true;
            this.chbOption2.Checked = true;
            this.chbOption2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOption2.Location = new System.Drawing.Point(149, 57);
            this.chbOption2.Name = "chbOption2";
            this.chbOption2.Size = new System.Drawing.Size(60, 16);
            this.chbOption2.TabIndex = 0;
            this.chbOption2.Text = "选项二";
            this.chbOption2.UseVisualStyleBackColor = true;
            this.chbOption2.CheckedChanged += new System.EventHandler(this.chbOption2_CheckedChanged);
            // 
            // chbOption4
            // 
            this.chbOption4.AutoSize = true;
            this.chbOption4.Checked = true;
            this.chbOption4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOption4.Location = new System.Drawing.Point(408, 57);
            this.chbOption4.Name = "chbOption4";
            this.chbOption4.Size = new System.Drawing.Size(60, 16);
            this.chbOption4.TabIndex = 0;
            this.chbOption4.Text = "选项四";
            this.chbOption4.UseVisualStyleBackColor = true;
            this.chbOption4.CheckedChanged += new System.EventHandler(this.chbOption4_CheckedChanged);
            // 
            // chbOption3
            // 
            this.chbOption3.AutoSize = true;
            this.chbOption3.Checked = true;
            this.chbOption3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOption3.Location = new System.Drawing.Point(274, 57);
            this.chbOption3.Name = "chbOption3";
            this.chbOption3.Size = new System.Drawing.Size(60, 16);
            this.chbOption3.TabIndex = 0;
            this.chbOption3.Text = "选项三";
            this.chbOption3.UseVisualStyleBackColor = true;
            this.chbOption3.CheckedChanged += new System.EventHandler(this.chbOption3_CheckedChanged);
            // 
            // chbOption1
            // 
            this.chbOption1.AutoSize = true;
            this.chbOption1.Checked = true;
            this.chbOption1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbOption1.Location = new System.Drawing.Point(31, 57);
            this.chbOption1.Name = "chbOption1";
            this.chbOption1.Size = new System.Drawing.Size(60, 16);
            this.chbOption1.TabIndex = 0;
            this.chbOption1.Text = "选项一";
            this.chbOption1.UseVisualStyleBackColor = true;
            this.chbOption1.CheckedChanged += new System.EventHandler(this.chbOption1_CheckedChanged);
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(28, 12);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(61, 21);
            this.txtXMLPath.TabIndex = 3;
            this.txtXMLPath.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML文件(*.xml)|*.xml|All files(*.*)|*.*";
            // 
            // 剧本编辑器
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 627);
            this.Controls.Add(this.splitContainer1);
            this.Name = "剧本编辑器";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "剧本编辑器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.主窗口_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.剧本编辑器_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.剧本编辑器_DragEnter);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.剧情.ResumeLayout(false);
            this.剧情.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TV;
        private System.Windows.Forms.Button btnSeleteXML;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnAddSubNode;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox 剧情;
        private System.Windows.Forms.TextBox Option4;
        private System.Windows.Forms.TextBox Option3;
        private System.Windows.Forms.TextBox Option2;
        private System.Windows.Forms.TextBox Option1;
        private System.Windows.Forms.CheckBox cheakBoxIsOption;
        private System.Windows.Forms.TextBox txtProfileID;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cbPos;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chbOption2;
        private System.Windows.Forms.CheckBox chbOption4;
        private System.Windows.Forms.CheckBox chbOption3;
        private System.Windows.Forms.CheckBox chbOption1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增子节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增同级节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除节点ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbOption1;
        private System.Windows.Forms.ComboBox cbOption4;
        private System.Windows.Forms.ComboBox cbOption3;
        private System.Windows.Forms.ComboBox cbOption2;


    }
}

