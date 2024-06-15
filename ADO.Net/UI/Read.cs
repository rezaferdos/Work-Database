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
        private void btnreadDataReader_Click(object sender, EventArgs e)
        {

        }
    }
}
