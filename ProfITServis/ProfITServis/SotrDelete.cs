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
    public partial class SotrDelete : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PrifITServis;Integrated Security=True";
        private SqlConnection myConnection;
        public SotrDelete()
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Sotrydnik] WHERE [ФИО]=@ФИО ", myConnection);
            command.Parameters.AddWithValue("ФИО", TB1.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Результаты удалены , пожалуйста перезапустите приложение");
            this.Close();
        }
    }
}
