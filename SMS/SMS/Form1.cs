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
namespace SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=SMS1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (_sqlconn.State == ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM USERS WHERE USERNAME=@UNAME AND PASS =@PASS", _sqlconn);
            _cmd.Parameters.AddWithValue("@UNAME", textBox1.Text);
            _cmd.Parameters.AddWithValue("@PASS", textBox2.Text);

            SqlDataReader dReader = _cmd.ExecuteReader();
            while (dReader.Read())
            {
                int roleid = dReader.GetInt32(3);
                switch (roleid)
                {
                    case 1:
                        frmMainWindow._AdminMenu.Visible = true;
                        this.Visible = false;
                        MessageBox.Show("admin");
                       
                        
                        break;
                    case 2:
                        frmMainWindow._StudentMenu.Visible = true;
                        this.Visible = false;
                        MessageBox.Show("Student");
                       
                        break;
                    case 3:
                        MessageBox.Show("Faculty");
                        break;
                    default:
                        break;
                }
               
            }
        }
    }
}
