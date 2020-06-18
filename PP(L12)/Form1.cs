using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L12_
{
    public partial class Lesson_12 : Form
    {
        public Lesson_12()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем объект GraphicsPath.
            GraphicsPath gp = new GraphicsPath();
            // Прибавляем два круга.
            gp.AddEllipse(0, 0, 100, 100);
            gp.AddEllipse(110, 0, 100, 100);
            // Создаем регион на основе экземпляра GraphicsPath.
            Region r = new Region(gp);
            // Присваиваем созданный регион
            // региону нашего окна.
            this.Region = r;
        }
    }
}
