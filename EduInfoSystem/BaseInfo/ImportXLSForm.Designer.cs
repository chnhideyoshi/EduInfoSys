namespace EduInfoSystem.BaseInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportXLSForm));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ExamId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.StudentId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.StudentName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Gender = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.BornData = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.IdentificationId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.PoliticalFace = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Nationality = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MajorId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.MajorName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ClassId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Level = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.EduSys = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.StudyMethod = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.EnterDate = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.CurrentGrade = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.BTN_OK = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Folder = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
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
            this.ExamId,
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.BornData,
            this.IdentificationId,
            this.PoliticalFace,
            this.Nationality,
            this.MajorId,
            this.MajorName,
            this.ClassId,
            this.Level,
            this.EduSys,
            this.StudyMethod,
            this.EnterDate,
            this.CurrentGrade});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(800, 365);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // ExamId
            // 
            this.ExamId.HeaderText = "考生号";
            this.ExamId.Name = "ExamId";
            this.ExamId.ReadOnly = true;
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // BornData
            // 
            this.BornData.HeaderText = "出生日期";
            this.BornData.Name = "BornData";
            this.BornData.ReadOnly = true;
            // 
            // IdentificationId
            // 
            this.IdentificationId.HeaderText = "身份证";
            this.IdentificationId.Name = "IdentificationId";
            this.IdentificationId.ReadOnly = true;
            // 
            // PoliticalFace
            // 
            this.PoliticalFace.HeaderText = "政治面貌";
            this.PoliticalFace.Name = "PoliticalFace";
            this.PoliticalFace.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "民族";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // MajorId
            // 
            this.MajorId.HeaderText = "专业代码";
            this.MajorId.Name = "MajorId";
            this.MajorId.ReadOnly = true;
            // 
            // MajorName
            // 
            this.MajorName.HeaderText = "专业名称";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;
            // 
            // ClassId
            // 
            this.ClassId.HeaderText = "班号";
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "层次";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // EduSys
            // 
            this.EduSys.HeaderText = "学制";
            this.EduSys.Name = "EduSys";
            this.EduSys.ReadOnly = true;
            // 
            // StudyMethod
            // 
            this.StudyMethod.HeaderText = "学习形式";
            this.StudyMethod.Name = "StudyMethod";
            this.StudyMethod.ReadOnly = true;
            // 
            // EnterDate
            // 
            this.EnterDate.HeaderText = "入学日期";
            this.EnterDate.Name = "EnterDate";
            this.EnterDate.ReadOnly = true;
            // 
            // CurrentGrade
            // 
            this.CurrentGrade.HeaderText = "当前所在级";
            this.CurrentGrade.Name = "CurrentGrade";
            this.CurrentGrade.ReadOnly = true;
            // 
            // BTN_OK
            // 
            this.BTN_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_OK.Image = ((System.Drawing.Image)(resources.GetObject("BTN_OK.Image")));
            this.BTN_OK.Location = new System.Drawing.Point(347, 392);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(81, 23);
            this.BTN_OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_OK.TabIndex = 1;
            this.BTN_OK.Text = "确认导入";
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancel.Image")));
            this.BTN_Cancel.Location = new System.Drawing.Point(484, 392);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(79, 23);
            this.BTN_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.Text = "取消";
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Folder
            // 
            this.BTN_Folder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Folder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Folder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Folder.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Folder.Image")));
            this.BTN_Folder.Location = new System.Drawing.Point(212, 392);
            this.BTN_Folder.Name = "BTN_Folder";
            this.BTN_Folder.Size = new System.Drawing.Size(86, 23);
            this.BTN_Folder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Folder.TabIndex = 5;
            this.BTN_Folder.Text = "选择文件";
            this.BTN_Folder.Click += new System.EventHandler(this.BTN_Folder_Click);
            // 
            // ImportXLSForm
            // 
            this.ClientSize = new System.Drawing.Size(810, 427);
            this.Controls.Add(this.BTN_Folder);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.dataGridViewX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportXLSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "确认导入数据";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX BTN_OK;
        private DevComponents.DotNetBar.ButtonX BTN_Cancel;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ExamId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn StudentId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn StudentName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Gender;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn BornData;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn IdentificationId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn PoliticalFace;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Nationality;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MajorId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn MajorName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ClassId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Level;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn EduSys;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn StudyMethod;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn EnterDate;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn CurrentGrade;
        private DevComponents.DotNetBar.ButtonX BTN_Folder;
    }
}