using Business_Service_DB_Code.Model;
using Business_Service_DB_Code.Service;

namespace Business_Service_DB_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Service.UserSrvice serv = new Service.UserSrvice();
        private void btnGenUser_Click(object sender, EventArgs e)
        {
            List<string> name = new List<string>()
            { "Ali", "Ahmad", "Hossein", "Akbar", "Elahe", "Nazanin", "Sara", "Fatemeh" };

            var Emails = new List<string>() {
                "ma@hostname.com",
                "ma@hostname.comcom",
                "MA@hostname.coMCom",
                "m.a@hostname.co",
                "m_a1a@hostname.com",
                "ma-a@hostname.com",
                "ma-a@hostname.com.edu",
                "ma-a.aa@hostname.com.edu",
                "ma.h.saraf.onemore@hostname.com.edu",
                "ma12@hostname.com",
                "12@hostname.com",
            };
            var Password = new List<string>() {
                "ma@hostname",
                "ma@hostname",
                "MA@hostname",
                "m.a@hostname",
                "m_a1a@hostname",
                "ma-a@hostname",
                "ma-a@hostname",
                "ma-a.aa@hostna",
                "ma.h.saraf.onem",
            };
            var Phone = new List<string>() {
                "1111111111",
                "2222222222",
                "3333333333",
                "4444444444",
                "6666666666",
                "5555555555",
                "7777777777",
            };

            var Username = new List<string>() {
                "@ma@Ali",
                "@ma@hostname",
                "@MA@hostname",
                "@m.a@hostname",
                "@m_a1a@hostname",
                "@ma-a@hostname",
                "@ma-a@hostname",
                "@ma-a.aa@hostna",
                "@ma.h.saraf.onem",
            };
            var active = new List<bool>() { true, false };

            var rnd = new Random();
            var user = new User()
            {
                Name = name[rnd.Next(7)],
                Email = Emails[rnd.Next(10)],
                Password = Password[rnd.Next(8)],
                Phone = Phone[rnd.Next(6)],
                UserName = Username[rnd.Next(8)],
                IsActive = active[rnd.Next(2)],
                Birthday = DateTime.Now,
            };
            serv.Add(user);
            MessageBox.Show("new User Generated");
            LoadData();
        }

        private void LoadData(string? filtername = null)
        {
            if (comboBox1.SelectedIndex == 0)
                dataGridView1.DataSource = serv.GetIQueryable(null, filtername);
            else
            {
                if (comboBox1.SelectedIndex == 1)
                    dataGridView1.DataSource = serv.GetIQueryable(true, filtername);
                else
                    dataGridView1.DataSource = serv.GetIQueryable(false, filtername);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            //LoadData();
            /* Bug Find In EF Profiler */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtFilterName.Text.Trim());
        }
    }
}
