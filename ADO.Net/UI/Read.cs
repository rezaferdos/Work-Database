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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }
        /*
         * Reading Data With ADO.Net : (2 Ways)
         *      - SqlDataReader (Standard, High Performance)
         *      - DataTable
         *
         *   SqlDataRaeder : (Steps)   
         *      1. Write Connection String
         *      2. Create Instance Of SqlConnection
         *      3. Create Instance Of SqlCommand
         *      4. Write Query On SqlCommand.Text OR Call SP
         *      5. SqlConnection Open
         *      6. ExecuteReader
         *      7. While Loop (if Select Returns 2 or More Records)
         *      8. Materialization/Population - Data
         *      9. SqlConnection Close
         *      
         *      
         *      
         */



        // Read Data With SqlDataReader
        private void btnreadDataReader_Click(object sender, EventArgs e)
        {
            dgProducts.DataSource = ReadDataReader();
        }
        private List<Product> ReadDataReader()
        {
            var Resualt = new List<Product>();
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
                Resualt.Add(new Product
                {
                    /// Materialization/population
                    ProductName = Convert.ToString(record["ProductName"]),
                    UnitPrice = Convert.ToDouble(record["UnitPrice"])
                });
            }

            conn.Close();
            return Resualt;
        }
    }
}
