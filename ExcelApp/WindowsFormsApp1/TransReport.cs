using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TransReport : Form
    {
        private DBConnection dbCon = DBConnection.Instance();
        public TransReport()
        {
            InitializeComponent();
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            radioButtonSingle.Checked = true;
            start();

        }


        private void start()
        {
            string query = "SELECT itemCode FROM inventory";
            var cmd = new MySqlCommand(query, dbCon.Connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                itemsComboBox.Items.Add(reader.GetString(0));
            }
            reader.Close();
            itemsComboBox.SelectedIndex = -1;
        }



        private void Generate_Click(object sender, EventArgs e)
        {
            string Datequery = "select itemCode,totalSellCost,Items,transDate from Transactions where transDate BETWEEN @startDate AND @EndDate";
            string DatequeryItemCode = "select itemCode,totalSellCost,Items,transDate from Transactions where itemCode = @code AND transDate BETWEEN @startDate AND @EndDate";
            string path = "D:\\POSReports\\TransactionsReport.txt";
            string endDate;
            int totalAmount = 0, soldItemsount = 0;
            try
            {
                string startDate = dateTimePickerStart.Text + " 00:00:00";
                if (radioButtonSingle.Checked)
                    endDate = dateTimePickerStart.Text + " 11:59:59";
                else
                    endDate = dateTimePickerEnd.Text + " 11:59:59";

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = dbCon.Connection;
                if (itemsComboBox.SelectedIndex != -1)
                {
                    comm.CommandText = DatequeryItemCode;
                    comm.Parameters.AddWithValue("@code", itemsComboBox.SelectedItem);
                }
                else
                    comm.CommandText = Datequery;
                comm.Parameters.AddWithValue("@startDate", startDate);
                comm.Parameters.AddWithValue("@EndDate", endDate);
                var reader = comm.ExecuteReader();
                StreamWriter writetext = new StreamWriter(path);


                writetext.WriteLine("++++++++++++++++ POS Report by BABLOO ++++++++++++++++++++");
                writetext.WriteLine("                 Transactions List");
                writetext.WriteLine("#####################################################################");
                writetext.WriteLine("itemCode".PadRight(10) + "totalSaleCost".PadRight(15) + "Items".PadRight(15) + "Date".PadRight(15));


                while (reader.Read())
                {
                    writetext.WriteLine(reader.GetString(0).PadRight(10) + reader.GetString(1).PadRight(15) + reader.GetString(2).PadRight(15) + reader.GetString(3).PadRight(15));
                    totalAmount = totalAmount + Convert.ToInt32(reader.GetString(1));
                    soldItemsount++;
                }
                writetext.WriteLine("Total Sold Cost =  " + totalAmount + " Rupees");
                writetext.WriteLine("Total Items Sold=  " + soldItemsount + " Rupees");
                writetext.Flush();
                reader.Close();
                MessageBox.Show("Report Generated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.Visible = false;
            EndLabel.Visible = false;
            startLabel.Text = "Date";

        }

        private void radioButtonPeriod_CheckedChanged(object sender, EventArgs e)
        {
            EndLabel.Visible = true;
            dateTimePickerEnd.Visible = true;
            startLabel.Text = "Start Date";
        }
    }
}
