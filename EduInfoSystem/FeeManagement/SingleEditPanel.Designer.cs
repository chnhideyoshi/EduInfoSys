namespace EduInfoSystem.FeeManagement
{
    partial class SingleEditPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleEditPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.LB_StudentName = new DevComponents.DotNetBar.LabelX();
            this.LB_StudentId = new DevComponents.DotNetBar.LabelX();
            this.BTN_Save = new DevComponents.DotNetBar.ButtonX();
            this.CB_FeeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.Term = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.FeeY = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.FeeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetOK = new System.Windows.Forms.ToolStripMenuItem();
            this.SetZero = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.LB_StudentName);
            this.panelEx1.Controls.Add(this.LB_StudentId);
            this.panelEx1.Controls.Add(this.BTN_Save);
            this.panelEx1.Controls.Add(this.CB_FeeType);
            this.panelEx1.Controls.Add(this.dataGridViewX1);
            this.panelEx1.Controls.Add(this.labelX16);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(381, 380);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // LB_StudentName
            // 
            // 
            // 
            // 
            this.LB_StudentName.BackgroundStyle.Class = "";
            this.LB_StudentName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LB_StudentName.Location = new System.Drawing.Point(39, 32);
            this.LB_StudentName.Name = "LB_StudentName";
            this.LB_StudentName.Size = new System.Drawing.Size(231, 25);
            this.LB_StudentName.TabIndex = 42;
            this.LB_StudentName.Text = "姓名：";
            // 
            // LB_StudentId
            // 
            // 
            // 
            // 
            this.LB_StudentId.BackgroundStyle.Class = "";
            this.LB_StudentId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LB_StudentId.Location = new System.Drawing.Point(39, 5);
            this.LB_StudentId.Name = "LB_StudentId";
            this.LB_StudentId.Size = new System.Drawing.Size(231, 21);
            this.LB_StudentId.TabIndex = 41;
            this.LB_StudentId.Text = "学号：";
            // 
            // BTN_Save
            // 
            this.BTN_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Save.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Save.Image")));
            this.BTN_Save.Location = new System.Drawing.Point(276, 63);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(87, 21);
            this.BTN_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Save.TabIndex = 40;
            this.BTN_Save.Text = "保存更改";
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // CB_FeeType
            // 
            this.CB_FeeType.DisplayMember = "Text";
            this.CB_FeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_FeeType.FormattingEnabled = true;
            this.CB_FeeType.ItemHeight = 15;
            this.CB_FeeType.Items.AddRange(new object[] {
            this.comboItem1});
            this.CB_FeeType.Location = new System.Drawing.Point(76, 63);
            this.CB_FeeType.Name = "CB_FeeType";
            this.CB_FeeType.Size = new System.Drawing.Size(180, 21);
            this.CB_FeeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CB_FeeType.TabIndex = 39;
            this.CB_FeeType.Text = "学历教育";
            this.CB_FeeType.SelectedIndexChanged += new System.EventHandler(this.CB_FeeType_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "学历教育";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
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
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Term,
            this.FeeY,
            this.FeeS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(14, 106);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(349, 259);
            this.dataGridViewX1.TabIndex = 38;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(14, 63);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(69, 21);
            this.labelX16.TabIndex = 37;
            this.labelX16.Text = "学生类别：";
            // 
            // Term
            // 
            this.Term.DataPropertyName = "Term";
            this.Term.HeaderText = "阶段";
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            // 
            // FeeY
            // 
            this.FeeY.DataPropertyName = "FeeY";
            this.FeeY.HeaderText = "学费额度";
            this.FeeY.Name = "FeeY";
            this.FeeY.ReadOnly = true;
            // 
            // FeeS
            // 
            this.FeeS.DataPropertyName = "FeeS";
            this.FeeS.HeaderText = "实际缴纳";
            this.FeeS.Name = "FeeS";
            this.FeeS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FeeS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetOK,
            this.SetZero});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // SetOK
            // 
            this.SetOK.Name = "SetOK";
            this.SetOK.Size = new System.Drawing.Size(135, 22);
            this.SetOK.Text = "设为已缴完费用";
            // 
            // SetZero
            // 
            this.SetZero.Name = "SetZero";
            this.SetZero.Size = new System.Drawing.Size(135, 22);
            this.SetZero.Text = "设为0";
            // 
            // SingleEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "SingleEditPanel";
            this.Size = new System.Drawing.Size(381, 380);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CB_FeeType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.ButtonX BTN_Save;
        private DevComponents.DotNetBar.LabelX LB_StudentName;
        private DevComponents.DotNetBar.LabelX LB_StudentId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Term;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn FeeY;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SetOK;
        private System.Windows.Forms.ToolStripMenuItem SetZero;
    }
}
