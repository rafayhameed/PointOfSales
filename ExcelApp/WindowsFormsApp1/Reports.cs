using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Reports : Form
    {
        private DBConnection dbCon = DBConnection.Instance();
        public Reports()
        {
            InitializeComponent();
        }

        public void start()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "D:\\POSReports\\InventoryList.txt";
                StreamWriter writetext = new StreamWriter(path);

                string query = "SELECT itemCode,name,purchaseCost,SellCost,quantity FROM inventory";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();

                writetext.WriteLine("++++++++++++++++ POS Report by BABLOO ++++++++++++++++++++");
                writetext.WriteLine("                 Inventory List");
                writetext.WriteLine("#####################################################################");
                writetext.WriteLine("itemCode".PadRight(10) + "Name".PadRight(15) + "PurchaseCost".PadRight(15) + "SellingCost".PadRight(15) + "quantity".PadRight(10));

                while (reader.Read())
                {
                    writetext.WriteLine(reader.GetString(0).PadRight(10) + reader.GetString(1).PadRight(15) + reader.GetString(2).PadRight(15) + reader.GetString(3).PadRight(15) + reader.GetString(4).PadRight(10));
                }
                writetext.Flush();
                reader.Close();
                MessageBox.Show("Report Generated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransReport teansReport = new TransReport();
            teansReport.Show();
        }
    }
}
