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
    public partial class YslygaAdd : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PrifITServis;Integrated Security=True";
        private SqlConnection myConnection;
        public YslygaAdd()
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

        private void BTAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Yslyga] (Название, Цена) VALUES (@a,@b)", myConnection);
            command.Parameters.AddWithValue("a", TB1.Text);
            command.Parameters.AddWithValue("b", TB2.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Резульаты сохранены");
            this.Close();
        }
    }
}
