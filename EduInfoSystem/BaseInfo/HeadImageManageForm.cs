using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EduInfoSystem.Model;

namespace EduInfoSystem.BaseInfo
{
    public partial class HeadImageManageForm : DevComponents.DotNetBar.Office2007Form
    {
        public HeadImageManageForm()
        {
            InitializeComponent();
            InitEventHandler();
            Init();
        }

        private void Init()
        {
            LoadData();
        }

        private void LoadData()
        {
            List<Student> list = DataCalls.GetAllStudents();
            List<string> idens = DataCalls.GetAllHeadImageNames();
            listViewEx1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = list[i];
                item.Text = list[i].StudentId;
                item.SubItems.Add(list[i].StudentName);
                item.SubItems.Add(list[i].Gender);
                item.SubItems.Add(list[i].MajorName);
                item.SubItems.Add(list[i].CurrentGrade);
                if (idens.Contains(list[i].IdentificationId))
                {
                    item.SubItems.Add("已上传");
                }
                else
                {
                    item.SubItems.Add("暂无");
                }
                listViewEx1.Items.Add(item);
            }
        }

        private void InitEventHandler()
        {
            superTabControl1.TabItemOpen += (sende, e) =>
            {
                SuperTabItem t = e.Tab as SuperTabItem;
                if (t != null && t == superTabItem1)
                {
                    LoadData();
                }
            };
            listViewEx1.SelectedIndexChanged += (sender, e) =>
            {
                if (listViewEx1.SelectedItems.Count == 0) { return; }
                Student stu = (Student)listViewEx1.SelectedItems[0].Tag;
                if(stu!=null)
                {
                    byte[] data=DataCalls.GetImageData(stu.IdentificationId);
                    BaseInfo.ComplexInfoPanel.LoadPicture(pictureBox1, data);
                }
            };
            listBox1.SelectedIndexChanged += (sender, e) => 
            {
                string path = listBox1.SelectedItem.ToString();
                pictureBox2.Image = Image.FromFile(path);
            };
        }
        static HeadImageManageForm staticform = null;
        public static DialogResult ShowForm()
        {
            if (staticform == null)
            {
                staticform = new HeadImageManageForm();
            }
            return staticform.ShowDialog();
        }

        private void BTN_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.TB_Path.Text = fbd.SelectedPath;
                listBox1.Items.Clear();
                string[] file = System.IO.Directory.GetFiles(TB_Path.Text,"*.jpg");
                this.listBox1.Tag = file;
                for (int i = 0; i < file.Length; i++)
                {
                    listBox1.Items.Add(file[i]);
                }
            }
        }

        private void BTN_Upload_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                string[] files = (string[])listBox1.Tag;
                if (files != null)
                {
                    ToolControls.ProgressWindow window = new ToolControls.ProgressWindow();
                    window.Work = (args) => 
                    {
                        DataCalls.UpdateAllHeadImages((string[])args,window.Worker);
                    };
                    window.Completed = (res) => 
                    {
                        Program.ShowWarningWindow("上传完成！");
                        listBox1.Items.Clear();
                        listBox1.Tag = null;
                    };
                    window.BeginWork(files);
                }
            }
        }
    }
}