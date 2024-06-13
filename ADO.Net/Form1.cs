using Microsoft.Data.SqlClient;

namespace ADO.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Name

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
         */

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Successful Added");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
