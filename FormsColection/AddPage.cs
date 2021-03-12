using SelfParse.Colections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfParse.FormsColection
{
    public partial class AddPage : Form
    {
        private Main main;
        public AddPage(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            main.datagrid.Rows.Add("id", "site url");
            //textBoxUrl.Text;
            this.Close();
        }
    }
}
