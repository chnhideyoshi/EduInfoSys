using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using EduInfoSystem.Model;

namespace EduInfoSystem.BaseInfo
{
    public partial class ImportXLSForm : DevComponents.DotNetBar.Office2007Form
    {
        ImportXLSForm()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            this.dataGridViewX1.AllowUserToResizeRows = false;
            dataGridViewX1.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewX1.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        }

        public void SetContent(string path)
        {
            DataTable dt = ExcelHelper.Import(path);
            dataGridViewX1.DataSource = null;
            dataGridViewX1.Rows.Clear();
            dataGridViewX1.Columns.Clear();
            dataGridViewX1.DataSource = dt;
            StringBuilder errorMessage =new StringBuilder();
            CheckColumns(dt, ref errorMessage);
            CheckRows(dt, ref errorMessage);
            if (errorMessage.Length >2 )
            {
                if (errorMessage.Length > 200)
                {
                    Program.ShowWarningWindow(errorMessage.ToString().Substring(0,200));
                }
                else
                {
                    Program.ShowWarningWindow(errorMessage.ToString());
                }
                
            }
        }

        private void CheckRows(DataTable dt, ref StringBuilder erMsg)
        {
            List<string> ids=new List<string>(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["学号"].ToString();
                ids.Add(id);
            }
            List<bool> dataCheckResult =new List<bool>(DataCalls.CheckStudentIds(ids));
            if (dataCheckResult.Contains(true))
            {
                for (int i = 0; i < dataCheckResult.Count; i++)
                {
                    if (dataCheckResult[i])
                        erMsg.Append(string.Format("学号\"{0}\"在数据库中已经存在！\n", ids[i]));
                }
            }
            Dictionary<string, int> dup = new Dictionary<string, int>();
            for (int i = 0; i < ids.Count; i++)
            {
                if(dup.ContainsKey(ids[i]))
                {
                    dup[ids[i]]++;
                }else
                {
                    dup.Add(ids[i], 1);
                }
            }
            foreach (KeyValuePair<string, int> kv in dup)
            {
                if (kv.Value != 1)
                {
                     erMsg.Append(string.Format("学号\"{0}\"存在重复！\n", kv.Key));
                }
            }

        }

        private void CheckColumns(DataTable dt, ref StringBuilder erMsg)
        {
            string[] realNames = BaseObject.GetRealNames(typeof(Student));
            List<string> realNameList=new List<string>(realNames);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string columnName = dt.Columns[i].ColumnName;
                if (!realNameList.Contains(columnName))
                {
                    erMsg.Append(string.Format("列\"{0}\"无法解析，请尝试改名\n", columnName));
                }
            }
        }

        public List<Student> GetStudents()
        {
            List<Student> list = new List<Student>(dataGridViewX1.Rows.Count);
            for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
            {
                Student stu = new Student();
                string[] props = BaseObject.GetProperties(typeof(Student));
                string[] realNames=BaseObject.GetRealNames(typeof(Student));
                for (int j = 0; j < props.Length; j++)
                {
                    stu.SetValue(props[j], dataGridViewX1.Rows[i].Cells[realNames[j]].Value);
                }
                list.Add(stu);
            }
            return list;
        }

        static ImportXLSForm staticform = null;

        public static DialogResult ShowForm()
        {
            if (staticform == null)
            {
                staticform = new ImportXLSForm();
            }
            //staticform.SetContent(path);
            return staticform.ShowDialog();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            List<Model.Student> stuList = this.GetStudents();
            int[] ret = EduInfoSystem.Model.DataCalls.InsertStudentList(stuList);
            int count = 0;
            for (int i = 0; i < ret.Length; i++)
            {
                if (ret[i] == 1)
                {
                    count++;
                }
            }
            Program.ShowWarningWindow(string.Format("插入成功{0}个学生信息，失败{1}个", count, ret.Length - count));
            this.DialogResult = DialogResult.OK;
        }

        private void BTN_Folder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SetContent(ofd.FileName);
            }
         }

    }
}