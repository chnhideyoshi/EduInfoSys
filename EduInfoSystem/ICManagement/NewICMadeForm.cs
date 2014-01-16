using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EduInfoSystem.Model;

namespace EduInfoSystem.ICManagement
{
    public partial class NewICMadeForm : DevComponents.DotNetBar.Office2007Form
    {
        public NewICMadeForm()
        {
            InitializeComponent();
        }
        private void SetDefaultContent()
        {
            simpleBaseInfoPanel1.SetContent(new Student());
        }
        public void SetContent(Model.Student student)
        {
            this.simpleBaseInfoPanel1.SetContent(student);
        }
        static NewICMadeForm staticform = null;
        public static DialogResult ShowForm()
        {
            if (staticform == null)
            {
                staticform = new ICManagement.NewICMadeForm();
            }
            staticform.SetDefaultContent();
            return staticform.ShowDialog();
        }
        public static DialogResult ShowForm(Model.Student stu)
        {
            if (staticform == null)
            {
                staticform = new ICManagement.NewICMadeForm();
            }
            staticform.SetContent(stu);
            return staticform.ShowDialog();
        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(icInputPanel1.GetICCardId()) && !string.IsNullOrEmpty(simpleBaseInfoPanel1.GetStudentId()))
            {
                if (Program.ShowConfirmWindow("确认关联卡号：" + icInputPanel1.GetICCardId() + " 与学号：" +simpleBaseInfoPanel1.GetStudentId()+ " ？"))
                {
                    DataCalls.InsertCardInfo(icInputPanel1.GetICCardId(), simpleBaseInfoPanel1.GetStudentId());
                    Program.ShowWarningWindow("建卡成功！");
                }
            }
            else
            {
                Program.ShowWarningWindow("请确认输入了卡号和学号！");
            }
        }
    }
}