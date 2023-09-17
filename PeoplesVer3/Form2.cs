using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dlyZheni
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private SQLiteConnection SQL;
        private async void Form2_Load(object sender, EventArgs e)
        {
            SQL = new SQLiteConnection(GVN.connection);
            await SQL.OpenAsync();
        }
    }
}
