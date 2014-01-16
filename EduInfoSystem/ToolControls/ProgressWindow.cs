using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace EduInfoSystem.ToolControls
{
    public partial class ProgressWindow : DevComponents.DotNetBar.Office2007Form
    {
        public BackgroundWorker Worker = new BackgroundWorker();
        public ProgressWindow()
        {
            InitializeComponent();
            Worker.WorkerReportsProgress = true;
            Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(worker_DoWork);
            Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(worker_ProgressChanged);
            Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }
        public delegate void DoWork(object args);
        public delegate void WorkComplete(object result);
        public void BeginWork(object args)
        {
            this.Worker.RunWorkerAsync(args);
            this.ShowDialog();
        }
        public DoWork Work { get; set; }
        public WorkComplete Completed { get; set; }

        void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (Work != null)
                Work(e.Argument);
        }

        void worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.progressBarX1.Value = e.ProgressPercentage;
        }

        void worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (Completed != null)
                Completed(e.Result);
            this.DialogResult = DialogResult.OK;
        }
    }
}