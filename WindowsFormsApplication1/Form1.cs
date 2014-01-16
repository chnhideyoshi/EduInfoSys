using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Test;
using System.IO;
using System.Data.Common;
using EduInfoSystem.Model;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.curveTableAdapter.FillBy(this.dBFileDataSet.Curve);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }
        TableManager manager;
        private void Form1_Load(object sender, EventArgs e)
        {
            manager = EduInfoSystem.Model.DataHelper.GetObjectTable("Select * from Student");
            dataGridViewX1.DataSource = manager.Table;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.SaveUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewX2.DataSource = manager.Table.GetChanges();
        }
    }
}
