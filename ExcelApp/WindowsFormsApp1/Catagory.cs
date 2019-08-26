using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Catagory : Form
    {
        private _Workbook oWB;
        private DBConnection dbCon = DBConnection.Instance();

        public Catagory(_Workbook oWBParam)
        {
            InitializeComponent();
            oWB = oWBParam;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            int no;

            if (nameText.Text == "")
                MessageBox.Show("Error. Please enter Name");
            else if (purchaseText.Text == "" || !(int.TryParse(purchaseText.Text, out no)))
                MessageBox.Show("Error. Please enter purchase Amount");
            else if (sellingText.Text == "" || !(int.TryParse(sellingText.Text, out no)))
                MessageBox.Show("Error. Please enter Selling amount");
            else if (quantityText.Text == "" || !(int.TryParse(quantityText.Text, out no)))
                MessageBox.Show("Error. Please enter quantity");
            else if (codeBox.Text == "")
                MessageBox.Show("Error. Please enter Item Code");
            else
            {

                try
                {
                    MySqlCommand comm = new MySqlCommand();
                    comm.Connection = dbCon.Connection;
                    comm.CommandText = "INSERT INTO Inventory(name,purchaseCost,SellCost,quantity,itemCode) VALUES (@name,@purchase,@sell,@quantity,@code)";
                    comm.Parameters.AddWithValue("@name", nameText.Text);
                    comm.Parameters.AddWithValue("@purchase", purchaseText.Text);
                    comm.Parameters.AddWithValue("@sell", sellingText.Text);
                    comm.Parameters.AddWithValue("@quantity", quantityText.Text);
                    comm.Parameters.AddWithValue("@code", codeBox.Text);
                    comm.ExecuteNonQuery();

                    Item item = new Item(nameText.Text, Convert.ToInt32(purchaseText.Text), Convert.ToInt32(sellingText.Text), Convert.ToInt32(quantityText.Text), codeBox.Text);
                    Form1.ItemsList.Add(codeBox.Text, item);
                    statusLabel.Text = "Added Succesfully";
                    clearButton.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex.ToString());
                }

            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            purchaseText.Text = "";
            sellingText.Text = "";
            quantityText.Text = "";
            codeBox.Text = "";
            statusLabel.Text = "";
            clearButton.Visible = false;
        }
    }
}
