using ADO.Net.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Net.UI
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        /// //////////////////////////////////////////////////////////////////////
        // Update With ADO.NET And Query
        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Product2();
            p.ProductId = Convert.ToInt32(txtID.Text);
            p.ProductName = txtPName.Text;
            p.UnitPrice = Convert.ToDouble(txtPPrice.Text);
            if (UpdateQuery(p))
                MessageBox.Show("Operation Successful");
        }
        private bool UpdateQuery(Product2 p)
        {
            // Connection String
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";

            var connection = new SqlConnection(connectionString2);
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"UPDATE dbo.Products SET ProductName = @ProductName, UnitPrice = @UnitPrice WHERE ProductID = @ProductID";
            command.Parameters.AddWithValue("ProductName", p.ProductName);
            command.Parameters.AddWithValue("UnitPrice", p.UnitPrice);
            command.Parameters.AddWithValue("ProductID", p.ProductId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        /// //////////////////////////////////////////////////////////////////////
        // Not Important (Read Data)
        private void ReadDataReader()
        {
            var Resualt = new List<Product2>();
            /// Connection string
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";
            /// Create SqlConnection
            var conn = new SqlConnection(connectionString2);
            var command = new SqlCommand("SELECT ProductID, ProductName, UnitPrice FROM dbo.Products", conn);
            conn.Open();

            /// ExecuteReader() => Get Only One Redcord
            var record = command.ExecuteReader();
            /// If We have 2 Or More Record Returns
            while (record.Read())
            {
                Resualt.Add(new Product2
                {
                    /// Materialization/population
                    ProductId = Convert.ToInt32(record["ProductId"]),
                    ProductName = Convert.ToString(record["ProductName"]),
                    UnitPrice = Convert.ToDouble(record["UnitPrice"])
                });
            }

            conn.Close();

            dgUpdate.DataSource = Resualt;
        }

        private void BrnLoad_Click(object sender, EventArgs e)
        {
            ReadDataReader();
        }

        private void dgUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgUpdate.Rows[e.RowIndex].Cells["ProductId"].Value);
            string ProductName = dgUpdate.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            double UnitPrice = Convert.ToDouble(dgUpdate.Rows[e.RowIndex].Cells["UnitPrice"].Value);

            txtPName.Text = ProductName;
            txtPPrice.Text = UnitPrice.ToString();
            txtID.Text = id.ToString();
        }
    }
}
