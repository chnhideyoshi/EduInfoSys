namespace EduInfoSystem.FeeManagement
{
    partial class ImportXLSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportXLSForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_Folder = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.BTN_OK = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.StudentName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.IdentificationId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.FeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Folder
            // 
            this.BTN_Folder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Folder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Folder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Folder.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Folder.Image")));
            this.BTN_Folder.Location = new System.Drawing.Point(199, 361);
            this.BTN_Folder.Name = "BTN_Folder";
            this.BTN_Folder.Size = new System.Drawing.Size(86, 23);
            this.BTN_Folder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Folder.TabIndex = 9;
            this.BTN_Folder.Text = "选择文件";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancel.Image")));
            this.BTN_Cancel.Location = new System.Drawing.Point(452, 361);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(79, 23);
            this.BTN_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Cancel.TabIndex = 8;
            this.BTN_Cancel.Text = "取消";
            // 
            // BTN_OK
            // 
            this.BTN_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_OK.Image = ((System.Drawing.Image)(resources.GetObject("BTN_OK.Image")));
            this.BTN_OK.Location = new System.Drawing.Point(330, 361);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(81, 23);
            this.BTN_OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_OK.TabIndex = 7;
            this.BTN_OK.Text = "确认导入";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
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
            this.StudentName,
            this.IdentificationId,
            this.FeeType,
            this.Term,
            this.FeeS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(2, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(737, 343);
            this.dataGridViewX1.TabIndex = 6;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // IdentificationId
            // 
            this.IdentificationId.HeaderText = "身份证";
            this.IdentificationId.Name = "IdentificationId";
            this.IdentificationId.ReadOnly = true;
            // 
            // FeeType
            // 
            this.FeeType.HeaderText = "收费类别";
            this.FeeType.Name = "FeeType";
            // 
            // Term
            // 
            this.Term.HeaderText = "交费阶段";
            this.Term.Name = "Term";
            // 
            // FeeS
            // 
            this.FeeS.HeaderText = "费用";
            this.FeeS.Name = "FeeS";
            // 
            // ImportXLSForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 389);
            this.Controls.Add(this.BTN_Folder);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.dataGridViewX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportXLSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入交费表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX BTN_Folder;
        private DevComponents.DotNetBar.ButtonX BTN_Cancel;
        private DevComponents.DotNetBar.ButtonX BTN_OK;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn StudentName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn IdentificationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeS;
    }
}