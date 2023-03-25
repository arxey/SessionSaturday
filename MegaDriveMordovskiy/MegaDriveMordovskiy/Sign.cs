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
using System.IO;

namespace MegaDriveMordovskiy
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void ButtonSign_Click(object sender, EventArgs e)
        {
            Form vehicle = new Vehicle();
            Hide();
            vehicle.ShowDialog();
        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }

        private void Sign_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
