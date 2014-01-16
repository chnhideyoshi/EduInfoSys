namespace EduInfoSystem.BaseInfo
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EduInfoSystem.Model.Student student1 = new EduInfoSystem.Model.Student();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.complexInfoPanel1 = new EduInfoSystem.BaseInfo.ComplexInfoPanel();
            this.SuspendLayout();
            // 
            // complexInfoPanel1
            // 
            this.complexInfoPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complexInfoPanel1.Location = new System.Drawing.Point(0, 0);
            this.complexInfoPanel1.Name = "complexInfoPanel1";
            this.complexInfoPanel1.Size = new System.Drawing.Size(684, 414);
            this.complexInfoPanel1.TabIndex = 0;
            student1.BornDate = "";
            student1.ClassId = "";
            student1.CurrentGrade = "";
            student1.EduSys = "";
            student1.EnterDate = "";
            student1.ExamId = "";
            student1.Gender = "";
            student1.IdentificationId = "";
            student1.Level = "";
            student1.MajorId = "";
            student1.MajorName = "";
            student1.Nationality = "";
            student1.PoliticalFace = "";
            student1.StudentId = "";
            student1.StudentName = "";
            student1.StudyMethod = "";
            this.complexInfoPanel1.Tag = student1;
            // 
            // InfoForm
            // 
            this.ClientSize = new System.Drawing.Size(684, 414);
            this.Controls.Add(this.complexInfoPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人详细信息";
            this.ResumeLayout(false);

        }

        #endregion

        private ComplexInfoPanel complexInfoPanel1;
    }
}