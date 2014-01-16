using System;
using System.Collections.Generic;
using System.Text;
using EduInfoSystem.Model;
using System.IO;

namespace EduInfoSystem
{
    public class Tools
    {
        public static void InsertSampleData()
        {
            List<Model.Student> list = DataCalls.GetAllStudents();
            if (list.Count > 10) { return; }
            list.Clear();
            Random r = new Random();
            RandomGenerator.DateGenerator rd=new RandomGenerator.DateGenerator();
            RandomGenerator.NameGenerator rn = new RandomGenerator.NameGenerator();
            RandomGenerator.WorkNumberGenerator rw = new RandomGenerator.WorkNumberGenerator();
            RandomGenerator.SetRandomSelector<string> sw = new RandomGenerator.SetRandomSelector<string>();
            sw.ObjectSet = new List<string> { "0011","0012","0013","0014","0015" };
            for (int i = 0; i < 600; i++)
            { 
                Model.Student stu = Model.Student.CreateSample();
                int j = r.Next(1, 100);
                if (j % 2 == 0)
                {
                    stu.StudentName = rn.GetARadomInstance(true);
                    stu.Gender = "男";
                    stu.StudyMethod="夜大学";
                }
                else
                {
                    stu.StudentName = rn.GetARadomInstance(false);
                    stu.Gender = "女";
                    stu.StudyMethod="脱产";
                }
                stu.StudentId=rw.GetARadomInstance("5",7);
                stu.ExamId=rw.GetARadomInstance("0411010",9);
                stu.IdentificationId = rw.GetARadomInstance("", 14);
                stu.CurrentGrade = "200" + j % 3;
                stu.ClassId = sw.GetARandomInstance(false);
                //stu.MajorId = rw.GetARadomInstance("0", 4);
                if (j % 6 != 0)
                    stu.Nationality = "汉族";
                else
                    stu.Nationality = "回族";
                if (j % 4 != 0)
                    stu.PoliticalFace = "群众";
                else
                    stu.PoliticalFace = "共青团员";
                if (j % 3 == 0)
                {
                    stu.MajorName = "环境艺术设计";
                    stu.MajorId = "00001";
                }
                else
                {
                    stu.MajorName = "服装设计";
                    stu.MajorId = "00002";
                }
               stu.BornDate=rd.GetARadomInstance("1985-1-1","1994-12-12",false);
               list.Add(stu);
            }
            DataCalls.InsertStudentList(list);
        }

        internal static void ModifyImageNames()
        {
            List<Student> list = DataCalls.GetAllStudents();
            string[] files = Directory.GetFiles(@"C:\Users\chnhideyoshi\Desktop\images");
            for (int i = 0; i < list.Count; i++)
            {
                File.Move(files[i], Path.GetDirectoryName(files[i]) + "\\" + list[i].IdentificationId + ".jpg");
            }
        }

        public static void InsertSampleICData()
        {
            RandomGenerator.WorkNumberGenerator wr = new RandomGenerator.WorkNumberGenerator();
            List<CardInfo> list1 = new List<CardInfo>();
            List<Model.Student> list = DataCalls.GetAllStudents();
            for (int i = 0; i < list.Count; i++)
            {
                string cardId = wr.GetARadomInstance("CARD", 8);
                list1.Add(new CardInfo() {CardId=cardId,StudentId=list[i].StudentId,State="正常"});
            }
            DataCalls.InsertCardInfoList(list1);
        }

        public static void InsertSampleFeeData()
        {
            RandomGenerator.SetRandomSelector<string> srs = new RandomGenerator.SetRandomSelector<string>();
            srs.ObjectSet = new List<string>()
            {
                "高起专_业余",
                "高起专_集中授课",
                "高起本_业余",
                "高起本_集中授课",
                "专升本_艺术类_业余",
                "专升本_艺术类_集中授课",
                "专升本_非艺术类_业余"
            };
            RandomGenerator.SetRandomSelector<double> srs2 = new RandomGenerator.SetRandomSelector<double>();
            srs2.ObjectSet = new List<double>() { 0,0.5,1};
            List<string> ids = DataCalls.GetStudentIds("");
            List<FeeInfo> feeslist = new List<FeeInfo>();
            for (int i = 0; i < ids.Count; i++)
            {
                FeeInfo info = new FeeInfo();
                info.StudentId = ids[i];
                info.FeeType = srs.GetARandomInstance(false);
                int[] feecrilist = FeeManagement.FeeManager.GetFeeCriList(info.FeeType);
                int[] fees=new int[feecrilist.Length];
                for (int j = 0; j < fees.Length; j++)
                {
                    fees[j] = (int)(srs2.GetARandomInstance(false) * feecrilist[j]);
                }
                info.FeeDetail = FeeManagement.FeeManager.ParseString(fees);
                feeslist.Add(info);
            }
            DataCalls.InsertFeeInfoList(feeslist);
        }
    }
}
