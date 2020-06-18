using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PP_L10_
{
    public partial class Lesson_10 : Form
    {
        public Lesson_10()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            // Размер экрана.
            Size sz = SystemInformation.PrimaryMonitorSize;
            rez1.Text = sz.ToString();

            // Имя компьтера.
            String cn = SystemInformation.ComputerName;

            // Количество кнопок у мыши.
            int k = SystemInformation.MouseButtons;

            // Используемый шрифт для меню и его имя.
            Font f = SystemInformation.MenuFont;
            String fn = f.Name;

            // Присутствует ли сеть?
            bool b = SystemInformation.Network;

            // Имя текущего пользователя.
            String un = SystemInformation.UserName;
            rez2.Text = un.ToString();

            // Ширина вертикальной полосы прокрутки.
            int w = SystemInformation.VerticalScrollBarWidth;
        }
    }
}
