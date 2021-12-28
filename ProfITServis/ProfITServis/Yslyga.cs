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
    public partial class Yslyga : Form
    {
        public Yslyga()
        {
            InitializeComponent();
        }

        private void Yslyga_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prifITServisDataSet.Yslyga". При необходимости она может быть перемещена или удалена.
            this.yslygaTableAdapter.Fill(this.prifITServisDataSet.Yslyga);

        }

        private void BTAdd2_Click(object sender, EventArgs e)
        {
            YslygaAdd form = new YslygaAdd();
            form.ShowDialog();
        }

        private void BTDelete2_Click(object sender, EventArgs e)
        {
            YslygaDelete form = new YslygaDelete();
            form.ShowDialog();
        }
    }
}
