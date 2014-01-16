using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EduInfoSystem.Model;

namespace EduInfoSystem.ICManagement
{
    public partial class ICPanel : UserControl
    {
        public ICPanel()
        {
            InitializeComponent();
            Init();
            InitEventHandler();
            LoadData();
        }
        TableManager manager;
        private void InitEventHandler()
        {
           
        }

        private void Init()
        {
            this.dataGridViewX1.AllowUserToResizeRows = false;
            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.State.Items.Add("正常");
            this.State.Items.Add("挂失");
        }

        public void LoadData()
        {
            manager = DataCalls.GetICLostTable();
            dataGridViewX1.DataSource = manager.Table;
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
                Program.ShowWarningWindow("保存更改完成");
                Refresh();
            }
        }
    }
}
