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

namespace ProfITServis
{
    public partial class ZakazDelete : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PrifITServis;Integrated Security=True";
        private SqlConnection myConnection;
        public ZakazDelete()
        {
            InitializeComponent();
            myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
            }
            catch
            {
                MessageBox.Show("База не подключена");
            }
        }

        private void ZakazDelete_Load(object sender, EventArgs e)
        {

        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Zakaz] WHERE [НомерЗаказа]=@НомерЗаказа ", myConnection);
            command.Parameters.AddWithValue("НомерЗаказа", TB1.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Результаты удалены , пожалуйста перезапустите приложение");
            this.Close();
        }
    }
}
