using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EduInfoSystem.Model;
using DevComponents.DotNetBar.Controls;

namespace EduInfoSystem.FeeManagement
{
    public partial class FeePanel : UserControl
    {
        public FeePanel()
        {
            InitializeComponent();
            InitEventHandler();
            Init();
        }
        private void InitEventHandler()
        {
            icInputPanel21.OnICNumberInput += (sender, e) => 
            {
                Program.ShowWarningWindow(e);
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
            contextMenuStrip1.Items["Edit"].Click += (sender, e) =>
            {
                if (dataGridViewX1.SelectedRows.Count != 0)
                {
                    FeeInfo fee=(FeeInfo)dataGridViewX1.SelectedRows[0].Tag;
                    SingleFeeInfoEditForm.ShowForm(fee);
                    this.Refresh();
                }
            };
        }

        private void Init()
        {
            LoadData();
        }

        private void LoadData()
        {
            this.CB_FeeType.Items.Clear();
            CB_FeeType.Items.AddRange(FeeManager.GetFeeTypes().ToArray());
            this.CB_FeeType.SelectedIndex = -1;
            this.dataGridViewX1.DataSource = null;
            this.dataGridViewX1.Columns.Clear();
            this.dataGridViewX1.Rows.Clear();
         
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {

        }

        private void CB_FeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FeeType.SelectedItem != null)
            {
                string typename = CB_FeeType.SelectedItem.ToString();
                List<FeeInfo> fees = DataCalls.GetFeeInfoByType(typename);
                List<string> ids = BaseObject.GetPropertySet<string, FeeInfo>(fees, "StudentId");
                List<string> names = DataCalls.GetStudentNames(ids);
                if (ids.Count != names.Count || ids.Count != fees.Count)
                    throw new Exception();
                InitGridView(ids,names,fees, typename);
            }
        }

        private void InitGridView(List<string> ids, List<string> names, List<FeeInfo> fees, string typename)
        {
            dataGridViewX1.Columns.Clear();
            dataGridViewX1.Rows.Clear();

            DataGridViewLabelXColumn col1 = new DataGridViewLabelXColumn();
            col1.HeaderText = "学号";
            DataGridViewLabelXColumn col2 = new DataGridViewLabelXColumn();
            col2.HeaderText = "姓名";
            dataGridViewX1.Columns.Add(col1);
            dataGridViewX1.Columns.Add(col2);

            string[] colNames = FeeManager.GetFeeCriDesciption(typename);
            int[] feeCriList = FeeManager.GetFeeCriList(typename);
            for (int i = 0; i < colNames.Length; i++)
            {
                DataGridViewLabelXColumn colomn = new DataGridViewLabelXColumn();
                colomn.HeaderText = colNames[i];
                dataGridViewX1.Columns.Add(colomn);
            }

            DataGridViewLabelXColumn col3 = new DataGridViewLabelXColumn();
            col3.HeaderText = "缴纳总额";
            DataGridViewLabelXColumn col4 = new DataGridViewLabelXColumn();
            col4.HeaderText = "应缴总额";
            dataGridViewX1.Columns.Add(col3);
            dataGridViewX1.Columns.Add(col4);

            for (int i = 0; i < dataGridViewX1.Columns.Count; i++)
            {
                dataGridViewX1.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
            }

            for (int i = 0; i < fees.Count; i++)
            {
                FeeManager feem = new FeeManager(fees[i]);
                int[] feedetail = feem.FeeList;
                if (feedetail.Length + 4 != dataGridViewX1.Columns.Count)
                    throw new Exception();

                DataGridViewRow row = new DataGridViewRow();
                row.Tag = fees[i];

                DataGridViewLabelXCell cell1 = new DataGridViewLabelXCell();
                DataGridViewLabelXCell cell2 = new DataGridViewLabelXCell();
                cell1.Value = ids[i];
                cell2.Value = names[i];
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);

                for (int j = 0; j < feem.Time; j++)
                {
                    DataGridViewLabelXCell cell = new DataGridViewLabelXCell();
                    cell.Value = feedetail[j];
                    if (feedetail[j] == 0)
                    {
                        cell.Style.ForeColor = Color.Red;
                    }
                    else if (feedetail[j] != feeCriList[j])
                    {
                        cell.Style.ForeColor = Color.Green;
                    }
                    row.Cells.Add(cell);
                }

                DataGridViewLabelXCell cell3 = new DataGridViewLabelXCell();
                DataGridViewLabelXCell cell4 = new DataGridViewLabelXCell();
                cell3.Value = feem.Sum;
                if (feem.Sum != FeeManager.GetSumCri(feeCriList))
                {
                    cell3.Style.ForeColor = Color.Red;
                }
                cell4.Value = FeeManager.GetSumCri(feeCriList);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);

                dataGridViewX1.Rows.Add(row);
            }
        }

        public override void Refresh()
        {
            LoadData();
            base.Refresh();
        }

    }
}
