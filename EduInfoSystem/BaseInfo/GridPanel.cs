using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using EduInfoSystem.Model;

namespace EduInfoSystem.BaseInfo
{
    public partial class GridPanel : UserControl
    {
        public GridPanel()
        {
            InitializeComponent();
            LoadAllStudents(null);
            InitEventHandler();
        }
        private void InitEventHandler()
        {
            dataGridViewX1.SortCompare += (sender, e) => 
            {
                string name = e.Column.Name;
                SortModes mode = BaseObject.GetSortMode(typeof(Student), name);
                switch (mode)
                {
                    case SortModes.Date:
                        {
                            e.Handled = true;
                        }break;
                    case SortModes.Number:
                        {
                            e.SortResult = ((double)e.CellValue1).CompareTo((double)e.CellValue2);
                        } break;
                    default:return;
                }
                e.Handled = true;
            };
            dataGridViewX1.CellMouseDown += (sender, e) => 
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0)
                    {
                        if (dataGridViewX1.Rows[e.RowIndex].Selected == false)
                        {
                            dataGridViewX1.ClearSelection();
                            dataGridViewX1.Rows[e.RowIndex].Selected = true;
                        }
                        if (dataGridViewX1.SelectedRows.Count == 1)
                        {
                            dataGridViewX1.CurrentCell = dataGridViewX1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        }
                        contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                    }
                }
               
            };
            contextMenuStrip1.Items["Detail"].Click += (sender, e) => 
            {
                if (dataGridViewX1.SelectedRows.Count != 0)
                {
                    BaseInfo.InfoForm.ShowForm((Student)dataGridViewX1.SelectedRows[0].Tag);
                }
            };
            contextMenuStrip1.Items["MakeCard"].Click += (sender, e) =>
            {
                if (dataGridViewX1.SelectedRows.Count!=0)
                {
                    ICManagement.NewICMadeForm.ShowForm((Student)dataGridViewX1.SelectedRows[0].Tag);
                }
            };
            contextMenuStrip1.Items["Lock"].Click += (sender, e) => 
            {
                if (dataGridViewX1.SelectedRows.Count != 0)
                {
                    Student stu = (Student)dataGridViewX1.SelectedRows[0].Tag;
                    ICManagement.LockICForm.ShowForm(stu);
                }
            };
            dataGridViewX1.CellDoubleClick += (sender, e) => 
            {
                if (e.RowIndex != -1)
                {
                    List<Student> list = (List<Student>)dataGridViewX1.Tag;
                    InfoForm.ShowForm(list[e.RowIndex]);
                }
                
            };
            BTN_Condition.Click += (sender, e) =>
            {
                string[] properties = BaseObject.GetProperties(typeof(Student));
                string[] descriptions = new string[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    descriptions[i] = BaseObject.GetRealName(typeof(Student),properties[i]);
                }
                if (ConditionForm.Show(descriptions,properties) == DialogResult.OK)
                {
                    string con = ConditionForm.GetCondition();
                    LoadAllStudents(con);
                }
            };
            BTN_Find.Click += (sender, e) => 
            {
                if(string.IsNullOrEmpty(TB_Search.Text)){return;}
                dataGridViewX1.ClearSelection();
                int count = 0;
                int first = -1;
                for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewX1.Columns.Count; j++)
                    {
                        if (dataGridViewX1.Rows[i].Cells[j].Value.ToString() == TB_Search.Text.Trim())
                        {
                            dataGridViewX1.Rows[i].Cells[j].Selected = true;
                            if (first == -1)
                            {
                                first = i;
                                dataGridViewX1.FirstDisplayedScrollingRowIndex = i;
                            }
                            count++;
                        }
                    }
                }
                if (count == 0)
                {
                    Program.ShowWarningWindow("未查找到关键字：" + TB_Search.Text.Trim());
                }
                else
                {
                    Program.ShowWarningWindow("查找到：" + count+"个");
                }
            };
            icInputPanel21.OnICNumberInput += (sender, e) => 
            {
                string id = DataCalls.GetStudentId(e);
                if (id != null)
                {
                    BaseInfo.InfoForm.ShowForm(id);
                }
                else 
                {
                    Program.ShowWarningWindow("此卡未关联任何学生");
                }
            };
        }
        private void InitColumns()
        {
            this.dataGridViewX1.Columns.Clear();
            string[] pinfos = BaseObject.GetProperties(typeof(Student));
            for (int i = 0; i < pinfos.Length; i++)
            {
                DataGridViewLabelXColumn col = new DataGridViewLabelXColumn();
                col.Name = pinfos[i];
                col.Text = pinfos[i];
                col.HeaderText = BaseObject.GetRealName(typeof(Student),pinfos[i]);
                col.SortMode = DataGridViewColumnSortMode.Automatic;
                dataGridViewX1.Columns.Add(col);
            }
        }
        public void LoadAllStudents(string condition)
        {
            InitColumns();
            if (condition == null)
            {
                List<Model.Student> list = Model.DataCalls.GetAllStudents();
                SetListToControl(list);
            }
            else
            {
                List<Model.Student> list = DataCalls.GetStudents(condition);
                SetListToControl(list);
            }
            LB_Count.Text = "总行数：" + dataGridViewX1.Rows.Count;
        }
        public void SetListToControl(List<Model.Student> list)
        {
            string[] pinfos = BaseObject.GetProperties(typeof(Model.Student));
            dataGridViewX1.Rows.Clear();
            dataGridViewX1.Tag = list;
            for (int i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = list[i];
                for (int j = 0; j < pinfos.Length; j++)
                {
                    DataGridViewLabelXCell cell = new DataGridViewLabelXCell();
                    cell.Value = list[i].GetValue(pinfos[j]);
                    row.Cells.Add(cell);
                }
                dataGridViewX1.Rows.Add(row);
            }
        }
        public override void Refresh()
        {
            base.Refresh();
            LoadAllStudents(null);
        }
 
    }
}
