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
    public partial class LockICForm : DevComponents.DotNetBar.Office2007Form
    {
        public LockICForm()
        {
            InitializeComponent();
        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxX1.Text))
            {
                bool ret=DataCalls.UpdateICCardState(textBoxX1.Text.Trim(), "��ʧ");
                if (ret)
                    Program.ShowWarningWindow("��ʧ�ɹ���");
                else
                    Program.ShowWarningWindow("��ʧʧ�ܣ�����ѧ���Ƿ���ȷ��");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Program.ShowWarningWindow("�������ʧ��ѧ�ţ�");
            }
        }
        static LockICForm staticform = null;
        public static DialogResult ShowForm()
        {
            if (staticform == null)
            {
                staticform = new ICManagement.LockICForm();
            }
            return staticform.ShowDialog();
        }
        public static DialogResult ShowForm(Model.Student stu)
        {
            if (staticform == null)
            {
                staticform = new ICManagement.LockICForm();
            }
            staticform.SetContent(stu);
            return staticform.ShowDialog();
        }

        public void SetContent(Student stu)
        {
            this.textBoxX1.Text = stu.StudentId;
        }
    }
}