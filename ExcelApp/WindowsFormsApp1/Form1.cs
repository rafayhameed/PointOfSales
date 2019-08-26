using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private _Workbook oWB = null;
        private DBConnection dbCon;

        public static Hashtable ItemsList = new Hashtable();


        public Form1()
        {
            InitializeComponent();
            //    LoadExcelFile();

            Start();


        }

        private void Start()
        {
            dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "pos_schema";
            if (!dbCon.IsConnect())
            {
                MessageBox.Show("Error. Could Not Connect with DataBase " + dbCon.DatabaseName);
                //dbCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Catagory catagory = new Catagory(oWB);
            catagory.Show();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            PayOrder payorder = new PayOrder();
            payorder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transactions trans = new Transactions();
            trans.Show();
        }


        //private void LoadExcelFile()
        //{
        //    Microsoft.Office.Interop.Excel.Application oXL = null;

        //    try
        //    {
        //        oXL = new Microsoft.Office.Interop.Excel.Application();
        //        oWB = oXL.Workbooks.Open("D:\\Record.xlsx");
        //        oSheet = (_Worksheet)oWB.ActiveSheet;

        //        oSheet.Cells[1, 1] = "Name";
        //        oSheet.Cells[1, 2] = "Purchase Cost";
        //        oSheet.Cells[1, 3] = "Selling Cost";
        //        oSheet.Cells[1, 4] = "Quantity";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (oWB != null)
        //            oWB.Close();
        //    }
        //}
        //private void UpdateExcel(string sheetName, int row, int col, string data)
        //{
        //    Microsoft.Office.Interop.Excel.Application oXL = null;
        //    _Workbook oWB = null;
        //    try
        //    {
        //        oXL = new Microsoft.Office.Interop.Excel.Application();
        //        oWB = oXL.Workbooks.Open("C:\\Users\rafay.hamid\\Documents\\Visual Studio 2017\\Projects\\ExcelApp\\Record.xlsx");
        //        oSheet = String.IsNullOrEmpty(sheetName) ? (_Worksheet)oWB.ActiveSheet : (_Worksheet)oWB.Worksheets[sheetName];

        //        oSheet.Cells[row, col] = data;

        //        oWB.Save();

        //        MessageBox.Show("Done!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        if (oWB != null)
        //            oWB.Close();
        //    }
        //}
    }
}
