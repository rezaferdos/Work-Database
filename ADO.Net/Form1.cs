using ADO.Net.Model;
using ADO.Net.UI;
using Microsoft.Data.SqlClient;

namespace ADO.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * ADO.Net Steps:
         *  *. Before Write Code, Must Install : Microsoft.Data.SqlClient
         *      1. Write Connection String
         *      2. Create Instance Of SqlConnection
         *      3. Create Instance Of SqlCommand
         *      4. Write Query On SqlCommand.Text
         *      5. SqlConnection Open
         *      6. EXEC SqlCommand.Text
         *      7. SqlConnection Close
         *      
         *      Warning:
         *          - SQL Injection
         *          - Use AddWithValue
         *          
         *      
         */

        /// //////////////////////////////////////////////////////////
        // Add Record, HardCode and Fix Value
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CreateFixValue())
                MessageBox.Show("Successful Added");
        }
        private bool CreateFixValue()
        {
            // Connection String
            /// With Username & Password
            string connectionString = "Server=.;Database=Northwind;User Id=sa;Password=828898;TrustServerCertificate=True;Integrated Security=true;";
            /// With Windows Authnticate
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";

            var connection = new SqlConnection(connectionString2);
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO dbo.Products (ProductName, UnitPrice) Values ('Coca Cola Testi', 2.5)";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        /// //////////////////////////////////////////////////////////
        // SQL Injection 💉
        /// With Parameter
        private void btnAddParam_Click(object sender, EventArgs e)
        {
            var p = new Product { ProductName = "Pepsi", UnitPrice = 2.5 };
            if (CreateInjection(p))
                MessageBox.Show("Operation Successful");
        }
        // Injection : P.ProductName = Pepsi', 2) GO DELETE dbo.Products --
        // Resualt = INSERT INTO dbo.Products (ProductName, UnitPrice) VALUES ('Pepsi', 2) GO DELETE dbo.Products --', {p.UnitPrice})"
        private bool CreateInjection(Product p)
        {
            // Connection String
            /// With Username & Password
            string connectionString = "Server=.;Database=Northwind;User Id=sa;Password=828898;TrustServerCertificate=True;Integrated Security=true;";
            /// With Windows Authnticate
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";

            var connection = new SqlConnection(connectionString2);
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"INSERT INTO dbo.Products (ProductName, UnitPrice) VALUES ('{p.ProductName}', {p.UnitPrice})";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }


        /// //////////////////////////////////////////////////////////
        // Solved SQL Injection With Add Parameter
        private void btnSolved_Click(object sender, EventArgs e)
        {
            var p = new Product { ProductName = "Coca Cola", UnitPrice = 2.5 };
            if (CreateAddParameter(p))
                MessageBox.Show("Operation Successful");
        }
        private bool CreateAddParameter(Product p)
        {
            // Connection String
            /// With Username & Password
            string connectionString = "Server=.;Database=Northwind;User Id=sa;Password=828898;TrustServerCertificate=True;Integrated Security=true;";
            /// With Windows Authnticate
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";

            var connection = new SqlConnection(connectionString2);
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"INSERT INTO dbo.Products (ProductName, UnitPrice) VALUES (@ProductName, @UnitPrice)";
            command.Parameters.AddWithValue("ProductName", p.ProductName);
            command.Parameters.AddWithValue("UnitPrice", p.UnitPrice);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }


        /// //////////////////////////////////////////////////////////
        // Call SP With ADO.Net
        private void btnAddSP_Click(object sender, EventArgs e)
        {
            var p = new Product { ProductName = "Coca Cola", UnitPrice = 2.5 };
            if (CreateSP(p))
                MessageBox.Show("Operation Successful");
        }
        private bool CreateSP(Product p)
        {
            // Connection String
            /// With Username & Password
            string connectionString = "Server=.;Database=Northwind;User Id=sa;Password=828898;TrustServerCertificate=True;Integrated Security=true;";
            /// With Windows Authnticate
            string connectionString2 = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=true;";

            var connection = new SqlConnection(connectionString2);
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "usp_InsertIntoProducts";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("ProductName", p.ProductName);
            command.Parameters.AddWithValue("UnitPrice", p.UnitPrice);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        private void btnReadPage_Click(object sender, EventArgs e)
        {
            Read rd = new Read();
            rd.ShowDialog();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.ShowDialog();
        }
    }
}
