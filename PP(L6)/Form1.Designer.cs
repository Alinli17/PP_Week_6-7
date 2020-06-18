namespace PP_L6_
{
    partial class Lesson_6
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_Thread = new System.Windows.Forms.Button();
            this.Msg_Box = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Start_Thread
            // 
            this.Start_Thread.Location = new System.Drawing.Point(27, 29);
            this.Start_Thread.Name = "Start_Thread";
            this.Start_Thread.Size = new System.Drawing.Size(147, 46);
            this.Start_Thread.TabIndex = 0;
            this.Start_Thread.Text = "Start Thread";
            this.Start_Thread.UseVisualStyleBackColor = true;
            this.Start_Thread.Click += new System.EventHandler(this.Start_Thread_Click);
            // 
            // Msg_Box
            // 
            this.Msg_Box.Location = new System.Drawing.Point(192, 29);
            this.Msg_Box.Name = "Msg_Box";
            this.Msg_Box.Size = new System.Drawing.Size(147, 46);
            this.Msg_Box.TabIndex = 1;
            this.Msg_Box.Text = "MsgBox";
            this.Msg_Box.UseVisualStyleBackColor = true;
            this.Msg_Box.Click += new System.EventHandler(this.Msg_Box_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Lesson_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 93);
            this.Controls.Add(this.Msg_Box);
            this.Controls.Add(this.Start_Thread);
            this.Name = "Lesson_6";
            this.Text = "Урок 6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_Thread;
        private System.Windows.Forms.Button Msg_Box;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

