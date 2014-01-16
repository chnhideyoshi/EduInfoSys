using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EduInfoSystem.ICManagement
{
    public partial class ICInputPanel2 : UserControl
    {
        public ICInputPanel2()
        {
            InitializeComponent();
            this.textBoxX1.KeyDown += new KeyEventHandler(TB_Input_KeyDown);
        }

        public delegate void OnICNumberInputEventHandler(object sender, string ICnumber);
        public event OnICNumberInputEventHandler OnICNumberInput;

        void TB_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (OnICNumberInput != null)
                    OnICNumberInput(this, textBoxX1.Text.Replace("\n",""));
                textBoxX1.Text = "";
            }
        }

        public override void Refresh()
        {
            base.Refresh();
        }
    }
}
