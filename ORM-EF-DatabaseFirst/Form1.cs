using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM_EF_DatabaseFirst.Model;
using ORM_EF_DatabaseFirst.Service;

namespace ORM_EF_DatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Services src = new Services();

        private void btnLoadData_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dgProducts.DataSource = src.GetAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var p = new Products();
            p.ProductName = "Database First Testi";
            p.UnitPrice = 12;
            src.Insert(p);
            MessageBox.Show("Operation Successful");
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(dgProducts.CurrentRow.Cells["ProductID"].Value.ToString());
            var id = Convert.ToInt32(txtProductID.Text);
            src.Remove(id);
            MessageBox.Show("Operation Successful");
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtProductID.Text);
            var p = new Products();
            p.ProductID = id;
            p.UnitPrice = 12;
            p.ProductName = "This Record Updated";

            src.Update(p);
            MessageBox.Show("Operation Successful");
            LoadData();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtProductID.Text);
            dgProducts.DataSource = src.GetByID(id);
        }
    }
}
