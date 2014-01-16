using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace EduInfoSystem.FeeManagement
{
    public partial class SingleFeeInfoEditForm : DevComponents.DotNetBar.Office2007Form
    {
        public SingleFeeInfoEditForm()
        {
            InitializeComponent();
            singleEditPanel1.IsEditable = true;
        }

        static SingleFeeInfoEditForm staticform = null;

        public static DialogResult ShowForm(Model.FeeInfo info)
        {
            if (staticform == null)
            {
                staticform = new SingleFeeInfoEditForm();
            }
            staticform.SetContent(info);
            return staticform.ShowDialog();
        }

        private void SetContent(Model.FeeInfo info)
        {
            this.singleEditPanel1.SetData(info);
        }
    }
}