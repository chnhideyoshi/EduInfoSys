using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace EduInfoSystem
{
    public partial class MainForm : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
            InitEventHandlers();
        }

        private void Init()
        {
            ribbonPanel1.Visible = true;
            this.SetAuthority();
        }

        private void InitEventHandlers()
        {
            #region BaseInfo
            BTN_ShowBaseInfo.Click += (sender, e) => 
            {
                NavigateTo<BaseInfo.GridPanel>();
            };
            BTN_ImportBaseInfo.Click += (sender, e) => 
            {
                BaseInfo.ImportXLSForm.ShowForm();
            };
            BTN_ExportBaseInfo.Click += (sender, e) => 
            {
                 ToolControls.PublicExportForm.ShowForm(-1);
            };
            BTN_HeadImageManage.Click += (sender, e) => 
            {
                BaseInfo.HeadImageManageForm.ShowForm();
            };
            BTN_EditBaseInfo.Click += (sender, e) => 
            {
                NavigateTo<BaseInfo.EditPanel>();
            };
            #endregion 
            #region IC
            BTN_CreatIC.Click += (sender, e) => 
            {
                ICManagement.NewICMadeForm.ShowForm();
            };
            BTN_LockIC.Click += (sender, e) => 
            {
                ICManagement.LockICForm.ShowForm();
            };
            BTN_Unlock.Click += (sender, e) => 
            {
                NavigateTo<ICManagement.ICPanel>();
            };
            BTN_ReNew.Click += (sender, e) =>
                {
                    ICManagement.NewICMadeForm.ShowForm();
                };
            BTN_ExportIC.Click += (sender, e) => 
            {
                EduInfoSystem.ToolControls.PublicExportForm.ShowForm(1);
            };
            #endregion
            #region Auth
            BTN_AuthManagement.Click += (sender, e) => 
            {
                NavigateTo<AuthorityManagement.AuthPanel>();
            };
            #endregion
            #region Fee
            this.BTN_ViewFee.Click += (sender, e) => 
            {
                NavigateTo<FeeManagement.FeePanel>();
            };
            #endregion
        }

       public T NavigateTo<T>() where T : UserControl
        {
            if (panelEx1.Controls.Count != 0)
            {
                #region ReserveControls
                GlobalControlCache.ReserveControl(panelEx1.Controls[0]);
                #endregion
            }
            panelEx1.Controls.Clear();
            if (GlobalControlCache.ExistControl(typeof(T)))
            {
                T control = GlobalControlCache.GetInstance<T>();
                panelEx1.Controls.Add(control);
                control.Refresh();
                return control;
            }
            else
            {
                T a = Activator.CreateInstance<T>();
                panelEx1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                return a;
            }
        }

       public UserControl GetCurrentPanel()
       {
           if (this.panelEx1.Controls.Count != 0)
               return (UserControl)this.panelEx1.Controls[0];
           else
               return null;
       }
      
       public void SetAuthority()
       {
           this.LB_CurrentUser.Text = string.Format("当前用户：{0}[{1}]",Program.Authority.UserName,Program.Authority.AuthType);
           //switch (Program.Authority.AuthType)
           //{

           //}
       }

    }
}