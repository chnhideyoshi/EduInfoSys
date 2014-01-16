using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EduInfoSystem.BaseInfo
{
    public partial class SimpleBaseInfoPanel : UserControl
    {
        public SimpleBaseInfoPanel()
        {
            InitializeComponent();
        }

        public string GetStudentId()
        {
            return TB_StudentId.Text.Trim();
        }

        public void SetContent(EduInfoSystem.Model.Student stu)
        {
            this.Tag = stu;
            TB_StudentId.Text = stu.StudentId;
            TB_StudentName.Text = stu.StudentName;
            TB_IdentificationId.Text = stu.IdentificationId;
            TB_MajorName.Text = stu.MajorName;
            TB_Gender.Text = stu.Gender;
        }
    }
}
