using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EduInfoSystem.Model;

namespace EduInfoSystem.AuthorityManagement
{
    public partial class LoginForm : DevComponents.DotNetBar.Office2007Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TB_UserName.Text)||string.IsNullOrEmpty(TB_Pwd.Text))
            {
                Program.ShowWarningWindow("�������û����������룡");
                return;
            }
            bool? ret = DataCalls.GetUserInfo(TB_UserName.Text.Trim(), TB_Pwd.Text.Trim(),CB_AuthType.Text, out Program.Authority);
            if (ret != null)
            {
                if (ret.Value)
                {
                   // Program.ShowWarningWindow("��¼�ɹ�!������Ȩ��Ϊ" + Authority.Convert(Program.Authority.AuthType));
                    Program.MainForm = new MainForm();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Program.ShowWarningWindow("��֤ʧ�ܣ�");
                }
            }
            else
            {
                
                Program.ShowWarningWindow("��ѯ���ݿ�������������Ƿ�������");
            }

        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}