using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EduInfoSystem.Model;
using DevComponents.DotNetBar.Controls;

namespace EduInfoSystem.BaseInfo
{
    public partial class ComplexInfoPanel : UserControl
    {
        public ComplexInfoPanel()
        {
            InitializeComponent();
            Init();
            InitEventHandler();
        }

        private void Init()
        {
            singleEditPanel1.IsEditable = false;
        }

        private void InitEventHandler()
        {

        }

        public void SetContentToControl(Model.Student student)
        {
            if (this.Tag == null || ((Model.Student)this.Tag).StudentId != student.StudentId)
            {
                this.Tag = student;
                this.TB_StudentId.Text=student.StudentId;
                this.TB_StudentName.Text=student.StudentName;
                this.TB_Gender.Text=student.Gender;
                this.TB_IdentificationId.Text = student.IdentificationId;
                this.TB_PoliticalFace.Text=student.PoliticalFace;
                this.TB_Nationality.Text=student.Nationality;
                this.TB_BornDate.Text=student.BornDate;
                this.TB_ExamId.Text=student.ExamId;
                this.TB_MajorId.Text=student.MajorId;
                this.TB_MajorName.Text=student.MajorName;
                this.TB_ClassId.Text=student.ClassId;
                this.TB_Level.Text=student.Level;
                this.TB_EduSys.Text=student.EduSys;
                this.TB_EnterDate.Text=student.EnterDate;
                this.TB_StudyMethod.Text=student.StudyMethod;
                this.TB_CurrentGrade.Text=student.CurrentGrade;
                LoadPicture(pictureBox1, DataCalls.GetImageData(student.IdentificationId));
                CardInfo cardInfo = DataCalls.GetCardInfoByStudentId(student.StudentId);
                if (cardInfo != null)
                {
                    TB_CardId.Text = cardInfo.CardId;
                    TB_State.Text = cardInfo.State;
                }
                FeeInfo feeInfo = DataCalls.GetFeeInfo(student.StudentId);
                this.singleEditPanel1.SetData(feeInfo);

            }
            
        }
        public static void LoadPicture(PictureBox pictureBox, byte[] data)
        {
            if (data == null) 
            {
                pictureBox.Image=Image.FromFile("Image\\ImageOnload\\default.bmp");
                return;
            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream(data, 0, data.Length);
            pictureBox.Image = Image.FromStream(ms, true);
            ms.Dispose();
        }
   
    }
}
