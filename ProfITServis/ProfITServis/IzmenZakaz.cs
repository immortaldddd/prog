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
    public partial class IzmenZakaz : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=PrifITServis;Integrated Security=True";
        private SqlConnection myConnection;
        public IzmenZakaz()
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

        private void BTIzmen_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE [Zakaz] SET [НазваниеУсл]=@НазваниеУсл, [ФИОСотр]=@ФИОСотр,[ДатаВзятияЗ]=@ДатаВзятияЗ,[ОбщЦена]=@ОбщЦена WHERE [НомерЗаказа]=@НомерЗаказа ", myConnection);
            command.Parameters.AddWithValue("НомерЗаказа", TB1.Text);
            command.Parameters.AddWithValue("НазваниеУсл", TB2.Text);
            command.Parameters.AddWithValue("ФИОСотр", TB3.Text);
            command.Parameters.AddWithValue("ДатаВзятияЗ", TB4.Text);
            command.Parameters.AddWithValue("ОбщЦена", TB5.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Результаты сохранены , пожалуйста перезапустите приложение");
            this.Close();
        }
    }
}
