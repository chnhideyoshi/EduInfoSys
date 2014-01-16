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
    public partial class SingleEditPanel : UserControl
    {
        public SingleEditPanel()
        {
            InitializeComponent();
            InitEventHandler();
            IsEditable = false;
        }

        private void InitEventHandler()
        {
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
            contextMenuStrip1.Items["SetOK"].Click += (sender, e) =>
            {
                if (dataGridViewX1.SelectedRows.Count != 0)
                {
                    dataGridViewX1.SelectedRows[0].Cells[2].Value = dataGridViewX1.SelectedRows[0].Cells[1].Value;
                }
            };
            contextMenuStrip1.Items["SetZero"].Click += (sender, e) =>
            {
                if (dataGridViewX1.SelectedCells.Count != 0)
                {
                    dataGridViewX1.SelectedRows[0].Cells[2].Value = 0;
                }
            };
        }
        public class RowItem
        {
            public string Term { get; set; }
            public int FeeY { get; set; }
            public int FeeS { get; set; }
        }
        public bool IsEditable
        {
            set { BTN_Save.Visible = value; }
            get { return BTN_Save.Visible; }
        }
        public void SetData(FeeInfo info)
        {
            this.CB_FeeType.Items.Clear();
            CB_FeeType.Items.AddRange(FeeManager.GetFeeTypes().ToArray());
            this.CB_FeeType.SelectedIndex = -1;

            this.Tag = info;

            LB_StudentId.Text = "学号：" + info.StudentId;
            LB_StudentName.Text = "姓名："+DataCalls.GetStudentName(info.StudentId);
            CB_FeeType.Text = info.FeeType;
            dataGridViewX1.DataSource = null;
            string[] des = FeeManager.GetFeeCriDesciption(info.FeeType);
            int[] feeCriList = FeeManager.GetFeeCriList(info.FeeType);
            if (des.Length != feeCriList.Length)
                throw new Exception();
            FeeManager fm = new FeeManager(info);
            List<RowItem> list = new List<RowItem>();
            for (int i = 0; i < fm.Time; i++)
            {
                RowItem ri = new RowItem();
                ri.Term = des[i];
                ri.FeeY = feeCriList[i];
                ri.FeeS = fm.FeeList[i];
                list.Add(ri);
            }
            dataGridViewX1.DataSource = list;
        }

        private void CB_FeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsEditable)
            {
                FeeInfo info = (FeeInfo)this.Tag;
                if (info != null)
                    CB_FeeType.Text = info.FeeType;
                return;
            }
            else
            {
                if (Program.ShowConfirmWindow("确定要更改类别?，若如此会丢失该生交费信息！"))
                {

                }
                else 
                {
                    FeeInfo info=(FeeInfo)this.Tag;
                    if(info!=null)
                        CB_FeeType.Text = info.FeeType;
                }
            }
        }
        private FeeInfo GetFeeInfo()
        {
            FeeInfo fee = this.Tag as FeeInfo;
            if (fee != null)
            {
                int[] feeList = new int[dataGridViewX1.Rows.Count];
                for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
                {
                    feeList[i] = (int)dataGridViewX1[2, i].Value;
                }
                fee.FeeDetail = FeeManager.ParseString(feeList);
                return fee;
            }
            else
                throw new Exception();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if(DataCalls.UpdateFeeInfo(this.GetFeeInfo()))
            {
                 Program.ShowWarningWindow("保存成功！");
            }
          else
            {
                Program.ShowWarningWindow("保存失败！");
            }
        }
    }
}
