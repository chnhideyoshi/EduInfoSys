using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EduInfoSystem.Model;

namespace EduInfoSystem.AuthorityManagement
{
    public partial class AuthPanel : UserControl
    {
        public AuthPanel()
        {
            InitializeComponent();
            AuthType.Items.AddRange(new string[] { "管理员", "普通用户" });
            LoadData();
        }
        TableManager manager;
        public void LoadData()
        {
            manager = DataCalls.GetAuthTable();
            dataGridViewX1.DataSource = manager.Table;
            //for (int i = 0; i < dataGridViewX1.Columns.Count; i++)
            //{
            //    dataGridViewX1.Columns[i].HeaderText = BaseObject.GetRealName(typeof(AuthInfo), manager.Table.Columns[i].ColumnName);
            //}
        }
        public override void Refresh()
        {
            base.Refresh();
            LoadData();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (manager != null)
            {
                manager.SaveUpdate();
                Program.ShowWarningWindow("更改已保存！");
            }
        }
    }
}
