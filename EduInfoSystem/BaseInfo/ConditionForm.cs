using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace EduInfoSystem.BaseInfo
{
    public partial class ConditionForm : DevComponents.DotNetBar.Office2007Form
    {
        public ConditionForm()
        {
            InitializeComponent();
        }
        private void BTN_OK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CB_Properties.Text) && !string.IsNullOrEmpty(TB_Value.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Program.ShowWarningWindow("请完整填写筛选条件！");
            }
        }
        public string GetCondition2()
        {
           int index=CB_Properties.Items.IndexOf(CB_Properties.Text);
           if (index == -1)
               throw new Exception();
            string[] pros=(string[])CB_Properties.Tag;
            return string.Format("where {0} = '{1}' ",pros[index],TB_Value.Text.Trim());
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        static ConditionForm staticform = null;
        public static string GetCondition()
        {
            return staticform.GetCondition2();
        }
        public static DialogResult Show(string[] descriptions,string[] properties)
        {
            if (staticform == null)
            {
                staticform = new ConditionForm();
            }
            staticform.SetProperties(descriptions,properties);
            return staticform.ShowDialog();
        }

        private void SetProperties(string[] descriptions, string[] properties)
        {
            if (descriptions.Length != properties.Length)
                throw new Exception();
            CB_Properties.Items.Clear();
            CB_Properties.Items.AddRange(descriptions);
            CB_Properties.Tag = properties;
        }
    }
}