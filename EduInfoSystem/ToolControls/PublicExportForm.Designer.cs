namespace EduInfoSystem.ToolControls
{
    partial class PublicExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicExportForm));
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.node1 = new DevComponents.AdvTree.Node();
            this.node2 = new DevComponents.AdvTree.Node();
            this.node3 = new DevComponents.AdvTree.Node();
            this.node4 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BTN_Export = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Cancle = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.AllowDrop = true;
            this.advTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Location = new System.Drawing.Point(12, 35);
            this.advTree1.Name = "advTree1";
            this.advTree1.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1,
            this.node2,
            this.node3,
            this.node4});
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeSpacing = 7;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.Size = new System.Drawing.Size(296, 240);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
            // 
            // node1
            // 
            this.node1.CheckBoxVisible = true;
            this.node1.Expanded = true;
            this.node1.Image = ((System.Drawing.Image)(resources.GetObject("node1.Image")));
            this.node1.Name = "node1";
            this.node1.Text = "基本信息";
            // 
            // node2
            // 
            this.node2.CheckBoxVisible = true;
            this.node2.Expanded = true;
            this.node2.Image = ((System.Drawing.Image)(resources.GetObject("node2.Image")));
            this.node2.Name = "node2";
            this.node2.Text = "学生卡信息";
            // 
            // node3
            // 
            this.node3.CheckBoxVisible = true;
            this.node3.Expanded = true;
            this.node3.Image = ((System.Drawing.Image)(resources.GetObject("node3.Image")));
            this.node3.Name = "node3";
            this.node3.Text = "交费信息";
            // 
            // node4
            // 
            this.node4.CheckBoxVisible = true;
            this.node4.Expanded = true;
            this.node4.Image = ((System.Drawing.Image)(resources.GetObject("node4.Image")));
            this.node4.Name = "node4";
            this.node4.Text = "成绩信息";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(199, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "选择要导出的数据：";
            // 
            // BTN_Export
            // 
            this.BTN_Export.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Export.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Export.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Export.Image")));
            this.BTN_Export.Location = new System.Drawing.Point(61, 281);
            this.BTN_Export.Name = "BTN_Export";
            this.BTN_Export.Size = new System.Drawing.Size(75, 23);
            this.BTN_Export.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Export.TabIndex = 2;
            this.BTN_Export.Text = "导出";
            this.BTN_Export.Click += new System.EventHandler(this.BTN_Export_Click);
            // 
            // BTN_Cancle
            // 
            this.BTN_Cancle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Cancle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Cancle.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancle.Image")));
            this.BTN_Cancle.Location = new System.Drawing.Point(171, 281);
            this.BTN_Cancle.Name = "BTN_Cancle";
            this.BTN_Cancle.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Cancle.TabIndex = 3;
            this.BTN_Cancle.Text = "取消";
            this.BTN_Cancle.Click += new System.EventHandler(this.BTN_Cancle_Click);
            // 
            // PublicExportForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 309);
            this.Controls.Add(this.BTN_Cancle);
            this.Controls.Add(this.BTN_Export);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.advTree1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublicExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出数据";
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree advTree1;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BTN_Export;
        private DevComponents.DotNetBar.ButtonX BTN_Cancle;
        private DevComponents.AdvTree.Node node2;
        private DevComponents.AdvTree.Node node3;
        private DevComponents.AdvTree.Node node4;
    }
}