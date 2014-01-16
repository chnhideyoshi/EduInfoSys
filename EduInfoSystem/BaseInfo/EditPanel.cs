using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EduInfoSystem.Model;

namespace EduInfoSystem.BaseInfo
{
    public partial class EditPanel : UserControl
    {
        public EditPanel()
        {
            InitializeComponent();
            InitEventHandler();
            LoadData();
        }

        private void InitEventHandler()
        {
            dataGridViewX1.CellValueChanged += (sender, e) =>
            {
                if (e.RowIndex == -1 || e.ColumnIndex == -1) { return; }
                DataGridViewCell cell = dataGridViewX1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.ForeColor = System.Drawing.Color.Red;
            };
        }

        TableManager manager;

        public void LoadData()
        {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.Rows.Clear();
            dataGridViewX1.Columns.Clear();
            manager = DataCalls.GetStudentTable();
            dataGridViewX1.DataSource = manager.Table;
            for (int i = 0; i < dataGridViewX1.Columns.Count; i++)
            {
                dataGridViewX1.Columns[i].HeaderText = BaseObject.GetRealName(typeof(Student), manager.Table.Columns[i].ColumnName);
                if (dataGridViewX1.Columns[i].HeaderText == "学号")
                {
                    dataGridViewX1.Columns[i].ReadOnly = true;
                }
            }
            LB_Count.Text = "总行数：" + dataGridViewX1.Rows.Count;
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count != 0)
            {
                for (int i = dataGridViewX1.SelectedRows.Count-1; i >=0; i--)
                    dataGridViewX1.Rows.Remove(dataGridViewX1.SelectedRows[i]);
            }
            else
            {
                Program.ShowWarningWindow("请选择至少一行！");
            }
        }

        private void BTN_New_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (Program.ShowConfirmWindow("确定保存修改？"))
            {
                manager.SaveUpdate();
                Program.ShowWarningWindow("保存更改完成！");
                Refresh();
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            LoadData();
        }
    }
}
