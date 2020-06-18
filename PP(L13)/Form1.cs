using System;
using System.Drawing.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L13_
{
    public partial class Lesson_13 : Form
    {
        public Lesson_13()
        {
            InitializeComponent();
        }
        System.Drawing.Text.InstalledFontCollection fontList =
            new System.Drawing.Text.InstalledFontCollection();
        private void Lesson_13_Load(object sender, EventArgs e)
        {
            // Заполняем список названиями всех шрифтов.
            foreach (FontFamily ff in fontList.Families)
            {
                List_Box.Items.Add(ff.Name);
            }
        }
        private void List_Box_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            forma.Font = new Font(List_Box.Text, 20);
        }

    }
}
