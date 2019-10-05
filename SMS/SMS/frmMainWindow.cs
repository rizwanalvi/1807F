using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class frmMainWindow : Form
    {
        public static MenuStrip _AdminMenu = null;
        public static MenuStrip _StudentMenu = null;
        public frmMainWindow()
        {
            InitializeComponent();
            _AdminMenu = this.menuStrip1;
            _StudentMenu = this.menuStrip2;
            
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            Form1 _login = new Form1();
            _login.MdiParent = this;
            _login.Show();
        }
    }
}
