using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SQLite;

namespace Test
{
    public class SQLiteImage
    {
        string path = "4201231231122.jpg";
        static string DbFileName = @"F:\workspacecsharp\RecentProject\EduInfoSystem\EduInfoSystem\bin\Debug\DBFile";
        static SQLiteConnection commonConnection = null;
        public void UpdateAllHeadImages()
        {
                    FileStream fs = File.OpenRead(path);
                    byte[] imageb = new byte[fs.Length];
                    fs.Read(imageb, 0, imageb.Length);
                    fs.Close();
                    try
                    {
                        if (commonConnection == null)
                        {
                            commonConnection = new SQLiteConnection();
                            SQLiteConnectionStringBuilder connstr = new System.Data.SQLite.SQLiteConnectionStringBuilder();
                            connstr.DataSource = DbFileName;
                            commonConnection.ConnectionString = connstr.ToString();
                        }
                        if (commonConnection.State != System.Data.ConnectionState.Open)
                            commonConnection.Open();
                        SQLiteCommand cmd = new SQLiteCommand(commonConnection);
                        cmd.CommandText = "Insert into [HeadImage](IdentificationId,ImageData) values ('" + 4201231231122 + "',@images)";
                        SQLiteParameter parameter = new SQLiteParameter("@images", System.Data.DbType.Binary);
                        parameter.Value = imageb;
                        cmd.Parameters.Add(parameter);
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
        public byte[] GetData()
        {
            try
            {
                if (commonConnection == null)
                {
                    commonConnection = new SQLiteConnection();
                    SQLiteConnectionStringBuilder connstr = new System.Data.SQLite.SQLiteConnectionStringBuilder();
                    connstr.DataSource = DbFileName;
                    commonConnection.ConnectionString = connstr.ToString();
                }
                if (commonConnection.State != System.Data.ConnectionState.Open)
                    commonConnection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(commonConnection);
                    cmd.CommandText="Select ImageData from HeadImage where IdentificationId='4201231231122'";
                    byte[] ret=(byte[])cmd.ExecuteScalar();
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

    }
}
