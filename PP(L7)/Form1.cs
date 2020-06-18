using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L7_
{
    public partial class Lesson_7 : Form
    {
        public Lesson_7()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            // Создаем новый xml-документ.
            XmlDocument xml = new XmlDocument();
            // Загружаем в xml-документ xml-файл.
            xml.Load("C:/Users/Алина/source/repos/PP(Week_6-7)/PP(L7)/XMLFile1.xml");
            // Берем корневой узел (тег) xml-документа.
            XmlNode d = xml.DocumentElement;
            // Берем все дочерние теги.
            XmlNodeList xnl = d.ChildNodes;
            // Перебираем все дочерние теги.
            for (int i = 0; i < d.ChildNodes.Count; i++)
            {
                // Выводим атрибуты тегов.
                MessageBox.Show(xnl[i].Attributes["text"].Value + " " +
                    xnl[i].Attributes["rustext"].Value);
            }
        }
    }
}
