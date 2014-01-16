using System;
using System.Collections.Generic;
using System.Text;

namespace EduInfoSystem.Model
{
    public class Student : BaseObject
    {
        [RealName(RealName = "学号"),SortModeAttribute(SortMode=SortModes.String)]
        [NullDescription(NullDescription = "未分配")]
        public string StudentId { get; set; }

        [RealName(RealName = "姓名"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string StudentName { get; set; }

        [RealName(RealName = "出生日期"), SortModeAttribute(SortMode = SortModes.Date)]
        [NullDescription(NullDescription = "未设置")]
        public string BornDate { get; set; }

        [RealName(RealName = "性别"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string Gender { get; set; }

        [RealName(RealName = "身份证"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string IdentificationId { get; set; }

        [RealName(RealName = "政治面貌"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string PoliticalFace { get; set; }

        [RealName(RealName = "民族"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string Nationality { get; set; }

        [RealName(RealName = "考生号"), SortModeAttribute(SortMode =SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string ExamId { get; set; }

        [RealName(RealName = "专业代码"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string MajorId { get; set; }

        [RealName(RealName = "专业名称"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string MajorName { get; set; }

        [RealName(RealName = "班号"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string ClassId { get; set; }

        [RealName(RealName = "层次"), SortModeAttribute(SortMode =SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string Level { get; set; }

        [RealName(RealName = "学制"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string EduSys { get; set; }

        [RealName(RealName = "学习形式"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string StudyMethod { get; set; }

        [RealName(RealName = "入学日期"), SortModeAttribute(SortMode = SortModes.Date)]
        [NullDescription(NullDescription = "未设置")]
        public string EnterDate { get; set; }

        [RealName(RealName = "当前所在级"), SortModeAttribute(SortMode = SortModes.String)]
        [NullDescription(NullDescription = "未设置")]
        public string CurrentGrade{ get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public static Student CreateDefault()
        {
            return new Student()
            {
                StudentId = "",
                StudentName = "",
                BornDate = "",
                Gender = "",
                IdentificationId = "",
                PoliticalFace = "",
                Nationality = "",
                ExamId = "",
                MajorId = "",
                MajorName = "",
                ClassId = "",
                Level = "",
                EduSys = "",
                StudyMethod = "",
                EnterDate = "",
                CurrentGrade = "",
            };
        }

        public static Student CreateSample()
        {
            return new Student() 
            {
                StudentId = "513032",
                StudentName = "李延",
                BornDate = "1990-2-3",
                Gender = "男",
                IdentificationId = "4321001987233311221",
                PoliticalFace = "群众",
                Nationality = "汉",
                ExamId = "0411010415300520",
                MajorId = "610204",
                MajorName = "环境艺术设计",
                ClassId = "",
                Level = "专升本",
                EduSys = "3",
                StudyMethod = "夜大学",
                EnterDate = "20050301",
                CurrentGrade = "2005",
            };
        }

       //StudentID 
       //StudentName
       //BornDate
       //Gender 
       //IdentificationID
       //PoliticalFace 
       //Nationality
       //ExamID
       //MajorID 
       //MajorName
       //ClassID
       //Level
       //EduSys 
       //StudyMethod
       //EnterDate
       //CurrentGrade
    }
}
