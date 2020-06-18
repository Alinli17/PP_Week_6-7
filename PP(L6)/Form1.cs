using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_L6_
{
    public partial class Lesson_6 : Form
    {
        public Lesson_6()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Запуск длинной операции
            for (int i = 0; i < 100; i++)
            {
                // отправляем значение, которое должен увидеть пользователь
                backgroundWorker1.ReportProgress(i);

                // Приостанавливаем операцию на 100 мс чтобы сделать операцию заметно дольше
                Thread.Sleep(millisecondsTimeout: 100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Результаты показываем в заголовке окна
            this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Выводим сообщение о завершении фоновой задачи
            MessageBox.Show("Finished!");

            // После завершения фоновой операции сделаем кнопку снова активной
            Start_Thread.Enabled = true;
        }

        private void Start_Thread_Click(object sender, EventArgs e)
        {
            // Проверяем, выполняется ли фоновая задача в момент нажатия кнопки
            if (!backgroundWorker1.IsBusy)
            {
                // Если задача не выполняется, то запускаем её асинхронно в качестве фоновой операции
                backgroundWorker1.RunWorkerAsync();
            }

            // Сделаем кнопку неактивной
            Start_Thread.Enabled = false;
        }

        private void Msg_Box_Click(object sender, EventArgs e)
        {
            // Обработка нажатия кнопки, которая может быть нажата во время выполнения фоновой операции
            MessageBox.Show("Some Action");
        }
    }
}
