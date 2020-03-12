using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class FormMenu : Form
    {
        string connectionString;
        public FormMenu(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            formNHANSU f = new formNHANSU(connectionString);
            f.ShowDialog();
            this.Hide();
        }

    }
}
