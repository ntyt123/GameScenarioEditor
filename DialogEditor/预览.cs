using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEditor
{
    public partial class 预览 : Form
    {
        public TreeNode treeNode;



        public 预览(TreeNode treeNode)
        {
            // TODO: Complete member initialization
            this.treeNode = treeNode;
            InitializeComponent();
        }

        public 预览()
        {
            // TODO: Complete member initialization
        }

        private string TestDefault(string str)
        {
            if (str.Contains("Default"))
            {
                str = "\r\n";
                return str;
            }
            else
            {
                return str + "\r\n";

            }

        }

        private void 预览_Load(object sender, EventArgs e)
        {
            剧本编辑器.AttType att = null;
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.VerticalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Visible = true;
            for (int i = 0; i < treeNode.Nodes.Count; i++)
            {
                //Label lbContent = null;
                //att = treeNode.Nodes[i].Tag as 剧本编辑器.AttType;
                //if (att.Pos == "Left")
                //{
                //    Label lbLeft = new Label();


                //    lbContent = new Label();
                //    lbContent.Text = att.Content;
                //    if (att.IsOption)
                //    {
                //        lbContent.Text = att.Content + "\r\n" + att.OptionName1 + ":" + att.OptionAction1 + "\r\n" +
                //                         att.OptionName2 + ":" + att.OptionAction2 + "\r\n" + att.OptionName3 + ":" +
                //                         att.OptionAction3 + "\r\n" + att.OptionName4 + ":" + att.OptionAction4;

                //    }
                //    lbLeft.Top = 10 + i * 60;
                //    lbLeft.Left = 30;
                //    lbContent.Top = lbLeft.Top+lbLeft.Height + 10;
                //    lbContent.Left = 30;
                //    lbLeft.Text = att.SpeakerName + ":";

                //    lbContent.AutoSize = true;
                //    this.Controls.Add(lbLeft);
                //}
                //else
                //{
                //    Label lbRight = new Label();

                //    lbContent = new Label();
                //    lbContent.Text = att.Content;
                //    if (att.IsOption)
                //    {
                //        lbContent.Text = att.Content + "\r\n" + att.OptionName1 + ":" + att.OptionAction1 + "\r\n" +
                //                         att.OptionName2 + ":" + att.OptionAction2 + "\r\n" + att.OptionName3 + ":" +
                //                         att.OptionAction3 + "\r\n" + att.OptionName4 + ":" + att.OptionAction4;

                //    }
                    
                //    lbRight.Top = lbContent.Top+lbContent.Height+10;
                //    lbRight.Left = lbContent.Left + lbContent.Width + 10;
                //    lbRight.Text = ":" + att.SpeakerName;
                //    lbContent.Top = lbRight.Top+lbRight.Height+10;
                //    lbContent.Left = 30;
                //    lbContent.AutoSize = true;
                //    this.Controls.Add(lbRight);
                //}
                //this.Controls.Add(lbContent);


                att = treeNode.Nodes[i].Tag as 剧本编辑器.AttType;
                if (att.Pos == "Left")
                {
                    tbView.Text += att.SpeakerName + ":\r\n";
                    tbView.Text += "    "+att.Content+"\r\n\r\n";
                    if (att.IsOption)
                    {
                        tbView.Text += att.OptionName1 +( att.OptionName1 == "" ? "" : ":") +( att.OptionName1 == "" ? "" : (int.Parse(att.OptionAction1)+1).ToString())+ "\r\n" +
                                        att.OptionName2 + (att.OptionName2 == "" ? "" : ":") + (att.OptionName2 == "" ? "" : (int.Parse(att.OptionAction2)+1).ToString() )+ "\r\n" +att.OptionName3+ (att.OptionName3 == "" ? "" : ":") +
                                        (att.OptionName3 == "" ? "" :(int.Parse(att.OptionAction3)+1).ToString()) + "\r\n" +att.OptionName4+ (att.OptionName4 == "" ? "" : ":") + (att.OptionName4 == "" ? "" :(int.Parse(att.OptionAction4)+1).ToString()) + "\r\n\r\n";
                    }
                }
                else
                {
                    tbView.Text += "                :"+att.SpeakerName + "\r\n";
                    tbView.Text += "    "+att.Content + "\r\n\r\n";
                    if (att.IsOption)
                    {
                        tbView.Text += att.OptionName1 + (att.OptionName1 == "" ? "" : ":") + (att.OptionName1 == "" ? "" : (int.Parse(att.OptionAction1) + 1).ToString()) + "\r\n" +
                                           att.OptionName2 + (att.OptionName2 == "" ? "" : ":") + (att.OptionName2 == "" ? "" : (int.Parse(att.OptionAction2) + 1).ToString()) + "\r\n" + att.OptionName3 + (att.OptionName3 == "" ? "" : ":") +
                                           (att.OptionName3 == "" ? "" : (int.Parse(att.OptionAction3) + 1).ToString()) + "\r\n" + att.OptionName4 + (att.OptionName4 == "" ? "" : ":") + (att.OptionName4 == "" ? "" : (int.Parse(att.OptionAction4) + 1).ToString()) + "\r\n\r\n";
                    }
                }
            }
        }
    }
}
