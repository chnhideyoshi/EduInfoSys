namespace EduInfoSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.BTN_ViewFee = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_ImportFee = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_FeeType = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.BTN_CreatIC = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_LockIC = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_Unlock = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_ReNew = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_ExportIC = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BTN_ShowBaseInfo = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_ImportBaseInfo = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_ExportBaseInfo = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_EditBaseInfo = new DevComponents.DotNetBar.ButtonItem();
            this.BTN_HeadImageManage = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.BTN_AuthManagement = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanel6 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.IC卡管理 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem3 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem5 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem6 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.LB_CurrentUser = new DevComponents.DotNetBar.LabelX();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CanCustomize = false;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Controls.Add(this.ribbonPanel5);
            this.ribbonControl1.Controls.Add(this.ribbonPanel6);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.IC卡管理,
            this.ribbonTabItem3,
            this.ribbonTabItem5,
            this.ribbonTabItem6,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1});
            this.ribbonControl1.Size = new System.Drawing.Size(934, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.UseCustomizeDialog = false;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBar2);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(934, 96);
            // 
            // 
            // 
            this.ribbonPanel3.Style.Class = "";
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.Class = "";
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.Class = "";
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTN_ViewFee,
            this.BTN_ImportFee,
            this.buttonItem6,
            this.BTN_FeeType});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(265, 93);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTN_ViewFee
            // 
            this.BTN_ViewFee.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ViewFee.Image")));
            this.BTN_ViewFee.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_ViewFee.Name = "BTN_ViewFee";
            this.BTN_ViewFee.SubItemsExpandWidth = 14;
            this.BTN_ViewFee.Text = "查看数据";
            // 
            // BTN_ImportFee
            // 
            this.BTN_ImportFee.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ImportFee.Image")));
            this.BTN_ImportFee.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_ImportFee.Name = "BTN_ImportFee";
            this.BTN_ImportFee.SubItemsExpandWidth = 14;
            this.BTN_ImportFee.Text = "数据导入";
            // 
            // buttonItem6
            // 
            this.buttonItem6.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem6.Image")));
            this.buttonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 14;
            this.buttonItem6.Text = "数据导出";
            // 
            // BTN_FeeType
            // 
            this.BTN_FeeType.Image = ((System.Drawing.Image)(resources.GetObject("BTN_FeeType.Image")));
            this.BTN_FeeType.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_FeeType.Name = "BTN_FeeType";
            this.BTN_FeeType.SubItemsExpandWidth = 14;
            this.BTN_FeeType.Text = "学生类别";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(934, 96);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 7;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTN_CreatIC,
            this.BTN_LockIC,
            this.BTN_Unlock,
            this.BTN_ReNew,
            this.BTN_ExportIC});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(294, 93);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTN_CreatIC
            // 
            this.BTN_CreatIC.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CreatIC.Image")));
            this.BTN_CreatIC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_CreatIC.Name = "BTN_CreatIC";
            this.BTN_CreatIC.SubItemsExpandWidth = 14;
            this.BTN_CreatIC.Text = "建卡";
            // 
            // BTN_LockIC
            // 
            this.BTN_LockIC.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LockIC.Image")));
            this.BTN_LockIC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_LockIC.Name = "BTN_LockIC";
            this.BTN_LockIC.SubItemsExpandWidth = 14;
            this.BTN_LockIC.Text = "挂失";
            // 
            // BTN_Unlock
            // 
            this.BTN_Unlock.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Unlock.Image")));
            this.BTN_Unlock.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Unlock.Name = "BTN_Unlock";
            this.BTN_Unlock.SubItemsExpandWidth = 14;
            this.BTN_Unlock.Text = "解挂";
            // 
            // BTN_ReNew
            // 
            this.BTN_ReNew.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ReNew.Image")));
            this.BTN_ReNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_ReNew.Name = "BTN_ReNew";
            this.BTN_ReNew.SubItemsExpandWidth = 14;
            this.BTN_ReNew.Text = "补办";
            // 
            // BTN_ExportIC
            // 
            this.BTN_ExportIC.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ExportIC.Image")));
            this.BTN_ExportIC.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_ExportIC.Name = "BTN_ExportIC";
            this.BTN_ExportIC.SubItemsExpandWidth = 14;
            this.BTN_ExportIC.Text = "导出数据";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(934, 96);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTN_ShowBaseInfo,
            this.BTN_ImportBaseInfo,
            this.BTN_ExportBaseInfo,
            this.BTN_EditBaseInfo,
            this.BTN_HeadImageManage});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(333, 93);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTN_ShowBaseInfo
            // 
            this.BTN_ShowBaseInfo.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ShowBaseInfo.Image")));
            this.BTN_ShowBaseInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_ShowBaseInfo.Name = "BTN_ShowBaseInfo";
            this.BTN_ShowBaseInfo.SubItemsExpandWidth = 14;
            this.BTN_ShowBaseInfo.Text = "查看数据";
            // 
            // BTN_ImportBaseInfo
            // 
            this.BTN_ImportBaseInfo.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ImportBaseInfo.Image")));
            this.BTN_ImportBaseInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_ImportBaseInfo.Name = "BTN_ImportBaseInfo";
            this.BTN_ImportBaseInfo.SubItemsExpandWidth = 14;
            this.BTN_ImportBaseInfo.Text = "导入数据";
            // 
            // BTN_ExportBaseInfo
            // 
            this.BTN_ExportBaseInfo.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ExportBaseInfo.Image")));
            this.BTN_ExportBaseInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_ExportBaseInfo.Name = "BTN_ExportBaseInfo";
            this.BTN_ExportBaseInfo.SubItemsExpandWidth = 14;
            this.BTN_ExportBaseInfo.Text = "导出数据";
            // 
            // BTN_EditBaseInfo
            // 
            this.BTN_EditBaseInfo.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EditBaseInfo.Image")));
            this.BTN_EditBaseInfo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_EditBaseInfo.Name = "BTN_EditBaseInfo";
            this.BTN_EditBaseInfo.SubItemsExpandWidth = 14;
            this.BTN_EditBaseInfo.Text = "编辑信息";
            // 
            // BTN_HeadImageManage
            // 
            this.BTN_HeadImageManage.Image = ((System.Drawing.Image)(resources.GetObject("BTN_HeadImageManage.Image")));
            this.BTN_HeadImageManage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_HeadImageManage.Name = "BTN_HeadImageManage";
            this.BTN_HeadImageManage.SubItemsExpandWidth = 14;
            this.BTN_HeadImageManage.Text = "照片管理";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Controls.Add(this.ribbonBar4);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(934, 96);
            // 
            // 
            // 
            this.ribbonPanel4.Style.Class = "";
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.Class = "";
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.Class = "";
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 8;
            this.ribbonPanel4.Visible = false;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.Class = "";
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BTN_AuthManagement,
            this.buttonItem4,
            this.buttonItem8});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(208, 93);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.Class = "";
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.Class = "";
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // BTN_AuthManagement
            // 
            this.BTN_AuthManagement.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AuthManagement.Image")));
            this.BTN_AuthManagement.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_AuthManagement.Name = "BTN_AuthManagement";
            this.BTN_AuthManagement.SubItemsExpandWidth = 14;
            this.BTN_AuthManagement.Text = "权限管理";
            // 
            // buttonItem4
            // 
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "数据库连接";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem8.Image")));
            this.buttonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.SubItemsExpandWidth = 14;
            this.buttonItem8.Text = "更多信息";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(934, 96);
            // 
            // 
            // 
            this.ribbonPanel5.Style.Class = "";
            this.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseDown.Class = "";
            this.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseOver.Class = "";
            this.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel5.TabIndex = 5;
            this.ribbonPanel5.Visible = false;
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel6.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel6.Size = new System.Drawing.Size(934, 96);
            // 
            // 
            // 
            this.ribbonPanel6.Style.Class = "";
            this.ribbonPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel6.StyleMouseDown.Class = "";
            this.ribbonPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel6.StyleMouseOver.Class = "";
            this.ribbonPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel6.TabIndex = 6;
            this.ribbonPanel6.Visible = false;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "基本信息维护";
            // 
            // IC卡管理
            // 
            this.IC卡管理.Name = "IC卡管理";
            this.IC卡管理.Panel = this.ribbonPanel2;
            this.IC卡管理.Text = "IC卡管理";
            // 
            // ribbonTabItem3
            // 
            this.ribbonTabItem3.Checked = true;
            this.ribbonTabItem3.Name = "ribbonTabItem3";
            this.ribbonTabItem3.Panel = this.ribbonPanel3;
            this.ribbonTabItem3.Text = "学费情况";
            // 
            // ribbonTabItem5
            // 
            this.ribbonTabItem5.Name = "ribbonTabItem5";
            this.ribbonTabItem5.Panel = this.ribbonPanel5;
            this.ribbonTabItem5.Text = "成绩管理";
            // 
            // ribbonTabItem6
            // 
            this.ribbonTabItem6.Name = "ribbonTabItem6";
            this.ribbonTabItem6.Panel = this.ribbonPanel6;
            this.ribbonTabItem6.Text = "毕业情况";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel4;
            this.ribbonTabItem2.Text = "系统设置";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.Image = ((System.Drawing.Image)(resources.GetObject("office2007StartButton1.Image")));
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(5, 155);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(934, 535);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // LB_CurrentUser
            // 
            this.LB_CurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.LB_CurrentUser.BackgroundStyle.Class = "";
            this.LB_CurrentUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LB_CurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("LB_CurrentUser.Image")));
            this.LB_CurrentUser.Location = new System.Drawing.Point(764, 32);
            this.LB_CurrentUser.Name = "LB_CurrentUser";
            this.LB_CurrentUser.Size = new System.Drawing.Size(172, 19);
            this.LB_CurrentUser.TabIndex = 2;
            this.LB_CurrentUser.Text = "当前用户：XXX";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(944, 692);
            this.Controls.Add(this.LB_CurrentUser);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.ribbonControl1);
            this.EnableGlass = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "北京服装学院继续教育学院学生信息管理系统";
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel6;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem3;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem5;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem6;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BTN_ImportBaseInfo;
        private DevComponents.DotNetBar.ButtonItem BTN_ExportBaseInfo;
        private DevComponents.DotNetBar.ButtonItem BTN_EditBaseInfo;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem IC卡管理;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem BTN_ImportFee;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem BTN_CreatIC;
        private DevComponents.DotNetBar.ButtonItem BTN_LockIC;
        private DevComponents.DotNetBar.ButtonItem BTN_Unlock;
        private DevComponents.DotNetBar.ButtonItem BTN_ReNew;
        private DevComponents.DotNetBar.ButtonItem BTN_ShowBaseInfo;
        private DevComponents.DotNetBar.ButtonItem BTN_ViewFee;
        private DevComponents.DotNetBar.LabelX LB_CurrentUser;
        private DevComponents.DotNetBar.ButtonItem BTN_ExportIC;
        private DevComponents.DotNetBar.ButtonItem BTN_FeeType;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem BTN_AuthManagement;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonItem BTN_HeadImageManage;

    }
}