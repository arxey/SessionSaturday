using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MegaDriveMordovskiy
{
    public partial class Vehicle : Form
    {
        static string connectionString = "Integrated Security=SSPI; Persist Security Info=False;Initial Catalog=MegaDriveMordovskiy;Data Source=MEPHI3-MSSQL";
        SqlConnection connection = new SqlConnection(connectionString);
        public Vehicle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM transport";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            VehicleView.DataSource = dataset.Tables[0];
            VehicleView.Columns[0].Visible = false;
            connection.Close();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "megaDriveMordovskiyDataSet.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.megaDriveMordovskiyDataSet.transport);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            (VehicleView.DataSource as DataTable).DefaultView.RowFilter = $"transport_number LIKE '%{TextBoxSearch.Text}%'";
            (VehicleView.DataSource as DataTable).DefaultView.RowFilter = $"transport_model LIKE '%{TextBoxSearch.Text}%'";
        }

        private void VehicleView_Click(object sender, EventArgs e)
        {
           
        }

        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxFilter.SelectedIndex)
            {
                case 0:
                    (VehicleView.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
                case 1:
                    (VehicleView.DataSource as DataTable).DefaultView.RowFilter = $"transport_enabled == Доступные для бронирования";
                    break;
                case 2:
                    (VehicleView.DataSource as DataTable).DefaultView.RowFilter = $"transport_enabled == Недоступные";
                    break;
                case 3:
                    (VehicleView.DataSource as DataTable).DefaultView.RowFilter = $"transport_type_id == {ComboBoxFilter.Text}";
                    break;
            }
        }
        private void Vehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
