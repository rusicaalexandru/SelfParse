using SelfParse.Colections;
using SelfParse.FormsColection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfParse
{
    public partial class Main : Form
    {
        List<ParsingTemplate> list = new List<ParsingTemplate>();
        public Main()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addPage = new AddPage(this);
            addPage.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //datagrid.Rows.Add("id", "site url");

        }
    }
}
