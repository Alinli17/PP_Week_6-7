﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L29_
{
    public partial class Lesson_29 : Form
    {
        public Lesson_29()
        {
            InitializeComponent();
        }
        Font userFont = DefaultFont;

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получение шрифта из диалогового окна.
                userFont = fontDialog1.Font;
                // Перерисовка формы.
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Test", userFont, Brushes.Blue, 20, 20);
            base.OnPaint(e);
        }
    }
}
