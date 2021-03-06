﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L8_
{
    public partial class Lesson_8 : Form
    {
        public Lesson_8()
        {
            InitializeComponent();
        }
        public int num = 0;
        private void Result_Click(object sender, EventArgs e)
        {
            // Увеличиваем счетчик пунктов меню.
            num++;
            // Создаем новый подпункт меню.
            // Для него задаем надпись
            // и обработчик выбора пользователем этого пункта.
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.toolStripMenuItem1_Click;
            // Подсоединяем новый пункт меню к главному меню формы.
            toolStripMenuItem1.DropDownItems.Add(mi);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Читаем текст на выбранном пользователе пункте меню.
            string s = ((ToolStripMenuItem)sender).Text;
            // Выводим этот текст.
            MessageBox.Show(s);
        }
    }
}
