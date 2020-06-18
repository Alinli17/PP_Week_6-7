using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L21_
{
    public partial class Lesson_21 : Form
    {
        public Lesson_21()
        {
            InitializeComponent();
        }
public class Class1 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class1");
        }
    }
    public class Class2 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class2");
        }
    }
        private void Result_Click(object sender, EventArgs e)
        {
            // Получаем тип по имени.
            Type t = Type.GetType("PP_L21_" + text.Text);
            // Создаем переменную по типу.
            ISomeInterface w = (PP_L21_.ISomeInterface)Activator.CreateInstance(t);
            // Вызываем метод.
            w.SomeMethod();
        }
    }
    public interface ISomeInterface
    {
        void SomeMethod();
    }
}
