using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EduInfoSystem.ICManagement
{
    public partial class ICInputPanel : UserControl
    {
        public ICInputPanel()
        {
            InitializeComponent();
            this.TB_Input.KeyDown += new KeyEventHandler(TB_Input_KeyDown);
        }

        public delegate void OnICNumberInputEventHandler(object sender, string ICnumber);
        public event OnICNumberInputEventHandler OnICNumberInput;

        void TB_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TB_ICCardID.Text = TB_Input.Text;
                if (OnICNumberInput != null)
                    OnICNumberInput(this, GetICCardId());
                TB_Input.Text = "";
            }
        }
        public string GetICCardId()
        {
            return TB_ICCardID.Text.Trim();
        }

        public override void Refresh()
        {
            base.Refresh();
            this.TB_Input.Focus();
        }
    }
}
