using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Transactions : Form
    {
        private DBConnection dbCon = DBConnection.Instance();
        private int selectedIndex = -1;
        public Transactions()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
            string query = "SELECT name,purchaseCost,SellCost,quantity,itemCode FROM inventory";
            var cmd = new MySqlCommand(query, dbCon.Connection);
            var reader = cmd.ExecuteReader();

            Dictionary<string, Item> comboSource = new Dictionary<string, Item>();

            while (reader.Read())
            {
                Item item = new Item(reader.GetString(0), Convert.ToInt32(reader.GetString(1)), Convert.ToInt32(reader.GetString(2)), Convert.ToInt32(reader.GetString(3)), reader.GetString(4));
                comboSource.Add(reader.GetString(4), item);
            }
            itemComboBox.DataSource = new BindingSource(comboSource, null);
            itemComboBox.DisplayMember = "Key";
            itemComboBox.ValueMember = "Value";
            itemComboBox.SelectedIndex = -1;
            reader.Close();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            int no, totalAmount, quan;
            Item item;
            try
            {
                if (itemComboBox.SelectedIndex == -1)
                    MessageBox.Show("Error.Select an Item");
                else if (sellBox.Text == "" || !(int.TryParse(sellBox.Text, out no)))
                    MessageBox.Show("Error.Enter Number of items to sell");
                else
                {
                    item = (itemComboBox.SelectedItem as dynamic).Value;
                    totalAmount = item.SellingCost * no;
                    quan = item.quantity - no;
                    if (!(quan < 0))
                    {
                        MySqlCommand insertComm = new MySqlCommand();
                        insertComm.Connection = dbCon.Connection;
                        MySqlCommand updateComm = new MySqlCommand();
                        updateComm.Connection = dbCon.Connection;

                        insertComm.CommandText = "INSERT INTO Transactions(itemCode,totalSellCost,Items,transDate) VALUES (@code,@amount,@remItm,NOW())";
                        insertComm.Parameters.AddWithValue("@code", item.itemCode);
                        insertComm.Parameters.AddWithValue("@amount", totalAmount);
                        insertComm.Parameters.AddWithValue("@remItm", no);
                        updateComm.CommandText = "UPDATE Inventory SET quantity = @quantity where itemCode = @code";
                        updateComm.Parameters.AddWithValue("@quantity", quan);
                        updateComm.Parameters.AddWithValue("@code", item.itemCode);

                        insertComm.ExecuteNonQuery();
                        updateComm.ExecuteNonQuery();
                        item.quantity = quan;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Error.Not Enough Items available to sell");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.ToString());
            }

        }

        private void reset()
        {
            nameBox.Text = "";
            amountBox.Text = "";
            quantityBox.Text = "";
            sellBox.Text = "";
            itemComboBox.SelectedItem = -1;
        }

        private void itemComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedIndex != selectedIndex)
            {
                selectedIndex = itemComboBox.SelectedIndex;
                Item item = (itemComboBox.SelectedItem as dynamic).Value;

                if (item.quantity != 0)
                {
                    errorLabel.Visible = false;
                    nameBox.Text = item.name;
                    amountBox.Text = item.SellingCost.ToString();
                    quantityBox.Text = item.quantity.ToString();
                }
                else
                {
                    errorLabel.Text = "Item out of stock";
                    errorLabel.Visible = true;
                    reset();
                }

            }

        }

    }
}
