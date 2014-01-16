using System;
using System.Collections.Generic;
using System.Text;
using org.in2bits.MyXls;
using System.Data;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = ExcelHelper.Import(@"C:\Users\Chnhideyoshi\Desktop\在校生_教育部.xls");
        }
    }
}
