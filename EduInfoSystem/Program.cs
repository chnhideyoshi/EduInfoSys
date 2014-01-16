using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduInfoSystem.AuthorityManagement;
using System.Reflection;
using EduInfoSystem.Model;

namespace EduInfoSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigReader = new Config.ConfigReader("Config.xml");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (DialogResult.OK == new EduInfoSystem.AuthorityManagement.LoginForm().ShowDialog())
            {
                Application.Run(Program.MainForm);
            }
            //Application.Run();
        }
        public static Config.ConfigReader ConfigReader = null;
        public static AuthInfo Authority = null;
        public static MainForm MainForm = null;
        public static bool ShowConfirmWindow(string message)
        {
            return MessageBox.Show(message, "警告", MessageBoxButtons.OKCancel) == DialogResult.OK;
        }
        public static void ShowWarningWindow(string message)
        {
            MessageBox.Show(message);
        }
        public static void SetControlValue(Type type, string propertyName, object obj)
        {
            switch (type.FullName)
            {
                case "DevComponents.DotNetBar.Controls.TextBoxX": 
                    {
                        PropertyInfo info = typeof(DevComponents.DotNetBar.Controls.TextBoxX).GetProperty("Text");
                    } break;
                case "DevComponents.DotNetBar.LabelX":
                    {

                    } break;
                case "System.Windows.Forms.PictureBox":
                    {
                       
                    } break;
                case "DevComponents.DotNetBar.Controls.ComboBoxEx":
                    {

                    } break;
                case "DevComponents.DotNetBar.Controls.CheckBoxX":
                    {

                    } break;
                case "DevComponents.Editors.DoubleInput":
                    {

                    } break;
                default: return;
            }
            return;
        }
    }
}
