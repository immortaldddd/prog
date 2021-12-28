using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfITServis
{
    public partial class Sotr : Form
    {
        public Sotr()
        {
            InitializeComponent();
        }

        private void Sotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prifITServisDataSet.Sotrydnik". При необходимости она может быть перемещена или удалена.
            this.sotrydnikTableAdapter.Fill(this.prifITServisDataSet.Sotrydnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prifITServisDataSet.Sotrydnik". При необходимости она может быть перемещена или удалена.
            this.sotrydnikTableAdapter.Fill(this.prifITServisDataSet.Sotrydnik);

        }

        private void BTAdd3_Click(object sender, EventArgs e)
        {
            SotrAdd form = new SotrAdd();
            form.ShowDialog();
        }

        private void BTDelete3_Click(object sender, EventArgs e)
        {
            SotrDelete form = new SotrDelete();
            form.ShowDialog();
        }
    }
}
