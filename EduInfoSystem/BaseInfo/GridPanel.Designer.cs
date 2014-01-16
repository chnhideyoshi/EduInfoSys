namespace EduInfoSystem.BaseInfo
{
    partial class GridPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.LB_Count = new DevComponents.DotNetBar.LabelX();
            this.BTN_Condition = new DevComponents.DotNetBar.ButtonX();
            this.TB_Search = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTN_Find = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.icInputPanel21 = new EduInfoSystem.ICManagement.ICInputPanel2();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MakeCard = new System.Windows.Forms.ToolStripMenuItem();
            this.Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.Lock = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.LB_Count);
            this.panelEx1.Controls.Add(this.BTN_Condition);
            this.panelEx1.Controls.Add(this.TB_Search);
            this.panelEx1.Controls.Add(this.BTN_Find);
            this.panelEx1.Controls.Add(this.dataGridViewX1);
            this.panelEx1.Controls.Add(this.icInputPanel21);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(964, 491);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // LB_Count
            // 
            // 
            // 
            // 
            this.LB_Count.BackgroundStyle.Class = "";
            this.LB_Count.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LB_Count.Location = new System.Drawing.Point(12, 6);
            this.LB_Count.Name = "LB_Count";
            this.LB_Count.Size = new System.Drawing.Size(75, 23);
            this.LB_Count.TabIndex = 5;
            this.LB_Count.Text = "总行数：";
            // 
            // BTN_Condition
            // 
            this.BTN_Condition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Condition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Condition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Condition.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Condition.Image")));
            this.BTN_Condition.Location = new System.Drawing.Point(460, 6);
            this.BTN_Condition.Name = "BTN_Condition";
            this.BTN_Condition.Size = new System.Drawing.Size(94, 21);
            this.BTN_Condition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Condition.TabIndex = 4;
            this.BTN_Condition.Text = "条件筛选";
            // 
            // TB_Search
            // 
            this.TB_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TB_Search.Border.Class = "TextBoxBorder";
            this.TB_Search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TB_Search.Location = new System.Drawing.Point(569, 6);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(139, 21);
            this.TB_Search.TabIndex = 3;
            // 
            // BTN_Find
            // 
            this.BTN_Find.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Find.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Find.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Find.Image")));
            this.BTN_Find.Location = new System.Drawing.Point(714, 6);
            this.BTN_Find.Name = "BTN_Find";
            this.BTN_Find.Size = new System.Drawing.Size(38, 21);
            this.BTN_Find.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Find.TabIndex = 2;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(964, 458);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // icInputPanel21
            // 
            this.icInputPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icInputPanel21.Location = new System.Drawing.Point(760, 3);
            this.icInputPanel21.Name = "icInputPanel21";
            this.icInputPanel21.Size = new System.Drawing.Size(204, 31);
            this.icInputPanel21.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeCard,
            this.Detail,
            this.Lock});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 70);
            // 
            // MakeCard
            // 
            this.MakeCard.Name = "MakeCard";
            this.MakeCard.Size = new System.Drawing.Size(99, 22);
            this.MakeCard.Text = "制卡";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(99, 22);
            this.Detail.Text = "详细信息";
            // 
            // Lock
            // 
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(99, 22);
            this.Lock.Text = "挂失";
            // 
            // GridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "GridPanel";
            this.Size = new System.Drawing.Size(964, 491);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TB_Search;
        private DevComponents.DotNetBar.ButtonX BTN_Find;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MakeCard;
        private DevComponents.DotNetBar.ButtonX BTN_Condition;
        private System.Windows.Forms.ToolStripMenuItem Detail;
        private System.Windows.Forms.ToolStripMenuItem Lock;
        private DevComponents.DotNetBar.LabelX LB_Count;
        private ICManagement.ICInputPanel2 icInputPanel21;
    }
}
