namespace EduInfoSystem.ICManagement
{
    partial class NewICMadeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewICMadeForm));
            this.BTN_Confirm = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.simpleBaseInfoPanel1 = new EduInfoSystem.BaseInfo.SimpleBaseInfoPanel();
            this.icInputPanel1 = new EduInfoSystem.ICManagement.ICInputPanel();
            this.SuspendLayout();
            // 
            // BTN_Confirm
            // 
            this.BTN_Confirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Confirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Confirm.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Confirm.Image")));
            this.BTN_Confirm.Location = new System.Drawing.Point(164, 221);
            this.BTN_Confirm.Name = "BTN_Confirm";
            this.BTN_Confirm.Size = new System.Drawing.Size(70, 23);
            this.BTN_Confirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Confirm.TabIndex = 3;
            this.BTN_Confirm.Text = "确认";
            this.BTN_Confirm.Click += new System.EventHandler(this.BTN_Confirm_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancel.Image")));
            this.BTN_Cancel.Location = new System.Drawing.Point(251, 221);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "取消";
            // 
            // simpleBaseInfoPanel1
            // 
            this.simpleBaseInfoPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleBaseInfoPanel1.Location = new System.Drawing.Point(251, 12);
            this.simpleBaseInfoPanel1.Name = "simpleBaseInfoPanel1";
            this.simpleBaseInfoPanel1.Size = new System.Drawing.Size(238, 203);
            this.simpleBaseInfoPanel1.TabIndex = 2;
            // 
            // icInputPanel1
            // 
            this.icInputPanel1.Location = new System.Drawing.Point(12, 12);
            this.icInputPanel1.Name = "icInputPanel1";
            this.icInputPanel1.Size = new System.Drawing.Size(222, 203);
            this.icInputPanel1.TabIndex = 1;
            // 
            // NewICMadeForm
            // 
            this.ClientSize = new System.Drawing.Size(514, 254);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Confirm);
            this.Controls.Add(this.simpleBaseInfoPanel1);
            this.Controls.Add(this.icInputPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewICMadeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "建卡";
            this.ResumeLayout(false);

        }

        #endregion

        private ICInputPanel icInputPanel1;
        private BaseInfo.SimpleBaseInfoPanel simpleBaseInfoPanel1;
        private DevComponents.DotNetBar.ButtonX BTN_Confirm;
        private DevComponents.DotNetBar.ButtonX BTN_Cancel;
    }
}