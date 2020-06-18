using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L32_
{
    public partial class Lesson_32 : Form
    {
        public Lesson_32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button pressed!");
        }

        private void Lesson_32_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
