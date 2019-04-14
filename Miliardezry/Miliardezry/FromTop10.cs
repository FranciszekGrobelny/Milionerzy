using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Miliardezry
{
    public partial class FromTop10 : Form
    {
        

        public FromTop10()
        {
            InitializeComponent();
        }

        private void buttonTop10_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = YOU; database = miliarderzy ; Trusted_Connection=Yes");
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT DISTINCT TOP 10 nick,money FROM TableGamers ORDER BY money DESC", connection);
            DataTable table = new DataTable();

            adapter.Fill(table);           
            dataGridViewTop10.DataSource = table;
           
        }

       
    }
}
