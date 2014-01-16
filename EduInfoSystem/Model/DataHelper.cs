using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Data;
using System.Data.Common;
using System.IO;
namespace EduInfoSystem.Model
{
    public static class  DataHelper
    {
        #region BasicOperation
        static string DbFileName = @"DBFile";
        static string DbProviderName = "System.Data.SqlClient";
        static DbProviderFactory factory = null;
        static DataHelper()
        {
            DbProviderName = Program.ConfigReader.GetDataProvider();
            factory = DbProviderFactories.GetFactory(DbProviderName);
        }
        static DbConnection commonConnection = null;
        static void SetProperties(object obj,DbDataReader sdr)
        {
            System.Reflection.PropertyInfo[] fields = obj.GetType().GetProperties();
            for (int i = 0; i < fields.Length; i++)
            {
                if (sdr[fields[i].Name] != null)
                {
                    fields[i].SetValue(obj, sdr[fields[i].Name], null);
                }
            }
        }
        private static void CreateConnection()
        {
            if (commonConnection == null)
            {
                commonConnection = factory.CreateConnection();
                commonConnection.ConnectionString = Program.ConfigReader.GetConnectionString();
            }
        }
        private static string BuildInsertCommandTemplate(object instance)
        {
            Type type = instance.GetType();
            StringBuilder text = new StringBuilder("Insert into " + type.Name);
            text.Append("(");
            PropertyInfo[] fis = type.GetProperties();
            for (int i = 0; i < fis.Length; i++)
            {
                if (fis[i].GetValue(instance, null) != null)
                {
                    text.Append("[");
                    text.Append(fis[i].Name);
                    text.Append("]");
                    text.Append(",");
                }
            }
            text.Remove(text.Length - 1, 1);
            text.Append(")");
            text.Append(" Values(");
            for (int i = 0; i < fis.Length; i++)
            {
                if (fis[i].GetValue(instance, null) != null)
                {
                    text.Append("@");
                    text.Append(fis[i].Name);
                    text.Append(",");
                }
            }
            text.Remove(text.Length - 1, 1);
            text.Append(")");
            return text.ToString();
        }
        private static void InitDBCommandParams(DbCommand cmd,object instance,string[] properties)
        {
            for (int i = 0; i < properties.Length; i++)
            {
                DbParameter pa = factory.CreateParameter();
                pa.ParameterName = "@" + properties[i];
                pa.Value = BaseObject.GetValue(instance, properties[i]);
                cmd.Parameters.Add(pa);
            }
        }
        /// <summary>
        /// GetObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static List<T> GetObject<T>(string condition)
        {
            List<T> list = new List<T>();
            string tableName = (typeof(T)).Name;//.Substring(obj.GetType().Name.LastIndexOf('.'));
           CreateConnection();
            try
            {
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = "Select * from " + tableName + " "+ condition;
                DbDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    T obj = Activator.CreateInstance<T>();
                    SetProperties(obj, sdr);
                    list.Add(obj);
                }
                sdr.Close();
                cmd.Dispose();
                commonConnection.Close();
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
            return list;
        }
        public static List<T> GetSetByColumn<T>(string tableName, string columnName, string condition)
        {
            List<T> list = new List<T>();
            CreateConnection();
            try
            {
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = "Select ["+columnName+"] from " + tableName + " " + condition;
                DbDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    object obj = sdr[columnName];
                    list.Add((T)obj);
                }
                sdr.Close();
                cmd.Dispose();
                commonConnection.Close();
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
            return list;
        }
        public static void GetSetByColumn2<T1,T2>(string tableName, string columnName1,string columnName2, string condition,ref List<T1> resultList1, ref List<T2> resultList2)
        {
            CreateConnection();
            try
            {
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = "Select [" + columnName1 + "],["+columnName2+"] from " + tableName + " " + condition;
                DbDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    object obj1 = sdr[columnName1];
                    object obj2 = sdr[columnName2];
                    resultList1.Add((T1)obj1);
                    resultList2.Add((T2)obj2);
                }
                sdr.Close();
                cmd.Dispose();
                commonConnection.Close();
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        public static TableManager GetObjectTable(string cmdText)
        {
            CreateConnection();
            TableManager tm;
            try
            {
                DbDataAdapter adapter;
                DataTable dt = new DataTable();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = cmdText;
                adapter = factory.CreateDataAdapter();
                adapter.SelectCommand = cmd;
                DbCommandBuilder builder = factory.CreateCommandBuilder();
                builder.DataAdapter = adapter;

                // Get the insert, update and delete commands.
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();

                adapter.Fill(dt);
                tm = new TableManager(adapter, dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tm;
        }
         /// <summary>
         /// 
         /// </summary>
         /// <typeparam name="T"></typeparam>
         /// <param name="instance"></param>
        public static void InsertObject<T>(T instance) 
        {
            try
            {
                string tableName = typeof(T).Name;
                CreateConnection();
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = BuildInsertCommandTemplate(instance);
                InitDBCommandParams(cmd, instance,BaseObject.GetProperties(instance));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                commonConnection.Close();
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        public static int[] InsertListObject<T>(List<T> list) 
        {
            try
            {
                int[] ret = new int[list.Count];
               string tableName = typeof(T).Name;//;.Substring(typeof(T).Name.LastIndexOf('.'));
               CreateConnection();
               if (commonConnection.State != ConnectionState.Open)
                   commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                string[] props=BaseObject.GetProperties(typeof(T));
                for (int i = 0; i < list.Count; i++)
                {
                    try
                    {
                        cmd.CommandText = BuildInsertCommandTemplate(list[i]);
                        cmd.Parameters.Clear();
                        InitDBCommandParams(cmd, list[i],props);
                        ret[i] = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        ret[i] = -1;
                        continue;
                    }
                }
                cmd.Dispose();
                commonConnection.Close();
                return ret;
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <returns></returns>
        public static void DeleteObject<T>(string condition)
        {
            ExecuteCommand("Delete  from " + typeof(T).Name + " " + condition);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <returns></returns>
        public static void UpdateObject<T>(T newInstance,string condition)
        {
            DbTransaction transaction = null;
            string tableName = typeof(T).Name;
            try
            {
                CreateConnection();
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                transaction = commonConnection.BeginTransaction();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.Transaction = transaction;
                cmd.CommandText = "Delete  from " + tableName +" "+condition;
                cmd.ExecuteNonQuery();
                cmd.CommandText = BuildInsertCommandTemplate(newInstance);
                InitDBCommandParams(cmd, newInstance, BaseObject.GetProperties(newInstance));
                cmd.ExecuteNonQuery();
                transaction.Commit();
                commonConnection.Close();
            }
            catch (Exception e)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                commonConnection.Close();
                throw e;
            }
        }
        public static void UpdateList<T>(string propertyName, object value, string condition)
        {
            string tableName = typeof(T).Name;
            try
            {
                CreateConnection();
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = "Update " + tableName + " Set " + propertyName + " = @" + propertyName + " " + condition ;
                DbParameter pa = factory.CreateParameter();
                pa.ParameterName = propertyName;
                pa.Value = value;
                cmd.Parameters.Add(pa);
                cmd.Dispose();
                commonConnection.Close();
            }
            catch (Exception e)
            {       
                commonConnection.Close();
                throw e;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string cmdtext)
        {
            CreateConnection();
            try
            {
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = cmdtext;
                int ret= cmd.ExecuteNonQuery();
                cmd.Dispose();
                commonConnection.Close();
                return ret;
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        public static int[] ExcuteCommandList(List<string> cmdlist)
        {
            int[] retl = new int[cmdlist.Count];
            CreateConnection();
            try
            {
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                for (int i = 0; i < cmdlist.Count; i++)
                {
                    try
                    {
                        cmd.CommandText = cmdlist[i];
                        retl[i] = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        continue;
                    }
                }
                cmd.Dispose();
                commonConnection.Close();
                return retl;
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        public static T[] ExecuteCommandListAndGetSimpleResult<T>(List<string> cmdlist)
        {
            CreateConnection();
            T[] retl = new T[cmdlist.Count];
            try
            {
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                for (int i = 0; i < cmdlist.Count; i++)
                {
                    try
                    {
                        cmd.CommandText = cmdlist[i];
                        retl[i]=(T)cmd.ExecuteScalar();
                    }
                    catch
                    {
                        continue;
                    }
                }
                cmd.Dispose();
                commonConnection.Close();
                return retl;
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        public static object ExecuteCommandAndGetSimpleResult(string cmdtext)
        {
           CreateConnection();
            try
            {
                if (commonConnection.State != ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection = commonConnection;
                cmd.CommandText = cmdtext;
                object o= cmd.ExecuteScalar();
                cmd.Dispose();
                commonConnection.Close();
                return o;
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        #endregion
        #region ExpandedOperation
        public static void InsertUpdateImages(string[] files,List<string> ids,System.ComponentModel.BackgroundWorker worker)
        {
            try
            {
               CreateConnection();
                if(commonConnection.State!=ConnectionState.Open)
                    commonConnection.Open();
                DbCommand cmd = factory.CreateCommand();
                cmd.Connection=commonConnection;
                DbParameter p = factory.CreateParameter();
                p.ParameterName = "@images";
                p.DbType = System.Data.DbType.Binary;
                cmd.Parameters.Add(p);
                for (int i = 0; i < files.Length; i++)
                {
                    try
                    {
                        string id = Path.GetFileNameWithoutExtension(files[i]);
                        FileStream fs = File.OpenRead(files[i]);
                        byte[] imageb = new byte[fs.Length];
                        fs.Read(imageb, 0, imageb.Length);
                        fs.Close();
                        if (!ids.Contains(id))
                        {
                            cmd.CommandText = "Insert into [HeadImage](IdentificationId,ImageData) values ('" + id + "',@images)";
                            p.Value = imageb;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd.CommandText = "Update [HeadImage] Set ImageData=@images where IdentificationId='" + id + "'";
                            p.Value = imageb;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch //(System.Exception ex)
                    {
                        continue;
                    }
                    if (worker != null&&worker.WorkerReportsProgress)
                        worker.ReportProgress(100 * (i + 1) / files.Length);
                }
                cmd.Dispose();
                commonConnection.Close();
            }
            catch (Exception ex)
            {
                commonConnection.Close();
                throw ex;
            }
        }
        #endregion



    }
    public class TableManager
    {
        public TableManager(DbDataAdapter dba, DataTable dt)
        {
            Table = dt;
            Adapter = dba;
        }
        public DataTable Table { get; set; }
        private DbDataAdapter Adapter { get; set; }
        public void SaveUpdate()
        {
            Adapter.Update(Table);
        }
    }
}
