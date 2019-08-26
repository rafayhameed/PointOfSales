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
    public partial class PayOrder : Form
    {
        private DBConnection dbCon = DBConnection.Instance();

        public PayOrder()
        {
            InitializeComponent();
            start();
        }


        public void start()
        {
            string query = "SELECT itemCode,quantity FROM inventory";
            var cmd = new MySqlCommand(query, dbCon.Connection);
            var reader = cmd.ExecuteReader();

            Dictionary<string, int> comboSource = new Dictionary<string, int>();

            while (reader.Read())
            {
                comboSource.Add(reader.GetString(0), Convert.ToInt32(reader.GetString(1)));
            }
            itemsComboBox.DataSource = new BindingSource(comboSource, null);
            itemsComboBox.DisplayMember = "Key";
            itemsComboBox.ValueMember = "Value";
            itemsComboBox.SelectedIndex = -1;
            reader.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int no;
            try
            {
                if (itemsComboBox.SelectedItem == null)
                    MessageBox.Show("Error. Please select item code");
                else if (quantityBox.Text == "" || !(int.TryParse(quantityBox.Text, out no)))
                    MessageBox.Show("Error. Please enter purchase Amount");
                else
                {
                    MySqlCommand comm = new MySqlCommand();
                    comm.Connection = dbCon.Connection;
                    comm.CommandText = "UPDATE Inventory SET quantity = @quantity where itemCode = @code";

                    int quan = (itemsComboBox.SelectedItem as dynamic).Value + no;
                    string itemCode = (itemsComboBox.SelectedItem as dynamic).Key;

                    comm.Parameters.AddWithValue("@quantity", quan);
                    comm.Parameters.AddWithValue("@code", itemCode);
                    comm.ExecuteNonQuery();
                    quantityBox.Text = "";
                    itemsComboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.ToString());
            }
        }
    }
}
