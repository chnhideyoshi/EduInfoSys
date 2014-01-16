using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EduInfoSystem.Model;

namespace EduInfoSystem.BaseInfo
{
    public partial class InfoForm : DevComponents.DotNetBar.Office2007Form
    {
        InfoForm()
        {
            InitializeComponent();
        }
        public void SetContentToControl(Model.Student student)
        {
            complexInfoPanel1.SetContentToControl(student);
        }
        static InfoForm staticform = null;
        public static DialogResult ShowForm(string studentId)
        {
            if (staticform == null)
            {
                staticform = new InfoForm();
            }
            EduInfoSystem.Model.Student student = DataCalls.GetStudent(studentId);
            staticform.SetContentToControl(student);
            return staticform.ShowDialog();
        }
        public static DialogResult ShowForm(Model.Student student)
        {
            if (staticform == null)
            {
                staticform = new InfoForm();
            }
            staticform.SetContentToControl(student);
            return staticform.ShowDialog();
        }
    }
}