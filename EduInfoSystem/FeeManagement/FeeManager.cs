using System;
using System.Collections.Generic;
using System.Text;
using EduInfoSystem.Model;

namespace EduInfoSystem.FeeManagement
{
    public class FeeManager
    {
        public FeeManager(FeeInfo info)
        {
            int[] feelist = null;
            FeeType = info.FeeType;
            Parse(info.FeeDetail, out feelist);
            FeeList = feelist;
        }
        public string FeeType
        {
            get;
            set;
        }
        public int Sum
        {
            get 
            { 
                int sum = 0;
                for (int i = 0; i < FeeList.Length; i++)
                    sum += FeeList[i];
                return sum;
            }
        }
        public int Time 
        { get { return FeeList.Length; } }
        public int[] FeeList { get; set; }
        public FeeInfo ToFeeInfo()
        {
            return ConvertToFeeInfo(this);
        }
        public static void Parse(string detailString,out int[] list)
        {
            string[] s = detailString.Split(' ');
            if (s.Length != 2)
                throw new Exception();
            int sum = int.Parse(s[0]);
            string[] ss = s[1].Split(',','，');
            int time = ss.Length;
            list = new int[time];
            for (int i = 0; i < time; i++)
                list[i] = int.Parse(ss[i]);
            int sum2 = 0;
            for (int i = 0; i < list.Length; i++)
                sum2 += list[i];
            if (sum2 != sum)
                throw new Exception();
        }
        public static string ParseString(int[] feeList)
        {
            int sum = 0;
            for (int i = 0; i < feeList.Length; i++)
                sum += feeList[i];
            StringBuilder sb = new StringBuilder();
            sb.Append(sum + " ");
            for (int i = 0; i < feeList.Length; i++)
            {
                sb.Append(feeList[i] + ",");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        public static List<string> GetFeeTypes()
        {
            return Program.ConfigReader.GetFeeType();
        }
        public static string ParseDetailString(FeeManager detail)
        {
            return ParseString(detail.FeeList);
        }
        public static Model.FeeInfo ConvertToFeeInfo(FeeManager detail)
        {
            FeeInfo feeinfo = new FeeInfo();
            feeinfo.FeeType = detail.FeeType;
            feeinfo.FeeDetail = ParseDetailString(detail);
            return feeinfo;
        }
        public static int[] GetFeeCriList(string typename)
        {
            string s = Program.ConfigReader.GetFeeCriString(typename);
            int[] list = null;
            Parse(s, out list);
            return list;
        }
        public static int GetSumCri(int[] feeCriList)
        {
            int sum = 0;
            for (int i = 0; i < feeCriList.Length; i++)
                sum += feeCriList[i];
            return sum;
        }
        public static string[] GetFeeCriDesciption(string typename)
        {
            string s = Program.ConfigReader.GetFeeCriDescriptionString(typename);
            return s.Split('，',',');
        }
    }
}
