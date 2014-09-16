using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using TreeExXML;
using MessageBox = System.Windows.Forms.MessageBox;

namespace DialogEditor
{
    [Serializable]
    public partial class 剧本编辑器 : Form 
    {
        public 剧本编辑器()
        {
            InitializeComponent();
        }
        public delegate void MyMethod();
        [Serializable]
        public class AttType
        {
            public string Type = "Default";
            public string Tag = "Default";
            public int ChapterID = 0;
            public int LevelID = 0;
            public int DifficultyID = 0;
            public int ActorID = 0;
            public int BattleID = 0;
            public int PointIndex = 0;
            public string SpeakerProfile = "Default";
            public string Pos = "Default";
            public string SpeakerName = "Default";
            public string Content = "Default";
            public bool IsOption = false;
            public string OptionName1 = null;
            public string OptionAction1 = null;
            public string OptionName2 = null;
            public string OptionAction2 = null;
            public string OptionName3 = null;
            public string OptionAction3 = null;
            public string OptionName4 = null;
            public string OptionAction4 = null;
            public int ScenesID = 0;
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            TV.HideSelection = false;
            TV.DrawMode = TreeViewDrawMode.OwnerDrawText;
           
        }
        private void btnLoadXML_Click(object sender, EventArgs e)
        {
          
            //try
            //{
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtXMLPath.Text = "";
                    txtXMLPath.Text = this.openFileDialog1.FileName;
                    LoadXML(txtXMLPath.Text);
                    MessageBox.Show("读取成功！");
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("这个不是有效的剧本文件！想要获取标准的剧本文件，请点击“新建XML文件”按钮！");
            //}
        }
        private void LoadXML(object path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load((string)path);
            TV.BeginUpdate();
           TV.Nodes.Clear();
            TreeNode tn = new TreeNode(xDoc.DocumentElement.Name);
            AttType at = SaveNodeToTag(xDoc.DocumentElement);
            tn.Tag = at;
            
            TV.Nodes.Add(tn);

            addTreeNode(xDoc.DocumentElement, TV.Nodes[0]);
            TV.EndUpdate();
        }
        private AttType SaveNodeToTag(XmlNode xmlnode)
        {
            AttType a = new AttType();
            a.ActorID = xmlnode.Attributes["E"]==null?0:int.Parse(xmlnode.Attributes["E"].Value.Substring(8,2));
            a.BattleID = xmlnode.Attributes["E"]==null?0:int.Parse(xmlnode.Attributes["E"].Value.Substring(10,2));
            a.ChapterID =xmlnode.Attributes["E"]==null?0: int.Parse(xmlnode.Attributes["E"].Value.Substring(2,2));
            a.Content = xmlnode.Attributes["D"] == null ? "" : xmlnode.Attributes["D"].Value;
            a.DifficultyID =xmlnode.Attributes["E"]==null?0: int.Parse(xmlnode.Attributes["E"].Value.Substring(6,2));
            a.IsOption = xmlnode.Attributes["E"] == null ? false : (xmlnode.Attributes["E"].Value.Substring(15,1) == "1" ? true : false);
            a.LevelID =xmlnode.Attributes["E"]==null?0: int.Parse(xmlnode.Attributes["E"].Value.Substring(4,2));
            a.OptionAction1 = xmlnode.Attributes["G"] == null ? "0" : xmlnode.Attributes["G"].Value;
            a.OptionName1 = xmlnode.Attributes["F"] == null ? "" : xmlnode.Attributes["F"].Value;
            a.OptionAction2 = xmlnode.Attributes["I"] == null ? "0" : xmlnode.Attributes["I"].Value;
            a.OptionName2 = xmlnode.Attributes["H"] == null ? "" : xmlnode.Attributes["H"].Value;
            a.OptionAction3 = xmlnode.Attributes["K"] == null ? "0" : xmlnode.Attributes["K"].Value;
            a.OptionName3 = xmlnode.Attributes["J"] == null ? "" : xmlnode.Attributes["J"].Value;
            a.OptionAction4 = xmlnode.Attributes["M"] == null ? "0" : xmlnode.Attributes["M"].Value;
            a.OptionName4 = xmlnode.Attributes["L"] == null ? "" : xmlnode.Attributes["L"].Value;
            a.PointIndex = xmlnode.Attributes["e"]==null?0:int.Parse(xmlnode.Attributes["e"].Value.Substring(12,2));
            a.Pos = xmlnode.Attributes["E"] == null ? "" : xmlnode.Attributes["E"].Value.Substring(14,1)=="1"?"Left":"Right";
            a.SpeakerName = xmlnode.Attributes["C"] == null ? "" : xmlnode.Attributes["C"].Value;
            a.SpeakerProfile = xmlnode.Attributes["N"] == null ? "" : xmlnode.Attributes["N"].Value;
            a.Tag = xmlnode.Attributes["B"] == null ? "" : xmlnode.Attributes["B"].Value;
            a.Type = xmlnode.Attributes["A"] == null ? "" : xmlnode.Attributes["A"].Value;
            a.ScenesID =xmlnode.Attributes["E"]==null?0: int.Parse(xmlnode.Attributes["E"].Value.Substring(0,2));
            return a;
        }

        private void addTreeNode(XmlNode xmlNode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList xNodeList;
            if (xmlNode.HasChildNodes)
            {
                xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                {
                    xNode = xmlNode.ChildNodes[x];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = treeNode.Nodes[x];
                    addTreeNode(xNode, tNode);
                    if (xmlNode.Name != "Root")
                    {
                        if (xmlNode.Attributes["B"] != null)
                        {
                            treeNode.Text = xmlNode.Attributes["B"].Value.Trim();
                        }
                        else{
                            treeNode.Text = xmlNode.Name.Trim();
                        }
                        treeNode.Tag = SaveNodeToTag(xmlNode);
                        
                    }
                }
            }
            else
            {
                if (xmlNode.Attributes["B"] != null)
                {
                    treeNode.Text = xmlNode.Attributes["B"].Value.Trim();
                }
                else
                {
                    treeNode.Text = xmlNode.Name.Trim();
                }
                treeNode.Tag = SaveNodeToTag(xmlNode);
               
            }
        }

        public AttType at = null;
        private void TV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //AttType a = TV.SelectedNode.Tag as AttType;
            //MessageBox.Show(a.Tag + "" + a.Type);

            List<string> OptionList1 = new List<string>();
            List<string> OptionList2 = new List<string>();
            List<string> OptionList3 = new List<string>();
            List<string> OptionList4 = new List<string>();
            try
            {
                TreeNodeCollection nodes = TV.SelectedNode.Parent.Nodes;
                foreach (ICloneable node in nodes)
                {
                    TreeNode t = (TreeNode) node.Clone();
                    OptionList1.Add(t.Text);
                    OptionList2.Add(t.Text);
                    OptionList3.Add(t.Text);
                    OptionList4.Add(t.Text);
                }
                cbOption1.DataSource = OptionList1;
                cbOption2.DataSource = OptionList2;
                cbOption3.DataSource = OptionList3;
                cbOption4.DataSource = OptionList4;
            }
            catch (Exception)
            {
            }
           
            try
            {
                at = TV.SelectedNode.Tag as AttType;
                if (at.Type == "Dialog")
                {
                    txtName.Text = at.SpeakerName.Trim();
                    txtProfileID.Text = at.SpeakerProfile.Trim();
                    if (at.Pos.Trim() == "Left")
                    {
                        cbPos.SelectedIndex = 0;
                    }
                    else
                    {
                        cbPos.SelectedIndex = 1;
                    }
                    txtContent.Text = at.Content.Trim();
                    if (at.IsOption)
                    {
                        cheakBoxIsOption.Checked = true;
                        Option1.Text = at.OptionName1 == null ? "" : at.OptionName1.Trim();
                        Option2.Text = at.OptionName2 == null ? "" : at.OptionName2.Trim();
                        Option3.Text = at.OptionName3 == null ? "" : at.OptionName3.Trim();
                        Option4.Text = at.OptionName4 == null ? "" : at.OptionName4.Trim();
                        cbOption1.SelectedIndex =at.OptionAction1==null?0: int.Parse(at.OptionAction1);
                        cbOption2.SelectedIndex = at.OptionAction2 == null ? 0 : int.Parse(at.OptionAction2);
                        cbOption3.SelectedIndex = at.OptionAction3 == null ? 0 : int.Parse(at.OptionAction3);
                        cbOption4.SelectedIndex = at.OptionAction4 == null ? 0 : int.Parse(at.OptionAction4);
                        if (!string.IsNullOrEmpty(at.OptionName1))
                        {
                            chbOption1.Checked = true;
                        }
                        else
                        {
                            chbOption1.Checked = false;

                        }
                        if (!string.IsNullOrEmpty(at.OptionName2))
                        {
                            chbOption2.Checked = true;
                        }
                        else
                        {
                            chbOption2.Checked = false;

                        }
                        if (!string.IsNullOrEmpty(at.OptionName3))
                        {
                            chbOption3.Checked = true;
                        }
                        else
                        {
                            chbOption3.Checked = false;

                        }
                        if (!string.IsNullOrEmpty(at.OptionName4))
                        {
                            chbOption4.Checked = true;
                        }
                        else
                        {
                            chbOption4.Checked = false;

                        }
                        if (string.IsNullOrEmpty(Option1.Text))
                        {
                            Option1.Enabled = false;
                            cbOption1.Enabled = false;
                        }
                        else
                        {
                            Option1.Enabled = true;
                            cbOption1.Enabled = true;
                        }
                        if (string.IsNullOrEmpty(Option2.Text))
                        {
                            Option2.Enabled = false;
                            cbOption2.Enabled = false;
                        }
                        else
                        {
                            Option2.Enabled = true;
                            cbOption2.Enabled = true;
                        }
                        if (string.IsNullOrEmpty(Option3.Text))
                        {
                            Option3.Enabled = false;
                            cbOption3.Enabled = false;
                        }
                        else
                        {
                            Option3.Enabled = true;
                            cbOption3.Enabled = true;
                        }
                        if (string.IsNullOrEmpty(Option4.Text))
                        {
                            Option4.Enabled = false;
                            cbOption4.Enabled = false;
                        }
                        else
                        {
                            Option4.Enabled = true;
                            cbOption4.Enabled = true;
                        }
                    }
                    else
                    {
                        cheakBoxIsOption.Checked = false;
                        Option1.Text = null;
                        Option2.Text = null;
                        Option3.Text = null;
                        Option4.Text = null;
                        cbOption1.SelectedIndex = 0;
                        cbOption2.SelectedIndex = 0;
                        cbOption3.SelectedIndex = 0;
                        cbOption4.SelectedIndex = 0;
                    }
                }





            }
            catch (Exception)
            {
                return;

            }
            if (at.Type == "Point")
            {
                btnPreview.Enabled = true;

            }
            else
            {
                btnPreview.Enabled = false;

            }

                //AttType xxx = TV.SelectedNode.Tag as AttType;
                //MessageBox.Show(xxx.Tag + ";" + xxx.Type);
          
        }

        private void btnAddSubNode_Click(object sender, EventArgs e)
        {

            if (TV.SelectedNode != null)
            {

                string SelectType = "";
                try
                {
                    SelectType = (TV.SelectedNode.Tag as AttType).Type;
                }
                catch (Exception)
                {
                    SelectType = "Root";

                }
                string CurrentType = "";
                TreeNode tr = null;


                switch (SelectType)
                {
                    case "Root":
                        CurrentType = "Scenes";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.Tag = tr.Text;
                        at.ScenesID = TV.Nodes[0].Nodes.Count;

                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    case "Scenes":
                        CurrentType = "Chapter";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.ChapterID = TV.SelectedNode.Nodes.Count;
                        at.Tag = tr.Text;
                        at.ScenesID = (TV.SelectedNode.Tag as AttType).ScenesID;
                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    case "Chapter":
                        CurrentType = "Level";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.LevelID = TV.SelectedNode.Nodes.Count;
                        at.Tag = tr.Text;
                        at.ScenesID = (TV.SelectedNode.Tag as AttType).ScenesID;
                        at.ChapterID = (TV.SelectedNode.Tag as AttType).ChapterID;
                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    case "Level":
                        CurrentType = "Difficulty";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.DifficultyID = TV.SelectedNode.Nodes.Count;
                        at.Tag = tr.Text;
                        at.ScenesID = (TV.SelectedNode.Tag as AttType).ScenesID;
                        at.ChapterID = (TV.SelectedNode.Tag as AttType).ChapterID;
                        at.LevelID = (TV.SelectedNode.Tag as AttType).LevelID;
                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    case "Difficulty":
                        CurrentType = "Actor";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.ActorID = TV.SelectedNode.Nodes.Count;
                        at.Tag = tr.Text;
                        at.ScenesID = (TV.SelectedNode.Tag as AttType).ScenesID;
                        at.ChapterID = (TV.SelectedNode.Tag as AttType).ChapterID;
                        at.LevelID = (TV.SelectedNode.Tag as AttType).LevelID;
                        at.DifficultyID = (TV.SelectedNode.Tag as AttType).DifficultyID;
                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    case "Actor":
                        CurrentType = "Battle";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.BattleID = TV.SelectedNode.Nodes.Count;
                        at.Tag = tr.Text;
                        at.ScenesID = (TV.SelectedNode.Tag as AttType).ScenesID;
                        at.ChapterID = (TV.SelectedNode.Tag as AttType).ChapterID;
                        at.LevelID = (TV.SelectedNode.Tag as AttType).LevelID;
                        at.DifficultyID = (TV.SelectedNode.Tag as AttType).DifficultyID;
                        at.ActorID = (TV.SelectedNode.Tag as AttType).DifficultyID;
                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    case "Battle":
                        CurrentType = "Point";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.PointIndex = TV.SelectedNode.Nodes.Count;
                        at.Tag = tr.Text;
                        at.ScenesID = (TV.SelectedNode.Tag as AttType).ScenesID;
                        at.ChapterID = (TV.SelectedNode.Tag as AttType).ChapterID;
                        at.LevelID = (TV.SelectedNode.Tag as AttType).LevelID;
                        at.DifficultyID = (TV.SelectedNode.Tag as AttType).DifficultyID;
                        at.ActorID = (TV.SelectedNode.Tag as AttType).DifficultyID;
                        at.BattleID = (TV.SelectedNode.Tag as AttType).BattleID;
                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    case "Point":
                        CurrentType = "Dialog";
                        tr = new TreeNode();
                        tr.Text = "new" + CurrentType;
                        at = new AttType();
                        at.Type = CurrentType;
                        at.Tag = tr.Text;
                        at.ScenesID = (TV.SelectedNode.Tag as AttType).ScenesID;
                        at.ChapterID = (TV.SelectedNode.Tag as AttType).ChapterID;
                        at.LevelID = (TV.SelectedNode.Tag as AttType).LevelID;
                        at.DifficultyID = (TV.SelectedNode.Tag as AttType).DifficultyID;
                        at.ActorID = (TV.SelectedNode.Tag as AttType).DifficultyID;
                        at.BattleID = (TV.SelectedNode.Tag as AttType).BattleID;
                        at.PointIndex = (TV.SelectedNode.Tag as AttType).PointIndex;
                        tr.Tag = at;
                        TV.SelectedNode.Nodes.Add(tr);
                        break;
                    default: break;
                }
                TV.SelectedNode.Expand();
            }
        }


        
        /// <summary>
        /// 单击节点时，保存修改项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }



        private void chbOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (cheakBoxIsOption.Checked)
            {
                if (chbOption1.Checked)
                {
                    Option1.Enabled = true;
                    cbOption1.Enabled = true;
                }
                else
                {

                    Option1.Enabled = false;
                    cbOption1.Enabled = false;
                }
            }
        }

        private void chbOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (cheakBoxIsOption.Checked)
            {
                if (chbOption2.Checked)
                {
                    Option2.Enabled = true;
                    cbOption2.Enabled = true;
                }
                else
                {

                    Option2.Enabled = false;
                    cbOption2.Enabled = false;
                }
            }
        }

        private void chbOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (cheakBoxIsOption.Checked)
            {
                if (chbOption3.Checked)
                {
                    Option3.Enabled = true;
                    cbOption3.Enabled = true;
                }
                else
                {

                    Option3.Enabled = false;
                    cbOption3.Enabled = false;
                }
            }
        }

        private void chbOption4_CheckedChanged(object sender, EventArgs e)
        {
            if (cheakBoxIsOption.Checked)
            {
                if (chbOption4.Checked)
                {
                    Option4.Enabled = true;
                    cbOption4.Enabled = true;
                }
                else
                {

                    Option4.Enabled = false;
                    cbOption4.Enabled = false;
                }
            }
        }

        private void cheakBoxIsOption_CheckedChanged(object sender, EventArgs e)
        {
            if (cheakBoxIsOption.Checked)
            {

                Option1.Enabled = true;
                cbOption1.Enabled = true;
                Option2.Enabled = true;
                cbOption2.Enabled = true;
                Option3.Enabled = true;
                cbOption3.Enabled = true;
                Option4.Enabled = true;
                cbOption4.Enabled = true;
            }
            else
            {
                Option1.Enabled = false;
                cbOption1.Enabled = false;
                Option2.Enabled = false;
                cbOption2.Enabled = false;
                Option3.Enabled = false;
                cbOption3.Enabled = false;
                Option4.Enabled = false;
                cbOption4.Enabled = false;

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.DialogResult result = MessageBox.Show("是否保存？", "保存", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SaveXML();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                TV.SelectedNode.Remove();

            }

            else
            {
                return;
            }
        }

        private void TV_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            TreeNode tn = TV.SelectedNode;
            AttType att = TV.SelectedNode.Tag as AttType;
            try
            {
                att.Tag = e.Label.Trim();

            }
            catch (Exception)
            {
            }
            tn.Tag = att;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AttType a = TV.SelectedNode.Tag as AttType;
                a.IsOption = cheakBoxIsOption.Checked;
                a.Content = txtContent.Text;
                a.OptionAction1 = cbOption1.SelectedIndex.ToString();
                a.OptionName1 = Option1.Text;
                a.OptionAction2 = cbOption2.SelectedIndex.ToString();
                a.OptionName2 = Option2.Text;
                a.OptionAction3 = cbOption3.SelectedIndex.ToString();
                a.OptionName3 = Option3.Text;
                a.OptionAction4 = cbOption4.SelectedIndex.ToString();
                a.OptionName4 = Option4.Text;
                a.Pos = cbPos.SelectedIndex == 0 ? "Left" : "Right";
                a.SpeakerName = txtName.Text;
                a.SpeakerProfile = txtProfileID.Text;
                TV.SelectedNode.Tag = a;
                SaveXML();
            }
            catch (Exception)
            {
                SaveXML();

            }
           
        }

        public void SaveXML()
        {

            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            string path = txtXMLPath.Text;
            TreeExXML.TreeExXMLCls tex = new TreeExXMLCls();
            try
            {
                tex.TreeToXML(TV, path);
                MessageBox.Show("保存成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败！");

            }

        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "XML文件(*.xml)|*.xml|All files(*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(sf.FileName);
                streamWriter.WriteLine("<?xml version=\"1.0\"?>");
                streamWriter.WriteLine("<Root A=\"Root\" B=\"Root\" Info=\"\" N=\"Default\"  C=\"Default\" D=\"Default\"  F=\"Default\" G=\"Default\" H=\"Default\" I=\"Default\" J=\"Default\" K=\"Default\" L=\"Default\" M=\"Default\">");
                streamWriter.WriteLine("</Root>");
                streamWriter.Close();
                MessageBox.Show("生成成功！自动加载！");
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(sf.FileName);
                TV.Nodes.Clear();
                TreeNode tn = new TreeNode(xDoc.DocumentElement.Name);
                AttType at = SaveNodeToTag(xDoc.DocumentElement);

                tn.Tag = at;
                TV.Nodes.Add(tn);

                TreeNode tNode = new TreeNode();
                tNode = (TreeNode)TV.Nodes[0];

                addTreeNode(xDoc.DocumentElement, tNode);
                txtXMLPath.Text = sf.FileName;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            预览 f = new 预览(TV.SelectedNode);
            f.Show();
        }

        private void 主窗口_Click(object sender, EventArgs e)
        {

        }

        private void TV_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                at = TV.SelectedNode.Tag as AttType;

                if (at != null && at.Type == "Dialog")
                {
                    at.SpeakerName = txtName.Text.Trim();
                    at.SpeakerProfile = txtProfileID.Text.Trim();
                    if (cbPos.SelectedIndex == 0)
                    {
                        at.Pos = "Left";
                    }
                    else
                    {
                        at.Pos = "Right";
                    }
                    at.Content = txtContent.Text.Trim();
                    if (cheakBoxIsOption.Checked)
                    {
                        at.IsOption = true;
                        if (chbOption1.Checked)
                        {
                            at.OptionName1 = Option1.Text.Trim();
                            at.OptionAction1 =cbOption1.SelectedIndex.ToString();

                        }
                        else
                        {
                            at.OptionName1 = null;
                            at.OptionAction1 = null;
                        }
                        if (chbOption2.Checked)
                        {
                            at.OptionName2 = Option2.Text.Trim();
                            at.OptionAction2 = cbOption2.SelectedIndex.ToString();
                        }
                        else
                        {
                            at.OptionName2 = null;
                            at.OptionAction2 = null;
                        }
                        if (chbOption3.Checked)
                        {
                            at.OptionName3 = Option3.Text.Trim();
                            at.OptionAction3 = cbOption3.SelectedIndex.ToString();
                        }
                        else
                        {
                            at.OptionName3 = null;
                            at.OptionAction3 = null;
                        }
                        if (chbOption4.Checked)
                        {
                            at.OptionName4 = Option4.Text.Trim();
                            at.OptionAction4 =cbOption4.SelectedIndex.ToString();
                        }
                        else
                        {
                            at.OptionName4 = null;
                            at.OptionAction4 = null;
                        }
                    }
                    else
                    {
                        at.IsOption = false;
                        at.OptionName1 = null;
                        at.OptionAction1 = null;
                        at.OptionName2 = null;
                        at.OptionAction2 = null;
                        at.OptionName3 = null;
                        at.OptionAction3 = null;
                        at.OptionName4 = null;
                        at.OptionAction4 = null;
                    }
                    try
                    {
                        at.Tag = (TV.SelectedNode.Tag as AttType).Tag;
                    }
                    catch (Exception)
                    {
                        at.Tag = at.Tag;
                    }

                }
            }
            catch (Exception)
            {
                
            }

        }

        private void 剧本编辑器_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            try
            {

                string DropPath = ((System.Array)e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop)).GetValue(0).ToString();
                txtXMLPath.Text = DropPath;
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(txtXMLPath.Text);
                TV.Nodes.Clear();
                TreeNode tn = new TreeNode(xDoc.DocumentElement.Name);
                AttType at = SaveNodeToTag(xDoc.DocumentElement);

                tn.Tag = at;
                TV.Nodes.Add(tn);

                TreeNode tNode = new TreeNode();
                tNode = (TreeNode)TV.Nodes[0];

                addTreeNode(xDoc.DocumentElement, tNode);
                //TV.ExpandAll();
                MessageBox.Show("加载成功！");


            }
            catch (Exception)
            {
                MessageBox.Show("这个不是有效的剧本文件！想要获取标准的剧本文件，请点击“新建XML文件”按钮！");

            }
        }


        private void 剧本编辑器_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
            {
                e.Effect = System.Windows.Forms.DragDropEffects.Link;

            }
            else
            {
                e.Effect = System.Windows.Forms.DragDropEffects.None;

            }
        }



        private void TV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                TV.SelectedNode.BeginEdit();

            }
        }

        private void TV_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.Node.Bounds);
            if (e.State == TreeNodeStates.Selected)//选中的失去焦点的节点
            {
                e.Graphics.FillRectangle(Brushes.DodgerBlue, new Rectangle(e.Node.Bounds.Left, e.Node.Bounds.Top, e.Node.Bounds.Width, e.Node.Bounds.Height)); //黑色背景               
                e.Graphics.DrawString(e.Node.Text, TV.Font, Brushes.White, e.Bounds);//白字           
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            TreeNode tn =new TreeNode();
            Object a = TV.SelectedNode.Tag;
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter=new BinaryFormatter();
                formatter.Serialize(objectStream,TV.SelectedNode.Clone());
                objectStream.Seek(0, SeekOrigin.Begin);
              tn= formatter.Deserialize(objectStream) as TreeNode;
            }
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream,a);
                objectStream.Seek(0, SeekOrigin.Begin);
                a = formatter.Deserialize(objectStream);
            }
            tn.Tag = a;
            TV.SelectedNode.Parent.Nodes.Insert(TV.SelectedNode.Index+1,tn);
        }

        private void 新增子节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddSubNode_Click(sender,e);
        }

        private void 新增同级节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNode_Click(sender,e);
        }

        private void 删除节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteNode_Click(sender,e);
        }



      
          
      
    }

}
