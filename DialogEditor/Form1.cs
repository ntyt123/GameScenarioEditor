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
    public partial class Form1 : Form
    {
        private TreeNode treeNode;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(TreeNode treeNode)
        {
            // TODO: Complete member initialization
            this.treeNode = treeNode;
            InitializeComponent();
        }
    }
}
