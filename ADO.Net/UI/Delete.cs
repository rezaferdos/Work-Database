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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        /// /////////////////////////////////////////////////////////////////////
        // Delete From Product Using ADO.Net Query
        private void dgDeleteProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgDeleteProducts.Rows[e.RowIndex].Cells["ProductId"].Value);

            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DeletedRow(id))
                {
                    MessageBox.Show("Operation Successful");
                    dgDeleteProducts.DataSource = ReadDataReader();
                }
            }
        }
        private bool DeletedRow(int id)
        {
            // Connection String
            /// With Windows Authnticate
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";
            var connection = new SqlConnection(connectionString2);
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM dbo.Products WHERE ProductId = @ID";
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        /// /////////////////////////////////////////////////////////////////////
        // No Important (Reading Data)
        private void Delete_Load(object sender, EventArgs e)
        {
            dgDeleteProducts.DataSource = ReadDataReader();
        }
        private List<Product2> ReadDataReader()
        {
            var Resualt = new List<Product2>();
            /// Connection string
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";
            /// Create SqlConnection
            var conn = new SqlConnection(connectionString2);
            var command = new SqlCommand("SELECT * FROM dbo.Products", conn);
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
            return Resualt;
        }


    }
}
