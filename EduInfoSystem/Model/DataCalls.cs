using System;
using System.Collections.Generic;
using System.Text;

using EduInfoSystem.AuthorityManagement;
using System.IO;
using EduInfoSystem.ICManagement;
using System.Data;


namespace EduInfoSystem.Model
{
 
    public class DataCalls
    {
        #region BaseInfo
        public static List<string> GetStudentIds(string condition)
        {
            try
            {
                return DataHelper.GetSetByColumn<string>("Student", "StudentId", condition);
            }
            catch
            {
                return null;
            }
        }
        public static List<string> GetStudentNames(List<string> ids)
        {
            List<string> CmdList = new List<string>();
            for (int i = 0; i < ids.Count; i++)
            {
                CmdList.Add(string.Format("Select StudentName from Student Where StudentId='{0}'", ids[i]));
            }
            return new List<string>(DataHelper.ExecuteCommandListAndGetSimpleResult<string>(CmdList));
        }
        public static string GetStudentName(string stuId)
        {
            try { return (string)DataHelper.ExecuteCommandAndGetSimpleResult(string.Format("Select [StudentName] from Student Where StudentId='{0}'", stuId)); }
            catch { return null; }
        }
        public static Student GetStudent(string stuId)
        {
            try
            {
                List<Student> list = DataHelper.GetObject<Student>(string.Format("where studentid='{0}'", stuId));
                if (list.Count > 1)
                    throw new Exception();
                else if (list.Count == 0)
                    return null;
                return list[0];
            }
            catch //(System.Exception ex)
            {
                return null;
            }
        }
        public static List<Model.Student> GetStudents(string condition)
        {
            try
            {
                 List<Student> stuList = DataHelper.GetObject<Student>(condition);
                 return stuList;
            }
            catch //(System.Exception ex)
            {
                return null;
            }
        }
        public static List<Model.Student> GetAllStudents()
        {
            try
            {
                List<Student> stuList = DataHelper.GetObject<Student>("");
                return stuList;
            }
            catch //(System.Exception ex)
            {
                return null;
            }
        }
        public static TableManager GetStudentTable()
        {
            return DataHelper.GetObjectTable("Select * from Student");
        }
        public static int[] InsertStudentList(List<Student> stuList)
        {
            try
            {
                return DataHelper.InsertListObject<Student>(stuList);
            }
            catch
            {
                return null;
            }
        }
        public static bool[] CheckStudentIds(List<string> studentIdList)
        {
            try
            {
                bool[] list = new bool[studentIdList.Count];
                List<string> students = DataHelper.GetSetByColumn<string>("Student","StudentId","");
                for (int i = 0; i < studentIdList.Count; i++)
                {
                    if (students.Contains(studentIdList[i]))
                    {
                        list[i]=true;
                    }
                    else
                    {
                        list[i]=false;
                    }
                }
                return list;
            }
            catch// (System.Exception ex)
            {
                return null;
            }
        }
        public static void UpdateAllHeadImages(string[] files,System.ComponentModel.BackgroundWorker worker)
        {
           try
           {
               List<string> ids=GetAllHeadImageNames();
               DataHelper.InsertUpdateImages(files,ids,worker);
           }
           catch //(System.Exception ex)
           {
           	
           }
        }
        public static byte[] GetImageData(string Id)
        {
            try
            {
                byte[] data = (byte[])DataHelper.ExecuteCommandAndGetSimpleResult("Select ImageData from HeadImage where IdentificationId='" + Id + "'");
                return data;
            }
            catch// (System.Exception ex)
            {
                return null;
            }
        }
        public static List<string> GetAllHeadImageNames()
        {
            try
            {
                return DataHelper.GetSetByColumn<string>("HeadImage", "IdentificationId", "");
            }
            catch// (System.Exception ex)
            {
                return new List<string>();
            }
        }
        public static void ExportStudentData(string path)
        {
            TableManager tm = DataHelper.GetObjectTable("Select * from Student");
            for (int i = 0; i < tm.Table.Columns.Count; i++)
            {
                tm.Table.Columns[i].ColumnName = BaseObject.GetRealName(typeof(Student), tm.Table.Columns[i].ColumnName);
            }
            ExcelHelper.Export(tm.Table, "", path);
        }
        #endregion
        #region Auth
        public static bool? GetUserInfo(string userName,string password,string authType,out AuthInfo auth)
        {
            try
            {
                List<AuthInfo> auList= DataHelper.GetObject<AuthInfo>(string.Format("where username='{0}' and password='{1}' and authtype='{2}'",userName,password,authType));
                if (auList.Count!=1)
                {
                    auth = null;
                    return false;
                }
                else
                {
                    auth = auList[0];
                    return true;
                }
            }
            catch// (System.Exception ex)
            {
                auth = null;
                return null;
            }
        }
        public static TableManager GetAuthTable()
        {
            return DataHelper.GetObjectTable("Select * from AuthInfo");
        }
        #endregion
        #region Card
        public static bool InsertCardInfo(string icCardId, string studentId)
        {
            try
            {
                List<string> idList = DataHelper.GetSetByColumn<string>("CardInfo", "StudentId", "");
                if (idList.Contains(studentId))
                {
                    DataHelper.ExecuteCommand(string.Format("Update CardInfo Set CardId='{0}',State='正常' Where StudentId='{1}'", icCardId, studentId));
                }
                else
                {
                    DataHelper.ExecuteCommand("Insert into CardInfo([CardId],[StudentId],[State]) values ('" + icCardId + "','" + studentId + "','正常')");
                }
                return true;
            }
            catch//(Exception ex)
            {
                return false;
            }
        }
        public static int[] InsertCardInfoList(List<CardInfo> list)
        {
            try
            {
                return DataHelper.InsertListObject<CardInfo>(list);
            }
            catch //(System.Exception ex)
            {
                return null;
            }
        }
        public static List<CardInfo> GetICList()
        {
            try
            {
                List<CardInfo> List = DataHelper.GetObject<CardInfo>("");
                return List;
            }
            catch //(System.Exception ex)
            {
                return null;
            }
        }
        public static TableManager GetICLostTable()
        {
            return DataHelper.GetObjectTable("Select [StudentId],[CardId],[State] from CardInfo where State='挂失'");// INNER JOIN Student  ON Student.StudentId=CardInfo.StudentId");
        }
        public static CardInfo GetCardInfoByStudentId(string stuId)
        {
            try
            {
                return DataHelper.GetObject<CardInfo>("Where StudentId='"+stuId+"'")[0];
            }
            catch //(System.Exception ex)
            {
                return null;
            }
        }
        public static bool UpdateICCardState(string stuId,string state)
        {
            try
            {
                if (state == "正常")
                {
                    int ret=DataHelper.ExecuteCommand("Update CardInfo Set State='正常' where StudentId='" + stuId + "' ");
                    if (ret == 1)
                        return true;
                    else
                        return false;
                }
                if (state == "挂失")
                {
                     int ret=DataHelper.ExecuteCommand("Update CardInfo Set State='挂失' where StudentId='" + stuId + "' ");
                    if (ret == 1)
                        return true;
                    else
                        return false;
                }
                throw new Exception();
            }
            catch// (System.Exception ex)
            {
            	return false;
            }
        }
        public static void ExportICData(string path)
        {
            TableManager tm = DataHelper.GetObjectTable("Select * from CardInfo");
            for (int i = 0; i < tm.Table.Columns.Count; i++)
            {
                tm.Table.Columns[i].ColumnName = BaseObject.GetRealName(typeof(CardInfo), tm.Table.Columns[i].ColumnName);
            }
            ExcelHelper.Export(tm.Table, "", path);
        }
        public static string GetStudentId(string cardId)
        {
            try
            {
                List<CardInfo> list = DataHelper.GetObject<CardInfo>(string.Format("Where cardid='{0}'",cardId));
                if (list.Count > 1)
                    throw new Exception();
                else if (list.Count == 0)
                    return null;
                return list[0].StudentId;
            }
            catch
            {
                return null;
            }
        }
        #endregion
        #region Fee
        public static FeeInfo GetFeeInfo(string studentId)
        {
            try
            {
                List<FeeInfo> list= DataHelper.GetObject<FeeInfo>(string.Format("where studentId='{0}'",studentId));
                if (list.Count != 1)
                    throw new Exception();
                return list[0];
            }
            catch// (System.Exception ex)
            {
                return null;
            }
        }
        public static List<FeeInfo> GetFeeInfoByType(string typeName)
        {
            try
            {
                return DataHelper.GetObject<FeeInfo>(string.Format("Where FeeType='{0}'",typeName));
            }
            catch //(System.Exception ex)
            {
                return null;
            }
        }
        public static bool InsertFeeInfoWithUpdate(FeeInfo fee)
        {
            try
            {
                string cmd = string.Format("IF EXISTS (SELECT [StudentId] FROM FeeInfo WHERE StudentId='{0}') "
                    + "UPDATE FeeInfo SET FeeType='{1}',FeeDetail='{2}' WHERE StudentId='{0}'"
                    + "ELSE INSERT INTO FeeInfo(StudentId,FeeType,FeeDetail) VALUES ({0},{1},{2})",fee.StudentId,fee.FeeType,fee.FeeDetail);
                DataHelper.ExecuteCommand(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateFeeInfo(FeeInfo fee)
        {
            try
            {
                DataHelper.UpdateObject<FeeInfo>(fee,"where StudentId='"+fee.StudentId+"'");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int[] InsertFeeInfoList(List<FeeInfo> fees)
        {
            try
            {
                return DataHelper.InsertListObject<FeeInfo>(fees);
            }
            catch 
            {
                return null;
            }
        }
        #endregion


    }
}
