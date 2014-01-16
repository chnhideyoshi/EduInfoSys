﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace Config
{
    public class ConfigReader
    {
        public ConfigReader(string path)
        {
            Path = path;
            if (doc == null)
            {
                doc = new XmlDocument();
                doc.Load(Path);
            }
            if (xnm == null)
            {
                xnm = new XmlNamespaceManager(doc.NameTable);
            }
        }
        #region private
        private string Path = null;
        private XmlDocument doc;
        private XmlNamespaceManager xnm;
        public XmlNode GetNode(string rPath)
        {
            if (doc == null)
            {
                doc = new XmlDocument();
                doc.Load(Path);
            }
            if (xnm == null)
            {
                xnm = new XmlNamespaceManager(doc.NameTable);
            }
            //读取节点值
            XmlNode node = doc.SelectSingleNode(rPath, xnm);
            return node;
        }
        public XmlNodeList GetNodeList(string rPath)
        {
            if (doc == null)
            {
                doc = new XmlDocument();
                doc.Load(Path);
            }
            if (xnm == null)
            {
                xnm = new XmlNamespaceManager(doc.NameTable);
            }
            //读取节点值
            XmlNodeList nodeList = doc.SelectNodes(rPath, xnm);
            return nodeList;
        }
        private string GetSettingItem(string name)
        {
            XmlNode node = GetNode("/Settings");
            foreach (XmlNode e in node.ChildNodes)
            {
                if ((e as XmlElement).Name == name)
                {
                    return e.Attributes["value"].Value;
                }
            }
            return null;
        }
        #endregion
        #region public method
        public bool GetBooleanSettingItem(string name, bool defaultvalue)
        {
            try
            {
                string value = GetSettingItem(name);
                return Convert.ToBoolean(value);
            }
            catch { return defaultvalue; }
        }
        public int GetIntSettingItem(string name, int defaultvalue)
        {
            try
            {
                string value = GetSettingItem(name);
                return Convert.ToInt32(value);
            }
            catch { return defaultvalue; }
        }
        public double GetDoubleSettingItem(string name, double defaultvalue)
        {
            try
            {
                string value = GetSettingItem(name);
                return Convert.ToDouble(value);
            }
            catch { return defaultvalue; }
        }
        public string GetStringSettingItem(string name, string defaultvalue)
        {
            if (string.IsNullOrEmpty(GetSettingItem(name)))
            {
                return defaultvalue;
            }
            else
            {
                return GetSettingItem(name);
            }
        }
        public List<string> GetStringCollectionSettingItem(string name, List<string> defaultvalue)
        {
            List<string> list = new List<string>();
            try
            {
                XmlNode node = GetNode("/Settings/" + name);
                foreach (XmlNode e in node.ChildNodes)
                {
                    string ext = e.Attributes["value"].Value;
                    list.Add(ext);
                }
            }
            catch { return defaultvalue; }
            if (list.Count == 0)
            {
                return defaultvalue;
            }
            return list;
        }
        public Dictionary<string, string> GetStringCollectionSettingItem(string name, Dictionary<string, string> defaultvalue)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            try
            {
                XmlNode node = GetNode("/Settings/" + name);
                foreach (XmlNode e in node.ChildNodes)
                {
                    string key = e.Attributes["name"].Value;
                    string ext = e.Attributes["value"].Value;
                    list.Add(key, ext);
                }
            }
            catch { return defaultvalue; }
            if (list.Count == 0)
            {
                return defaultvalue;
            }
            return list;
        }
        public void SetStringValue(string name, object value)
        {
            XmlNode node = GetNode("/Settings");
            foreach (XmlNode e in node.ChildNodes)
            {
                if ((e as XmlElement).Name == name)
                {
                    e.Attributes["value"].Value = value.ToString();
                }
            }
            doc.Save(this.Path);
            return;
        }

        #endregion

        #region Sp
        public string GetConnectionString()
        {
            XmlNode node = GetNode("/Settings/DataBase");
            if (node.Attributes["connectionstring"] != null)
                return node.Attributes["connectionstring"].Value;
            return null;
        }
        public string GetDataProvider()
        {
            XmlNode node = GetNode("/Settings/DataBase");
            if (node.Attributes["dataprovider"] != null)
                return node.Attributes["dataprovider"].Value;
            return null;
        }
        public List<string> GetFeeType()
        {
            List<string> list=new List<string>();
            XmlNodeList nodes = GetNodeList("/Settings/FeeTypes/Fee");
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes["typename"] != null)
                    list.Add(node.Attributes["typename"].Value);
            }
            return list;
        }
        public string GetFeeCriString(string typeName)
        {
            System.Xml.XmlNodeList nodes = GetNodeList("/Settings/FeeTypes/Fee");
            for (int i = 0; i < nodes.Count; i++)
            {
                System.Xml.XmlElement node = nodes[i] as System.Xml.XmlElement;
                if (node != null)
                {
                    if (node.Attributes["typename"] != null && node.Attributes["typename"].Value==typeName)
                    {
                        return node.Attributes["criterion"].Value;
                    }
                }
            }
            return null;
        }
        public string GetFeeCriDescriptionString(string typeName)
        {
            System.Xml.XmlNodeList nodes = GetNodeList("/Settings/FeeTypes/Fee");
            for (int i = 0; i < nodes.Count; i++)
            {
                System.Xml.XmlElement node = nodes[i] as System.Xml.XmlElement;
                if (node != null)
                {
                    if (node.Attributes["typename"] != null && node.Attributes["typename"].Value == typeName)
                    {
                        return node.Attributes["criteriondescription"].Value;
                    }
                }
            }
            return null;
        }
        #endregion
    }
}

