using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L26_
{
    public partial class Lesson_26 : Form
    {
        public Lesson_26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр класса, соответствующего второй форме
            Lesson_26_2 f = new Lesson_26_2();
            // Если нажата кнопка OK
            if (f.ShowDialog() == DialogResult.OK)
            {
                // то передаем данные из текстового поля второй формы в поле на первой форме
                textBox1.Text = f.textBox1.Text;
            }
        }
    }
}
