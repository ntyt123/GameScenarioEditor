using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace WpfDialogEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            treeView.ItemsSource = new XmlHeaderLogic[]
            {
                XmlHeaderLogic.FromXml(System.IO.File.ReadAllText("textfile1.xml"))
            };
        }
    }
    class XmlHeaderLogic
    {

        //用于输出XML属性的格式化文本

        const string ATTR_FORMAT = "{0} = {1}";



        //显示名称

        public string Header { get; private set; }

        //类型

        public string Type { get; private set; }

        //子成员

        public IEnumerable<XmlHeaderLogic> Children { get; private set; }



        XmlHeaderLogic(string header, string type, IEnumerable<XmlHeaderLogic> children)
        {

            Header = header;

            Type = type;

            Children = children;

        }



        //从XML文本来创建XmlHeaderLogic类型

        public static XmlHeaderLogic FromXml(string xml)
        {

            if (xml == null)
            {

                throw new ArgumentNullException("xml");

            }

            var xmldoc = new XmlDocument();

            xmldoc.LoadXml(xml);

            return FromXmlElement(xmldoc.DocumentElement);

        }



        //（内部）从XmlNode来创建XmlHeaderLogic

        static XmlHeaderLogic FromXmlElement(XmlNode node)
        {

            //生成子成员

            var children = node.ChildNodes.Cast<XmlNode>()

                .Select(n => FromXmlElement(n))

                .Where(n => n != null);

            //生成显示名称

            string header;

            switch (node.NodeType)
            {

                case XmlNodeType.Text:

                case XmlNodeType.CDATA:

                case XmlNodeType.Comment:

                    header = node.Value.Trim();

                    break;

                case XmlNodeType.Element:

                    header = node.Name;

                    break;

                default:

                    return null;

            }

            //如果有XML属性的话，直接从属性创建XmlHeaderLogic然后加在子成员前面。

            //注意这里不用递归是因为当XmlNode的类型为XmlNodeType.Attribute，该

            //XmlNode的ChildNodes属性仍然会返回一个类型为XmlNodeType.Text的XmlNode代表属性值。

            if (node.Attributes != null)
            {

                var attrs = node.Attributes.Cast<XmlNode>()

                    .Select(n => new XmlHeaderLogic(

                        String.Format(ATTR_FORMAT, n.Name, n.Value),

                        XmlNodeType.Attribute.ToString(),

                        null));

                children = attrs.Concat(children);

            }



            return new XmlHeaderLogic(header, node.NodeType.ToString(), children);

        }

    }
}
