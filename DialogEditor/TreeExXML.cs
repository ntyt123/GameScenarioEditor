using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DialogEditor;


namespace TreeExXML
{
    class TreeExXMLCls
    {
        private TreeView thetreeview;
        private string xmlfilepath;
        XmlTextWriter textWriter;
        XmlNode Xmlroot;
        XmlDocument textdoc;

        public TreeExXMLCls()
        {
            //----构造函数
            textdoc = new XmlDocument();

        }

        ~TreeExXMLCls()
        {
            //----析构函数

        }

        #region 遍历treeview并实现向XML的转化
        /// <summary>   
        /// 遍历treeview并实现向XML的转化
        /// </summary>   
        /// <param name="TheTreeView">树控件对象</param>   
        /// <param name="XMLFilePath">XML输出路径</param>   
        /// <returns>0表示函数顺利执行</returns>   

        public int TreeToXML(TreeView TheTreeView, string XMLFilePath)
        {
            //-------初始化转换环境变量
            thetreeview = TheTreeView;
            xmlfilepath = XMLFilePath;
            textWriter = new XmlTextWriter(xmlfilepath, null);

            //-------创建XML写操作对象
            textWriter.Formatting = Formatting.Indented;

            //-------开始写过程，调用WriteStartDocument方法
            textWriter.WriteStartDocument();



            ////-------添加第一个根节点
            textWriter.WriteStartElement((thetreeview.Nodes[0].Tag as 剧本编辑器.AttType).Type);



            剧本编辑器.AttType attType = new 剧本编辑器.AttType();

            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
            {"A","Root"},{"B","Root"},
            {"E","0000000000000000"},{"N","Default"},
            {"C","Default"},
            {"D","Default"},
            {"F","Default"},{"G","0"},
            {"H","Default"},{"I","0"},
            {"J","Default"},{"K","0"},
            {"L","Default"},{"M","0"}
            
            };

            foreach (KeyValuePair<string, string> pair in dic)
            {
                textWriter.WriteStartAttribute(pair.Key);
                textWriter.WriteString(pair.Value);
                textWriter.WriteEndAttribute();
            }











            textWriter.WriteEndElement();

            //------ 写文档结束，调用WriteEndDocument方法
            textWriter.WriteEndDocument();

            //-----关闭输入流
            textWriter.Close();

            //-------创建XMLDocument对象
            textdoc.Load(xmlfilepath);

            //------选中根节点
            XmlElement Xmlnode = textdoc.CreateElement(thetreeview.Nodes[0].Text);
            Xmlroot = textdoc.SelectSingleNode((thetreeview.Nodes[0].Tag as 剧本编辑器.AttType).Type);

            //------遍历原treeview控件，并生成相应的XML
            TransTreeSav(thetreeview.Nodes[0].Nodes, (XmlElement)Xmlroot);

             textdoc.Save(xmlfilepath);

            return 0;
        }

        private int TransTreeSav(TreeNodeCollection nodes, XmlElement ParXmlnode)
        {

            //-------遍历树的各个故障节点，同时添加节点至XML
            XmlElement xmlnode;
            //string nodeName = (thetreeview.Nodes[0].Tag as 剧本编辑器.AttType).Type;
            //if (nodeName == "Dialog")
            //{
            Xmlroot = textdoc.SelectSingleNode((thetreeview.Nodes[0].Tag as 剧本编辑器.AttType).Type);
            剧本编辑器.AttType att = new 剧本编辑器.AttType();
            foreach (TreeNode node in nodes)
            {
                xmlnode = textdoc.CreateElement((node.Tag as 剧本编辑器.AttType).Type);


                att = node.Tag as 剧本编辑器.AttType;

                if (xmlnode.Name == "Dialog")
                {

                    att.ScenesID = node.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Index;
                    att.ChapterID = node.Parent.Parent.Parent.Parent.Parent.Parent.Index;
                    att.LevelID = node.Parent.Parent.Parent.Parent.Parent.Index;
                    att.DifficultyID = node.Parent.Parent.Parent.Parent.Index;
                    att.ActorID = node.Parent.Parent.Parent.Index;
                    att.BattleID = node.Parent.Parent.Index;
                    att.PointIndex = node.Parent.Index;
                    string Info = att.ScenesID < 10 ? "0" + att.ScenesID : att.ScenesID.ToString();
                    Info += att.ChapterID < 10 ? "0" + att.ChapterID : att.ChapterID.ToString();
                    Info += att.LevelID < 10 ? "0" + att.LevelID : att.LevelID.ToString();
                    Info += att.DifficultyID < 10 ? "0" + att.DifficultyID : att.DifficultyID.ToString();
                    Info += att.ActorID < 10 ? "0" + att.ActorID : att.ActorID.ToString();
                    Info += att.BattleID <10 ? "0" + att.BattleID : att.BattleID.ToString();
                    Info += att.PointIndex <10 ? "0" + att.PointIndex : att.PointIndex.ToString();
                    Info += att.Pos == "Left" ? "1" : "0";
                    Info += att.IsOption ? "1" : "0";

                    xmlnode.SetAttribute("A", att.Type);
                    xmlnode.SetAttribute("B", att.Tag);
                    xmlnode.SetAttribute("C", att.SpeakerName);
                    xmlnode.SetAttribute("D", att.Content);
                    xmlnode.SetAttribute("E", Info);
                    xmlnode.SetAttribute("F", att.OptionName1);
                    xmlnode.SetAttribute("G", att.OptionAction1);
                    xmlnode.SetAttribute("H", att.OptionName2);
                    xmlnode.SetAttribute("I", att.OptionAction2);
                    xmlnode.SetAttribute("J", att.OptionName3);
                    xmlnode.SetAttribute("K", att.OptionAction3);
                    xmlnode.SetAttribute("L", att.OptionName4);
                    xmlnode.SetAttribute("M", att.OptionAction4);
                    xmlnode.SetAttribute("N", att.SpeakerProfile);
                }
                else
                {
                    xmlnode.SetAttribute("A", att.Type);
                    xmlnode.SetAttribute("B", att.Tag);
                }
                ParXmlnode.AppendChild(xmlnode);

                if (node.Nodes.Count > 0)
                {
                    TransTreeSav(node.Nodes, xmlnode);
                }



            }

            return 0;
            
        }

        #endregion



        #region 遍历XML并实现向tree的转化
        /// <summary>   
        /// 遍历treeview并实现向XML的转化
        /// </summary>   
        /// <param name="XMLFilePath">XML输出路径</param>   
        /// <param name="TheTreeView">树控件对象</param>   
        /// <returns>0表示函数顺利执行</returns>   

        public int XMLToTree(string XMLFilePath, TreeView TheTreeView)
        {
            //-------重新初始化转换环境变量
            thetreeview = TheTreeView;
            xmlfilepath = XMLFilePath;

            //-------重新对XMLDocument对象赋值
            textdoc.Load(xmlfilepath);

            XmlNode root = textdoc.SelectSingleNode("TreeExXMLCls");

            foreach (XmlNode subXmlnod in root.ChildNodes)
            {
                TreeNode trerotnod = new TreeNode();
                trerotnod.Text = subXmlnod.Name;
                thetreeview.Nodes.Add(trerotnod);
                TransXML(subXmlnod.ChildNodes, trerotnod);

            }

            return 0;
        }

        private int TransXML(XmlNodeList Xmlnodes, TreeNode partrenod)
        {
            //------遍历XML中的所有节点，仿照treeview节点遍历函数
            foreach (XmlNode xmlnod in Xmlnodes)
            {
                TreeNode subtrnod = new TreeNode();
                subtrnod.Text = xmlnod.Name;
                partrenod.Nodes.Add(subtrnod);

                if (xmlnod.ChildNodes.Count > 0)
                {
                    TransXML(xmlnod.ChildNodes, subtrnod);
                }
            }

            return 0;

        }

        #endregion


    }
}