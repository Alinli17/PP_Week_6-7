using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L22_
{
    public partial class Lesson_22 : Form
    {
        public Lesson_22()
        {
            InitializeComponent();
        }

        private void Lesson_22_Load(object sender, EventArgs e)
        {
            linkLabel1.Links[0].LinkData = "https://microsoft.com";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Запускаем браузер и открываем в нем страницу.
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
