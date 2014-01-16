namespace EduInfoSystem.AuthorityManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Close = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Login = new DevComponents.DotNetBar.ButtonX();
            this.TB_UserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CB_AuthType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Admin = new DevComponents.Editors.ComboItem();
            this.Finance = new DevComponents.Editors.ComboItem();
            this.Other = new DevComponents.Editors.ComboItem();
            this.TB_Pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Close
            // 
            this.BTN_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Close.Location = new System.Drawing.Point(227, 178);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "取消";
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Login
            // 
            this.BTN_Login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Login.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Login.Image")));
            this.BTN_Login.Location = new System.Drawing.Point(95, 178);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(75, 23);
            this.BTN_Login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Login.TabIndex = 2;
            this.BTN_Login.Text = "登入";
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // TB_UserName
            // 
            // 
            // 
            // 
            this.TB_UserName.Border.Class = "TextBoxBorder";
            this.TB_UserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TB_UserName.Location = new System.Drawing.Point(162, 104);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(121, 21);
            this.TB_UserName.TabIndex = 3;
            this.TB_UserName.Text = "admin";
            // 
            // CB_AuthType
            // 
            this.CB_AuthType.DisplayMember = "Text";
            this.CB_AuthType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_AuthType.FormattingEnabled = true;
            this.CB_AuthType.ItemHeight = 15;
            this.CB_AuthType.Items.AddRange(new object[] {
            this.Admin,
            this.Finance,
            this.Other});
            this.CB_AuthType.Location = new System.Drawing.Point(162, 74);
            this.CB_AuthType.Name = "CB_AuthType";
            this.CB_AuthType.Size = new System.Drawing.Size(121, 21);
            this.CB_AuthType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CB_AuthType.TabIndex = 4;
            this.CB_AuthType.Text = "管理员";
            // 
            // Admin
            // 
            this.Admin.Text = "管理员";
            // 
            // Finance
            // 
            this.Finance.Text = "财务";
            // 
            // Other
            // 
            this.Other.Text = "待添加";
            // 
            // TB_Pwd
            // 
            // 
            // 
            // 
            this.TB_Pwd.Border.Class = "TextBoxBorder";
            this.TB_Pwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TB_Pwd.Location = new System.Drawing.Point(162, 134);
            this.TB_Pwd.Name = "TB_Pwd";
            this.TB_Pwd.PasswordChar = '*';
            this.TB_Pwd.Size = new System.Drawing.Size(121, 21);
            this.TB_Pwd.TabIndex = 5;
            this.TB_Pwd.Text = "admin";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(84, 75);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 21);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "用户类别：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(95, 105);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 21);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "用户名：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(109, 135);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(43, 21);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "密码：";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.BTN_Close);
            this.panelEx1.Controls.Add(this.BTN_Login);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(376, 213);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(376, 213);
            this.Controls.Add(this.TB_Pwd);
            this.Controls.Add(this.CB_AuthType);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "学生信息管理系统登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX BTN_Close;
        private DevComponents.DotNetBar.ButtonX BTN_Login;
        private DevComponents.DotNetBar.Controls.TextBoxX TB_UserName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CB_AuthType;
        private DevComponents.DotNetBar.Controls.TextBoxX TB_Pwd;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.Editors.ComboItem Admin;
        private DevComponents.Editors.ComboItem Finance;
        private DevComponents.Editors.ComboItem Other;
    }
}