using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.AdvTree;
using EduInfoSystem.Model;

namespace EduInfoSystem.ToolControls
{
    public partial class PublicExportForm : DevComponents.DotNetBar.Office2007Form
    {
        public PublicExportForm()
        {
            InitializeComponent();
            this.advTree1.Nodes[0].NodeClick += new EventHandler(PublicExportForm_NodeClick);
            this.advTree1.Nodes[1].NodeClick += new EventHandler(PublicExportForm_NodeClick);
            this.advTree1.Nodes[2].NodeClick += new EventHandler(PublicExportForm_NodeClick);
            this.advTree1.Nodes[3].NodeClick += new EventHandler(PublicExportForm_NodeClick);
        }

        void PublicExportForm_NodeClick(object sender, EventArgs e)
        {
            for (int i = 0; i < advTree1.Nodes.Count; i++)
                advTree1.Nodes[i].Checked = false;
            Node node = (Node)sender;
            node.Checked = true;
        }
        static PublicExportForm staticform = null;
        public static DialogResult ShowForm(int type)
        {
            if (staticform == null)
            {
                staticform = new PublicExportForm();
            }
            staticform.SetCheckState(type);
            return staticform.ShowDialog();
        }

        private void SetCheckState(int type)
        {
            for (int i = 0; i < advTree1.Nodes.Count; i++)
                advTree1.Nodes[i].Checked = false;
            if(type!=-1)
                advTree1.Nodes[type].Checked = true;
        }

        private void BTN_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd.FileName = "导出数据.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (node1.Checked)
                {
                    DataCalls.ExportStudentData(sfd.FileName);
                }
                if (node2.Checked)
                {
                    DataCalls.ExportICData(sfd.FileName);
                }
                if (node3.Checked)
                {

                }
                if (node4.Checked)
                {

                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void BTN_Cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}