namespace EduInfoSystem.BaseInfo
{
    partial class ConditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionForm));
            this.BTN_OK = new DevComponents.DotNetBar.ButtonX();
            this.TB_Value = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CB_Properties = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.BTN_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_OK.Location = new System.Drawing.Point(52, 87);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_OK.TabIndex = 0;
            this.BTN_OK.Text = "确定";
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // TB_Value
            // 
            // 
            // 
            // 
            this.TB_Value.Border.Class = "TextBoxBorder";
            this.TB_Value.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TB_Value.Location = new System.Drawing.Point(162, 37);
            this.TB_Value.Name = "TB_Value";
            this.TB_Value.Size = new System.Drawing.Size(103, 21);
            this.TB_Value.TabIndex = 1;
            // 
            // CB_Properties
            // 
            this.CB_Properties.DisplayMember = "Text";
            this.CB_Properties.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_Properties.FormattingEnabled = true;
            this.CB_Properties.ItemHeight = 15;
            this.CB_Properties.Location = new System.Drawing.Point(12, 37);
            this.CB_Properties.Name = "CB_Properties";
            this.CB_Properties.Size = new System.Drawing.Size(115, 21);
            this.CB_Properties.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CB_Properties.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(138, 39);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(23, 19);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "=";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(50, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "属性";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(198, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(27, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "值";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Cancel.Location = new System.Drawing.Point(162, 87);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "取消";
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // ConditionForm
            // 
            this.ClientSize = new System.Drawing.Size(285, 122);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.CB_Properties);
            this.Controls.Add(this.TB_Value);
            this.Controls.Add(this.BTN_OK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "筛选条件";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BTN_OK;
        private DevComponents.DotNetBar.Controls.TextBoxX TB_Value;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CB_Properties;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX BTN_Cancel;
    }
}